﻿using NCop.Aspects.Advices;
using NCop.Aspects.Aspects;
using NCop.Weaving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCop.Core.Extensions;
using System.Reflection;

namespace NCop.Aspects.Weaving.Expressions
{
    internal class OnMethodBoundaryAspectExpression : AbstractAspectExpression
    {
        internal OnMethodBoundaryAspectExpression(IAspectExpression expression, IAspectDefinition aspectDefinition = null)
            : base(expression, aspectDefinition) {
        }

        public override IAspcetWeaver Reduce(IAspectWeaverSettings settings) {
            return new OnMethodBoundaryAspectWeaver(expression, aspectDefinition, settings);
        }
    }
}