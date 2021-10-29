using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Helium.Logging
{
	public static class LogExtensions
	{
		public static void LogTrace(this ILogger logger, String message,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogMessage(message, LogLevel.Trace, context);
		}

		public static void LogTrace(this ILogger logger, Exception exception,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogException(exception, LogLevel.Trace, context);
		}

		public static void LogDebug(this ILogger logger, String message,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogMessage(message, LogLevel.Debug, context);
		}

		public static void LogDebug(this ILogger logger, Exception exception,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogException(exception, LogLevel.Debug, context);
		}

		public static void LogInformation(this ILogger logger, String message,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogMessage(message, LogLevel.Information, context);
		}

		public static void LogInformation(this ILogger logger, Exception exception,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogException(exception, LogLevel.Information, context);
		}

		public static void LogWarning(this ILogger logger, String message,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogMessage(message, LogLevel.Warning, context);
		}

		public static void LogWarning(this ILogger logger, Exception exception,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogException(exception, LogLevel.Warning, context);
		}

		public static void LogError(this ILogger logger, String message,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogMessage(message, LogLevel.Error, context);
		}

		public static void LogError(this ILogger logger, Exception exception,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogException(exception, LogLevel.Error, context);
		}

		public static void LogCritical(this ILogger logger, String message,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogMessage(message, LogLevel.Critical, context);
		}

		public static void LogCritical(this ILogger logger, Exception exception,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogException(exception, LogLevel.Critical, context);
		}

		public static void LogFatal(this ILogger logger, String message,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogMessage(message, LogLevel.Fatal, context);
		}

		public static void LogFatal(this ILogger logger, Exception exception,
			[CallerMemberName]
			String callingMethod = null)
		{
			Assembly asm = Assembly.GetCallingAssembly();
			StackTrace trace = new(1);

			LogEntryContext context = new()
			{
				CallingAssembly = asm,
				CallingAssemblyName = asm.FullName,
				CallingMethodName = callingMethod,
				StackFrame = trace.GetFrame(0),
				StackTrace = trace
			};

			logger.LogException(exception, LogLevel.Fatal, context);
		}
	}
}
