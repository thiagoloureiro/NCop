﻿using NCop.Weaving.Extensions;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace NCop.Aspects.Weaving
{
    internal abstract class AbstractAspectPropertyArgsWeaver : IArgumentsWeaver
    {
        protected readonly MethodInfo method = null;
        private readonly LocalBuilder methodLocalBuilder = null;
        private readonly IAspectWeavingSettings aspectWeavingSettings = null;

        internal AbstractAspectPropertyArgsWeaver(MethodInfo method, LocalBuilder methodLocalBuilder, IAspectWeavingSettings aspectWeavingSettings) {
            this.method = method;
            this.methodLocalBuilder = methodLocalBuilder;
            this.aspectWeavingSettings = aspectWeavingSettings;
        }

        public void Weave(ILGenerator ilGenerator) {
            var typeofType = typeof(Type);
            var typeofObject = typeof(object);
            FieldBuilder contractFieldBuilder = null;
            var weavingSettings = aspectWeavingSettings.WeavingSettings;
            var getTypeFromHandleMethodInfo = typeofType.GetMethod("GetTypeFromHandle");

            contractFieldBuilder = weavingSettings.TypeDefinition.GetFieldBuilder(weavingSettings.ContractType);
            ilGenerator.EmitLoadArg(0);
            ilGenerator.Emit(OpCodes.Ldfld, contractFieldBuilder);
            ilGenerator.Emit(OpCodes.Callvirt, typeofObject.GetMethod("GetType"));
            ilGenerator.Emit(OpCodes.Ldstr, PropertyName);
            ilGenerator.Emit(OpCodes.Ldtoken, PropertyType);
            ilGenerator.Emit(OpCodes.Call, getTypeFromHandleMethodInfo);
            ilGenerator.Emit(OpCodes.Callvirt, typeofType.GetMethod("GetProperty", new[] { typeof(string), typeof(Type) }));
            ilGenerator.Emit(OpCodes.Callvirt, PropertyMethod);
            ilGenerator.EmitStoreLocal(methodLocalBuilder);
        }

        protected abstract Type PropertyType { get; }

        protected abstract string PropertyName { get; }

        protected abstract MethodInfo PropertyMethod { get; }
    }
}
