#pragma checksum "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b67aea3950645aaa2beeffcaaf0977195f09a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_ServiceInjectionCalc), @"mvc.1.0.view", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b67aea3950645aaa2beeffcaaf0977195f09a0e", @"/Views/Calc/ServiceInjectionCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b856ffc28bb915aac4f86c443e1a63cacffcc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_ServiceInjectionCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
   ViewData["Title"] = "AccessServiceDirectly";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>AccessServiceDirectly</h2>\n\n<div><b>Rand Value First: ");
#nullable restore
#line 7 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                     Write(Calculate.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n<div><b>Rand Value Second: ");
#nullable restore
#line 8 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                      Write(Calculate.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n<div>\n    <b>Add :</b>\n    <br />\n    ");
#nullable restore
#line 12 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
Write(Calculate.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 12 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                   Write(Calculate.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 12 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                       Write(Calculate.Add());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    <b>Sub :</b>\n    <br />\n    ");
#nullable restore
#line 17 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
Write(Calculate.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                   Write(Calculate.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 17 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                       Write(Calculate.Sub());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    <b>Mult :</b>\n    <br />\n    ");
#nullable restore
#line 22 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
Write(Calculate.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * ");
#nullable restore
#line 22 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                   Write(Calculate.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 22 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                       Write(Calculate.Mult());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    <b>Div :</b>\n    <br />\n    ");
#nullable restore
#line 27 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
Write(Calculate.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 27 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                   Write(Calculate.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 27 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                                             if (Calculate.Div() == -1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" error\n");
#nullable restore
#line 30 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
Write(Calculate.Div());

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Elijah\source\repos\lab1\Views\Calc\ServiceInjectionCalc.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public lab1.Services.ICalc Calculate { get; private set; }
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