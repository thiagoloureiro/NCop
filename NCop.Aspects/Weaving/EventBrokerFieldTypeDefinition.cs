﻿using NCop.Core.Extensions;
using NCop.Weaving;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using FA = System.Reflection.FieldAttributes;

namespace NCop.Aspects.Weaving
{
    public class EventBrokerFieldTypeDefinition : IFieldBuilderDefinition
    {
        private static int eventBrokersCounter;
        private readonly IFieldBuilderDefinition fieldBuilderDefinition = null;
        private static readonly FieldAttributes fieldAttributes = FA.Family | FA.FamANDAssem | FA.InitOnly;

        public EventBrokerFieldTypeDefinition(EventInfo @event, EventBrokerResolvedType eventBrokerResolvedType, TypeBuilder typeBuilder, Type eventBrokerGeneratedType) {
            string fieldName = null;

            Event = @event;
            EventBrokerType = eventBrokerGeneratedType;
            InvokeMethodName = "Invoke{0}".Fmt(@event.Name);
            EventInterceptionArgs = eventBrokerResolvedType.EventInterceptionArgs;
            EventBrokerDelegateType = eventBrokerResolvedType.EventBrokerInvokeDelegateType;
            EventInterceptionContractArgs = eventBrokerResolvedType.EventInterceptionContractArgs;
            fieldName = "EventBroker_{0}".Fmt(Interlocked.Increment(ref eventBrokersCounter)).ToUniqueName();
            fieldBuilderDefinition = new FieldBuilderDefinition(eventBrokerResolvedType.EventBrokerFieldType, typeBuilder, fieldName, fieldAttributes);
        }

        public EventInfo Event { get; private set; }

        public Type Type {
            get {
                return fieldBuilderDefinition.Type;
            }
        }

        public Type EventBrokerType { get; private set; }

        public string InvokeMethodName { get; private set; }

        public FieldBuilder FieldBuilder {
            get {
                return fieldBuilderDefinition.FieldBuilder;
            }
        }

        public MethodBuilder InvokeMethodBuilder { get; set; }

        public Type EventInterceptionArgs { get; private set; }

        public Type EventBrokerDelegateType { get; private set; }

        public Type EventInterceptionContractArgs { get; private set; }
    }
}
