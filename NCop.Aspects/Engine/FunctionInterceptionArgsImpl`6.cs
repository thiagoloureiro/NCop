﻿using NCop.Aspects.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCop.Aspects.Engine
{
    public class FunctionInterceptionArgsImpl<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> : FunctionExecutionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>, IInterceptable
	{
        private readonly IFunctionBinding<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> funcBinding = null;

        public FunctionInterceptionArgsImpl(object instance, IFunctionBinding<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> funcBinding, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6) {
            Arg1 = arg1;
            Arg2 = arg2;
            Arg3 = arg3;
            Arg4 = arg4;
            Arg5 = arg5;
            Instance = instance;
            this.funcBinding = funcBinding;
        }

        public void Proceed() {
            var instance = Instance;

            funcBinding.Invoke(ref instance, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
        }
	}
}
