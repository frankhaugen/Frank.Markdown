namespace Frank.Markdown;

public static partial class MarkdownBuilderExtensions
{
    public static IMarkdownBuilder WithTable(this IMarkdownBuilder builder, IMarkdownTable table) => builder.With(table);
    
    public static IMarkdownBuilder WithTable<T>(this IMarkdownBuilder builder, IEnumerable<T> items) => builder.WithTable(new MarkdownTable<T>(items));
}