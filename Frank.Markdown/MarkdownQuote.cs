namespace Frank.Markdown;

public class MarkdownQuote : IMarkdownQuote
{
    public IEnumerable<string> Text { get; }

    public MarkdownQuote(string text)
    {
        Text = text.ReplaceLineEndings(IMarkdownSection.NewLine.ToString()).Split(IMarkdownSection.NewLine);
    }

    public override string ToString() => string.Join(IMarkdownSection.NewLine, Text.Select(line => $"> {line}")) + IMarkdownSection.NewLine;
}