using System.Text;

namespace Frank.Markdown;

public class MarkdownParagraphBuilder : IMarkdownParagraphBuilder
{
    private readonly StringBuilder _builder = new();

    public IMarkdownParagraphBuilder Append(string text)
    {
        _builder.Append(text);
        return this;
    }

    public IMarkdownParagraphBuilder AppendLine(string text)
    {
        _builder.AppendLine(text);
        return this;
    }

    public IMarkdownParagraphBuilder AppendLine()
    {
        _builder.AppendLine();
        return this;
    }

    public IMarkdownParagraph Build() => new MarkdownParagraph(_builder.ToString());
}