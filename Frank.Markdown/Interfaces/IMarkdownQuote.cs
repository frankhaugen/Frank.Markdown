// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public interface IMarkdownQuote : IMarkdownSection
{
    IEnumerable<string> Text { get; }
}