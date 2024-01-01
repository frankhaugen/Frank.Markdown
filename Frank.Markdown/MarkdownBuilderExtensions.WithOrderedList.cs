namespace Frank.Markdown;

public static partial class MarkdownBuilderExtensions
{
    public static IMarkdownBuilder WithOrderedList(this IMarkdownBuilder builder, IMarkdownOrderedList orderedList) => builder.With(orderedList);
    
    public static IMarkdownBuilder WithOrderedList(this IMarkdownBuilder builder, params string[] items) => builder.WithOrderedList(new MarkdownOrderedList(items));
    
    public static IMarkdownBuilder WithOrderedList(this IMarkdownBuilder builder, IEnumerable<string> items, MarkdownOrderedListStyle style = MarkdownOrderedListStyle.Numbered)
        => builder.WithOrderedList(new MarkdownOrderedList(items, style));
}