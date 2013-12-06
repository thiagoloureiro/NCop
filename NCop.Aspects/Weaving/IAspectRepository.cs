﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NCop.Aspects.Weaving
{
    public interface IAspectRepository
    {
        FieldInfo GetAspectFieldByType(Type type);
    }
}
