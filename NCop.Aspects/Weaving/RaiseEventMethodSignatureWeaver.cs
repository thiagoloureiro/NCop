﻿using NCop.Weaving;
using System.Reflection;
using System.Reflection.Emit;

namespace NCop.Aspects.Weaving
{
    public class RaiseEventMethodSignatureWeaver : AbstractEventSignatureWeaver
    {
        private readonly EventBrokerFieldTypeDefinition eventBrokerFieldTypeDefinition = null;

        public RaiseEventMethodSignatureWeaver(IEventTypeBuilder eventTypeBuilder, ITypeDefinition typeDefinition, EventBrokerFieldTypeDefinition eventBrokerFieldTypeDefinition)
            : base(eventTypeBuilder, typeDefinition) {
            this.eventBrokerFieldTypeDefinition = eventBrokerFieldTypeDefinition;
        }

        public override MethodBuilder Weave(MethodInfo method) {
            var methodBuilder = typeDefinition.TypeBuilder.DefineMethod(eventBrokerFieldTypeDefinition.InvokeMethodName, MethodAttributes.Public | MethodAttributes.HideBySig, method.ReturnType, new[] { eventBrokerFieldTypeDefinition.EventInterceptionContractArgs });

            return eventBrokerFieldTypeDefinition.InvokeMethodBuilder = methodBuilder;
        }
    }
}