// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public interface IMarkdownHeader : IMarkdownSection
{
    string Text { get; }
    
    int Level { get; }
}