﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NCop.Aspects.Tests.ActionWith5RefArgumentsAspect.Subjects;
using System;

namespace NCop.Aspects.Tests
{
    [TestClass]
    public class ActionWith5RefArgumentsAspectTest : AbstractAspectTest
    {
        private int i = 0;
        private int j = 0;
        private int k = 0;
        private int l = 0;
        private int m = 0;
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void InitializeAllprivateVariablesForEachTest() {
            m = l = i = j = k = 0;
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithOnMethodBoundaryAspect_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new OnMethodBoundaryAspectOrderedJoinPoints().Calculate();

            instance.OnMethodBoundaryAspect(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithInterceptionAspect_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new InterceptionAspectOrderedJoinPoints().Calculate();

            instance.InterceptionAspect(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithMultipleInterceptionAspects_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new MultipleInterceptionAspectOrderedJoinPoints().Calculate();

            instance.MultipleInterceptionAspects(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithMultipleOnMethodBoundaryAspects_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new MultipleOnMethodBoundaryAspectOrderedJoinPoints().Calculate();

            instance.MultipleOnMethodBoundaryAspects(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithAllAspectsStartingWithInterceptionAspect_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new AllAspectOrderedJoinPointsStartingWithInterceptionAspect().Calculate();

            instance.AllAspectsStartingWithInterception(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithAllAspectsStartingWithOnMethodBoundaryAspect_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new AllAspectOrderedJoinPointsStartingWithOnMethodBoundaryAspect().Calculate();

            instance.AllAspectsStartingWithOnMethodBoundary(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithAlternateAspectsStartingWithInterceptionAspect_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new AlternateAspectOrderedJoinPointsStartingWithInterceptionAspect().Calculate();

            instance.AlternatelAspectsStartingWithInterception(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithAlternateAspectsStartingWithOnMethodBoundaryAspect_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new AlternateAspectOrderedJoinPointsStartingWithOnMethodBoundaryAspect().Calculate();

            instance.AlternateAspectsStartingWithOnMethodBoundary(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ActionWith5RefArguments_AnnotatedWithOnMethodBoundaryAspectThatRaisesAnExceptionInMethodInvocationWithDefaultFlowBehaviour_ThrowsException() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();

            instance.OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(ref i, ref j, ref k, ref l, ref m);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithOnMethodBoundaryAspectThatRaisesAnExceptionInMethodInvocationWithContinueFlowBehaviour_OmitsTheOnSuccessAdvice() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new WithExceptionFlowBehaviourContinueOnMethodBoundaryAspectOrderedJoinPoints().Calculate();

            instance.OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplDecoratedWithContinueFlowBehaviourAspect(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithATryFinallyOnMethodBoundaryAspectThatRaisesAnExceptionInMethodInvocation_OmitsTheOnSuccessAdviceAndReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new TryFinallyWithExceptionOnMethodBoundaryAspectOrderedJoinPoints().Calculate();

            try {
                instance.TryfinallyOnMethodBoundaryAspectThatRaiseAnExceptionInMethodImpl(ref i, ref j, ref k, ref l, ref m);
            }
            catch (Exception) {
                Assert.AreEqual(i, joinPoints);
                Assert.AreEqual(j, joinPoints);
                Assert.AreEqual(k, joinPoints);
                Assert.AreEqual(l, joinPoints);
                Assert.AreEqual(m, joinPoints);
            }
        }

        [TestMethod]
        public void ActionWith5RefArguments_OnMethodBoundaryAspectThatRaisesAnExceptionInMethodInvocationWithoutTryFinally_OmitsTheOnSuccessAdviceAndReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new OnMethodBoundaryAspectWithExceptionAndWithoutTryFinallyOrderedJoinPoints().Calculate();

            try {
                instance.OnMethodBoundaryAspectThatRaiseAnExceptionInMethodImplWithoutTryFinally(ref i, ref j, ref k, ref l, ref m);
            }
            catch (Exception) {
                Assert.AreEqual(i, joinPoints);
                Assert.AreEqual(j, joinPoints);
                Assert.AreEqual(k, joinPoints);
                Assert.AreEqual(l, joinPoints);
                Assert.AreEqual(m, joinPoints);
            }
        }

        [TestMethod]
        public void ActionWith5RefArguments_OnMethodBoundaryAspectWithOnlyOnEntryAdvice_ReturnsTheCorrectSequenceOfAdvices() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new OnMethodBoundaryAspectWithOnlyOnEntryAdviceOrderedJoinPoints().Calculate();
            instance.OnMethodBoundaryAspectWithOnlyOnEntryAdvide(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }

        [TestMethod]
        public void ActionWith5RefArguments_AnnotatedWithAllAspectsStartingFromInterceptionAspectThatCallsTheInvokeMethodOfTheArgs_ReturnsTheInMethodAdviceAndIgnoresAllOtherAspects() {
            var instance = container.Resolve<IActionWith5RefArgumentsComposite>();
            var joinPoints = new InterceptionAspectUsingInvokeOrderedJoinPoints().Calculate();

            instance.InterceptionAspectUsingInvoke(ref i, ref j, ref k, ref l, ref m);

            Assert.AreEqual(i, joinPoints);
            Assert.AreEqual(j, joinPoints);
            Assert.AreEqual(k, joinPoints);
            Assert.AreEqual(l, joinPoints);
            Assert.AreEqual(m, joinPoints);
        }
    }
}