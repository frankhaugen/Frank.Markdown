// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public interface IMarkdownOrderedList : IMarkdownSection
{
    IEnumerable<string> Items { get; }
}