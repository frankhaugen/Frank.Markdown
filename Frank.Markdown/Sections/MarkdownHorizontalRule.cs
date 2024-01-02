// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public class MarkdownHorizontalRule : IMarkdownHorizontalRule
{
    public override string ToString() => new string('-', 3);
}