﻿using NCop.Aspects.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCop.Aspects.Engine
{
    public class FunctionInterceptionArgsImpl<TInstance, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> : FunctionInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
	{
        private TInstance instance = default(TInstance);
        private readonly IFunctionBinding<TInstance, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> funcBinding = null;

        public FunctionInterceptionArgsImpl(TInstance instance, IFunctionBinding<TInstance, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> funcBinding, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5) {
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
            Arg5 = arg5;
            Instance = instance;
            this.funcBinding = funcBinding;
        }

        public override void Proceed() {
            var instance = Instance;

            ReturnValue = funcBinding.Invoke(ref this.instance, Arg1, Arg2, Arg3, Arg4, Arg5);
        }
    }
}