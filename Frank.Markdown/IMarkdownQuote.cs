namespace Frank.Markdown;

public interface IMarkdownQuote : IMarkdownSection
{
    IEnumerable<string> Text { get; }
}