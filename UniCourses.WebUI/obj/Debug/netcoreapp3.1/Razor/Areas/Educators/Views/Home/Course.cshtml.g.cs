#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Educators_Views_Home_Course), @"mvc.1.0.view", @"/Areas/Educators/Views/Home/Course.cshtml")]
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb", @"/Areas/Educators/Views/Home/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b097cc864e19282c5285d8c04a0f0821fcd3e1", @"/Areas/Educators/Views/_ViewImports.cshtml")]
    public class Areas_Educators_Views_Home_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CourseList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateLesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadVideo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditLesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Areas/Educators/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""content-wrapper"">
        <!-- Content Header (Page header) -->
        <section class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">

                    </div>
                    <div class=""col-sm-6"">
                        <ol class=""breadcrumb float-sm-right"">
                            <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb8144", async() => {
                WriteLiteral("Ana Sayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb9365", async() => {
                WriteLiteral("Kurslar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li class=\"breadcrumb-item active\">");
#nullable restore
#line 20 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ol>
                    </div>
                </div>
            </div><!-- /.container-fluid -->
        </section>

        <!-- Main content -->
        <section class=""content"">

            <!-- Default box -->
            <div class=""card card-solid"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-12 col-sm-4"">
                            <div class=""col-12"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 1344, "\"", 1369, 2);
            WriteAttributeValue("", 1350, "/img/", 1350, 5, true);
#nullable restore
#line 36 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
WriteAttributeValue("", 1355, item.ImageURL, 1355, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid\">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-12 col-sm-8\">\r\n                            <h3 class=\"my-3\">");
#nullable restore
#line 40 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 42 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <br />\r\n                            <p>\r\n                                ");
#nullable restore
#line 46 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                           Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>

                            <hr>

                            <div class=""row"">
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Ders Sayısı</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">");
#nullable restore
#line 56 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                                                                 Write(item.Lessons.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Ders</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Toplam Süre</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">");
#nullable restore
#line 64 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                                                                  Write(item.Duration/3600);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Saat ");
#nullable restore
#line 64 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                                                                                             Write(item.Duration/60);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Dakika</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""info-box bg-light"">
                                        <div class=""info-box-content"">
                                            <span class=""info-box-text text-center text-muted"">Fiyat</span>
                                            <span class=""info-box-number text-center text-muted mb-0"">");
