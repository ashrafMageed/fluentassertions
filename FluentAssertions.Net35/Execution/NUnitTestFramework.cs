﻿namespace FluentAssertions.Execution
{
    public class NUnitTestFramework : LateBoundTestFramework
    {
        protected override string AssemblyName
        {
            get { return "nunit.framework"; }
        }

        protected override string ExceptionFullName
        {
            get { return "NUnit.Framework.AssertionException"; }
        }
    }
}