using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Helium.Logging
{
	public class HeliumLogger : ILogger
	{
		private List<ILoggingSink> _sinks;

		private String _messageTemplate;
		private String _exceptionTemplate;

		private LogLevel _level;
		private Boolean _async;

		#region Interface implementation

		public List<ILoggingSink> Sinks => _sinks;

		public ILogger ClearSinks()
		{
			_sinks = new();
			return this;
		}

		public Boolean IsEnabled(LogLevel level)
		{
			return level >= _level;
		}

		public void LogException(Exception exception, LogLevel level, LogEntryContext context)
		{
			if(_async)
			{
				foreach(ILoggingSink sink in _sinks)
				{
					Task.Run(() => sink.LogException(exception, level, context));
				}
			}
			else
			{
				foreach(ILoggingSink sink in _sinks)
				{
					sink.LogException(exception, level, context);
				}
			}
		}

		public void LogMessage(String message, LogLevel level, LogEntryContext context)
		{
			throw new NotImplementedException();
		}

		public ILogger RegisterSink(ILoggingSink sink)
		{
			_sinks.Add(sink);
			return this;
		}

		public ILogger RemoveAllSinks<T>() where T : ILoggingSink
		{
			_sinks.RemoveAll(xm => xm.GetType() == typeof(T));
			return this;
		}

		public ILogger RemoveSink(ILoggingSink sink)
		{
			_sinks.Remove(sink);
			return this;
		}

		public ILogger SetDefaultExceptionTemplate(String template)
		{
			_exceptionTemplate = template;
			return this;
		}

		public ILogger SetDefaultMessageTemplate(String template)
		{
			_messageTemplate = template;
			return this;
		}

		#endregion

		public ILogger SetLogLevel(LogLevel level)
		{
			_level = level;
			return this;
		}

		public ILogger SetAsync(Boolean @async)
		{
			_async = async;
			return this;
		}

		public String MessageTemplate => _messageTemplate;
		public String ExceptionTemplate => _exceptionTemplate;
	}
}