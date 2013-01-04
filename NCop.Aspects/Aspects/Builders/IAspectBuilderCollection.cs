﻿using NCop.Aspects.Engine;
using NCop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCop.Aspects.Aspects.Builders
{
    public interface IAspectBuilderCollection : IReadOnlyCollection<IAspectBuilder>
    {
    }
}