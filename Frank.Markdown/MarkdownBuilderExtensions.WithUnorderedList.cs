namespace Frank.Markdown;

public static partial class MarkdownBuilderExtensions
{
    public static IMarkdownBuilder WithUnorderedList(this IMarkdownBuilder builder, IMarkdownUnorderedList unorderedList) => builder.With(unorderedList);
    
    public static IMarkdownBuilder WithUnorderedList(this IMarkdownBuilder builder, params string[] items) => builder.WithUnorderedList(new MarkdownUnorderedList(items));
    
    public static IMarkdownBuilder WithUnorderedList(this IMarkdownBuilder builder, IEnumerable<string> items) => builder.WithUnorderedList(new MarkdownUnorderedList(items));
}