﻿using NCop.Aspects.Framework;
using NCop.Aspects.Tests.Extensions;
using NCop.Composite.Framework;
using NCop.Core.Extensions;
using NCop.Mixins.Framework;
using System;
using System.Collections.Generic;

namespace NCop.Aspects.Tests.FunctionWith8ArgumentsAspect.Subjects
{
    public interface IFunctionWith8ArgumentsBoundaryAspect
    {
        string InterceptionAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string OnMethodBoundaryAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string MultipleInterceptionAspects(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string InterceptionAspectUsingInvoke(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string MultipleOnMethodBoundaryAspects(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string AllAspectsStartingWithInterception(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string AllAspectsStartingWithOnMethodBoundary(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string AlternatelAspectsStartingWithInterception(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string OnMethodBoundaryAspectWithOnlyOnEntryAdvide(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string AlternateAspectsStartingWithOnMethodBoundary(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string TryfinallyOnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplWithoutTryFinally(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
        string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplDecoratedWithContinueFlowBehaviourAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
    }

    public class Mixin : IFunctionWith8ArgumentsBoundaryAspect
    {
        private string AddInMethodJoinPoint(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            first.Add(AspectJoinPoints.InMethod);
            second.Add(AspectJoinPoints.InMethod);
            third.Add(AspectJoinPoints.InMethod);
            fourth.Add(AspectJoinPoints.InMethod);
            fifth.Add(AspectJoinPoints.InMethod);
            sixth.Add(AspectJoinPoints.InMethod);
            seventh.Add(AspectJoinPoints.InMethod);
            eighth.Add(AspectJoinPoints.InMethod);

            return AspectJoinPoints.InMethod.ToString();
        }

        public string InterceptionAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string OnMethodBoundaryAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string MultipleInterceptionAspects(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string InterceptionAspectUsingInvoke(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string MultipleOnMethodBoundaryAspects(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string AllAspectsStartingWithInterception(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string AllAspectsStartingWithOnMethodBoundary(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string AlternatelAspectsStartingWithInterception(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string OnMethodBoundaryAspectWithOnlyOnEntryAdvide(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string AlternateAspectsStartingWithOnMethodBoundary(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            AddInMethodJoinPoint(first, second, third, fourth, fifth, sixth, seventh, eighth);
            throw new Exception("InMethodException");
        }

        public string TryfinallyOnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplWithoutTryFinally(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }

        public string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplDecoratedWithContinueFlowBehaviourAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth) {
            return OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(first, second, third, fourth, fifth, sixth, seventh, eighth);
        }
    }

    [TransientComposite]
    [Mixins(typeof(Mixin))]
    public interface IFunctionWith8ArgumentsComposite : IFunctionWith8ArgumentsBoundaryAspect
    {
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect))]
        new string InterceptionAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect))]
        new string OnMethodBoundaryAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect))]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect))]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect))]
        new string MultipleOnMethodBoundaryAspects(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect))]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect))]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect))]
        new string MultipleInterceptionAspects(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionUsinInvokeAspect), AspectPriority = 1)]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 2)]
        new string InterceptionAspectUsingInvoke(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 1)]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 2)]
        new string AllAspectsStartingWithInterception(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 1)]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 2)]
        new string AllAspectsStartingWithOnMethodBoundary(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 1)]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 2)]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 3)]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 4)]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 5)]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 6)]
        new string AlternatelAspectsStartingWithInterception(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(OnEntry_FunctionWith8ArgumentsBoundaryAspect))]
        new string OnMethodBoundaryAspectWithOnlyOnEntryAdvide(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 1)]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 2)]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 3)]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 4)]
        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect), AspectPriority = 5)]
        [MethodInterceptionAspect(typeof(FunctionWith8ArgumentsInterceptionAspect), AspectPriority = 6)]
        new string AlternateAspectsStartingWithOnMethodBoundary(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(FunctionWith8ArgumentsOnMethodBoundaryAspect))]
        new string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(OnEntry_OnSuccess_OnExit_FunctionWith8ArgumentsBoundaryAspect))]
        new string TryfinallyOnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(OnEntry_OnSuccess_FunctionWith8ArgumentsBoundaryAspect))]
        new string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplWithoutTryFinally(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);

        [OnMethodBoundaryAspect(typeof(WithContinueFlowBehvoiurFunctionWith8ArgumentsBoundaryAspect))]
        new string OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplDecoratedWithContinueFlowBehaviourAspect(List<AspectJoinPoints> first, List<AspectJoinPoints> second, List<AspectJoinPoints> third, List<AspectJoinPoints> fourth, List<AspectJoinPoints> fifth, List<AspectJoinPoints> sixth, List<AspectJoinPoints> seventh, List<AspectJoinPoints> eighth);
    }

    public class FunctionWith8ArgumentsOnMethodBoundaryAspect : OnFunctionBoundaryAspect<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnEntry(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnEntry);
            args.Arg2.Add(AspectJoinPoints.OnEntry);
            args.Arg3.Add(AspectJoinPoints.OnEntry);
            args.Arg4.Add(AspectJoinPoints.OnEntry);
            args.Arg5.Add(AspectJoinPoints.OnEntry);
            args.Arg6.Add(AspectJoinPoints.OnEntry);
            args.Arg7.Add(AspectJoinPoints.OnEntry);
            args.Arg8.Add(AspectJoinPoints.OnEntry);
            args.AddToReturnValue(AspectJoinPoints.OnEntry);
            base.OnEntry(args);
        }

        public override void OnSuccess(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnSuccess);
            args.Arg2.Add(AspectJoinPoints.OnSuccess);
            args.Arg3.Add(AspectJoinPoints.OnSuccess);
            args.Arg4.Add(AspectJoinPoints.OnSuccess);
            args.Arg5.Add(AspectJoinPoints.OnSuccess);
            args.Arg6.Add(AspectJoinPoints.OnSuccess);
            args.Arg7.Add(AspectJoinPoints.OnSuccess);
            args.Arg8.Add(AspectJoinPoints.OnSuccess);
            args.AddToReturnValue(AspectJoinPoints.OnSuccess);
            base.OnSuccess(args);
        }

        public override void OnException(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var ex = args.Exception;

            if (ex.IsNotNull() && ex.GetType() == typeof(Exception) && ex.Message.Equals("InMethodException")) {
                args.Arg1.Add(AspectJoinPoints.OnException);
                args.Arg2.Add(AspectJoinPoints.OnException);
                args.Arg3.Add(AspectJoinPoints.OnException);
                args.Arg4.Add(AspectJoinPoints.OnException);
                args.Arg5.Add(AspectJoinPoints.OnException);
                args.Arg6.Add(AspectJoinPoints.OnException);
                args.Arg7.Add(AspectJoinPoints.OnException);
                args.Arg8.Add(AspectJoinPoints.OnException);
                args.AddToReturnValue(AspectJoinPoints.OnException);
            }

            base.OnException(args);
        }

        public override void OnExit(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnExit);
            args.Arg2.Add(AspectJoinPoints.OnExit);
            args.Arg3.Add(AspectJoinPoints.OnExit);
            args.Arg4.Add(AspectJoinPoints.OnExit);
            args.Arg5.Add(AspectJoinPoints.OnExit);
            args.Arg6.Add(AspectJoinPoints.OnExit);
            args.Arg7.Add(AspectJoinPoints.OnExit);
            args.Arg8.Add(AspectJoinPoints.OnExit);
            args.AddToReturnValue(AspectJoinPoints.OnExit);
            base.OnExit(args);
        }
    }

    public class OnEntry_FunctionWith8ArgumentsBoundaryAspect : OnFunctionBoundaryAspect<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnEntry(FunctionExecutionArgs<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.FlowBehavior = FlowBehavior.Continue;
            args.Arg1.Add(AspectJoinPoints.OnEntry);
            args.Arg2.Add(AspectJoinPoints.OnEntry);
            args.Arg3.Add(AspectJoinPoints.OnEntry);
            args.Arg4.Add(AspectJoinPoints.OnEntry);
            args.Arg5.Add(AspectJoinPoints.OnEntry);
            args.Arg6.Add(AspectJoinPoints.OnEntry);
            args.Arg7.Add(AspectJoinPoints.OnEntry);
            args.Arg8.Add(AspectJoinPoints.OnEntry);
            base.OnEntry(args);
        }
    }

    public class OnEntry_OnSuccess_FunctionWith8ArgumentsBoundaryAspect : OnFunctionBoundaryAspect<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnEntry(FunctionExecutionArgs<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.FlowBehavior = FlowBehavior.Continue;
            args.Arg1.Add(AspectJoinPoints.OnEntry);
            args.Arg2.Add(AspectJoinPoints.OnEntry);
            args.Arg3.Add(AspectJoinPoints.OnEntry);
            args.Arg4.Add(AspectJoinPoints.OnEntry);
            args.Arg5.Add(AspectJoinPoints.OnEntry);
            args.Arg6.Add(AspectJoinPoints.OnEntry);
            args.Arg7.Add(AspectJoinPoints.OnEntry);
            args.Arg8.Add(AspectJoinPoints.OnEntry);
            base.OnEntry(args);
        }

        public override void OnSuccess(FunctionExecutionArgs<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnSuccess);
            args.Arg2.Add(AspectJoinPoints.OnSuccess);
            args.Arg3.Add(AspectJoinPoints.OnSuccess);
            args.Arg4.Add(AspectJoinPoints.OnSuccess);
            args.Arg5.Add(AspectJoinPoints.OnSuccess);
            args.Arg6.Add(AspectJoinPoints.OnSuccess);
            args.Arg7.Add(AspectJoinPoints.OnSuccess);
            args.Arg8.Add(AspectJoinPoints.OnSuccess);
            base.OnSuccess(args);
        }
    }

    public class OnEntry_OnSuccess_OnExit_FunctionWith8ArgumentsBoundaryAspect : OnFunctionBoundaryAspect<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnEntry(FunctionExecutionArgs<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.FlowBehavior = FlowBehavior.Continue;
            args.Arg1.Add(AspectJoinPoints.OnEntry);
            args.Arg2.Add(AspectJoinPoints.OnEntry);
            args.Arg3.Add(AspectJoinPoints.OnEntry);
            args.Arg4.Add(AspectJoinPoints.OnEntry);
            args.Arg5.Add(AspectJoinPoints.OnEntry);
            args.Arg6.Add(AspectJoinPoints.OnEntry);
            args.Arg7.Add(AspectJoinPoints.OnEntry);
            args.Arg8.Add(AspectJoinPoints.OnEntry);
            base.OnEntry(args);
        }

        public override void OnSuccess(FunctionExecutionArgs<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnSuccess);
            args.Arg2.Add(AspectJoinPoints.OnSuccess);
            args.Arg3.Add(AspectJoinPoints.OnSuccess);
            args.Arg4.Add(AspectJoinPoints.OnSuccess);
            args.Arg5.Add(AspectJoinPoints.OnSuccess);
            args.Arg6.Add(AspectJoinPoints.OnSuccess);
            args.Arg7.Add(AspectJoinPoints.OnSuccess);
            args.Arg8.Add(AspectJoinPoints.OnSuccess);
            base.OnSuccess(args);
        }

        public override void OnExit(FunctionExecutionArgs<List<AspectJoinPoints>,List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnExit);
            args.Arg2.Add(AspectJoinPoints.OnExit);
            args.Arg3.Add(AspectJoinPoints.OnExit);
            args.Arg4.Add(AspectJoinPoints.OnExit);
            args.Arg5.Add(AspectJoinPoints.OnExit);
            args.Arg6.Add(AspectJoinPoints.OnExit);
            args.Arg7.Add(AspectJoinPoints.OnExit);
            args.Arg8.Add(AspectJoinPoints.OnExit);
            base.OnExit(args);
        }
    }

    public class WithContinueFlowBehvoiurFunctionWith8ArgumentsBoundaryAspect : OnFunctionBoundaryAspect<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnEntry(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.FlowBehavior = FlowBehavior.Continue;
            args.Arg1.Add(AspectJoinPoints.OnEntry);
            args.Arg2.Add(AspectJoinPoints.OnEntry);
            args.Arg3.Add(AspectJoinPoints.OnEntry);
            args.Arg4.Add(AspectJoinPoints.OnEntry);
            args.Arg5.Add(AspectJoinPoints.OnEntry);
            args.Arg6.Add(AspectJoinPoints.OnEntry);
            args.Arg7.Add(AspectJoinPoints.OnEntry);
            args.Arg8.Add(AspectJoinPoints.OnEntry);
            args.AddToReturnValue(AspectJoinPoints.OnEntry);
            base.OnEntry(args);
        }

        public override void OnSuccess(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnSuccess);
            args.Arg2.Add(AspectJoinPoints.OnSuccess);
            args.Arg3.Add(AspectJoinPoints.OnSuccess);
            args.Arg4.Add(AspectJoinPoints.OnSuccess);
            args.Arg5.Add(AspectJoinPoints.OnSuccess);
            args.Arg6.Add(AspectJoinPoints.OnSuccess);
            args.Arg7.Add(AspectJoinPoints.OnSuccess);
            args.Arg8.Add(AspectJoinPoints.OnSuccess);
            args.AddToReturnValue(AspectJoinPoints.OnSuccess);
            base.OnSuccess(args);
        }

        public override void OnException(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            var ex = args.Exception;

            if (ex.IsNotNull() && ex.GetType() == typeof(Exception) && ex.Message.Equals("InMethodException")) {
                args.Arg1.Add(AspectJoinPoints.OnException);
                args.Arg2.Add(AspectJoinPoints.OnException);
                args.Arg3.Add(AspectJoinPoints.OnException);
                args.Arg4.Add(AspectJoinPoints.OnException);
                args.Arg5.Add(AspectJoinPoints.OnException);
                args.Arg6.Add(AspectJoinPoints.OnException);
                args.Arg7.Add(AspectJoinPoints.OnException);
                args.Arg8.Add(AspectJoinPoints.OnException);
                args.AddToReturnValue(AspectJoinPoints.InMethod);
                args.AddToReturnValue(AspectJoinPoints.OnException);
            }

            base.OnException(args);
        }

        public override void OnExit(FunctionExecutionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnExit);
            args.Arg2.Add(AspectJoinPoints.OnExit);
            args.Arg3.Add(AspectJoinPoints.OnExit);
            args.Arg4.Add(AspectJoinPoints.OnExit);
            args.Arg5.Add(AspectJoinPoints.OnExit);
            args.Arg6.Add(AspectJoinPoints.OnExit);
            args.Arg7.Add(AspectJoinPoints.OnExit);
            args.Arg8.Add(AspectJoinPoints.OnExit);
            args.AddToReturnValue(AspectJoinPoints.OnExit);
            base.OnExit(args);
        }
    }

    public class FunctionWith8ArgumentsInterceptionAspect : FunctionInterceptionAspect<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnInvoke(FunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Arg1.Add(AspectJoinPoints.OnInvoke);
            args.Arg2.Add(AspectJoinPoints.OnInvoke);
            args.Arg3.Add(AspectJoinPoints.OnInvoke);
            args.Arg4.Add(AspectJoinPoints.OnInvoke);
            args.Arg5.Add(AspectJoinPoints.OnInvoke);
            args.Arg6.Add(AspectJoinPoints.OnInvoke);
            args.Arg7.Add(AspectJoinPoints.OnInvoke);
            args.Arg8.Add(AspectJoinPoints.OnInvoke);
            args.AddToReturnValue(AspectJoinPoints.OnInvoke);
            base.OnInvoke(args);
        }
    }

    public class FunctionWith8ArgumentsInterceptionUsinInvokeAspect : FunctionInterceptionAspect<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string>
    {
        public override void OnInvoke(FunctionInterceptionArgs<List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, List<AspectJoinPoints>, string> args) {
            args.Invoke();
        }
    }
}
