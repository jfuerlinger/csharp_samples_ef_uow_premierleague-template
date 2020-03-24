using System;
using System.Collections.Generic;
using System.Text;
using Serilog.Events;

namespace Utils
{
    public class SqlCommandsObserver : IObserver<LogEvent>
    {

        public string LogText { get; private set; }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(LogEvent logEvent)
        {
            foreach (var prop in logEvent.Properties)
            {
                if (prop.Key == "commandText")
                {
                    LogText = LogText += prop.Value;
                    LogText += "\n";
                }
            }
        }

        public void ClearLogText()
        {
            LogText = "";
        }
    }
}
