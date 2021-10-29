using System;
using System.Collections.Generic;

namespace Helium.Logging
{
	public interface ILogger
	{
		public List<ILoggingSink> Sinks { get; }

		public Boolean IsEnabled(LogLevel level);
		public ILogger RegisterSink(ILoggingSink sink);

		public ILogger SetDefaultMessageTemplate(String template);
		public ILogger SetDefaultExceptionTemplate(String template);

		public ILogger RemoveSink(ILoggingSink sink);
		public ILogger RemoveAllSinks<T>() 
			where T : ILoggingSink;

		public ILogger ClearSinks();

		public void LogMessage(String message, LogLevel level, LogEntryContext context);
		public void LogException(Exception exception, LogLevel level, LogEntryContext context);
	}
}