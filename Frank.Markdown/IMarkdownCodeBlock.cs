namespace Frank.Markdown;

public interface IMarkdownCodeBlock : IMarkdownSection
{
    string Code { get; }
    
    string Language { get; }
}