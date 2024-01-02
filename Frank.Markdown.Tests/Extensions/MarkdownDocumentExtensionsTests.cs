using JetBrains.Annotations;

using Xunit.Abstractions;

namespace Frank.Markdown.Tests.Extensions
{
    [TestSubject(typeof(MarkdownDocumentExtensions))]
    public class MarkdownDocumentExtensionsTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public MarkdownDocumentExtensionsTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void ToHtml()
        {
            // Arrange
            var markdownBuilder = new MarkdownDocument()
                .WithHeader("Test Header")
                .WithAlert("Test Alert", MarkdownAlertLevel.Caution)
                .WithParagraph(new MarkdownParagraph().WithText("Test Paragraph"))
                .WithOrderedList(new List<string> {"Test", "Example", "Ex."})
                .WithTable(new MarkdownTable<TestTypeSimple>(new List<TestTypeSimple>
                {
                    new() {IntNumber = 1, StrValue = "test", GuidValue = Guid.NewGuid(), Date = DateTime.Now},
                    new() {IntNumber = 2, StrValue = "example", GuidValue = Guid.NewGuid(), Date = DateTime.Now},
                    new() {IntNumber = 3, StrValue = "ex.", GuidValue = Guid.NewGuid(), Date = DateTime.Now},
                }));
            var markdownDocument = markdownBuilder;
            
            _outputHelper.WriteLine(markdownDocument.ToString());
            
            // Act
            // var html = markdownDocument.ToHtml();
            var html = markdownDocument.ToHtml();
            
            // Assert
            _outputHelper.WriteLine(html);
        }

        private class TestTypeSimple
        {
            public int IntNumber { get; set; }

            public string StrValue { get; set; }

            public Guid GuidValue { get; set; }

            public DateTime Date { get; set; }
        }
    }
}