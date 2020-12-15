#pragma checksum "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05de64fb92967685f56ca714c5a03499d6aae09a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ForeignAddresses), @"mvc.1.0.view", @"/Views/User/ForeignAddresses.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05de64fb92967685f56ca714c5a03499d6aae09a", @"/Views/User/ForeignAddresses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456b2da68c8e23ca842b1027fb6f7ad83127957e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ForeignAddresses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user-panel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
  
    ViewData["Title"] = "Packages";
    Layout = "_UserPanelLayout";
    var customerId = "";
    var fullName = "";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
     if (signInManager.IsSignedIn(User))
    {
        //Full name of user
        fullName = UserManager.FindByNameAsync(User.Identity.Name).Result.FirstName + " " + UserManager.FindByNameAsync(User.Identity.Name).Result.LastName;
        //Cutsomer id of user
        customerId = UserManager.FindByNameAsync(User.Identity.Name).Result.CustomerId;
    }

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05de64fb92967685f56ca714c5a03499d6aae09a5011", async() => {
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
            WriteLiteral(@"<!-- Foreign-address -->
<div class=""col-md-9 col-sm-11 col-xs-11 order-body address panel-right"" data-content=""panel-foreign-address""
     id=""foreign-address"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""block"">
                <ul role=""tablist"" class=""nav nav-tabs"">
                    <li class=""active"">
                        <a href=""#turkey""
                           data-toggle=""tab""
                           class=""order-img1 active"">Türkiyə</a>
                    </li>
                    <li");
            BeginWriteAttribute("class", " class=\"", 1236, "\"", 1244, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <a href=""#usa""
                           data-toggle=""tab""
                           class=""order-img2"">Amerika</a>
                    </li>
                </ul>
                <div class=""tab-content"">
                    <div id=""turkey""
                         class=""tab-pane fade active in"">
                        <ul>
                            <li>
                                <b>Ad, Soyad</b>
                                <p>
                                    <span id=""p1"">
                                        ");
#nullable restore
#line 46 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
                                   Write(customerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - LİMAK İTHALAT VE İHRACAT
                                        LİMİTED
                                    </span>
                                    şirketi
                                    <button class=""btn"">
                                        <i class=""fa fa-copy""></i> Copy
                                    </button>
                                </p>
                            </li>
                            <li>
                                <b>Adres başlığı</b>
                                <p>
                                    <span id=""p2"">
                                        LİMAK - ");
#nullable restore
#line 59 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
                                           Write(customerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 59 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
                                                         Write(fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span>
                                </p>
                            </li>
                            <li>
                                <b>
                                    Adres satır 1 (Müştəri kodu,ad və soyadınızla
                                    birgə tam olaraq kopyalayın)
                                </b>
                                <p>
                                    <span id=""p3"">
                                        ");
#nullable restore
#line 70 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
                                   Write(customerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
                                               Write(fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", Halkalı, 1.Tuna cd.
                                        Üzümlü SK. 5a
                                    </span><button class=""btn"">
                                        <i class=""fa fa-copy""></i> Copy
                                    </button>
                                </p>
                            </li>
                            <li>
                                <b>İl-Şehir</b>
                                <p>Istanbul</p>
                            </li>
                            <li>
                                <b>İlçe</b>
                                <p>Küçükçekmece</p>
                            </li>
                            <li>
                                <b>Vergi dairesi</b>
                                <p>Halkalı</p>
                            </li>
                        </ul>
                        <ul>
                            <li>
                                <b>Semt</b>
                                <p>Halkalı<");
            WriteLiteral(@"/p>
                            </li>
                            <li>
                                <b>ZIP/Post kodu</b>
                                <p>34303</p>
                            </li>
                            <li>
                                <b>Ülke</b>
                                <p>Türkiye</p>
                            </li>
                            <li>
                                <b>TC kimlik</b>
                                <p>35650276048</p>
                            </li>
                            <li>
                                <b>Cep telefon</b>
                                <p>05364700021</p>
                            </li>
                            <li>
                                <b>Vergi numarası</b>
                                <p>6081089593</p>
                            </li>
                        </ul>
                    </div>
                    <div id=""usa"" class=""tab-pane in"">
                   ");
            WriteLiteral("     <ul>\r\n                            <li>\r\n                                <b>Name</b>\r\n                                <p>AZ ");
#nullable restore
#line 121 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
                                 Write(customerId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 121 "C:\Users\HP\Desktop\project\back\Limak\Views\User\ForeignAddresses.cshtml"
                                             Write(fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </li>
                            <li>
                                <b>Address Line</b>
                                <p>28 W Ayre Street</p>
                            </li>
                            <li>
                                <b>Address Line2</b>
                                <p>Suite#AZ0072482</p>
                            </li>
                            <li>
                                <b>State</b>
                                <p>Delaware (DE)</p>
                            </li>
                        </ul>
                        <ul>
                            <li>
                                <b>City</b>
                                <p>Wilmington</p>
                            </li>
                            <li>
                                <b>ZIP/Postal code</b>
                                <p>19804</p>
                            </li>
                            <li>
                         ");
            WriteLiteral(@"       <b>Country</b>
                                <p>United States</p>
                            </li>
                            <li>
                                <b>Phone Number</b>
                                <p>800-4315119</p>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
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
