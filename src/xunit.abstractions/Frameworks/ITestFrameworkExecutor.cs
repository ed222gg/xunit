using System;
using System.Collections.Generic;

namespace Xunit.Abstractions
{
    /// <summary>
    /// Represents an implementation of the execution part of a test framework.
    /// </summary>
    public interface ITestFrameworkExecutor : IDisposable
    {
        /// <summary>
        /// De-serializes a test case.
        /// </summary>
        /// <param name="value">The string representation of the test case.</param>
        /// <returns>The de-serialized test case.</returns>
        ITestCase Deserialize(string value);

        /// <summary>
        /// Starts the process of running all the tests in the assembly.
        /// </summary>
        /// <param name="messageSink">The message sink to report results back to.</param>
        /// <param name="discoveryOptions">The options to be used during test discovery.</param>
        /// <param name="executionOptions">The options to be used during test execution.</param>
        void RunAll(IMessageSink messageSink, ITestFrameworkOptions discoveryOptions, ITestFrameworkOptions executionOptions);

        /// <summary>
        /// Starts the process of running selected tests in the assembly.
        /// </summary>
        /// <param name="testCases">The test cases to run.</param>
        /// <param name="messageSink">The message sink to report results back to.</param>
        /// <param name="executionOptions">The options to be used during test execution.</param>
        void RunTests(IEnumerable<ITestCase> testCases, IMessageSink messageSink, ITestFrameworkOptions executionOptions);
    }
}