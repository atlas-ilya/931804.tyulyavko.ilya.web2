#pragma checksum "C:\Users\Elijah\source\repos\931804.tyulyavko.ilya.web2\lab4\Views\Controls\ResultControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d621adb1228d84929b9ec0e326460f3bf81b5d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_ResultControl), @"mvc.1.0.view", @"/Views/Controls/ResultControl.cshtml")]
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
#line 1 "C:\Users\Elijah\source\repos\931804.tyulyavko.ilya.web2\lab4\Views\_ViewImports.cshtml"
using lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elijah\source\repos\931804.tyulyavko.ilya.web2\lab4\Views\_ViewImports.cshtml"
using lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d621adb1228d84929b9ec0e326460f3bf81b5d6", @"/Views/Controls/ResultControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b856ffc28bb915aac4f86c443e1a63cacffcc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_ResultControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab1.Models.Controls>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Elijah\source\repos\931804.tyulyavko.ilya.web2\lab4\Views\Controls\ResultControl.cshtml"
  
    ViewData["Title"] = "Check Box";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <h1>");
#nullable restore
#line 6 "C:\Users\Elijah\source\repos\931804.tyulyavko.ilya.web2\lab4\Views\Controls\ResultControl.cshtml"
   Write(Model.ControlElement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <b style=\"display: inline\">");
#nullable restore
#line 7 "C:\Users\Elijah\source\repos\931804.tyulyavko.ilya.web2\lab4\Views\Controls\ResultControl.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\n    <h6>");
#nullable restore
#line 8 "C:\Users\Elijah\source\repos\931804.tyulyavko.ilya.web2\lab4\Views\Controls\ResultControl.cshtml"
   Write(Model.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab1.Models.Controls> Html { get; private set; }
    }
}
#pragma warning restore 1591
