#pragma checksum "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/ASP.NET Core/ViewModelFun/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99885e400bf6597b02483a3e418f433241c163b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/ASP.NET Core/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 1 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/ASP.NET Core/ViewModelFun/Views/Home/Index.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99885e400bf6597b02483a3e418f433241c163b1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 87, true);
            WriteLiteral("\r\n<h1>Here is a list of names.</h1>\r\n<p>Brought to you by rendering from a model!</p>\r\n");
            EndContext();
#line 6 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/ASP.NET Core/ViewModelFun/Views/Home/Index.cshtml"
 foreach(var name in Model){

#line default
#line hidden
            BeginContext(162, 8, true);
            WriteLiteral("    <h5>");
            EndContext();
            BeginContext(171, 4, false);
#line 7 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/ASP.NET Core/ViewModelFun/Views/Home/Index.cshtml"
   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(175, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 8 "/Users/skylarmacias/Documents/Coding_Dojo_Projects/C#_Stack/ASP.NET Core/ViewModelFun/Views/Home/Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
