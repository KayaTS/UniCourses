#pragma checksum "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\Home\Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf058df460f45001287261733cd5fd269306f181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_uye_Views_Home_Profil), @"mvc.1.0.view", @"/Areas/uye/Views/Home/Profil.cshtml")]
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
#line 1 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\_ViewImports.cshtml"
using UniCourses.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\_ViewImports.cshtml"
using UniCourses.WebUI.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\_ViewImports.cshtml"
using UniCourses.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\_ViewImports.cshtml"
using UniCourses.Dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf058df460f45001287261733cd5fd269306f181", @"/Areas/uye/Views/Home/Profil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14015c86891622e121c9cad3467d87433b6b55c3", @"/Areas/uye/Views/_ViewImports.cshtml")]
    public class Areas_uye_Views_Home_Profil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniCourses.Dal.Entities.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("profileimage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadPicture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inputPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\Home\Profil.cshtml"
  
    ViewData["Title"] = "Profil";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--\r\n    row\r\n        col 3   profil fotoğrafı\r\n        col 9   profili editle\r\n                kullanıcı adı\r\n                okul, sınıf bilgisi\r\n                (opsiyonel) teknik becerileri\r\n        col 12  aldığım kurslar, verdiğim kurslar\r\n-->\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row element-animate mt-3\">\r\n        <div class=\"col-md-4 mt-lg-5 mb-3\">\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf058df460f45001287261733cd5fd269306f1817452", async() => {
                WriteLiteral(@"
                <div class=""card card-primary card-outline"">
                    <div class=""card-body box-profile"">
                        <div class=""text-center"">
                            <div class=""row d-flex align-items-center justify-content-center"">
                                <img class=""profile-user-img img-fluid img-circle""
                                     style=""max-width:250px; height: auto; margin:auto;""");
                BeginWriteAttribute("src", " src=\"", 2272, "\"", 2304, 2);
                WriteAttributeValue("", 2278, "/Picture/", 2278, 9, true);
#nullable restore
#line 53 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\Home\Profil.cshtml"
WriteAttributeValue("", 2287, Model.PictureURL, 2287, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row d-flex align-items-center justify-content-center m-3"">

                    <label for=""profileimg"" class=""btn btn-outline-light""><i class=""fa fa-eye"">Yeni Fotoğraf Yükle</i></label>
                    <small>Tercihen 250x250 boyutunda ve kare fotoğraflar ekleyin</small>
                    <small>Yeni fotoğraf ekledikten sonra kaydet tuşuna basınız. Değişiklik o zaman görünecek</small>
                    <input type=""file"" name=""file"" multiple=""multiple"" id=""profileimg"" class=""form-control-file"" style=""display:none;"" required>
");
                WriteLiteral(@"  <!--yeni eklenecek fotoğrafın linkini göstermeye çalışalım-->
                    <input type=""submit"" class=""btn btn-primary"" value=""Kaydet"">
                    <!--iki input yerine bir inputta yüklemeyi tamamlamaya çalışalım-->
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"col-md-8 mt-lg-5 text-left\">\r\n            <div class=\"icon-row\">\r\n");
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf058df460f45001287261733cd5fd269306f18111371", async() => {
                WriteLiteral(@"
                    <div class=""form-group row"">
                        <label for=""nameSurname"" class=""col-md-4 col-form-label text-right""><i class=""fa fa-user m-2"" aria-hidden=""true"" style=""color:#cc2444;""></i>İsim Soyisim</label>
                        <div class=""col-lg-6"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf058df460f45001287261733cd5fd269306f18111955", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 93 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\Home\Profil.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.NameSurName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\Areas\uye\Views\Home\Profil.cshtml"
                                                                                                               WriteLiteral(Model.NameSurName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""col-md-2"">
                            <input type=""submit"" class=""form-control btn btn-primary"" value=""Kaydet"">
                        </div>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
    </div>
    <!--Tanıtım ends-->
    <!--Kurslar starts-->
    <div class=""row bg-light"">
        <div class=""col-md-12 block-25"">
            <div id=""Page1"">

                <div class=""row justify-content-between m-3 p-2"">
                    <div style=""float:left; margin:5px;"">
                        <h4>Takip Ettiğim Kurslar</h4>
                    </div>
                    <div style=""float:right;margin:5px;"">
                        <a href=""#"" class=""btn btn-outline-primary"" onclick=""return show('Page2','Page1');"">Sunulan Kursları Göster</a>
                    </div>
                </div>



                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6029, "\"", 6035, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                                    </div>

                                </div>
                            </a>
                        </div>
                    </div>

                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6931, "\"", 6937, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                                    </div>

                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7831, "\"", 7837, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                                    </div>

                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8731, "\"", 8737, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                                    </div>

                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9630, "\"", 9636, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                    <div class=""progress"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                                    </div>

                                </div>
                            </a>
                        </div>
                    </div>
                </div>

                <!--Courses ENDS-->


            </div>

            <div id=""Page2"" style=""display:none"">

                <div class=""row justify-content-between m-3 p-2"">
                    <div style=""float:left; margin:5px;"">
                        <h4>Sunduğum Kurslar</h4>
                    </div>
                    <div style=""float:right;margin:5px;"">
                       ");
            WriteLiteral(@" <a href=""#"" class=""btn btn-outline-primary"" onclick=""return show('Page1','Page2');"">Takip Ettilen Kursları Göster</a>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class="" m-2"">
                            <a href=""#"" class=""d-flex"" style=""vertical-align:middle;"">
                                <img style=""height:100px; width:auto; margin:5px 10px 10px 0px;"" src=""/images/img_2_b.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11166, "\"", 11172, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                                <div class=""text m-2"">
                                    <h3 class=""heading"">Create cool websites using this template</h3>

                                    <div class=""price text-right""><del class=""mr-3"">$23</del><span>Free</span></div>

                                </div>
                            </a>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <!--kurslar sonu-->
    <!--faaliyetler başı-->
    
</div>
<script>
    function show(shown, hidden) {
        document.getElementById(shown).style.display = 'block';
        document.getElementById(hidden).style.display = 'none';
        return false;
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniCourses.Dal.Entities.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
