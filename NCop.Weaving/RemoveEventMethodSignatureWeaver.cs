﻿using System.Reflection;
using System.Reflection.Emit;

namespace NCop.Weaving
{
    public class RemoveEventMethodSignatureWeaver : AbstractEventSignatureWeaver
    {
        public RemoveEventMethodSignatureWeaver(IEventTypeBuilder eventTypeBuilder, ITypeDefinition typeDefinition)
            : base(eventTypeBuilder, typeDefinition) {
        }

        public override MethodBuilder Weave(MethodInfo method) {
            var methodSignatureWeaver = new MethodSignatureWeaver(typeDefinition);
            var methodBuilder = methodSignatureWeaver.Weave(method);

            eventTypeBuilder.SetRemoveMethod(methodBuilder);

            return methodBuilder;
        }
    }
}