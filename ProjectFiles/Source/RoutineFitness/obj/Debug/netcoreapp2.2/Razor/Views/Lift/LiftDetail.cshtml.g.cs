#pragma checksum "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Lift\LiftDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91680d1f6a6016158fd38ad7591340b23cf65e17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lift_LiftDetail), @"mvc.1.0.view", @"/Views/Lift/LiftDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lift/LiftDetail.cshtml", typeof(AspNetCore.Views_Lift_LiftDetail))]
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
#line 1 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\_ViewImports.cshtml"
using RoutineFitness;

#line default
#line hidden
#line 2 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\_ViewImports.cshtml"
using RoutineFitness.Models;

#line default
#line hidden
#line 3 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\_ViewImports.cshtml"
using RoutineFitness.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91680d1f6a6016158fd38ad7591340b23cf65e17", @"/Views/Lift/LiftDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e58fe342f906a6ca2ef134bbf2ce5a0614ffbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Lift_LiftDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LiftsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Lift\LiftDetail.cshtml"
  
    ViewData["Title"] = "LiftDetail";
    Layout = "~/Views/Shared/_LayoutTwo.cshtml";

#line default
#line hidden
            BeginContext(121, 23, true);
            WriteLiteral("\r\n<h2>LiftDetail</h2>\r\n");
            EndContext();
#line 9 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Lift\LiftDetail.cshtml"
 foreach (var l in Model.Lifts)
{

#line default
#line hidden
            BeginContext(180, 62, true);
            WriteLiteral("    <video width=\"320\" height=\"240\" controls>\r\n        <source");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 242, "\"", 259, 1);
#line 12 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Lift\LiftDetail.cshtml"
WriteAttributeValue("", 248, l.VideoUrl, 248, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(260, 34, true);
            WriteLiteral(" type=\"video/mp4\">\r\n    </video>\r\n");
            EndContext();
            BeginContext(296, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(304, 10, false);
#line 15 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Lift\LiftDetail.cshtml"
  Write(l.LiftName);

#line default
#line hidden
            EndContext();
            BeginContext(314, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(328, 17, false);
#line 16 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Lift\LiftDetail.cshtml"
  Write(l.LiftDescription);

#line default
#line hidden
            EndContext();
            BeginContext(345, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 17 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Lift\LiftDetail.cshtml"
}

#line default
#line hidden
            BeginContext(354, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LiftsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
