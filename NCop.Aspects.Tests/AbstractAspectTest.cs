﻿using NCop.Composite.Framework;

namespace NCop.Aspects.Tests
{
    public enum AspectJoinPoints
    {
        OnExit = 1,
        OnEntry,
        NoEvent,
        OnInvoke,
        InMethod,
        OnSuccess,
        OnAddEvent,
        OnException,
        Intercepted,
        OnRemoveEvent,
        GetPropertyInterception,
        SetPropertyInterception
    }

    public abstract class AbstractAspectTest
    {
        protected static CompositeContainer container = null;

        static AbstractAspectTest() {
            container = new CompositeContainer();
            container.Configure();
        }
    }
}
