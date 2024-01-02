// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public interface IMarkdownAlert : IMarkdownQuote
{
    MarkdownAlertLevel Level { get; }
}