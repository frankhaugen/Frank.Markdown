// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public interface IMarkdownParagraphItem
{
    string Text { get; }
    
    MarkdownParagraphItemType Type { get; }
}