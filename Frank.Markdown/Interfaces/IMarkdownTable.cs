// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public interface IMarkdownTable : IMarkdownSection
{
    IEnumerable<string> Headers { get; }
    
    IEnumerable<IEnumerable<string>> Rows { get; }
}