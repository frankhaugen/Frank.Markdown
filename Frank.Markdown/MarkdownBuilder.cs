namespace Frank.Markdown;

public class MarkdownBuilder : IMarkdownBuilder
{
    private readonly List<IMarkdownSection> _sections = new();

    public IMarkdownBuilder With(IMarkdownSection section)
    {
        _sections.Add(section);
        return this;
    }

    public override string ToString() => string.Join(IMarkdownSection.NewLine, _sections.Select(x => x.ToString()));
}