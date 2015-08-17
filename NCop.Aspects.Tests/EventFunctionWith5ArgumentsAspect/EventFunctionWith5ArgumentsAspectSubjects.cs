﻿using NCop.Aspects.Framework;
using NCop.Composite.Framework;
using NCop.Core.Extensions;
using NCop.Mixins.Framework;
using System;
using System.Collections.Generic;

namespace NCop.Aspects.Tests.EventFunctionWith5ArgumentsAspect.Subjects
{
    public interface IEventFunctionWith5ArgumentsAspect
    {
        List<AspectJoinPoints> Values { get; set; }
        event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> InterceptionAspect;
        event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> MultipleInterceptionAspects;
        event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> MultipleIgnoredInterceptionAspects;
        string RaiseInterceptionAspect(List<AspectJoinPoints> arg1, List<AspectJoinPoints> arg2, List<AspectJoinPoints> arg3, List<AspectJoinPoints> arg4, List<AspectJoinPoints> arg5);
        string RaiseMultipleInterceptionAspect(List<AspectJoinPoints> arg1, List<AspectJoinPoints> arg2, List<AspectJoinPoints> arg3, List<AspectJoinPoints> arg4, List<AspectJoinPoints> arg5);
        string RaiseMultipleIgnoredInterceptionAspects(List<AspectJoinPoints> arg1, List<AspectJoinPoints> arg2, List<AspectJoinPoints> arg3, List<AspectJoinPoints> arg4, List<AspectJoinPoints> arg5);
    }

    public class Mixin : IEventFunctionWith5ArgumentsAspect
    {
        public event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> InterceptionAspect;
        public event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> MultipleInterceptionAspects;
        public event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> MultipleIgnoredInterceptionAspects;

        public Mixin() {
            Values = new List<AspectJoinPoints>();
        }

        public List<AspectJoinPoints> Values { get; set; }

        public string RaiseInterceptionAspect(List<AspectJoinPoints> arg1, List<AspectJoinPoints> arg2, List<AspectJoinPoints> arg3, List<AspectJoinPoints> arg4, List<AspectJoinPoints> arg5) {
            return RaiseInterceptionAspect(InterceptionAspect, arg1, arg2, arg3, arg4, arg5);
        }

        public string RaiseMultipleInterceptionAspect(List<AspectJoinPoints> arg1, List<AspectJoinPoints> arg2, List<AspectJoinPoints> arg3, List<AspectJoinPoints> arg4, List<AspectJoinPoints> arg5) {
            return RaiseInterceptionAspect(MultipleInterceptionAspects, arg1, arg2, arg3, arg4, arg5);
        }

        public string RaiseMultipleIgnoredInterceptionAspects(List<AspectJoinPoints> arg1, List<AspectJoinPoints> arg2, List<AspectJoinPoints> arg3, List<AspectJoinPoints> arg4, List<AspectJoinPoints> arg5) {
            return RaiseInterceptionAspect(MultipleIgnoredInterceptionAspects, arg1, arg2, arg3, arg4, arg5);
        }

        public string RaiseInterceptionAspect(Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> func, List<AspectJoinPoints> arg1, List<AspectJoinPoints> arg2, List<AspectJoinPoints> arg3, List<AspectJoinPoints> arg4, List<AspectJoinPoints> arg5) {
            if (func.IsNotNull()) {
                return func(arg1, arg2, arg3, arg4, arg5);
            }

            return AspectJoinPoints.NoEvent.ToString();
        }
    }

    [TransientComposite]
    [Mixins(typeof(Mixin))]
    public interface IEventFunctionWith5ArgumentsComposite : IEventFunctionWith5ArgumentsAspect
    {
        [EventInterceptionAspect(typeof(EventFunctionInterceptionAspect))]
        new event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> InterceptionAspect;

        [EventInterceptionAspect(typeof(EventFunctionInterceptionAspect), AspectPriority = 1)]
        [EventInterceptionAspect(typeof(EventFunctionInterceptionAspect), AspectPriority = 1)]
        [EventInterceptionAspect(typeof(EventFunctionInterceptionAspect), AspectPriority = 1)]
        new event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> MultipleInterceptionAspects;

        [EventInterceptionAspect(typeof(EventFunctionInterceptionAspectIgnoreFollowingfAspects), AspectPriority = 1)]
        [EventInterceptionAspect(typeof(EventFunctionInterceptionAspect), AspectPriority = 2)]
        [EventInterceptionAspect(typeof(EventFunctionInterceptionAspect), AspectPriority = 3)]
        new event Func<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> MultipleIgnoredInterceptionAspects;
    }

    public class EventFunctionInterceptionAspect : EventFunctionInterceptionAspect<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnAddHandler(EventFunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var instance = (IEventFunctionWith5ArgumentsAspect)args.Instance;

            instance.Values.Add(AspectJoinPoints.OnAddEvent);
            args.ProceedAddHandler();
        }

        public override void OnInvokeHandler(EventFunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var instance = (IEventFunctionWith5ArgumentsAspect)args.Instance;

            instance.Values.Add(AspectJoinPoints.OnInvoke);
            args.Arg1.Add(AspectJoinPoints.OnInvoke);
            args.Arg2.Add(AspectJoinPoints.OnInvoke);
            args.Arg3.Add(AspectJoinPoints.OnInvoke);
            args.Arg4.Add(AspectJoinPoints.OnInvoke);
            args.Arg5.Add(AspectJoinPoints.OnInvoke);
            args.ProceedInvokeHandler();
        }

        public override void OnRemoveHandler(EventFunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var instance = (IEventFunctionWith5ArgumentsAspect)args.Instance;

            instance.Values.Add(AspectJoinPoints.OnRemoveEvent);
            args.ProceedRemoveHandler();
        }
    }

    public class EventFunctionInterceptionAspectIgnoreFollowingfAspects : EventFunctionInterceptionAspect<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnAddHandler(EventFunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var instance = (IEventFunctionWith5ArgumentsAspect)args.Instance;

            instance.Values.Add(AspectJoinPoints.OnAddEvent);
            args.ProceedAddHandler();
        }

        public override void OnInvokeHandler(EventFunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var instance = (IEventFunctionWith5ArgumentsAspect)args.Instance;

            instance.Values.Add(AspectJoinPoints.OnInvoke);
            args.Arg1.Add(AspectJoinPoints.OnInvoke);
            args.Arg2.Add(AspectJoinPoints.OnInvoke);
            args.Arg3.Add(AspectJoinPoints.OnInvoke);
            args.Arg4.Add(AspectJoinPoints.OnInvoke);
            args.Arg5.Add(AspectJoinPoints.OnInvoke);
            args.InvokeHanlder();
        }

        public override void OnRemoveHandler(EventFunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var instance = (IEventFunctionWith5ArgumentsAspect)args.Instance;

            instance.Values.Add(AspectJoinPoints.OnRemoveEvent);
            args.ProceedRemoveHandler();
        }
    }
}