namespace Helium.Logging
{
	/// <summary>
	/// Controls the log severity levels.
	/// </summary>
	public enum LogLevel
	{
		/// <summary>
		/// Everything is logged. This may expose sensitive information.
		/// </summary>
		Trace,

		/// <summary>
		/// Debug-relevant information is logged.
		/// </summary>
		Debug,

		/// <summary>
		/// Generic information is logged. This is the standard filter level.
		/// </summary>
		Information,

		/// <summary>
		/// Warnings are logged.
		/// </summary>
		Warning,

		/// <summary>
		/// Errors are logged.
		/// </summary>
		Error,

		/// <summary>
		/// Critical errors are logged.
		/// </summary>
		Critical,

		/// <summary>
		/// Fatal errors are logged.
		/// </summary>
		Fatal
	}
}
