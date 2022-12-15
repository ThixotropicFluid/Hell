using System;

namespace Hell.Source
{
    internal static class Debug
    {
        internal static class Logger
        {
            static DateTimeOffset now;
            static public void InitializeLogger()
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;

                LogInfo("Debugger Initialized");
            }
            static public void Log(string output)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff] ") + "  Debug:   " + output);
            }
            static public void Log(string output, params object[] args)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff] ") + "  Debug:   " + output, args);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static public void LogInfo(string output)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff] ") + "   Info:   " + output);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static public void LogInfo(string output, params object[] args)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff] ") + "   Info:   " + output, args);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static public void LogError(string output)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff] ") + "  ERROR:   " + output);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static public void LogError(string output, params object[] args)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff] ") + "  ERROR:   " + output, args);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static public void LogWarning(string output)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff]") + " Warning:   " + output);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static public void LogWarning(string output, params object[] args)
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.Now;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(now.ToString("[HH:mm:ss.ff]") + " Warning:   " + output, args);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    } // wites debug info to command line and logger
}
