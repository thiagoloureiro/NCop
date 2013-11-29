﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCop.Aspects.Engine
{
    public interface IFunctionBinding<TInstance, TArg1, TArg2, TArg3, TArg4, TResult>
    {
        TResult Invoke(ref TInstance instance, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);
    }
}