namespace Frank.Markdown;

public static partial class MarkdownBuilderExtensions
{
    public static IMarkdownBuilder WithHeader(this IMarkdownBuilder builder, IMarkdownHeader header) => builder.With(header);
    
    public static IMarkdownBuilder WithHeader(this IMarkdownBuilder builder, string text, int level = 1) => builder.WithHeader(new MarkdownHeader(text, level));
    
    public static IMarkdownBuilder WithHeader(this IMarkdownBuilder builder, string text, MarkdownHeaderLevel level) => builder.WithHeader(new MarkdownHeader(text, level.ToInt()));
}