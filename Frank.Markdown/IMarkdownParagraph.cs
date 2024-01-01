namespace Frank.Markdown;

public interface IMarkdownParagraph : IMarkdownSection
{
    string Text { get; }
}