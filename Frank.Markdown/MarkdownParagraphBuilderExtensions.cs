namespace Frank.Markdown;

public static class MarkdownParagraphBuilderExtensions
{
    public static IMarkdownParagraphBuilder WithBold(this IMarkdownParagraphBuilder builder, string text)
    {
        builder.Append("**");
        builder.Append(text);
        builder.Append("**");
        return builder;
    }
    
    public static IMarkdownParagraphBuilder WithItalic(this IMarkdownParagraphBuilder builder, string text)
    {
        builder.Append("*");
        builder.Append(text);
        builder.Append("*");
        return builder;
    }
    
    public static IMarkdownParagraphBuilder WithLink(this IMarkdownParagraphBuilder builder, string text, string url)
    {
        builder.Append("[");
        builder.Append(text);
        builder.Append("](");
        builder.Append(url);
        builder.Append(")");
        return builder;
    }
    
    public static IMarkdownParagraphBuilder WithCode(this IMarkdownParagraphBuilder builder, string text)
    {
        builder.Append("`");
        builder.Append(text);
        builder.Append("`");
        return builder;
    }
    
    public static IMarkdownParagraphBuilder WithIndent(this IMarkdownParagraphBuilder builder, int indent = 1)
    {
        for (var i = 0; i < indent; i++)
        {
            builder.Append("    ");
        }
        return builder;
    }
}