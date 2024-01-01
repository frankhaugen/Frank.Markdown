namespace Frank.Markdown;

public static partial class MarkdownBuilderExtensions
{
    public static IMarkdownBuilder WithCodeBlock(this IMarkdownBuilder builder, IMarkdownCodeBlock codeBlock) => builder.With(codeBlock);
    
    public static IMarkdownBuilder WithCodeBlock(this IMarkdownBuilder builder, string code, string language = "") => builder.WithCodeBlock(new MarkdownCodeBlock(code, language));
}