#pragma checksum "C:\Users\HP\Desktop\project\back\Limak\Views\User\Courier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09376f84cc3c3fdcc91c2e67bb9bda3a85fa5388"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Courier), @"mvc.1.0.view", @"/Views/User/Courier.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\project\back\Limak\Views\_ViewImports.cshtml"
using Limak;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\project\back\Limak\Views\_ViewImports.cshtml"
using Limak.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\project\back\Limak\Views\_ViewImports.cshtml"
using Limak.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\project\back\Limak\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09376f84cc3c3fdcc91c2e67bb9bda3a85fa5388", @"/Views/User/Courier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456b2da68c8e23ca842b1027fb6f7ad83127957e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Courier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user-panel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\project\back\Limak\Views\User\Courier.cshtml"
  
    ViewData["Title"] = "Packages";
    Layout = "_UserPanelLayout";


#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09376f84cc3c3fdcc91c2e67bb9bda3a85fa53885047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"<!-- Panel Courier -->
<div class=""col-md-9 col-sm-11 col-xs-11 courier panel-right"" id=""panel-courier"" data-content=""panel-courier"">
    <div class=""row"">
        <div class=""col-xs-12 courier-log"">
            <div class=""block col-xs-12"">
                <h2>Kuryer</h2>
                <div class=""form-list"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09376f84cc3c3fdcc91c2e67bb9bda3a85fa53886639", async() => {
                WriteLiteral(@"
                        <div>
                            <div class=""row"">
                                <div class=""col-md-12 col-sm-12 col-xs-12"">
                                    <h3>Ərazi seç</h3>
                                    <div class=""row"">
                                        <div class=""col-md-7"">
                                            <h4>Bakı və Abşeron</h4>
                                            <br />
                                            <p>
                                                <input type=""radio"" name=""radio"" id=""1"" value=""1"" />
                                                <label for=""1"">
                                                    Səbail, Yasamal, Nəsimi, Binəqədi,
                                                    Nərimanov - 3AZN
                                                </label>
                                            </p>
                                            <p>
                                       ");
                WriteLiteral(@"         <input type=""radio"" name=""radio"" id=""2"" value=""2"" />
                                                <label for=""2"">
                                                    Xətai, Nizami, Sabunçu, Suraxanı -
                                                    4AZN
                                                </label>
                                            </p>
                                            <p>
                                                <input type=""radio"" name=""radio"" id=""3"" value=""3"" />
                                                <label for=""3"">
                                                    Xırdalan,Masazır,Lökbatan - 5
                                                    AZN
                                                </label>
                                            </p>
                                            <p>
                                                <input type=""radio"" name=""radio"" id=""4"" value=""4"" />
                           ");
                WriteLiteral(@"                     <label for=""4"">
                                                    Bakı ətrafı kənd və qəsəbələr - 5
                                                    AZN
                                                </label>
                                            </p>
                                        </div>
                                        <div class=""col-md-5"">
                                            <h4>Regionlar</h4>
                                            <br />
                                            <p>
                                                <input type=""radio"" name=""radio"" id=""12"" value=""12"" />
                                                <label for=""12"">Gəncə (Şəhər daxili) - 2 AZN</label>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div ");
                WriteLiteral(@"class=""row"">
                                <div class=""col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""input-group border-radius"">
                                        <label>
                                            <input type=""text""
                                                   name=""region""
                                                   placeholder="" ""
                                                   class=""form-control inputText"" />
                                            <span>Rayon *</span>
                                        </label>
                                         
                                    </div>
                                </div>
                                <div class=""col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""input-group border-radius"">
                                        <label>
                                            <input type=""text""
                 ");
                WriteLiteral(@"                                  name=""village""
                                                   placeholder="" ""
                                                   class=""form-control inputText"" />
                                            <span>Qəsəbə </span>
                                        </label>
                                    </div>
                                </div>
                                <div class=""col-md-4 col-sm-6 col-xs-12"">
                                    <div class=""input-group border-radius"">
                                        <label>
                                            <input type=""text""
                                                   name=""street""
                                                   placeholder="" ""
                                                   class=""form-control inputText"" />
                                            <span>Küçə *</span>
                                        </label>
                    ");
                WriteLiteral(@"                     
                                    </div>
                                </div>
                                <div class=""col-md-6 col-sm-5 col-xs-12"">
                                    <div class=""input-group border-radius"">
                                        <label>
                                            <input type=""text""
                                                   name=""home""
                                                   placeholder="" ""
                                                   class=""form-control inputText"" />
                                            <span>Ev *</span>
                                        </label>
                                         
                                    </div>
                                </div>
                                <div class=""col-md-6 col-sm-6 col-xs-12"">
                                    <div class=""input-group border-radius"">
                                        <l");
                WriteLiteral(@"abel>
                                            <input type=""number""
                                                   name=""tel""
                                                   placeholder="" ""
                                                   class=""form-control inputText"" />
                                            <span>Telefon *</span>
                                        </label>
                                         
                                    </div>
                                </div>
                                <div class=""col-md-12 col-sm-12 col-xs-12"">
                                    <label>
                                        Kuryer sifariş etmək üçün bağlamanız
                                        yoxdur
                                    </label>
                                    <div class=""input-group border-radius"">
                                        <ul class=""select-outer"">
                                            <li cla");
                WriteLiteral("ss=\"package-menu-courier-item package-menu-courier form-control\">\r\n                                                <p");
                BeginWriteAttribute("class", " class=\"", 7809, "\"", 7817, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <span> Bağlamanı seçin</span>
                                                </p>
                                                <ul class=""dropdown-menu"">
                                                    <li class=""select-item"">
                                                        <label class=""check-button"">
                                                            <span class=""check-text"">Hamısı</span>
                                                            <input type=""checkbox"" />
                                                            <span class=""checkmark""></span>
                                                        </label>
                                                    </li>
                                                </ul>
                                            </li>
                                             
                                        </ul>
                                    </d");
                WriteLiteral(@"iv>
                                </div>
                                <div class=""col-xs-12"">
                                    <div class=""textarea-form form-group"">
                                        <textarea rows=""4""
                                                  id=""comment""
                                                  placeholder=""Əlavə qeydlərinizi yazın""
                                                  class=""form-control""></textarea>
                                    </div>
                                </div>
                                <div class=""col-xs-12 button-part"">
                                    <button type=""submit"" class=""btn-effect"">
                                        Təsdiq et
                                    </button>
                                </div>
                                <div class=""col-xs-12"">
                                    <br />
                                    <p>
                                    ");
                WriteLiteral(@"    <b>
                                            <span>
                                                Kuryer sifarişiniz 24 saat ərzində təyin
                                                olunur.
                                            </span>
                                        </b>
                                    </p>
                                    <p>
                                        <b>
                                            <span>
                                                Kuryerin iş saatları 10:00 - 19:00
                                                (həftənin 6 günü).
                                            </span>
                                        </b>
                                    </p>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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