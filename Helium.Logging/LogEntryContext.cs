using System;
using System.Diagnostics;
using System.Reflection;

namespace Helium.Logging
{
	public record struct LogEntryContext
	{
		public String CallingMethodName { get; init; }
		public String CallingAssemblyName { get; init; }
		public Assembly CallingAssembly { get; init; }
		public StackFrame StackFrame { get; init; }
		public StackTrace StackTrace { get; init; }
	}
}