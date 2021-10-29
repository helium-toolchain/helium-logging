using System;

namespace Helium.Logging
{
	public interface ILoggingSink
	{
		public String Format { get; }
		public String ExceptionFormat { get; }

		public Boolean IsEnabled(LogLevel level);
		public void LogMessage(String message, LogLevel level, LogEntryContext context);
		public void LogException(Exception exception, LogLevel level, LogEntryContext context);
	}
}