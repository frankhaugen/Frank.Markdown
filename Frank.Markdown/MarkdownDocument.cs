using System.Collections;

// ReSharper disable CheckNamespace
namespace Frank.Markdown;

public class MarkdownDocument() : IMarkdownDocument
{
    private readonly SortedList<int, IMarkdownSection> _sections = new();

    public IMarkdownSection this[int index] => _sections[index];
    
    public IEnumerator<IMarkdownSection> GetEnumerator() => _sections.Values.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public override string ToString() => string.Join(IMarkdownSection.NewLine, _sections.Values.Select(x => x.ToString())) + IMarkdownSection.NewLine;
    public IMarkdownDocument With(IMarkdownSection section)
    {
        _sections.Add(_sections.Count, section);
        return this;
    }

    public IMarkdownDocument With(IEnumerable<IMarkdownSection> sections)
    {
        foreach (var section in sections)
        {
            _sections.Add(_sections.Count, section);
        }
        return this;
    }
    
    public static IMarkdownDocument Empty => new MarkdownDocument();
    
    public static IMarkdownDocument Create(params IMarkdownSection[] sections) => new MarkdownDocument().With(sections);
    
    public static IMarkdownDocument Create(IEnumerable<IMarkdownSection> sections) => new MarkdownDocument().With(sections);
    
    public static IMarkdownDocument Create(params string[] sections) => new MarkdownDocument().With(sections.Select(x => new MarkdownParagraph().WithText(x)));
    
    public static IMarkdownDocument Create(IEnumerable<string> sections) => new MarkdownDocument().With(sections.Select(x => new MarkdownParagraph().WithText(x)));
}