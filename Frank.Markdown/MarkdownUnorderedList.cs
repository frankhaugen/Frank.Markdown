namespace Frank.Markdown;

public class MarkdownUnorderedList : IMarkdownUnorderedList
{
    private readonly List<string> _items;

    public MarkdownUnorderedList(IEnumerable<string> items) => _items = items.ToList();

    public override string ToString() => string.Join(IMarkdownSection.NewLine, _items.Select(x => $"- {x}")) + IMarkdownSection.NewLine;
}