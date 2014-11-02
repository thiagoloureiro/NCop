﻿using NCop.Aspects.Aspects;
using NCop.Aspects.Extensions;
using NCop.Composite.Weaving;
using NCop.Weaving;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace NCop.Aspects.Weaving
{
    internal class NestedMethodInterceptionAspectWeaver : AbstractMethodInterceptionAspectWeaver
    {
        private readonly IArgumentsWeaver argumentsWeaver = null;

        internal NestedMethodInterceptionAspectWeaver(Type topAspectInScopeArgType, IAspectDefinition aspectDefinition, IAspectMethodWeavingSettings aspectWeavingSettings, FieldInfo weavedType)
            : base(aspectDefinition, aspectWeavingSettings, weavedType) {
            var argumentWeavingSettings = aspectDefinition.ToArgumentsWeavingSettings();

            argumentWeavingSettings.BindingsDependency = weavedType;
            argumentsWeaver = new NestedMethodIntercpetionArgumentsWeaver(topAspectInScopeArgType, aspectWeavingSettings, argumentWeavingSettings);
            methodScopeWeavers.Add(new NestedAspectArgsMappingWeaver(topAspectInScopeArgType, aspectWeavingSettings, argumentsWeavingSetings));
            weaver = new MethodScopeWeaversQueue(methodScopeWeavers);
        }

        public override ILGenerator Weave(ILGenerator ilGenerator) {
            argumentsWeaver.Weave(ilGenerator);

            return weaver.Weave(ilGenerator);
        }
    }
}
