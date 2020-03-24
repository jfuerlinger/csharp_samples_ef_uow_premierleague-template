using Serilog;
using Serilog.Events;

namespace Utils
{
    public static class MyLogger
    {
        public static SqlCommandsObserver SqlCommandLogObserver { get; private set; }
        public static void InitializeLogger()
        {
            SqlCommandLogObserver = new SqlCommandsObserver();
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                // Log-Meldungen des Entity Frameworks filtern:
                .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
                .WriteTo.Console()
                .WriteTo.File("Serilog.log")
                .WriteTo.Observers(events => events
                    .Subscribe(SqlCommandLogObserver))
                .CreateLogger();
        }
    }
}