#nullable restore
#line 72 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" tl</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <hr>
                        </div>
                    </div>
                    <div class=""row d-flex align-items-center justify-content-center"">
                        <div class=""text-center mt-5 mb-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb16791", async() => {
                WriteLiteral("Ders Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb18061", async() => {
                WriteLiteral("Kursu Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb20383", async() => {
                WriteLiteral("Kursu Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <!--/. edit, delete buttons-->
                    <div class=""row"">
                        <div class=""col-9 mt-4"">
                            <nav class=""w-100"">
                                <div class=""nav nav-tabs"" id=""product-tab"" role=""tablist"">
                                    <a class=""nav-item nav-link active"" id=""product-desc-tab"" data-toggle=""tab"" href=""#product-desc"" role=""tab"" aria-controls=""product-desc"" aria-selected=""true"">Description</a>
                                    <a class=""nav-item nav-link"" id=""product-comments-tab"" data-toggle=""tab"" href=""#product-comments"" role=""tab"" aria-controls=""product-comments"" aria-selected=""false"">Yorumlar</a>
                                    <a class=""nav-item nav-link"" id=""product-rating-tab"" data-toggle=""tab"" href=""#product-rating"" role=""tab"" aria-controls=""product-rating"" aria-selected=""false"">Rating</a>
                                </div>
         ");
            WriteLiteral(@"                   </nav>
                            <div class=""tab-content p-3"" id=""nav-tabContent"">
                                <div class=""tab-pane fade show active"" id=""product-desc"" role=""tabpanel"" aria-labelledby=""product-desc-tab"">
                                    ");
#nullable restore
#line 99 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                               Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""tab-pane fade"" id=""product-comments"" role=""tabpanel"" aria-labelledby=""product-comments-tab"">
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            ");
#nullable restore
#line 104 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                       Write(await Component.InvokeAsync("KursYorumlari", item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""tab-pane fade"" id=""product-rating"" role=""tabpanel"" aria-labelledby=""product-rating-tab"">
                                    Cras ut ipsum ornare, aliquam ipsum non, posuere elit. In hac habitasse platea dictumst. Aenean elementum leo augue, id fermentum risus efficitur vel. Nulla iaculis malesuada scelerisque. Praesent vel ipsum felis. Ut molestie, purus aliquam placerat sollicitudin, mi ligula euismod neque, non bibendum nibh neque et erat. Etiam dignissim aliquam ligula, aliquet feugiat nibh rhoncus ut. Aliquam efficitur lacinia lacinia. Morbi ac molestie lectus, vitae hendrerit nisl. Nullam metus odio, malesuada in vehicula at, consectetur nec justo. Quisque suscipit odio velit, at accumsan urna vestibulum a. Proin dictum, urna ut varius consectetur, sapien justo porta lectus, at mollis nisi orci et nulla. Donec pellentesque tort");
            WriteLiteral(@"or vel nisl commodo ullamcorper. Donec varius massa at semper posuere. Integer finibus orci vitae vehicula placerat.
                                </div>
                            </div>
                        </div>
                        <!--/.comments-->
                    </div>
                    <!--/.row-->
                </div>
                <!-- /.card-body -->
            </div>
            <!-- /Lessons card -->
            <div class=""card card-solid"">
                <div class=""card-body"">
                    <div class=""row"">
                            <div class=""card-header"">
                                <h3 class=""card-title"">Eklediğim Dersler</h3>
                            </div>
                            <!-- /.card-header -->
                            <div class=""card-body table-responsive p-0"">
                                <table class=""table table-striped projects"">
                                    <thead>
                                 ");
            WriteLiteral(@"       <tr>
                                            <th style=""width: 10%"">
                                                Ders No
                                            </th>
                                            <th style=""width: 30%"">
                                                Ders İsmi
                                            </th>
                                            <th style=""width: 20%"">
                                                Toplam Uzunluk
                                            </th>
                                            <th style=""width: 20%"" class=""text-center"">
                                                Durum
                                            </th>
                                            <th style=""width: 20%"">
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 168 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                         foreach (Lesson lessons in item.Lessons)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 172 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                           Write(lessons.LessonNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <a>\r\n                                                    ");
#nullable restore
#line 176 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                               Write(lessons.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                                <br />\r\n                                                <small>\r\n                                                    ");
#nullable restore
#line 180 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                               Write(lessons.LessonDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </small>
                                            </td>

                                            <td class=""project_progress"">

                                                <small>
                                                    lessons.Videos.Count Video
                                                </small>
                                            </td>
                                            <td class=""project-state"">
                                                <span class=""badge badge-success"">Tamamlandı</span>
                                            </td>
                                            <td class=""project-actions text-right"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb30909", async() => {
                WriteLiteral(@"
                                                    <i class=""fa fa-file-video-o "">
                                                    </i>
                                                    Video Ekle
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 194 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                                                                    WriteLiteral(lessons.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adc6fe9c6036c35e3a895ae9cc41e0e720a1f3fb33529", async() => {
                WriteLiteral("\r\n                                                    <i class=\"fa fa-pencil\">\r\n                                                    </i>\r\n                                                    Düzenle\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <a class=""btn btn-danger btn-sm"" href=""#"">
                                                    <i class=""fa fa-trash"">
                                                    </i>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 210 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            
                            <!-- /.card-body -->
                        </div>
                        
                    </div>
                    <!--/Lessons row-->
                </div>
                <!-- /Lessons card-body -->
            </div>
        </section>
        <!-- /.content -->
    </div>
    <!-- /.content-wrapper -->
");
#nullable restore
#line 226 "C:\Users\omerf\source\repos\KayaTS\UniCourses2\UniCourses\UniCourses.WebUI\Areas\Educators\Views\Home\Course.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
