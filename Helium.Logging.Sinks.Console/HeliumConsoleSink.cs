using System;

namespace Helium.Logging.Sinks.Console
{
	public class HeliumConsoleSink : ILoggingSink
	{
		private readonly String _format;
		private readonly String _exceptionFormat;
		private readonly LogLevel _level;
		private readonly Colormap _colormap;

		public String Format => _format;

		public String ExceptionFormat => _exceptionFormat;

		public String DateTimeFormat { get; set; }

		public Boolean IsEnabled(LogLevel level)
		{
			return level >= _level;
		}

		public void LogException(Exception exception, LogLevel level, LogEntryContext context)
		{
			Colorful.Console.Write(DateTimeOffset.UtcNow.ToString(DateTimeFormat), _colormap.TextForegroundColors[level]);
			Colorful.Console.Write($" [{level}] ", _colormap.LevelForegroundColors[level]);
			Colorful.Console.Write(_exceptionFormat.Replace("$exception", exception.GetType().ToString())
				.Replace("$exception-message", exception.Message)
				.Replace("$calling-assembly", context.CallingAssemblyName)
				.Replace("$calling-method", context.CallingMethodName)
				.Replace("$stack-frame", context.StackFrame.ToString())
				.Replace("$stack-trace", context.StackTrace.ToString()));
			Colorful.Console.WriteLine();
		}

		public void LogMessage(String message, LogLevel level, LogEntryContext context)
		{
			Colorful.Console.Write(DateTimeOffset.UtcNow.ToString(DateTimeFormat), _colormap.TextForegroundColors[level]);
			Colorful.Console.Write($" [{level}] ", _colormap.LevelForegroundColors[level]);
			Colorful.Console.Write(_format.Replace("$calling-assembly", context.CallingAssemblyName)
				.Replace("$calling-method", context.CallingMethodName)
				.Replace("$stack-frame", context.StackFrame.ToString())
				.Replace("$stack-trace", context.StackTrace.ToString()));
			Colorful.Console.WriteLine();
		}

		public HeliumConsoleSink(HeliumLogger logger, LogLevel level, Colormap colormap)
		{
			this._format = logger.MessageTemplate;
			this._exceptionFormat = logger.ExceptionTemplate;
			this._level = level;
			this._colormap = colormap;
		}

		public HeliumConsoleSink(String messageFormat, String exceptionFormat, LogLevel level, Colormap colormap)
		{
			this._format = messageFormat;
			this._exceptionFormat = exceptionFormat;
			this._level = level;
			this._colormap = colormap;
		}
	}
}
