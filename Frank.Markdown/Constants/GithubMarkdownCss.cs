﻿namespace Frank.Markdown;

public static class GithubMarkdownCss
{
    public const string DefaultUrl = "https://cdnjs.cloudflare.com/ajax/libs/github-markdown-css/4.0.0/github-markdown.min.css";

    public const string Default = """
                                  .markdown-body .octicon{display:inline-block;fill:currentColor;vertical-align:text-bottom}.markdown-body .anchor{float:left;line-height:1;margin-left:-20px;padding-right:4px}.markdown-body .anchor:focus{outline:0}.markdown-body h1 .octicon-link,.markdown-body h2 .octicon-link,.markdown-body h3 .octicon-link,.markdown-body h4 .octicon-link,.markdown-body h5 .octicon-link,.markdown-body h6 .octicon-link{color:#1b1f23;vertical-align:middle;visibility:hidden}.markdown-body h1:hover .anchor,.markdown-body h2:hover .anchor,.markdown-body h3:hover .anchor,.markdown-body h4:hover .anchor,.markdown-body h5:hover .anchor,.markdown-body h6:hover .anchor{text-decoration:none}.markdown-body h1:hover .anchor .octicon-link,.markdown-body h2:hover .anchor .octicon-link,.markdown-body h3:hover .anchor .octicon-link,.markdown-body h4:hover .anchor .octicon-link,.markdown-body h5:hover .anchor .octicon-link,.markdown-body h6:hover .anchor .octicon-link{visibility:visible}.markdown-body h1:hover .anchor .octicon-link:before,.markdown-body h2:hover .anchor .octicon-link:before,.markdown-body h3:hover .anchor .octicon-link:before,.markdown-body h4:hover .anchor .octicon-link:before,.markdown-body h5:hover .anchor .octicon-link:before,.markdown-body h6:hover .anchor .octicon-link:before{width:16px;height:16px;content:' ';display:inline-block;background-image:url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' version='1.1' width='16' height='16' aria-hidden='true'%3E%3Cpath fill-rule='evenodd' d='M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z'%3E%3C/path%3E%3C/svg%3E")}.markdown-body{-ms-text-size-adjust:100%;-webkit-text-size-adjust:100%;line-height:1.5;color:#24292e;font-family:-apple-system,BlinkMacSystemFont,Segoe UI,Helvetica,Arial,sans-serif,Apple Color Emoji,Segoe UI Emoji;font-size:16px;line-height:1.5;word-wrap:break-word}.markdown-body details{display:block}.markdown-body summary{display:list-item}.markdown-body a{background-color:initial}.markdown-body a:active,.markdown-body a:hover{outline-width:0}.markdown-body strong{font-weight:inherit;font-weight:bolder}.markdown-body h1{font-size:2em;margin:.67em 0}.markdown-body img{border-style:none}.markdown-body code,.markdown-body kbd,.markdown-body pre{font-family:monospace,monospace;font-size:1em}.markdown-body hr{box-sizing:initial;height:0;overflow:visible}.markdown-body input{font:inherit;margin:0}.markdown-body input{overflow:visible}.markdown-body [type=checkbox]{box-sizing:border-box;padding:0}.markdown-body *{box-sizing:border-box}.markdown-body input{font-family:inherit;font-size:inherit;line-height:inherit}.markdown-body a{color:#0366d6;text-decoration:none}.markdown-body a:hover{text-decoration:underline}.markdown-body strong{font-weight:600}.markdown-body hr{height:0;margin:15px 0;overflow:hidden;background:0 0;border:0;border-bottom:1px solid #dfe2e5}.markdown-body hr:after,.markdown-body hr:before{display:table;content:""}.markdown-body hr:after{clear:both}.markdown-body table{border-spacing:0;border-collapse:collapse}.markdown-body td,.markdown-body th{padding:0}.markdown-body details summary{cursor:pointer}.markdown-body kbd{display:inline-block;padding:3px 5px;font:11px SFMono-Regular,Consolas,Liberation Mono,Menlo,monospace;line-height:10px;color:#444d56;vertical-align:middle;background-color:#fafbfc;border:1px solid #d1d5da;border-radius:3px;box-shadow:inset 0 -1px 0 #d1d5da}.markdown-body h1,.markdown-body h2,.markdown-body h3,.markdown-body h4,.markdown-body h5,.markdown-body h6{margin-top:0;margin-bottom:0}.markdown-body h1{font-size:32px}.markdown-body h1,.markdown-body h2{font-weight:600}.markdown-body h2{font-size:24px}.markdown-body h3{font-size:20px}.markdown-body h3,.markdown-body h4{font-weight:600}.markdown-body h4{font-size:16px}.markdown-body h5{font-size:14px}.markdown-body h5,.markdown-body h6{font-weight:600}.markdown-body h6{font-size:12px}.markdown-body p{margin-top:0;margin-bottom:10px}.markdown-body blockquote{margin:0}.markdown-body ol,.markdown-body ul{padding-left:0;margin-top:0;margin-bottom:0}.markdown-body ol ol,.markdown-body ul ol{list-style-type:lower-roman}.markdown-body ol ol ol,.markdown-body ol ul ol,.markdown-body ul ol ol,.markdown-body ul ul ol{list-style-type:lower-alpha}.markdown-body dd{margin-left:0}.markdown-body code,.markdown-body pre{font-family:SFMono-Regular,Consolas,Liberation Mono,Menlo,monospace;font-size:12px}.markdown-body pre{margin-top:0;margin-bottom:0}.markdown-body input::-webkit-inner-spin-button,.markdown-body input::-webkit-outer-spin-button{margin:0;-webkit-appearance:none;appearance:none}.markdown-body :checked+.radio-label{position:relative;z-index:1;border-color:#0366d6}.markdown-body .border{border:1px solid #e1e4e8!important}.markdown-body .border-0{border:0!important}.markdown-body .border-bottom{border-bottom:1px solid #e1e4e8!important}.markdown-body .rounded-1{border-radius:3px!important}.markdown-body .bg-white{background-color:#fff!important}.markdown-body .bg-gray-light{background-color:#fafbfc!important}.markdown-body .text-gray-light{color:#6a737d!important}.markdown-body .mb-0{margin-bottom:0!important}.markdown-body .my-2{margin-top:8px!important;margin-bottom:8px!important}.markdown-body .pl-0{padding-left:0!important}.markdown-body .py-0{padding-top:0!important;padding-bottom:0!important}.markdown-body .pl-1{padding-left:4px!important}.markdown-body .pl-2{padding-left:8px!important}.markdown-body .py-2{padding-top:8px!important;padding-bottom:8px!important}.markdown-body .pl-3,.markdown-body .px-3{padding-left:16px!important}.markdown-body .px-3{padding-right:16px!important}.markdown-body .pl-4{padding-left:24px!important}.markdown-body .pl-5{padding-left:32px!important}.markdown-body .pl-6{padding-left:40px!important}.markdown-body .f6{font-size:12px!important}.markdown-body .lh-condensed{line-height:1.25!important}.markdown-body .text-bold{font-weight:600!important}.markdown-body .pl-c{color:#6a737d}.markdown-body .pl-c1,.markdown-body .pl-s .pl-v{color:#005cc5}.markdown-body .pl-e,.markdown-body .pl-en{color:#6f42c1}.markdown-body .pl-s .pl-s1,.markdown-body .pl-smi{color:#24292e}.markdown-body .pl-ent{color:#22863a}.markdown-body .pl-k{color:#d73a49}.markdown-body .pl-pds,.markdown-body .pl-s,.markdown-body .pl-s .pl-pse .pl-s1,.markdown-body .pl-sr,.markdown-body .pl-sr .pl-cce,.markdown-body .pl-sr .pl-sra,.markdown-body .pl-sr .pl-sre{color:#032f62}.markdown-body .pl-smw,.markdown-body .pl-v{color:#e36209}.markdown-body .pl-bu{color:#b31d28}.markdown-body .pl-ii{color:#fafbfc;background-color:#b31d28}.markdown-body .pl-c2{color:#fafbfc;background-color:#d73a49}.markdown-body .pl-c2:before{content:"^M"}.markdown-body .pl-sr .pl-cce{font-weight:700;color:#22863a}.markdown-body .pl-ml{color:#735c0f}.markdown-body .pl-mh,.markdown-body .pl-mh .pl-en,.markdown-body .pl-ms{font-weight:700;color:#005cc5}.markdown-body .pl-mi{font-style:italic;color:#24292e}.markdown-body .pl-mb{font-weight:700;color:#24292e}.markdown-body .pl-md{color:#b31d28;background-color:#ffeef0}.markdown-body .pl-mi1{color:#22863a;background-color:#f0fff4}.markdown-body .pl-mc{color:#e36209;background-color:#ffebda}.markdown-body .pl-mi2{color:#f6f8fa;background-color:#005cc5}.markdown-body .pl-mdr{font-weight:700;color:#6f42c1}.markdown-body .pl-ba{color:#586069}.markdown-body .pl-sg{color:#959da5}.markdown-body .pl-corl{text-decoration:underline;color:#032f62}.markdown-body .mb-0{margin-bottom:0!important}.markdown-body .my-2{margin-bottom:8px!important}.markdown-body .my-2{margin-top:8px!important}.markdown-body .pl-0{padding-left:0!important}.markdown-body .py-0{padding-top:0!important;padding-bottom:0!important}.markdown-body .pl-1{padding-left:4px!important}.markdown-body .pl-2{padding-left:8px!important}.markdown-body .py-2{padding-top:8px!important;padding-bottom:8px!important}.markdown-body .pl-3{padding-left:16px!important}.markdown-body .pl-4{padding-left:24px!important}.markdown-body .pl-5{padding-left:32px!important}.markdown-body .pl-6{padding-left:40px!important}.markdown-body .pl-7{padding-left:48px!important}.markdown-body .pl-8{padding-left:64px!important}.markdown-body .pl-9{padding-left:80px!important}.markdown-body .pl-10{padding-left:96px!important}.markdown-body .pl-11{padding-left:112px!important}.markdown-body .pl-12{padding-left:128px!important}.markdown-body hr{border-bottom-color:#eee}.markdown-body kbd{display:inline-block;padding:3px 5px;font:11px SFMono-Regular,Consolas,Liberation Mono,Menlo,monospace;line-height:10px;color:#444d56;vertical-align:middle;background-color:#fafbfc;border:1px solid #d1d5da;border-radius:3px;box-shadow:inset 0 -1px 0 #d1d5da}.markdown-body:after,.markdown-body:before{display:table;content:""}.markdown-body:after{clear:both}.markdown-body>:first-child{margin-top:0!important}.markdown-body>:last-child{margin-bottom:0!important}.markdown-body a:not([href]){color:inherit;text-decoration:none}.markdown-body blockquote,.markdown-body details,.markdown-body dl,.markdown-body ol,.markdown-body p,.markdown-body pre,.markdown-body table,.markdown-body ul{margin-top:0;margin-bottom:16px}.markdown-body hr{height:.25em;padding:0;margin:24px 0;background-color:#e1e4e8;border:0}.markdown-body blockquote{padding:0 1em;color:#6a737d;border-left:.25em solid #dfe2e5}.markdown-body blockquote>:first-child{margin-top:0}.markdown-body blockquote>:last-child{margin-bottom:0}.markdown-body h1,.markdown-body h2,.markdown-body h3,.markdown-body h4,.markdown-body h5,.markdown-body h6{margin-top:24px;margin-bottom:16px;font-weight:600;line-height:1.25}.markdown-body h1{font-size:2em}.markdown-body h1,.markdown-body h2{padding-bottom:.3em;border-bottom:1px solid #eaecef}.markdown-body h2{font-size:1.5em}.markdown-body h3{font-size:1.25em}.markdown-body h4{font-size:1em}.markdown-body h5{font-size:.875em}.markdown-body h6{font-size:.85em;color:#6a737d}.markdown-body ol,.markdown-body ul{padding-left:2em}.markdown-body ol ol,.markdown-body ol ul,.markdown-body ul ol,.markdown-body ul ul{margin-top:0;margin-bottom:0}.markdown-body li{word-wrap:break-all}.markdown-body li>p{margin-top:16px}.markdown-body li+li{margin-top:.25em}.markdown-body dl{padding:0}.markdown-body dl dt{padding:0;margin-top:16px;font-size:1em;font-style:italic;font-weight:600}.markdown-body dl dd{padding:0 16px;margin-bottom:16px}.markdown-body table{display:block;width:100%;overflow:auto}.markdown-body table th{font-weight:600}.markdown-body table td,.markdown-body table th{padding:6px 13px;border:1px solid #dfe2e5}.markdown-body table tr{background-color:#fff;border-top:1px solid #c6cbd1}.markdown-body table tr:nth-child(2n){background-color:#f6f8fa}.markdown-body img{max-width:100%;box-sizing:initial;background-color:#fff}.markdown-body img[align=right]{padding-left:20px}.markdown-body img[align=left]{padding-right:20px}.markdown-body code{padding:.2em .4em;margin:0;font-size:85%;background-color:rgba(27,31,35,.05);border-radius:3px}.markdown-body pre{word-wrap:normal}.markdown-body pre>code{padding:0;margin:0;font-size:100%;word-break:normal;white-space:pre;background:0 0;border:0}.markdown-body .highlight{margin-bottom:16px}.markdown-body .highlight pre{margin-bottom:0;word-break:normal}.markdown-body .highlight pre,.markdown-body pre{padding:16px;overflow:auto;font-size:85%;line-height:1.45;background-color:#f6f8fa;border-radius:3px}.markdown-body pre code{display:inline;max-width:auto;padding:0;margin:0;overflow:visible;line-height:inherit;word-wrap:normal;background-color:initial;border:0}.markdown-body .commit-tease-sha{display:inline-block;font-family:SFMono-Regular,Consolas,Liberation Mono,Menlo,monospace;font-size:90%;color:#444d56}.markdown-body .full-commit .btn-outline:not(:disabled):hover{color:#005cc5;border-color:#005cc5}.markdown-body .blob-wrapper{overflow-x:auto;overflow-y:hidden}.markdown-body .blob-wrapper-embedded{max-height:240px;overflow-y:auto}.markdown-body .blob-num{width:1%;min-width:50px;padding-right:10px;padding-left:10px;font-family:SFMono-Regular,Consolas,Liberation Mono,Menlo,monospace;font-size:12px;line-height:20px;color:rgba(27,31,35,.3);text-align:right;white-space:nowrap;vertical-align:top;cursor:pointer;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none}.markdown-body .blob-num:hover{color:rgba(27,31,35,.6)}.markdown-body .blob-num:before{content:attr(data-line-number)}.markdown-body .blob-code{position:relative;padding-right:10px;padding-left:10px;line-height:20px;vertical-align:top}.markdown-body .blob-code-inner{overflow:visible;font-family:SFMono-Regular,Consolas,Liberation Mono,Menlo,monospace;font-size:12px;color:#24292e;word-wrap:normal;white-space:pre}.markdown-body .pl-token.active,.markdown-body .pl-token:hover{cursor:pointer;background:#ffea7f}.markdown-body .tab-size[data-tab-size="1"]{-moz-tab-size:1;tab-size:1}.markdown-body .tab-size[data-tab-size="2"]{-moz-tab-size:2;tab-size:2}.markdown-body .tab-size[data-tab-size="3"]{-moz-tab-size:3;tab-size:3}.markdown-body .tab-size[data-tab-size="4"]{-moz-tab-size:4;tab-size:4}.markdown-body .tab-size[data-tab-size="5"]{-moz-tab-size:5;tab-size:5}.markdown-body .tab-size[data-tab-size="6"]{-moz-tab-size:6;tab-size:6}.markdown-body .tab-size[data-tab-size="7"]{-moz-tab-size:7;tab-size:7}.markdown-body .tab-size[data-tab-size="8"]{-moz-tab-size:8;tab-size:8}.markdown-body .tab-size[data-tab-size="9"]{-moz-tab-size:9;tab-size:9}.markdown-body .tab-size[data-tab-size="10"]{-moz-tab-size:10;tab-size:10}.markdown-body .tab-size[data-tab-size="11"]{-moz-tab-size:11;tab-size:11}.markdown-body .tab-size[data-tab-size="12"]{-moz-tab-size:12;tab-size:12}.markdown-body .task-list-item{list-style-type:none}.markdown-body .task-list-item+.task-list-item{margin-top:3px}.markdown-body .task-list-item input{margin:0 .2em .25em -1.6em;vertical-align:middle}
                                  /*# sourceMappingURL=github-markdown.min.css.map */
                                  """;

