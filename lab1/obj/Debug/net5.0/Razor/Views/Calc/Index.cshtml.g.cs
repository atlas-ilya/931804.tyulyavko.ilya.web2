#pragma checksum "C:\Users\Elijah\source\repos\lab1\Views\Calc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120a62f55a3900ec6b8f87f5f68004fe2ab8fd67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_Index), @"mvc.1.0.view", @"/Views/Calc/Index.cshtml")]
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
#line 1 "C:\Users\Elijah\source\repos\lab1\Views\_ViewImports.cshtml"
using lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elijah\source\repos\lab1\Views\_ViewImports.cshtml"
using lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120a62f55a3900ec6b8f87f5f68004fe2ab8fd67", @"/Views/Calc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b856ffc28bb915aac4f86c443e1a63cacffcc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Elijah\source\repos\lab1\Views\Calc\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Calc Service Demonstration</h2>
<ul>
    <li>
        <a href=""/Calc/UsingModelCalc"">Using Model Calc</a>
    </li>
    <li>
        <a href=""/Calc/ViewDataCalc"">Using ViewData Calc</a>
    </li>
    <li>
        <a href=""/Calc/ViewBagCalc"">Using ViewBag Calc</a>
    </li>
    <li>
        <a href=""/Calc/ServiceInjectionCalc"">Using Service Injection Calc</a>
    </li>
</ul>");
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