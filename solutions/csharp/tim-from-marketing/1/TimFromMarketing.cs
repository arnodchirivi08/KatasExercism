static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var departamentString = string.IsNullOrEmpty(department) ? "- OWNER":  $"- {department.ToUpper()}";     
        return id.HasValue ? $"[{id}] - {name} {departamentString}": $"{name} {departamentString}";
    }
}
