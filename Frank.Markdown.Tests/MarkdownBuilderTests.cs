using Frank.Markdown;

using JetBrains.Annotations;

using Xunit;

using System.Collections.Generic;
using System.Numerics;

using Xunit.Abstractions;

namespace Frank.Markdown.Tests;

[TestSubject(typeof(MarkdownBuilder))]
public class MarkdownBuilderTests
{
    private readonly ITestOutputHelper _outputHelper;

    public MarkdownBuilderTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void Append_AddSection_ReturnsSelf()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var section = new MarkdownHeader("Header");
        
        // Act
        var result = builder.With(section);
        
        // Assert
        Assert.Equal(builder, result);
    }

    [Fact]
    public void Append_AddSection_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var section1 = new MarkdownHeader("Header");
        var section2 = new MarkdownHeader("Header", 2);

        // Act
        builder.With(section1);
        builder.With(section2);
        
        // Assert
        Assert.Equal("# Header\n\n## Header\n", builder.ToString());
    }

    [Fact]
    public void ToString_NoSections_ReturnsEmpty()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        
        // Act
        
        // Assert
        Assert.Equal("", builder.ToString());
    }

    [Fact]
    public void ToString_SingleSection_ReturnsSectionString()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var section = new MarkdownHeader("Header");
        
        // Act
        builder.With(section);
        
        // Assert
        Assert.Equal("# Header\n", builder.ToString());
    }

    [Fact]
    public void ToString_MultipleSections_ReturnsAllSectionStrings()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var section1 = new MarkdownHeader("Header");
        var section2 = new MarkdownHeader("Header", 2);
        
        // Act
        builder.With(section1);
        builder.With(section2);
        
        // Assert
        Assert.Equal("# Header\n\n## Header\n", builder.ToString());
    }
    
    [Fact]
    public void WithOrderedList_AddItems_ReturnsSelf()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var items = new[] {"Item 1", "Item 2"};
        var orderedList = new MarkdownOrderedList(items);
        
        // Act
        var result = builder.WithOrderedList(orderedList);
        
        // Assert
        Assert.Equal(builder, result);
    }
    
    [Fact]
    public void WithOrderedList_AddItems_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var items = new[] {"Item 1", "Item 2"};
        var orderedList = new MarkdownOrderedList(items);
        
        // Act
        builder.WithOrderedList(orderedList);
        
        // Assert
        Assert.Equal("1. Item 1\n2. Item 2\n", builder.ToString());
    }
    
    [Fact]
    public void WithOrderedList_AddItemsWithStyle_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var items = new[] {"Item 1", "Item 2"};
        var orderedList = new MarkdownOrderedList(items, MarkdownOrderedListStyle.Alpha);
        
        // Act
        builder.WithOrderedList(orderedList);
        
        // Assert
        Assert.Equal("a. Item 1\nb. Item 2\n", builder.ToString());
    }
    
    [Fact]
    public void WithUnorderedList_AddItems_ReturnsSelf()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var items = new[] {"Item 1", "Item 2"};
        var unorderedList = new MarkdownUnorderedList(items);
        
        // Act
        var result = builder.WithUnorderedList(unorderedList);
        
        // Assert
        Assert.Equal(builder, result);
    }
    
    [Fact]
    public void WithUnorderedList_AddItems_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var items = new[] {"Item 1", "Item 2"};
        var unorderedList = new MarkdownUnorderedList(items);
        
        // Act
        builder.WithUnorderedList(unorderedList);
        
        // Assert
        Assert.Equal("- Item 1\n- Item 2\n", builder.ToString());
    }
    
    [Fact]
    public void WithCodeBlock_AddCodeBlock_ReturnsSelf()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var codeBlock = new MarkdownCodeBlock("var x = 1;");
        
        // Act
        var result = builder.WithCodeBlock(codeBlock);
        
        // Assert
        Assert.Equal(builder, result);
    }
    
    [Fact]
    public void WithCodeBlock_AddCodeBlock_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var codeBlock = new MarkdownCodeBlock("var x = 1;");
        
        // Act
        builder.WithCodeBlock(codeBlock);
        
        // Assert
        Assert.Equal("```\nvar x = 1;\n```\n", builder.ToString());
    }
    
    [Fact]
    public void WithCodeBlock_AddCodeBlockWithLanguage_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var codeBlock = new MarkdownCodeBlock("var x = 1;", "csharp");
        
        // Act
        builder.WithCodeBlock(codeBlock);
        
        // Assert
        Assert.Equal("```csharp\nvar x = 1;\n```\n", builder.ToString());
    }
    
    [Fact]
    public void WithTable_AddTable_ReturnsSelf()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var table = new MarkdownTable<MarkdownTableTestRow>(new List<MarkdownTableTestRow>
        {
            new() {Name = "Name 1", Value = 1, Vector = new Vector2(1, 2), Version = new Version(1, 2, 3)},
            new() {Name = "Name 2", Value = 2, Vector = new Vector2(3, 4), Version = new Version(4, 5, 6)}
        });
        
        // Act
        var result = builder.WithTable(table);
        
        // Assert
        Assert.Equal(builder, result);
    }
    
    [Fact]
    public void WithTable_AddTable_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var table = new MarkdownTable<MarkdownTableTestRow>(new List<MarkdownTableTestRow>
        {
            new() {Name = "Name 1", Value = 1, Vector = new Vector2(1, 2), Version = new Version(1, 2, 3)},
            new() {Name = "Name 2", Value = 2, Vector = new Vector2(3, 4), Version = new Version(4, 5, 6)}
        });
        builder.WithTable(table);
        
        // Act
        var result = builder.ToString();
        
        // Assert
        _outputHelper.WriteLine(result);
        Assert.Equal("| Name | Value | Vector | Version |\n| --- | --- | --- | --- |\n| Name 1 | 1 | <1, 2> | 1.2.3 |\n| Name 2 | 2 | <3, 4> | 4.5.6 |\n", result, StringComparer.InvariantCulture);
    }
    
    [Fact]
    public void WithAlert_AddAlert_ReturnsSelf()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var alert = new MarkdownAlert("This is a warning!", MarkdownAlertLevel.Warning);
        
        // Act
        var result = builder.WithAlert(alert);
        
        // Assert
        Assert.Equal(builder, result);
    }
    
    [Fact]
    public void WithAlert_AddAlert_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var alert = new MarkdownAlert("Urgent info that needs immediate user attention to avoid problems.", MarkdownAlertLevel.Warning);
        builder.WithAlert(alert);
        
        // Act
        var result = builder.ToString();
        
        // Assert
        _outputHelper.WriteLine(result);
        Assert.Equal("> [!WARNING]\n> Urgent info that needs immediate user attention to avoid problems.\n", result);
    }
    
    [Fact]
    public void WithAlert_AddAlertWithMultipleLines_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var alert = new MarkdownAlert("Urgent info that needs immediate user attention to avoid problems.\n\nThis is a second line.", MarkdownAlertLevel.Warning);
        builder.WithAlert(alert);
        
        // Act
        var result = builder.ToString();
        
        // Assert
        _outputHelper.WriteLine(result);
        Assert.Equal("> [!WARNING]\n> Urgent info that needs immediate user attention to avoid problems.\n> \n> This is a second line.\n", result);
    }
    
    [Fact]
    public void WithAlert_AddAlertWithMultipleLinesAndLeadingSpaces_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var alert = new MarkdownAlert("Urgent info that needs immediate user attention to avoid problems.\n\n  This is a second line.", MarkdownAlertLevel.Warning);
        builder.WithAlert(alert);
        
        // Act
        var result = builder.ToString();
        
        // Assert
        _outputHelper.WriteLine(result);
        Assert.Equal("> [!WARNING]\n> Urgent info that needs immediate user attention to avoid problems.\n> \n>   This is a second line.\n", result);
    }
    
    [Fact]
    public void WithAlert_AddAlertWithMultipleLinesAndLeadingSpacesAndLeadingGreaterThanSigns_AppendInSectionList()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var alert = new MarkdownAlert("> Urgent info that needs immediate user attention to avoid problems.\n\n  This is a second line.", MarkdownAlertLevel.Warning);
        builder.WithAlert(alert);
        
        // Act
        var result = builder.ToString();
        
        // Assert
        _outputHelper.WriteLine(result);
        Assert.Equal("> [!WARNING]\n> Urgent info that needs immediate user attention to avoid problems.\n> \n>   This is a second line.\n", result);
    }
    
    [Fact]
    public void WithEverything_AddAllSections_ReturnsSelf()
    {
        // Arrange
        var builder = new MarkdownBuilder();
        var section1 = new MarkdownHeader("Header");
        var section2 = new MarkdownHeader("Header", 2);
        var items = new[] {"Item 1", "Item 2"};
        var orderedList = new MarkdownOrderedList(items);
        var unorderedList = new MarkdownUnorderedList(items);
        var codeBlock = new MarkdownCodeBlock("var x = 1;");
        var table = new MarkdownTable<MarkdownTableTestRow>(new List<MarkdownTableTestRow>
        {
            new() {Name = "Name 1", Value = 1, Vector = new Vector2(1, 2), Version = new Version(1, 2, 3)},
            new() {Name = "Name 2", Value = 2, Vector = new Vector2(3, 4), Version = new Version(4, 5, 6)}
        });
        var alert = new MarkdownAlert("Urgent info that needs immediate user attention to avoid problems.", MarkdownAlertLevel.Warning);

        // Act
        var result = builder
            .With(section1)
            .WithHeader(section2)
            .WithOrderedList(orderedList)
            .WithUnorderedList(unorderedList)
            .WithCodeBlock(codeBlock)
            .WithTable(table)
            .WithAlert(alert);
        
        // Assert
        _outputHelper.WriteLine(result.ToString());
        Assert.Equal(builder, result);
    }

    private class MarkdownTableTestRow
    {
        public string Name { get; set; }
        
        public decimal Value { get; set; }
        
        public Vector2 Vector { get; set; }
        
        public Version Version { get; set; }
    }
}