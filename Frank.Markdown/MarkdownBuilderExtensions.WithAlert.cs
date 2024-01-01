namespace Frank.Markdown;

public partial class MarkdownBuilderExtensions
{
    public static IMarkdownBuilder WithAlert(this IMarkdownBuilder builder, IMarkdownAlert alert) => builder.With(alert);
    
    public static IMarkdownBuilder WithAlert(this IMarkdownBuilder builder, string message, MarkdownAlertLevel level) => builder.WithAlert(new MarkdownAlert(message, level));
}