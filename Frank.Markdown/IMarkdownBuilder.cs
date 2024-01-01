namespace Frank.Markdown;

public interface IMarkdownBuilder
{
    IMarkdownBuilder With(IMarkdownSection section);
    
    string ToString();
}