#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Views\Shared\Components\VideoPlayer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d8a13263753c101e1a38c144ad8ed7cf6cd419c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VideoPlayer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VideoPlayer/Default.cshtml")]
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d8a13263753c101e1a38c144ad8ed7cf6cd419c", @"/Views/Shared/Components/VideoPlayer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046cb80209a1bb73991b3ca11cb3939ec8dac1d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VideoPlayer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-10 bg-light"">
    <video id=""myplayer""
           style=""width: 100% !important;height:auto;""
           class=""video-js vjs-big-play-centered""
           controls
           preload=""auto""
           data-setup='{}'>
        <source src=""/videos/video.mp4#t=2"" type=""video/mp4"" />
        <p class=""vjs-no-js"">
            To view this video please enable JavaScript, and consider upgrading to a
            web browser that
            <a href=""https://videojs.com/html5-video-support/"" target=""_blank"">
                supports HTML5 video
            </a>
        </p>
    </video>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
