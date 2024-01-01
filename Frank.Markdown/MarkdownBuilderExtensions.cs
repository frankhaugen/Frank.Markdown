namespace Frank.Markdown;

public static partial class MarkdownBuilderExtensions
{
    public static IMarkdownBuilder WithParagraph(this IMarkdownBuilder builder, IMarkdownParagraph paragraph) => builder.With(paragraph);

    public static IMarkdownBuilder WithHorizontalRule(this IMarkdownBuilder builder, IMarkdownHorizontalRule horizontalRule) => builder.With(horizontalRule);
}