#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e64072f0a3e6780bbc4ea4cafef9432dbf65e28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_KursYorumlari_Default), @"mvc.1.0.view", @"/Views/Shared/Components/KursYorumlari/Default.cshtml")]
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
using UniCourses.WebUI.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e64072f0a3e6780bbc4ea4cafef9432dbf65e28", @"/Views/Shared/Components/KursYorumlari/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9610a0b4e08ff27db021206b3e1634715074c956", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_KursYorumlari_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UniCourses.Dal.Entities.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("</UniCourses.WebUI.ViewComponents.KursYorumlari>\n\n\n    <div>\n");
#nullable restore
#line 7 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
         foreach (Comment comment in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\n                <div class=\"row m-3\">\n                    <div class=\"col-md-10\">\n                        <strong class=\"text-info\">-");
#nullable restore
#line 12 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
                                              Write(comment.MemberID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <span class=\"text-muted\">");
#nullable restore
#line 12 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
                                                                                                  Write(comment.CommentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Tarihinde Yorumladı</span>\n                    </div>\n                    <i>\"");
#nullable restore
#line 14 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
                   Write(comment.UserComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("!\"</i>\n                    <div style=\"width:100%;\"><p style=\"text-align:right;\"></p></div>\n                </div>\n            </ul>\n");
#nullable restore
#line 18 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Views\Shared\Components\KursYorumlari\Default.cshtml"
           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UniCourses.Dal.Entities.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591