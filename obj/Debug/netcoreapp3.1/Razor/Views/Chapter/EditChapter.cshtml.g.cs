#pragma checksum "A:\WebApplication1\Views\Chapter\EditChapter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c2ce36b3ba9aafe5e0b123992a8bb6d08ac272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chapter_EditChapter), @"mvc.1.0.view", @"/Views/Chapter/EditChapter.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "A:\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c2ce36b3ba9aafe5e0b123992a8bb6d08ac272", @"/Views/Chapter/EditChapter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Chapter_EditChapter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/markdown.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c2ce36b3ba9aafe5e0b123992a8bb6d08ac2725217", async() => {
                WriteLiteral("\r\n    <h4>");
#nullable restore
#line 5 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
   Write(Localizer["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n    <hr />\r\n    <div class=\"text-danger\"></div>\r\n    <div class=\"form-group\">\r\n        <label>");
#nullable restore
#line 9 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
          Write(Localizer["Label"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        <input name=\"Title\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 349, "\"", 379, 1);
#nullable restore
#line 10 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
WriteAttributeValue("", 357, ViewBag.Chapter.Title, 357, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span class=\"text-danger\"></span>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input oninput=\"this.editor.update()\" id=\"inputContent\" name=\"Content\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 569, "\"", 601, 1);
#nullable restore
#line 14 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
WriteAttributeValue("", 577, ViewBag.Chapter.Content, 577, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span class=\"text-danger\"></span>\r\n    </div>\r\n    <div id=\"drop-area\">\r\n        <p>");
#nullable restore
#line 18 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
      Write(Localizer["LoadImage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p></p>\r\n    </div>\r\n    <a id=\"submit\" class=\"btn btn-primary\">");
#nullable restore
#line 21 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
                                      Write(Localizer["Save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h4>");
#nullable restore
#line 24 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
Write(Localizer["Preview"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

<div id=""preview""> </div>
<img id=""img"" width=""70%"">

<style>
    #drop-area {
        border: 2px dashed #ccc;
        border-radius: 20px;
        width: 480px;
        font-family: sans-serif;
        margin: 100px auto;
        padding: 20px;
    }

        #drop-area.highlight {
            border-color: purple;
        }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c2ce36b3ba9aafe5e0b123992a8bb6d08ac2729542", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c2ce36b3ba9aafe5e0b123992a8bb6d08ac27210581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    if (\"");
#nullable restore
#line 47 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
    Write(ViewBag.Chapter.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\".length > 0) {\r\n        getImage(\"");
#nullable restore
#line 48 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
             Write(ViewBag.Chapter.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
    };

function getImage(imageName) {
    $.get(""/Chapter/GetImage"", { ""filename"": imageName }, function (data) {
        let image = document.getElementById(""img"");
        var ssil = ""data:image/png;base64,"" + data;
        image.src = ssil;
    });
}

function Editor(input, preview) {
    this.update = function () {
        preview.innerHTML = markdown.toHTML(input.value);
    };
    input.editor = this;
    this.update();
}
var $g = function (id) { return document.getElementById(id); };
new Editor($g(""inputContent""), $g(""preview""));

let dropArea = document.getElementById('drop-area');
let image;

['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
    dropArea.addEventListener(eventName, preventDefaults, false)
});

function preventDefaults(e) {
    e.preventDefault();
    e.stopPropagation();
}

['dragenter', 'dragover'].forEach(eventName => {
    dropArea.addEventListener(eventName, highlight, false)
});

['dragleave', 'drop'].forEach(eventNam");
            WriteLiteral(@"e => {
    dropArea.addEventListener(eventName, unhighlight, false)
});

function highlight(e) {
    dropArea.classList.add('highlight');
}

function unhighlight(e) {
    dropArea.classList.remove('highlight');
}

dropArea.addEventListener('drop', handleDrop, false);

function handleDrop(e) {
    let dt = e.dataTransfer;
    let files = dt.files;
    handleFiles(files);
}

function handleFiles(files) {
    image = files[0];
    console.log(image);
    previewFile(image);
}

function previewFile(file) {
    let reader = new FileReader()
    reader.readAsDataURL(file)
    reader.onloadend = function () {
        let img = document.getElementById('img')
        img.src = reader.result
    }
}

$(""#submit"").click(function () {
    let formData = new FormData();
    var data = $(""#form"").serializeArray();
    createData(formData, data);
    alert(""Изменена глава: "" + data[0].value);
})

function createData(formData, data) {
    for (let i = 0; i < data.length; i++) {
   ");
            WriteLiteral("     formData.append(data[i].name, data[i].value)\r\n    }\r\n    formData.append(\"image\", image);\r\n    formData.append(\"chapterId\", \"");
#nullable restore
#line 132 "A:\WebApplication1\Views\Chapter\EditChapter.cshtml"
                             Write(ViewBag.Chapter.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n    send(formData);\r\n}\r\n\r\nfunction send(formData) {\r\n    var xhr = new XMLHttpRequest();\r\n    xhr.open(\'POST\', \'/Chapter/EditChapter\');\r\n    xhr.send(formData);\r\n}\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
