﻿using NCop.Aspects.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCop.Aspects.Engine
{
    public class ActionInterceptionArgsImpl<TInstance, TArg1, TArg2, TArg3, TArg4, TArg5> : ActionInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5>
    {
        private TInstance instance = default(TInstance);
        private readonly IActionBinding<TInstance, TArg1, TArg2, TArg3, TArg4, TArg5> actionBinding = null;

        public ActionInterceptionArgsImpl(TInstance instance, IActionBinding<TInstance, TArg1, TArg2, TArg3, TArg4, TArg5> actionBinding, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5) {
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
            Arg5 = arg5;
            this.actionBinding = actionBinding;
            Instance = this.instance = instance;
        }

        public override void Proceed() {
            var instance = Instance;

            actionBinding.Invoke(ref this.instance, Arg1, Arg2, Arg3, Arg4, Arg5);
        }
    }
}