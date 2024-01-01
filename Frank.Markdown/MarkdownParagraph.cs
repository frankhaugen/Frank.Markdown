namespace Frank.Markdown;

public class MarkdownParagraph : IMarkdownParagraph
{
    public string Text { get; }

    public MarkdownParagraph(string text) => Text = text;

    public override string ToString() => Text + IMarkdownSection.NewLine;
}