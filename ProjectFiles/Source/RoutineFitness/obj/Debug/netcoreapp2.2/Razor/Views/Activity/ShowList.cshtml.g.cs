#pragma checksum "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b19e31bb370186d3d12cea1dbac355896b4499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activity_ShowList), @"mvc.1.0.view", @"/Views/Activity/ShowList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Activity/ShowList.cshtml", typeof(AspNetCore.Views_Activity_ShowList))]
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
#line 4 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b19e31bb370186d3d12cea1dbac355896b4499", @"/Views/Activity/ShowList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdfdb7f6bf7d563e3fc3287ac9d96171df2fccad", @"/Views/_ViewImports.cshtml")]
    public class Views_Activity_ShowList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SavedWorkoutViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
  
    Layout = "_LayoutTwo";

#line default
#line hidden
            BeginContext(67, 313, true);
            WriteLiteral(@"
        <table>
            <thead>
                <tr>
                    <th>Lift Name</th>
                    <th>Sets</th>
                    <th>Reps</th>
                    <th>Weight</th>
                    <th>Notes</th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 19 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
                 foreach (var a in Model.Activities.Zip(Model.LiftName, Tuple.Create))
                {

#line default
#line hidden
            BeginContext(487, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(542, 7, false);
#line 22 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
                       Write(a.Item2);

#line default
#line hidden
            EndContext();
            BeginContext(549, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(585, 12, false);
#line 23 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
                       Write(a.Item1.Sets);

#line default
#line hidden
            EndContext();
            BeginContext(597, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(633, 12, false);
#line 24 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
                       Write(a.Item1.Reps);

#line default
#line hidden
            EndContext();
            BeginContext(645, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(681, 14, false);
#line 25 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
                       Write(a.Item1.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(695, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(731, 12, false);
#line 26 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
                       Write(a.Item1.Note);

#line default
#line hidden
            EndContext();
            BeginContext(743, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 28 "C:\Users\turtl\OneDrive\Cloud Developer Class\7. Project\RoutineFitness\RoutineFitness\Views\Activity\ShowList.cshtml"
                }

#line default
#line hidden
            BeginContext(796, 44, true);
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SavedWorkoutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591