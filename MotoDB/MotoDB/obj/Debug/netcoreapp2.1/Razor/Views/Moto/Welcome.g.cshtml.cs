#pragma checksum "C:\Users\Andrius\Documents\GitHub\MotoDB\MotoDB\MotoDB\Views\Moto\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c15bfabf0ab961c2bbf12d3807f86b46b8eec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moto_Welcome), @"mvc.1.0.view", @"/Views/Moto/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Moto/Welcome.cshtml", typeof(AspNetCore.Views_Moto_Welcome))]
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
#line 1 "C:\Users\Andrius\Documents\GitHub\MotoDB\MotoDB\MotoDB\Views\_ViewImports.cshtml"
using MotoDB;

#line default
#line hidden
#line 2 "C:\Users\Andrius\Documents\GitHub\MotoDB\MotoDB\MotoDB\Views\_ViewImports.cshtml"
using MotoDB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c15bfabf0ab961c2bbf12d3807f86b46b8eec5", @"/Views/Moto/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082d2253b1f9fa9bdfe771902156d56ed0be7e2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Moto_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Andrius\Documents\GitHub\MotoDB\MotoDB\MotoDB\Views\Moto\Welcome.cshtml"
   
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(44, 28, true);
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 8 "C:\Users\Andrius\Documents\GitHub\MotoDB\MotoDB\MotoDB\Views\Moto\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(137, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(150, 19, false);
#line 10 "C:\Users\Andrius\Documents\GitHub\MotoDB\MotoDB\MotoDB\Views\Moto\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\Andrius\Documents\GitHub\MotoDB\MotoDB\MotoDB\Views\Moto\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(183, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
