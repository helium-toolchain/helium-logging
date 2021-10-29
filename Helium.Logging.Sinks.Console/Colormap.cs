using System.Collections.Generic;
using System.Drawing;

namespace Helium.Logging.Sinks.Console
{
	public class Colormap
	{
		public Dictionary<LogLevel, Color> LevelForegroundColors { get; set; }
		public Dictionary<LogLevel, Color> TextForegroundColors { get; set; }
	}
}
