#pragma checksum "C:\Users\Shayne Maravillo\Desktop\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Thumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c6f5d0c7a541968d110a54c343bcd449bbb8e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Posts_Thumbnail), @"mvc.1.0.view", @"/Areas/Manage/Views/Posts/Thumbnail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Posts/Thumbnail.cshtml", typeof(AspNetCore.Areas_Manage_Views_Posts_Thumbnail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6f5d0c7a541968d110a54c343bcd449bbb8e13", @"/Areas/Manage/Views/Posts/Thumbnail.cshtml")]
    public class Areas_Manage_Views_Posts_Thumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts.ThumbnailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/posts/update-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Thumbnail.cshtml"
  
    ViewData["Title"] = "Thumbnail";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(191, 80, true);
            WriteLiteral("<h2>Post Thumbnail</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(271, 722, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddba343c05a1499bbcdcb6a36867934f", async() => {
                BeginContext(362, 90, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"PostId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 452, "\"", 473, 1);
#line 11 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Thumbnail.cshtml"
WriteAttributeValue("", 460, Model.PostId, 460, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(474, 86, true);
                WriteLiteral(" />\r\n                <label for=\"Thumbnail\">Thumbnail:</label><br />\r\n                ");
                EndContext();
                BeginContext(560, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "844363da9b8b459f9c4903f790b49e32", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 570, "~/posts/", 570, 8, true);
#line 13 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Thumbnail.cshtml"
AddHtmlAttributeValue("", 578, Model.PostId, 578, 13, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 591, "/thumbnail.png", 591, 14, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(643, 105, true);
                WriteLiteral("</br></br>\r\n                <input type=\"file\" class=\"form-control\" name=\"Thumbnail\" />\r\n                ");
                EndContext();
                BeginContext(749, 24, false);
#line 15 "C:\Users\Shayne Maravillo\Desktop\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Thumbnail.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(773, 213, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-10\">\r\n                    <input type=\"submit\" value=\"Upload\" />\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(993, 21, true);
            WriteLiteral("\r\n    </div>\r\n</div> ");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts.ThumbnailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
