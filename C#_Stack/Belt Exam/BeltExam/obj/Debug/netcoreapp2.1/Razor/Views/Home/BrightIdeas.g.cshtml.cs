#pragma checksum "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84bcb262e72fbff22b5be3490fcc0ac0c679b0b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BrightIdeas), @"mvc.1.0.view", @"/Views/Home/BrightIdeas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BrightIdeas.cshtml", typeof(AspNetCore.Views_Home_BrightIdeas))]
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
#line 1 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 2 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84bcb262e72fbff22b5be3490fcc0ac0c679b0b9", @"/Views/Home/BrightIdeas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BrightIdeas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-8 d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/PostIdea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("/LikeThisIdea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block ml-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 206, true);
            WriteLiteral("<div class=\"container-fluid bg-light border rounded\">\n    <div class=\"header container-fluid mb-4 mt-2 text-center\">\n        <h1 class=\"border-bottom\" style=\"\" class=\"text-center\">Welcome to the Main Page, ");
            EndContext();
            BeginContext(225, 16, false);
#line 4 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
                                                                                    Write(Model.User.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(241, 248, true);
            WriteLiteral("!</h1>\n    </div>\n    <div class=\"header container-fluid\">\n        <div class=\"text-right\">\n            <a class=\"align-top\" href=\"/logout\">Logout</a>\n        </div>\n    </div>\n    <div class=\"container-fluid ml-0 mr-0 border-bottom mb-3\">\n        ");
            EndContext();
            BeginContext(489, 430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63746069c2c43319888f0ba9f0e1966", async() => {
                BeginContext(557, 190, true);
                WriteLiteral("\n            <textarea class=\"form-control col-7 d-inline-block\" name=\"Content\" rows=\"4\" placeholder=\"post something witty here...\"></textarea>\n            <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 747, "\"", 773, 1);
#line 14 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
WriteAttributeValue("", 755, Model.User.UserId, 755, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(774, 138, true);
                WriteLiteral(">\n            <input style=\"vertical-align: top;\" class=\"btn btn-outline-success d-inline-block ml-3\" type=\"submit\" value=\"Post\">\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(919, 36, true);
            WriteLiteral("\n    </div>\n    <div class=\"posts\">\n");
            EndContext();
#line 19 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
          
            foreach(var idea in Model.DisplayIdeas)
            {

#line default
#line hidden
            BeginContext(1032, 87, true);
            WriteLiteral("                <div class=\"idea mb-5\">\n                    <h3 class=\"d-inline-block\">");
            EndContext();
            BeginContext(1120, 18, false);
#line 23 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
                                          Write(idea.Creator.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 58, true);
            WriteLiteral(" says:</h3>\n                    <p class=\"d-inline-block\">");
            EndContext();
            BeginContext(1197, 12, false);
#line 24 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
                                         Write(idea.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 77, true);
            WriteLiteral("</p>\n                    <br>\n                    <h6 class=\"d-inline-block\">");
            EndContext();
            BeginContext(1287, 24, false);
#line 26 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
                                          Write(idea.UsersWhoLiked.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 45, true);
            WriteLiteral(" people liked this!</h6>\n                    ");
            EndContext();
            BeginContext(1356, 311, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5721b2821fe54af38bdff9fae05aabd7", async() => {
                BeginContext(1412, 59, true);
                WriteLiteral("\n                        <input type=\"hidden\" name=\"IdeaId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1471, "\"", 1491, 1);
#line 28 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
WriteAttributeValue("", 1479, idea.IdeaId, 1479, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1492, 60, true);
                WriteLiteral(">\n                        <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1552, "\"", 1578, 1);
#line 29 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
WriteAttributeValue("", 1560, Model.User.UserId, 1560, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1579, 81, true);
                WriteLiteral(">\n                        <input type=\"submit\" value=\"Like\">\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1667, 24, true);
            WriteLiteral("\n                </div>\n");
            EndContext();
#line 33 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/Belt Exam/BeltExam/Views/Home/BrightIdeas.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1715, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
