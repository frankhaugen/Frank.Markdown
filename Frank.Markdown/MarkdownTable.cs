namespace Frank.Markdown;

public class MarkdownTable<T>(IEnumerable<T> items) : IMarkdownTable
{
    public override string ToString() => MarkdownTableFormatter.Format(items) + IMarkdownSection.NewLine;
}