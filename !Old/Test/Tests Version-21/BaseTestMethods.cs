using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaFoundation;

namespace TestsVersion_21
{
    [TestClass]
    public class BaseTestMethods
    {
        [AssemblyInitialize]
        public static void InitializeBeforeTests(TestContext context)
        {
            MFExtern.MFStartup(MFExtern.MF_VERSION_WIN7, MFStartup.Full);
            MFExtern.MFLockPlatform();
        }

        [AssemblyCleanup]
        public static void CleanupAfterTests()
        {
            MFExtern.MFUnlockPlatform();
            MFExtern.MFShutdown();
        }
    }
}
