#pragma checksum "A:\WebApplication1\Views\Story\StoryPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a392295ca03278d96a677ecec37a8c4976b261e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_StoryPage), @"mvc.1.0.view", @"/Views/Story/StoryPage.cshtml")]
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
#line 3 "A:\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "A:\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "A:\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "A:\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a392295ca03278d96a677ecec37a8c4976b261e8", @"/Views/Story/StoryPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cab0dbc4f7b000a721b24830647f7c2fa4842bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Story_StoryPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chapter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
Write(await Html.PartialAsync("/Views/_ViewImports.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3 class=\"text-center\">");
#nullable restore
#line 4 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                   Write(ViewBag.Story.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>");
#nullable restore
#line 5 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
Write(Localizer["Author"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a392295ca03278d96a677ecec37a8c4976b261e85530", async() => {
#nullable restore
#line 5 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                                                                  Write(ViewBag.Author);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                              WriteLiteral(ViewBag.Author);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 6 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
Write(Localizer["Desc"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 6 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                  Write(ViewBag.Story.Descript);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 7 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
Write(Localizer["Genre"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 7 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                   Write(Localizer[@ViewBag.Story.Genre]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 8 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
Write(Localizer["Tags"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 8 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                  Write(ViewBag.Story.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
#nullable restore
#line 11 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
 for (int i = 1; i <= Model.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 70%;\">\r\n        <img class=\"card-img-top chapter-image\"");
            BeginWriteAttribute("id", " id=\"", 560, "\"", 586, 1);
#nullable restore
#line 14 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
WriteAttributeValue("", 565, Model[i-1].ImageName, 565, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 16 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                              Write(Localizer["Chapter"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 16 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                        Write(Model[i - 1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n            <p class=\"content card-text\"");
            BeginWriteAttribute("id", " id=\"", 751, "\"", 758, 1);
#nullable restore
#line 17 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
WriteAttributeValue("", 756, i, 756, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                            Write(Model[i - 1].Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
             if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><button");
            BeginWriteAttribute("name", " name=\"", 878, "\"", 899, 1);
#nullable restore
#line 20 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
WriteAttributeValue("", 885, Model[i-1].Id, 885, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary active like\">");
#nullable restore
#line 20 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                                                Write(Localizer["Like"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></p>\r\n");
#nullable restore
#line 21 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p id=\"likes\" class=\"content card-text\">");
#nullable restore
#line 22 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                               Write(Localizer["Likes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 22 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                                    Write(Model[i - 1].Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
 if (User.IsInRole("Active"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
     <div class=""rating-area"">
         <input class=""star"" type=""radio"" id=""star-5"" name=""rating"" value=""5"">
         <label for=""star-5""></label>
         <input class=""star"" type=""radio"" id=""star-4"" name=""rating"" value=""4"">
         <label for=""star-4""></label>
         <input class=""star"" type=""radio"" id=""star-3"" name=""rating"" value=""3"">
         <label for=""star-3""></label>
         <input class=""star"" type=""radio"" id=""star-2"" name=""rating"" value=""2"">
         <label for=""star-2""></label>
         <input class=""star"" type=""radio"" id=""star-1"" name=""rating"" value=""1"">
         <label for=""star-1""></label>
     </div>
 </div>    
");
#nullable restore
#line 42 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"comment-area\">\r\n    <h5>");
#nullable restore
#line 46 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
   Write(Localizer["Comments"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <div id=\"comments\">\r\n");
#nullable restore
#line 48 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
         foreach (var comment in ViewBag.Comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"margin-bottom:10px\">\r\n                <div class=\"card-header\">\r\n                    ");
#nullable restore
#line 52 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
               Write(comment.AuthorEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item\">");
#nullable restore
#line 55 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                           Write(comment.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n");
#nullable restore
#line 58 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 60 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
     if (User.IsInRole("Active"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"new-comment\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a392295ca03278d96a677ecec37a8c4976b261e815952", async() => {
                WriteLiteral("\r\n                <input id=\"new\" class=\"form-control\" name=\"comment\" type=\"text\" />\r\n                <a id=\"submit\" class=\"btn btn-lg btn-outline-success\">");
#nullable restore
#line 65 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                                 Write(Localizer["Send"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 68 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 71 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
Write(await Html.PartialAsync("/Views/_ScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $("".content"").each(function () {
        this.innerHTML = markdown.toHTML(this.innerHTML);
    })

    $("".chapter-image"").each(function () {
        if (this.id.length > 0) {
            getImage(this.id, this);
        }
    })

    function getImage(imageName, image) {
            $.get(""/Chapter/GetImage"", { ""filename"": imageName }, function (data) {
                let ssil = ""data:image/png;base64,"" + data;
                image.src = ssil;
            });
    }

    const hubConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/update"")
        .build();

    hubConnection.on(""updatecomments"", function (comment, email) {
        createComment(comment, email);
        if ($("".card-header"").length > 10) {
            document.getElementById(""comments"").style.height = ""400px"";
            document.getElementById(""comments"").style.overflow = ""auto"";
        }
    });

    function createComment(content, email) {
        let div = document.createEle");
            WriteLiteral(@"ment('div');
        createCardFromDiv(div);
        let title = document.createElement(""div"");
        createTitleFromDiv(title, email);
        let divComment = document.createElement(""ul"");
        createCommentDiv(divComment);
        let comment = document.createElement(""li"");
        createCommentContent(comment, content);
        createCommentBlock(div, title, divComment, comment);
    }

    function createCardFromDiv(div) {
        div.classList.add(""card"");
    }

    function createTitleFromDiv(title, email) {
        title.classList.add(""card-header"");
        title.innerHTML = email;
    }

    function createCommentDiv(divComment) {
        divComment.classList.add(""list-group"");
        divComment.classList.add(""list-group-flush"");
    }

    function createCommentContent(comment, content) {
        comment.classList.add(""list-group-item"");
        comment.innerHTML = content
    }

    function createCommentBlock(div, title, divComment, comment) {
        div.app");
            WriteLiteral(@"endChild(title);
        div.appendChild(divComment);
        divComment.appendChild(comment);
        div.style.marginBottom = ""10px""
        document.getElementById(""comments"").appendChild(div);
    }

    hubConnection.start();

    let timer = setInterval(() => {
        if (hubConnection.state == ""Connected"") {
            hubConnection.invoke('AddToStory', """);
#nullable restore
#line 145 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                           Write(ViewBag.Story.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
            clearInterval(timer)
        }
    }, 100);

    if ($("".card-header"").length > 10) {
        document.getElementById(""comments"").style.height = ""400px"";
        document.getElementById(""comments"").style.overflow = ""auto"";
    }

    $(""#submit"").click(function () {
        let content = document.getElementById(""new"").value;
        hubConnection.invoke(""Send"",content, """);
#nullable restore
#line 157 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                         Write(ViewBag.Story.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"");
#nullable restore
#line 157 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                              Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" );\r\n        $.post(\"/Comment/SendComment\", { \"content\": content, \"storyId\": \"");
#nullable restore
#line 158 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                                    Write(ViewBag.Story.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" });\r\n    })\r\n\r\n    $(\".star\").each(function () {\r\n        $(this).click(function () {\r\n            $.post(\"/Story/SetRate\", { \"value\": this.value, \"storyId\":");
#nullable restore
#line 163 "A:\WebApplication1\Views\Story\StoryPage.cshtml"
                                                                 Write(ViewBag.Story.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("});\r\n        })\r\n    })\r\n\r\n    $(\".like\").each(function () {\r\n        $(this).click(function () {\r\n            $.post(\"/Chapter/SetLike\", { \"chapterId\": this.name });            \r\n        })\r\n    })\r\n</script>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> LocOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> RoleManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chapter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
