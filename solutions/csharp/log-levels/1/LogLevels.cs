static class LogLine
{
    public static string Message(string logLine)
    {
        return ObtenerPartesLog(logLine)[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        return ObtenerPartesLog(logLine)[0][1..^1].ToLower().Trim();
    }

    public static string Reformat(string logLine)
    {
        var primeraLinea = ObtenerPartesLog(logLine)[1].Trim();
        var segundaLinea = ObtenerPartesLog(logLine)[0].Trim().ToLower().Replace("[", "(").Replace("]", ")");
        return $"{primeraLinea} {segundaLinea}";
    }

    public static string[] ObtenerPartesLog(string logLine)
    {
        return logLine.Split(":");
    }
}
