public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string seperador){
        return str.Split(seperador)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string text, string separator1, string separator2)
    {
        var startIndex = text.IndexOf(separator1) + separator1.Length;
        var endIndex = text.IndexOf(separator2,startIndex);
        var length = endIndex - startIndex;
        return text.Substring(startIndex,length);
    }
        
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string text)
    {
        return text.Split(":")[1].Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string text)
    {
        return text.Split(":")[0][1..^1];
    }
}