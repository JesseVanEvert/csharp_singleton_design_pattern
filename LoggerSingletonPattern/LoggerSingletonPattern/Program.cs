using LoggerSingletonPattern;

Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

Console.WriteLine(logger1 == logger2);

logger1.Log("A log message");
logger2.Log("Another log message");
