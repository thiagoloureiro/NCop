﻿using NCop.Core;
using NCop.Weaving;
using System;
using System.Collections.Generic;

namespace NCop.Composite.Weaving
{
    internal class CompositeTypeDefinitionWeaver : AbstractTypeDefinitionWeaver
    {
        private readonly ITypeDefinitionIntilaizer typeDefinitionInitializer = null;

        internal CompositeTypeDefinitionWeaver(Type contractType, ITypeMap mixinsMap, IEnumerable<Type> eventBrokersType)
            : base(contractType, mixinsMap) {
            typeDefinitionInitializer = new CompositeTypeDefinition(Type, mixinsMap, eventBrokersType);
        }

        public override ITypeDefinition Weave() {
            return typeDefinitionInitializer.Initialize();
        }
    }
}