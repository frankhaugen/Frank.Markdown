namespace Frank.Markdown;

public interface IMarkdownParagraphBuilder
{
    IMarkdownParagraphBuilder Append(string text);

    IMarkdownParagraphBuilder AppendLine(string text);

    IMarkdownParagraphBuilder AppendLine();

    IMarkdownParagraph Build();
}