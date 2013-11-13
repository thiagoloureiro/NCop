﻿using NCop.Aspects.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCop.Aspects.Framework
{
    public abstract class ActionExecutionArgs : ExecutionArgs, IActionExecutionArgs
    {
        public FlowBehavior FlowBehavior { get; protected set; }
    }
}
