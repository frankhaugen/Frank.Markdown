# Frank.Markdown

A great fluent API for creating markdown documents in C#.

___
[![GitHub License](https://img.shields.io/github/license/frankhaugen/Frank.Markdown)](LICENSE)
[![NuGet](https://img.shields.io/nuget/v/Frank.Markdown.svg)](https://www.nuget.org/packages/Frank.Markdown)
[![NuGet](https://img.shields.io/nuget/dt/Frank.Markdown.svg)](https://www.nuget.org/packages/Frank.Markdown)

![GitHub contributors](https://img.shields.io/github/contributors/frankhaugen/Frank.Markdown)
![GitHub Release Date - Published_At](https://img.shields.io/github/release-date/frankhaugen/Frank.Markdown)
![GitHub last commit](https://img.shields.io/github/last-commit/frankhaugen/Frank.Markdown)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/frankhaugen/Frank.Markdown)
![GitHub pull requests](https://img.shields.io/github/issues-pr/frankhaugen/Frank.Markdown)
![GitHub issues](https://img.shields.io/github/issues/frankhaugen/Frank.Markdown)
![GitHub closed issues](https://img.shields.io/github/issues-closed/frankhaugen/Frank.Markdown)
___

## Installation

### NuGet

```powershell
Install-Package Frank.Markdown
```

## Usage

### Create a markdown document

```csharp
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

var builder = new MarkdownDocument();
    .With(section1)
    .WithHeader(section2)
    .WithOrderedList(orderedList)
    .WithUnorderedList(unorderedList)
    .WithCodeBlock(codeBlock)
    .WithTable(table)
    .WithAlert(alert);

var result = builder.ToString();
```

### Result

```markdown
# Header

## Header

1. Item 1
2. Item 2

- Item 1
- Item 2

@```
var x = 1;
@```

| Name | Value | Vector | Version |
| --- | --- | --- | --- |
| Name 1 | 1 | <1  2> | 1.2.3 |
| Name 2 | 2 | <3  4> | 4.5.6 |

> [!WARNING]
> Urgent info that needs immediate user attention to avoid problems.
```