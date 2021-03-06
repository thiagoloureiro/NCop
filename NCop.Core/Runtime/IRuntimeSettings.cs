﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace NCop.Core.Runtime
{
    public interface IRuntimeSettings
    {
        IEnumerable<Type> Types { get; }
        IEnumerable<Assembly> Assemblies { get; }
    }
}
