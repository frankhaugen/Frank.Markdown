namespace Frank.Markdown;

public interface IMarkdownAlert : IMarkdownQuote
{
    MarkdownAlertLevel Level { get; }
}