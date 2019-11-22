private static void Logger(string msg)
{
    string path = $"C:/LOGS/{ DateTime.Now.Day.ToString()}{DateTime.Now.Month.ToString()}{DateTime.Now.Year.ToString()}.txt";
    if (File.Exists(path))
    {
        using (StreamWriter w = File.AppendText(path))
        {
            Log(msg, w);
        }
    }
    else
    {
        using (StreamWriter w = File.CreateText(path))
        {
            Log(msg, w);
        }
    }
}

private static void Log(string logMessage, TextWriter w)
{
    w.Write("\r\nLog : ");
    w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
    w.WriteLine("");
    w.WriteLine($"{logMessage}");
    w.WriteLine("-------------------------------");
}