    public const string Other = """
                                @media (prefers-color-scheme: dark) {
                                  .markdown-body,
                                  [data-theme="dark"] {
                                    /*dark*/
                                    color-scheme: dark;
                                    --color-prettylights-syntax-comment: #8b949e;
                                    --color-prettylights-syntax-constant: #79c0ff;
                                    --color-prettylights-syntax-entity: #d2a8ff;
                                    --color-prettylights-syntax-storage-modifier-import: #c9d1d9;
                                    --color-prettylights-syntax-entity-tag: #7ee787;
                                    --color-prettylights-syntax-keyword: #ff7b72;
                                    --color-prettylights-syntax-string: #a5d6ff;
                                    --color-prettylights-syntax-variable: #ffa657;
                                    --color-prettylights-syntax-brackethighlighter-unmatched: #f85149;
                                    --color-prettylights-syntax-invalid-illegal-text: #f0f6fc;
                                    --color-prettylights-syntax-invalid-illegal-bg: #8e1519;
                                    --color-prettylights-syntax-carriage-return-text: #f0f6fc;
                                    --color-prettylights-syntax-carriage-return-bg: #b62324;
                                    --color-prettylights-syntax-string-regexp: #7ee787;
                                    --color-prettylights-syntax-markup-list: #f2cc60;
                                    --color-prettylights-syntax-markup-heading: #1f6feb;
                                    --color-prettylights-syntax-markup-italic: #c9d1d9;
                                    --color-prettylights-syntax-markup-bold: #c9d1d9;
                                    --color-prettylights-syntax-markup-deleted-text: #ffdcd7;
                                    --color-prettylights-syntax-markup-deleted-bg: #67060c;
                                    --color-prettylights-syntax-markup-inserted-text: #aff5b4;
                                    --color-prettylights-syntax-markup-inserted-bg: #033a16;
                                    --color-prettylights-syntax-markup-changed-text: #ffdfb6;
                                    --color-prettylights-syntax-markup-changed-bg: #5a1e02;
                                    --color-prettylights-syntax-markup-ignored-text: #c9d1d9;
                                    --color-prettylights-syntax-markup-ignored-bg: #1158c7;
                                    --color-prettylights-syntax-meta-diff-range: #d2a8ff;
                                    --color-prettylights-syntax-brackethighlighter-angle: #8b949e;
                                    --color-prettylights-syntax-sublimelinter-gutter-mark: #484f58;
                                    --color-prettylights-syntax-constant-other-reference-link: #a5d6ff;
                                    --color-fg-default: #e6edf3;
                                    --color-fg-muted: #848d97;
                                    --color-fg-subtle: #6e7681;
                                    --color-canvas-default: #0d1117;
                                    --color-canvas-subtle: #161b22;
                                    --color-border-default: #30363d;
                                    --color-border-muted: #21262d;
                                    --color-neutral-muted: rgba(110,118,129,0.4);
                                    --color-accent-fg: #2f81f7;
                                    --color-accent-emphasis: #1f6feb;
                                    --color-success-fg: #3fb950;
                                    --color-success-emphasis: #238636;
                                    --color-attention-fg: #d29922;
                                    --color-attention-emphasis: #9e6a03;
                                    --color-attention-subtle: rgba(187,128,9,0.15);
                                    --color-danger-fg: #f85149;
                                    --color-danger-emphasis: #da3633;
                                    --color-done-fg: #a371f7;
                                    --color-done-emphasis: #8957e5;
                                  }
                                }

                                @media (prefers-color-scheme: light) {
                                  .markdown-body,
                                  [data-theme="light"] {
                                    /*light*/
                                    color-scheme: light;
                                    --color-prettylights-syntax-comment: #57606a;
                                    --color-prettylights-syntax-constant: #0550ae;
                                    --color-prettylights-syntax-entity: #6639ba;
                                    --color-prettylights-syntax-storage-modifier-import: #24292f;
                                    --color-prettylights-syntax-entity-tag: #116329;
                                    --color-prettylights-syntax-keyword: #cf222e;
                                    --color-prettylights-syntax-string: #0a3069;
                                    --color-prettylights-syntax-variable: #953800;
                                    --color-prettylights-syntax-brackethighlighter-unmatched: #82071e;
                                    --color-prettylights-syntax-invalid-illegal-text: #f6f8fa;
                                    --color-prettylights-syntax-invalid-illegal-bg: #82071e;
                                    --color-prettylights-syntax-carriage-return-text: #f6f8fa;
                                    --color-prettylights-syntax-carriage-return-bg: #cf222e;
                                    --color-prettylights-syntax-string-regexp: #116329;
                                    --color-prettylights-syntax-markup-list: #3b2300;
                                    --color-prettylights-syntax-markup-heading: #0550ae;
                                    --color-prettylights-syntax-markup-italic: #24292f;
                                    --color-prettylights-syntax-markup-bold: #24292f;
                                    --color-prettylights-syntax-markup-deleted-text: #82071e;
                                    --color-prettylights-syntax-markup-deleted-bg: #ffebe9;
                                    --color-prettylights-syntax-markup-inserted-text: #116329;
                                    --color-prettylights-syntax-markup-inserted-bg: #dafbe1;
                                    --color-prettylights-syntax-markup-changed-text: #953800;
                                    --color-prettylights-syntax-markup-changed-bg: #ffd8b5;
                                    --color-prettylights-syntax-markup-ignored-text: #eaeef2;
                                    --color-prettylights-syntax-markup-ignored-bg: #0550ae;
                                    --color-prettylights-syntax-meta-diff-range: #8250df;
                                    --color-prettylights-syntax-brackethighlighter-angle: #57606a;
                                    --color-prettylights-syntax-sublimelinter-gutter-mark: #8c959f;
                                    --color-prettylights-syntax-constant-other-reference-link: #0a3069;
                                    --color-fg-default: #1F2328;
                                    --color-fg-muted: #656d76;
                                    --color-fg-subtle: #6e7781;
                                    --color-canvas-default: #ffffff;
                                    --color-canvas-subtle: #f6f8fa;
                                    --color-border-default: #d0d7de;
                                    --color-border-muted: hsla(210,18%,87%,1);
                                    --color-neutral-muted: rgba(175,184,193,0.2);
                                    --color-accent-fg: #0969da;
                                    --color-accent-emphasis: #0969da;
                                    --color-success-fg: #1a7f37;
                                    --color-success-emphasis: #1f883d;
                                    --color-attention-fg: #9a6700;
                                    --color-attention-emphasis: #9a6700;
                                    --color-attention-subtle: #fff8c5;
                                    --color-danger-fg: #d1242f;
                                    --color-danger-emphasis: #cf222e;
                                    --color-done-fg: #8250df;
                                    --color-done-emphasis: #8250df;
                                  }
                                }

                                .markdown-body {
                                  -ms-text-size-adjust: 100%;
                                  -webkit-text-size-adjust: 100%;
                                  margin: 0;
                                  color: var(--color-fg-default);
                                  background-color: var(--color-canvas-default);
                                  font-family: -apple-system,BlinkMacSystemFont,"Segoe UI","Noto Sans",Helvetica,Arial,sans-serif,"Apple Color Emoji","Segoe UI Emoji";
                                  font-size: 16px;
                                  line-height: 1.5;
                                  word-wrap: break-word;
                                }

                                .markdown-body .octicon {
                                  display: inline-block;
                                  fill: currentColor;
                                  vertical-align: text-bottom;
                                }

                                .markdown-body h1:hover .anchor .octicon-link:before,
                                .markdown-body h2:hover .anchor .octicon-link:before,
                                .markdown-body h3:hover .anchor .octicon-link:before,
                                .markdown-body h4:hover .anchor .octicon-link:before,
                                .markdown-body h5:hover .anchor .octicon-link:before,
                                .markdown-body h6:hover .anchor .octicon-link:before {
                                  width: 16px;
                                  height: 16px;
                                  content: ' ';
                                  display: inline-block;
                                  background-color: currentColor;
                                  -webkit-mask-image: url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' version='1.1' aria-hidden='true'><path fill-rule='evenodd' d='M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z'></path></svg>");
                                  mask-image: url("data:image/svg+xml,<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 16 16' version='1.1' aria-hidden='true'><path fill-rule='evenodd' d='M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z'></path></svg>");
                                }

                                .markdown-body details,
                                .markdown-body figcaption,
                                .markdown-body figure {
                                  display: block;
                                }

                                .markdown-body summary {
                                  display: list-item;
                                }

                                .markdown-body [hidden] {
                                  display: none !important;
                                }

                                .markdown-body a {
                                  background-color: transparent;
                                  color: var(--color-accent-fg);
                                  text-decoration: none;
                                }

                                .markdown-body abbr[title] {
                                  border-bottom: none;
                                  -webkit-text-decoration: underline dotted;
                                  text-decoration: underline dotted;
                                }

                                .markdown-body b,
                                .markdown-body strong {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                }

                                .markdown-body dfn {
                                  font-style: italic;
                                }

                                .markdown-body h1 {
                                  margin: .67em 0;
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  padding-bottom: .3em;
                                  font-size: 2em;
                                  border-bottom: 1px solid var(--color-border-muted);
                                }

                                .markdown-body mark {
                                  background-color: var(--color-attention-subtle);
                                  color: var(--color-fg-default);
                                }

                                .markdown-body small {
                                  font-size: 90%;
                                }

                                .markdown-body sub,
                                .markdown-body sup {
                                  font-size: 75%;
                                  line-height: 0;
                                  position: relative;
                                  vertical-align: baseline;
                                }

                                .markdown-body sub {
                                  bottom: -0.25em;
                                }

                                .markdown-body sup {
                                  top: -0.5em;
                                }

                                .markdown-body img {
                                  border-style: none;
                                  max-width: 100%;
                                  box-sizing: content-box;
                                  background-color: var(--color-canvas-default);
                                }

                                .markdown-body code,
                                .markdown-body kbd,
                                .markdown-body pre,
                                .markdown-body samp {
                                  font-family: monospace;
                                  font-size: 1em;
                                }

                                .markdown-body figure {
                                  margin: 1em 40px;
                                }

                                .markdown-body hr {
                                  box-sizing: content-box;
                                  overflow: hidden;
                                  background: transparent;
                                  border-bottom: 1px solid var(--color-border-muted);
                                  height: .25em;
                                  padding: 0;
                                  margin: 24px 0;
                                  background-color: var(--color-border-default);
                                  border: 0;
                                }

                                .markdown-body input {
                                  font: inherit;
                                  margin: 0;
                                  overflow: visible;
                                  font-family: inherit;
                                  font-size: inherit;
                                  line-height: inherit;
                                }

                                .markdown-body [type=button],
                                .markdown-body [type=reset],
                                .markdown-body [type=submit] {
                                  -webkit-appearance: button;
                                  appearance: button;
                                }

                                .markdown-body [type=checkbox],
                                .markdown-body [type=radio] {
                                  box-sizing: border-box;
                                  padding: 0;
                                }

                                .markdown-body [type=number]::-webkit-inner-spin-button,
                                .markdown-body [type=number]::-webkit-outer-spin-button {
                                  height: auto;
                                }

                                .markdown-body [type=search]::-webkit-search-cancel-button,
                                .markdown-body [type=search]::-webkit-search-decoration {
                                  -webkit-appearance: none;
                                  appearance: none;
                                }

                                .markdown-body ::-webkit-input-placeholder {
                                  color: inherit;
                                  opacity: .54;
                                }

                                .markdown-body ::-webkit-file-upload-button {
                                  -webkit-appearance: button;
                                  appearance: button;
                                  font: inherit;
                                }

                                .markdown-body a:hover {
                                  text-decoration: underline;
                                }

                                .markdown-body ::placeholder {
                                  color: var(--color-fg-subtle);
                                  opacity: 1;
                                }

                                .markdown-body hr::before {
                                  display: table;
                                  content: "";
                                }

                                .markdown-body hr::after {
                                  display: table;
                                  clear: both;
                                  content: "";
                                }

                                .markdown-body table {
                                  border-spacing: 0;
                                  border-collapse: collapse;
                                  display: block;
                                  width: max-content;
                                  max-width: 100%;
                                  overflow: auto;
                                }

                                .markdown-body td,
                                .markdown-body th {
                                  padding: 0;
                                }

                                .markdown-body details summary {
                                  cursor: pointer;
                                }

                                .markdown-body details:not([open])>*:not(summary) {
                                  display: none !important;
                                }

                                .markdown-body a:focus,
                                .markdown-body [role=button]:focus,
                                .markdown-body input[type=radio]:focus,
                                .markdown-body input[type=checkbox]:focus {
                                  outline: 2px solid var(--color-accent-fg);
                                  outline-offset: -2px;
                                  box-shadow: none;
                                }

                                .markdown-body a:focus:not(:focus-visible),
                                .markdown-body [role=button]:focus:not(:focus-visible),
                                .markdown-body input[type=radio]:focus:not(:focus-visible),
                                .markdown-body input[type=checkbox]:focus:not(:focus-visible) {
                                  outline: solid 1px transparent;
                                }

                                .markdown-body a:focus-visible,
                                .markdown-body [role=button]:focus-visible,
                                .markdown-body input[type=radio]:focus-visible,
                                .markdown-body input[type=checkbox]:focus-visible {
                                  outline: 2px solid var(--color-accent-fg);
                                  outline-offset: -2px;
                                  box-shadow: none;
                                }

                                .markdown-body a:not([class]):focus,
                                .markdown-body a:not([class]):focus-visible,
                                .markdown-body input[type=radio]:focus,
                                .markdown-body input[type=radio]:focus-visible,
                                .markdown-body input[type=checkbox]:focus,
                                .markdown-body input[type=checkbox]:focus-visible {
                                  outline-offset: 0;
                                }

                                .markdown-body kbd {
                                  display: inline-block;
                                  padding: 3px 5px;
                                  font: 11px ui-monospace,SFMono-Regular,SF Mono,Menlo,Consolas,Liberation Mono,monospace;
                                  line-height: 10px;
                                  color: var(--color-fg-default);
                                  vertical-align: middle;
                                  background-color: var(--color-canvas-subtle);
                                  border: solid 1px var(--color-neutral-muted);
                                  border-bottom-color: var(--color-neutral-muted);
                                  border-radius: 6px;
                                  box-shadow: inset 0 -1px 0 var(--color-neutral-muted);
                                }

                                .markdown-body h1,
                                .markdown-body h2,
                                .markdown-body h3,
                                .markdown-body h4,
                                .markdown-body h5,
                                .markdown-body h6 {
                                  margin-top: 24px;
                                  margin-bottom: 16px;
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  line-height: 1.25;
                                }

                                .markdown-body h2 {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  padding-bottom: .3em;
                                  font-size: 1.5em;
                                  border-bottom: 1px solid var(--color-border-muted);
                                }

                                .markdown-body h3 {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  font-size: 1.25em;
                                }

                                .markdown-body h4 {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  font-size: 1em;
                                }

                                .markdown-body h5 {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  font-size: .875em;
                                }

                                .markdown-body h6 {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  font-size: .85em;
                                  color: var(--color-fg-muted);
                                }

                                .markdown-body p {
                                  margin-top: 0;
                                  margin-bottom: 10px;
                                }

                                .markdown-body blockquote {
                                  margin: 0;
                                  padding: 0 1em;
                                  color: var(--color-fg-muted);
                                  border-left: .25em solid var(--color-border-default);
                                }

                                .markdown-body ul,
                                .markdown-body ol {
                                  margin-top: 0;
                                  margin-bottom: 0;
                                  padding-left: 2em;
                                }

                                .markdown-body ol ol,
                                .markdown-body ul ol {
                                  list-style-type: lower-roman;
                                }

                                .markdown-body ul ul ol,
                                .markdown-body ul ol ol,
                                .markdown-body ol ul ol,
                                .markdown-body ol ol ol {
                                  list-style-type: lower-alpha;
                                }

                                .markdown-body dd {
                                  margin-left: 0;
                                }

                                .markdown-body tt,
                                .markdown-body code,
                                .markdown-body samp {
                                  font-family: ui-monospace,SFMono-Regular,SF Mono,Menlo,Consolas,Liberation Mono,monospace;
                                  font-size: 12px;
                                }

                                .markdown-body pre {
                                  margin-top: 0;
                                  margin-bottom: 0;
                                  font-family: ui-monospace,SFMono-Regular,SF Mono,Menlo,Consolas,Liberation Mono,monospace;
                                  font-size: 12px;
                                  word-wrap: normal;
                                }

                                .markdown-body .octicon {
                                  display: inline-block;
                                  overflow: visible !important;
                                  vertical-align: text-bottom;
                                  fill: currentColor;
                                }

                                .markdown-body input::-webkit-outer-spin-button,
                                .markdown-body input::-webkit-inner-spin-button {
                                  margin: 0;
                                  -webkit-appearance: none;
                                  appearance: none;
                                }

                                .markdown-body .mr-2 {
                                  margin-right: var(--base-size-8, 8px) !important;
                                }

                                .markdown-body::before {
                                  display: table;
                                  content: "";
                                }

                                .markdown-body::after {
                                  display: table;
                                  clear: both;
                                  content: "";
                                }

                                .markdown-body>*:first-child {
                                  margin-top: 0 !important;
                                }

                                .markdown-body>*:last-child {
                                  margin-bottom: 0 !important;
                                }

                                .markdown-body a:not([href]) {
                                  color: inherit;
                                  text-decoration: none;
                                }

                                .markdown-body .absent {
                                  color: var(--color-danger-fg);
                                }

                                .markdown-body .anchor {
                                  float: left;
                                  padding-right: 4px;
                                  margin-left: -20px;
                                  line-height: 1;
                                }

                                .markdown-body .anchor:focus {
                                  outline: none;
                                }

                                .markdown-body p,
                                .markdown-body blockquote,
                                .markdown-body ul,
                                .markdown-body ol,
                                .markdown-body dl,
                                .markdown-body table,
                                .markdown-body pre,
                                .markdown-body details {
                                  margin-top: 0;
                                  margin-bottom: 16px;
                                }

                                .markdown-body blockquote>:first-child {
                                  margin-top: 0;
                                }

                                .markdown-body blockquote>:last-child {
                                  margin-bottom: 0;
                                }

                                .markdown-body h1 .octicon-link,
                                .markdown-body h2 .octicon-link,
                                .markdown-body h3 .octicon-link,
                                .markdown-body h4 .octicon-link,
                                .markdown-body h5 .octicon-link,
                                .markdown-body h6 .octicon-link {
                                  color: var(--color-fg-default);
                                  vertical-align: middle;
                                  visibility: hidden;
                                }

                                .markdown-body h1:hover .anchor,
                                .markdown-body h2:hover .anchor,
                                .markdown-body h3:hover .anchor,
                                .markdown-body h4:hover .anchor,
                                .markdown-body h5:hover .anchor,
                                .markdown-body h6:hover .anchor {
                                  text-decoration: none;
                                }

                                .markdown-body h1:hover .anchor .octicon-link,
                                .markdown-body h2:hover .anchor .octicon-link,
                                .markdown-body h3:hover .anchor .octicon-link,
                                .markdown-body h4:hover .anchor .octicon-link,
                                .markdown-body h5:hover .anchor .octicon-link,
                                .markdown-body h6:hover .anchor .octicon-link {
                                  visibility: visible;
                                }

                                .markdown-body h1 tt,
                                .markdown-body h1 code,
                                .markdown-body h2 tt,
                                .markdown-body h2 code,
                                .markdown-body h3 tt,
                                .markdown-body h3 code,
                                .markdown-body h4 tt,
                                .markdown-body h4 code,
                                .markdown-body h5 tt,
                                .markdown-body h5 code,
                                .markdown-body h6 tt,
                                .markdown-body h6 code {
                                  padding: 0 .2em;
                                  font-size: inherit;
                                }

                                .markdown-body summary h1,
                                .markdown-body summary h2,
                                .markdown-body summary h3,
                                .markdown-body summary h4,
                                .markdown-body summary h5,
                                .markdown-body summary h6 {
                                  display: inline-block;
                                }

                                .markdown-body summary h1 .anchor,
                                .markdown-body summary h2 .anchor,
                                .markdown-body summary h3 .anchor,
                                .markdown-body summary h4 .anchor,
                                .markdown-body summary h5 .anchor,
                                .markdown-body summary h6 .anchor {
                                  margin-left: -40px;
                                }

                                .markdown-body summary h1,
                                .markdown-body summary h2 {
                                  padding-bottom: 0;
                                  border-bottom: 0;
                                }

                                .markdown-body ul.no-list,
                                .markdown-body ol.no-list {
                                  padding: 0;
                                  list-style-type: none;
                                }

                                .markdown-body ol[type="a s"] {
                                  list-style-type: lower-alpha;
                                }

                                .markdown-body ol[type="A s"] {
                                  list-style-type: upper-alpha;
                                }

                                .markdown-body ol[type="i s"] {
                                  list-style-type: lower-roman;
                                }

                                .markdown-body ol[type="I s"] {
                                  list-style-type: upper-roman;
                                }

                                .markdown-body ol[type="1"] {
                                  list-style-type: decimal;
                                }

                                .markdown-body div>ol:not([type]) {
                                  list-style-type: decimal;
                                }

                                .markdown-body ul ul,
                                .markdown-body ul ol,
                                .markdown-body ol ol,
                                .markdown-body ol ul {
                                  margin-top: 0;
                                  margin-bottom: 0;
                                }

                                .markdown-body li>p {
                                  margin-top: 16px;
                                }

                                .markdown-body li+li {
                                  margin-top: .25em;
                                }

                                .markdown-body dl {
                                  padding: 0;
                                }

                                .markdown-body dl dt {
                                  padding: 0;
                                  margin-top: 16px;
                                  font-size: 1em;
                                  font-style: italic;
                                  font-weight: var(--base-text-weight-semibold, 600);
                                }

                                .markdown-body dl dd {
                                  padding: 0 16px;
                                  margin-bottom: 16px;
                                }

                                .markdown-body table th {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                }

                                .markdown-body table th,
                                .markdown-body table td {
                                  padding: 6px 13px;
                                  border: 1px solid var(--color-border-default);
                                }

                                .markdown-body table td>:last-child {
                                  margin-bottom: 0;
                                }

                                .markdown-body table tr {
                                  background-color: var(--color-canvas-default);
                                  border-top: 1px solid var(--color-border-muted);
                                }

                                .markdown-body table tr:nth-child(2n) {
                                  background-color: var(--color-canvas-subtle);
                                }

                                .markdown-body table img {
                                  background-color: transparent;
                                }

                                .markdown-body img[align=right] {
                                  padding-left: 20px;
                                }

                                .markdown-body img[align=left] {
                                  padding-right: 20px;
                                }

                                .markdown-body .emoji {
                                  max-width: none;
                                  vertical-align: text-top;
                                  background-color: transparent;
                                }

                                .markdown-body span.frame {
                                  display: block;
                                  overflow: hidden;
                                }

                                .markdown-body span.frame>span {
                                  display: block;
                                  float: left;
                                  width: auto;
                                  padding: 7px;
                                  margin: 13px 0 0;
                                  overflow: hidden;
                                  border: 1px solid var(--color-border-default);
                                }

                                .markdown-body span.frame span img {
                                  display: block;
                                  float: left;
                                }

                                .markdown-body span.frame span span {
                                  display: block;
                                  padding: 5px 0 0;
                                  clear: both;
                                  color: var(--color-fg-default);
                                }

                                .markdown-body span.align-center {
                                  display: block;
                                  overflow: hidden;
                                  clear: both;
                                }

                                .markdown-body span.align-center>span {
                                  display: block;
                                  margin: 13px auto 0;
                                  overflow: hidden;
                                  text-align: center;
                                }

                                .markdown-body span.align-center span img {
                                  margin: 0 auto;
                                  text-align: center;
                                }

                                .markdown-body span.align-right {
                                  display: block;
                                  overflow: hidden;
                                  clear: both;
                                }

                                .markdown-body span.align-right>span {
                                  display: block;
                                  margin: 13px 0 0;
                                  overflow: hidden;
                                  text-align: right;
                                }

                                .markdown-body span.align-right span img {
                                  margin: 0;
                                  text-align: right;
                                }

                                .markdown-body span.float-left {
                                  display: block;
                                  float: left;
                                  margin-right: 13px;
                                  overflow: hidden;
                                }

                                .markdown-body span.float-left span {
                                  margin: 13px 0 0;
                                }

                                .markdown-body span.float-right {
                                  display: block;
                                  float: right;
                                  margin-left: 13px;
                                  overflow: hidden;
                                }

                                .markdown-body span.float-right>span {
                                  display: block;
                                  margin: 13px auto 0;
                                  overflow: hidden;
                                  text-align: right;
                                }

                                .markdown-body code,
                                .markdown-body tt {
                                  padding: .2em .4em;
                                  margin: 0;
                                  font-size: 85%;
                                  white-space: break-spaces;
                                  background-color: var(--color-neutral-muted);
                                  border-radius: 6px;
                                }

                                .markdown-body code br,
                                .markdown-body tt br {
                                  display: none;
                                }

                                .markdown-body del code {
                                  text-decoration: inherit;
                                }

                                .markdown-body samp {
                                  font-size: 85%;
                                }

                                .markdown-body pre code {
                                  font-size: 100%;
                                }

                                .markdown-body pre>code {
                                  padding: 0;
                                  margin: 0;
                                  word-break: normal;
                                  white-space: pre;
                                  background: transparent;
                                  border: 0;
                                }

                                .markdown-body .highlight {
                                  margin-bottom: 16px;
                                }

                                .markdown-body .highlight pre {
                                  margin-bottom: 0;
                                  word-break: normal;
                                }

                                .markdown-body .highlight pre,
                                .markdown-body pre {
                                  padding: 16px;
                                  overflow: auto;
                                  font-size: 85%;
                                  line-height: 1.45;
                                  color: var(--color-fg-default);
                                  background-color: var(--color-canvas-subtle);
                                  border-radius: 6px;
                                }

                                .markdown-body pre code,
                                .markdown-body pre tt {
                                  display: inline;
                                  max-width: auto;
                                  padding: 0;
                                  margin: 0;
                                  overflow: visible;
                                  line-height: inherit;
                                  word-wrap: normal;
                                  background-color: transparent;
                                  border: 0;
                                }

                                .markdown-body .csv-data td,
                                .markdown-body .csv-data th {
                                  padding: 5px;
                                  overflow: hidden;
                                  font-size: 12px;
                                  line-height: 1;
                                  text-align: left;
                                  white-space: nowrap;
                                }

                                .markdown-body .csv-data .blob-num {
                                  padding: 10px 8px 9px;
                                  text-align: right;
                                  background: var(--color-canvas-default);
                                  border: 0;
                                }

                                .markdown-body .csv-data tr {
                                  border-top: 0;
                                }

                                .markdown-body .csv-data th {
                                  font-weight: var(--base-text-weight-semibold, 600);
                                  background: var(--color-canvas-subtle);
                                  border-top: 0;
                                }

                                .markdown-body [data-footnote-ref]::before {
                                  content: "[";
                                }

                                .markdown-body [data-footnote-ref]::after {
                                  content: "]";
                                }

                                .markdown-body .footnotes {
                                  font-size: 12px;
                                  color: var(--color-fg-muted);
                                  border-top: 1px solid var(--color-border-default);
                                }

                                .markdown-body .footnotes ol {
                                  padding-left: 16px;
                                }

                                .markdown-body .footnotes ol ul {
                                  display: inline-block;
                                  padding-left: 16px;
                                  margin-top: 16px;
                                }

                                .markdown-body .footnotes li {
                                  position: relative;
                                }

                                .markdown-body .footnotes li:target::before {
                                  position: absolute;
                                  top: -8px;
                                  right: -8px;
                                  bottom: -8px;
                                  left: -24px;
                                  pointer-events: none;
                                  content: "";
                                  border: 2px solid var(--color-accent-emphasis);
                                  border-radius: 6px;
                                }

                                .markdown-body .footnotes li:target {
                                  color: var(--color-fg-default);
                                }

                                .markdown-body .footnotes .data-footnote-backref g-emoji {
                                  font-family: monospace;
                                }

                                .markdown-body .pl-c {
                                  color: var(--color-prettylights-syntax-comment);
                                }

                                .markdown-body .pl-c1,
                                .markdown-body .pl-s .pl-v {
                                  color: var(--color-prettylights-syntax-constant);
                                }

                                .markdown-body .pl-e,
                                .markdown-body .pl-en {
                                  color: var(--color-prettylights-syntax-entity);
                                }

                                .markdown-body .pl-smi,
                                .markdown-body .pl-s .pl-s1 {
                                  color: var(--color-prettylights-syntax-storage-modifier-import);
                                }

                                .markdown-body .pl-ent {
                                  color: var(--color-prettylights-syntax-entity-tag);
                                }

                                .markdown-body .pl-k {
                                  color: var(--color-prettylights-syntax-keyword);
                                }

                                .markdown-body .pl-s,
                                .markdown-body .pl-pds,
                                .markdown-body .pl-s .pl-pse .pl-s1,
                                .markdown-body .pl-sr,
                                .markdown-body .pl-sr .pl-cce,
                                .markdown-body .pl-sr .pl-sre,
                                .markdown-body .pl-sr .pl-sra {
                                  color: var(--color-prettylights-syntax-string);
                                }

                                .markdown-body .pl-v,
                                .markdown-body .pl-smw {
                                  color: var(--color-prettylights-syntax-variable);
                                }

                                .markdown-body .pl-bu {
                                  color: var(--color-prettylights-syntax-brackethighlighter-unmatched);
                                }

                                .markdown-body .pl-ii {
                                  color: var(--color-prettylights-syntax-invalid-illegal-text);
                                  background-color: var(--color-prettylights-syntax-invalid-illegal-bg);
                                }

                                .markdown-body .pl-c2 {
                                  color: var(--color-prettylights-syntax-carriage-return-text);
                                  background-color: var(--color-prettylights-syntax-carriage-return-bg);
                                }

                                .markdown-body .pl-sr .pl-cce {
                                  font-weight: bold;
                                  color: var(--color-prettylights-syntax-string-regexp);
                                }

                                .markdown-body .pl-ml {
                                  color: var(--color-prettylights-syntax-markup-list);
                                }

                                .markdown-body .pl-mh,
                                .markdown-body .pl-mh .pl-en,
                                .markdown-body .pl-ms {
                                  font-weight: bold;
                                  color: var(--color-prettylights-syntax-markup-heading);
                                }

                                .markdown-body .pl-mi {
                                  font-style: italic;
                                  color: var(--color-prettylights-syntax-markup-italic);
                                }

                                .markdown-body .pl-mb {
                                  font-weight: bold;
                                  color: var(--color-prettylights-syntax-markup-bold);
                                }

                                .markdown-body .pl-md {
                                  color: var(--color-prettylights-syntax-markup-deleted-text);
                                  background-color: var(--color-prettylights-syntax-markup-deleted-bg);
                                }

                                .markdown-body .pl-mi1 {
                                  color: var(--color-prettylights-syntax-markup-inserted-text);
                                  background-color: var(--color-prettylights-syntax-markup-inserted-bg);
                                }

                                .markdown-body .pl-mc {
                                  color: var(--color-prettylights-syntax-markup-changed-text);
                                  background-color: var(--color-prettylights-syntax-markup-changed-bg);
                                }

                                .markdown-body .pl-mi2 {
                                  color: var(--color-prettylights-syntax-markup-ignored-text);
                                  background-color: var(--color-prettylights-syntax-markup-ignored-bg);
                                }

                                .markdown-body .pl-mdr {
                                  font-weight: bold;
                                  color: var(--color-prettylights-syntax-meta-diff-range);
                                }

                                .markdown-body .pl-ba {
                                  color: var(--color-prettylights-syntax-brackethighlighter-angle);
                                }

                                .markdown-body .pl-sg {
                                  color: var(--color-prettylights-syntax-sublimelinter-gutter-mark);
                                }

                                .markdown-body .pl-corl {
                                  text-decoration: underline;
                                  color: var(--color-prettylights-syntax-constant-other-reference-link);
                                }

                                .markdown-body g-emoji {
                                  display: inline-block;
                                  min-width: 1ch;
                                  font-family: "Apple Color Emoji","Segoe UI Emoji","Segoe UI Symbol";
                                  font-size: 1em;
                                  font-style: normal !important;
                                  font-weight: var(--base-text-weight-normal, 400);
                                  line-height: 1;
                                  vertical-align: -0.075em;
                                }

                                .markdown-body g-emoji img {
                                  width: 1em;
                                  height: 1em;
                                }

                                .markdown-body .task-list-item {
                                  list-style-type: none;
                                }

                                .markdown-body .task-list-item label {
                                  font-weight: var(--base-text-weight-normal, 400);
                                }

                                .markdown-body .task-list-item.enabled label {
                                  cursor: pointer;
                                }

                                .markdown-body .task-list-item+.task-list-item {
                                  margin-top: 4px;
                                }

                                .markdown-body .task-list-item .handle {
                                  display: none;
                                }

                                .markdown-body .task-list-item-checkbox {
                                  margin: 0 .2em .25em -1.4em;
                                  vertical-align: middle;
                                }

                                .markdown-body .contains-task-list:dir(rtl) .task-list-item-checkbox {
                                  margin: 0 -1.6em .25em .2em;
                                }

                                .markdown-body .contains-task-list {
                                  position: relative;
                                }

                                .markdown-body .contains-task-list:hover .task-list-item-convert-container,
                                .markdown-body .contains-task-list:focus-within .task-list-item-convert-container {
                                  display: block;
                                  width: auto;
                                  height: 24px;
                                  overflow: visible;
                                  clip: auto;
                                }

                                .markdown-body ::-webkit-calendar-picker-indicator {
                                  filter: invert(50%);
                                }

                                .markdown-body .markdown-alert {
                                  padding: var(--base-size-8) var(--base-size-16);
                                  margin-bottom: 16px;
                                  color: inherit;
                                  border-left: .25em solid var(--color-border-default);
                                }

                                .markdown-body .markdown-alert>:first-child {
                                  margin-top: 0;
                                }

                                .markdown-body .markdown-alert>:last-child {
                                  margin-bottom: 0;
                                }

                                .markdown-body .markdown-alert .markdown-alert-title {
                                  display: flex;
                                  font-weight: var(--base-text-weight-medium, 500);
                                  align-items: center;
                                  line-height: 1;
                                }

                                .markdown-body .markdown-alert.markdown-alert-note {
                                  border-left-color: var(--color-accent-emphasis);
                                }

                                .markdown-body .markdown-alert.markdown-alert-note .markdown-alert-title {
                                  color: var(--color-accent-fg);
                                }

                                .markdown-body .markdown-alert.markdown-alert-important {
                                  border-left-color: var(--color-done-emphasis);
                                }

                                .markdown-body .markdown-alert.markdown-alert-important .markdown-alert-title {
                                  color: var(--color-done-fg);
                                }

                                .markdown-body .markdown-alert.markdown-alert-warning {
                                  border-left-color: var(--color-attention-emphasis);
                                }

                                .markdown-body .markdown-alert.markdown-alert-warning .markdown-alert-title {
                                  color: var(--color-attention-fg);
                                }

                                .markdown-body .markdown-alert.markdown-alert-tip {
                                  border-left-color: var(--color-success-emphasis);
                                }

                                .markdown-body .markdown-alert.markdown-alert-tip .markdown-alert-title {
                                  color: var(--color-success-fg);
                                }

                                .markdown-body .markdown-alert.markdown-alert-caution {
                                  border-left-color: var(--color-danger-emphasis);
                                }

                                .markdown-body .markdown-alert.markdown-alert-caution .markdown-alert-title {
                                  color: var(--color-danger-fg);
                                }
                                """;
}