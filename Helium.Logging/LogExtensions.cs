using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Helium.Logging
{
	public static class LogExtensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
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
