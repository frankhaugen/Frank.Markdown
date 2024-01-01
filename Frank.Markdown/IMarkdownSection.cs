namespace Frank.Markdown;

public interface IMarkdownSection
{
    static char NewLine => '\n';
    
    string ToString();
}