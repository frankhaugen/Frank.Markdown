// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public interface IMarkdownParagraph : IMarkdownSection
{
    IEnumerable<IMarkdownParagraphItem> Items { get; }
}