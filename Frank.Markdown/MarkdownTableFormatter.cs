namespace Frank.Markdown;

internal static class MarkdownTableFormatter
{
    public static string Format<T>(IEnumerable<T> items)
    {
        var type = typeof(T);
        var properties = type.GetProperties();

        // Create header
        var header = "| " + string.Join(" | ", properties.Select(prop => prop.Name)) + " |";
        
        // Create separator
        var separator = "| " + string.Join(" | ", properties.Select(_ => "---")) + " |";

        // Create lines
        var lines = new List<string> { header, separator };
        lines.AddRange(items.Select(item => "| " + string.Join(" | ", properties.Select(prop => FormatCellValue(prop.GetValue(item), prop.PropertyType))) + " |"));

        return string.Join(IMarkdownSection.NewLine, lines);
    }

    private static string FormatCellValue(object? value, Type type)
    {
        if (value == null)
            return string.Empty;

        if (IsSimpleType(type) || HasCustomToString(value))
            return value.ToString()?.ReplaceLineEndings(string.Empty) ?? string.Empty;

        return "{}";
    }

    private static bool HasCustomToString(object? obj)
    {
        var toString = obj?.ToString();
        return !string.IsNullOrEmpty(toString) && toString != obj?.GetType().ToString() && toString.Length < 128;
    }

    private static bool IsSimpleType(Type type)
    {
        return
            type.IsPrimitive ||
            new Type[] {
                typeof(Enum),
                typeof(String),
                typeof(Decimal),
                typeof(DateTime),
                typeof(DateTimeOffset),
                typeof(TimeSpan),
                typeof(Guid)
            }.Contains(type) ||
            Convert.GetTypeCode(type) != TypeCode.Object;
    }
}