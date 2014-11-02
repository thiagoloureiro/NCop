﻿using NCop.Aspects.Extensions;
using NCop.Core.Extensions;
using NCop.Weaving.Extensions;
using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace NCop.Aspects.Weaving
{
    internal abstract class AbstractBindingMethodInterceptionArgumentsWeaver: AbstractArgumentsWeaver
    {
        private readonly FieldInfo bindingsDependency = null;

        internal AbstractBindingMethodInterceptionArgumentsWeaver(IArgumentsWeavingSettings argumentWeavingSettings, IAspectMethodWeavingSettings aspectWeavingSettings)
            : base(argumentWeavingSettings, aspectWeavingSettings) {
            bindingsDependency = argumentWeavingSettings.BindingsDependency;
        }

        public override void Weave(ILGenerator ilGenerator) {
            LocalBuilder argsImplLocalBuilder = null;
            var methodInfoImpl = WeavingSettings.MethodInfoImpl;
            var ctorInterceptionArgs = ArgumentType.GetConstructors()[0];
            var aspectArgsType = methodInfoImpl.ToAspectArgumentContract();
            var methodProperty = aspectArgsType.GetProperty("Method");

            argsImplLocalBuilder = LocalBuilderRepository.GetOrDeclare(ArgumentType, () => {
                return ilGenerator.DeclareLocal(ArgumentType);
            });

            ilGenerator.EmitLoadArg(1);
            ilGenerator.Emit(OpCodes.Ldind_Ref);
            WeaveAspectArg(ilGenerator);
            ilGenerator.Emit(OpCodes.Callvirt, methodProperty.GetGetMethod());
            ilGenerator.Emit(OpCodes.Ldsfld, bindingsDependency);

            Parameters.ForEach(1, (parameter, i) => {
                var property = aspectArgsType.GetProperty("Arg{0}".Fmt(i));

                WeaveAspectArg(ilGenerator);
                ilGenerator.Emit(OpCodes.Callvirt, property.GetGetMethod());
            });

            ilGenerator.Emit(OpCodes.Newobj, ctorInterceptionArgs);
            ilGenerator.EmitStoreLocal(argsImplLocalBuilder);
        }

        protected abstract void WeaveAspectArg(ILGenerator ilGenerator);
    }
}
