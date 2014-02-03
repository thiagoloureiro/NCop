﻿using NCop.Aspects.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCop.Aspects.Engine
{
    public interface IFunctionInterceptionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> : IFunctionArgs<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>, IFunctionInterceptionArgs
    {
        TResult Invoke(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);
    }
}