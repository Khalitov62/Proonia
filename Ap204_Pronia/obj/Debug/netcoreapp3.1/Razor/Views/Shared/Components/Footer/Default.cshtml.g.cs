#pragma checksum "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d634a9221d8dc3fa0cebdabda6bb8e5c69ccddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\_ViewImports.cshtml"
using Ap204_Pronia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\_ViewImports.cshtml"
using Ap204_Pronia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\_ViewImports.cshtml"
using Ap204_Pronia.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\_ViewImports.cshtml"
using Ap204_Pronia.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d634a9221d8dc3fa0cebdabda6bb8e5c69ccddc", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f805a5b4d1460fc05f23883ef49b62520ba839b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Seetting>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/website-images/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Payment Method"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
  <div class=""footer-top section-space-top-100 pb-60"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-3"">
                            <div class=""footer-widget-item"">
                                <div class=""footer-widget-logo"">
                                    <a href=""index.html"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d634a9221d8dc3fa0cebdabda6bb8e5c69ccddc5118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 446, "~/assets/images/logo/", 446, 21, true);
#nullable restore
#line 10 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 467, Model.FirstOrDefault(s=>s.Key=="FooterLogo")?.Value, 467, 52, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </div>
                                <p class=""footer-widget-desc"">
                                    Lorem ipsum dolor sit amet, consec adipisl elit, sed do
                                    eiusmod tempor
                                    <br />
                                    incidio ut labore et dolore magna.
                                </p>
                                <div class=""social-link with-border"">
                                    <ul>
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 1186, "\"", 1245, 1);
#nullable restore
#line 22 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1193, Model.FirstOrDefault(s=>s.Key=="Facebook")?.IconUrl, 1193, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                               data-tippy=""Facebook""
                                               data-tippy-inertia=""true""
                                               data-tippy-animation=""shift-away""
                                               data-tippy-delay=""50""
                                               data-tippy-arrow=""true""
                                               data-tippy-theme=""sharpborder"">
                                                <i");
            BeginWriteAttribute("class", " class=\"", 1746, "\"", 1804, 1);
#nullable restore
#line 29 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1754, Model.FirstOrDefault(s=>s.Key=="Facebook")?.Value, 1754, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2001, "\"", 2059, 1);
#nullable restore
#line 33 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2008, Model.FirstOrDefault(s=>s.Key=="Twitter")?.IconUrl, 2008, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                               data-tippy=""Twitter""
                                               data-tippy-inertia=""true""
                                               data-tippy-animation=""shift-away""
                                               data-tippy-delay=""50""
                                               data-tippy-arrow=""true""
                                               data-tippy-theme=""sharpborder"">
                                                <i");
            BeginWriteAttribute("class", " class=\"", 2559, "\"", 2616, 1);
#nullable restore
#line 40 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2567, Model.FirstOrDefault(s=>s.Key=="Twitter")?.Value, 2567, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2813, "\"", 2873, 1);
#nullable restore
#line 44 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2820, Model.FirstOrDefault(s=>s.Key=="Pinterest")?.IconUrl, 2820, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                               data-tippy=""Pinterest""
                                               data-tippy-inertia=""true""
                                               data-tippy-animation=""shift-away""
                                               data-tippy-delay=""50""
                                               data-tippy-arrow=""true""
                                               data-tippy-theme=""sharpborder"">
                                                <i");
            BeginWriteAttribute("class", " class=\"", 3375, "\"", 3434, 1);
#nullable restore
#line 51 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3383, Model.FirstOrDefault(s=>s.Key=="Pinterest")?.Value, 3383, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                            </a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3631, "\"", 3690, 1);
#nullable restore
#line 55 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 3638, Model.FirstOrDefault(s=>s.Key=="Dribbble")?.IconUrl, 3638, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                               data-tippy=""Dribbble""
                                               data-tippy-inertia=""true""
                                               data-tippy-animation=""shift-away""
                                               data-tippy-delay=""50""
                                               data-tippy-arrow=""true""
                                               data-tippy-theme=""sharpborder"">
                                                <i");
            BeginWriteAttribute("class", " class=\"", 4191, "\"", 4249, 1);
#nullable restore
#line 62 "C:\Users\user\OneDrive\Masaüstü\Pronia\Ap204_Pronia\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 4199, Model.FirstOrDefault(s=>s.Key=="Dribbble")?.Value, 4199, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-2 col-md-4 pt-40"">
                            <div class=""footer-widget-item"">
                                <h3 class=""footer-widget-title"">Useful Links</h3>
                                <ul class=""footer-widget-list-item"">
                                    <li>
                                        <a href=""#"">About Pronia</a>
                                    </li>
                                    <li>
                                        <a href=""#"">How to shop</a>
                                    </li>
                                    <li>
                                        <a href=""#"">FAQ</a>
                                    </li>
                                    ");
            WriteLiteral(@"<li>
                                        <a href=""#"">Contact us</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Log in</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-2 col-md-4 pt-40"">
                            <div class=""footer-widget-item"">
                                <h3 class=""footer-widget-title"">My Account</h3>
                                <ul class=""footer-widget-list-item"">
                                    <li>
                                        <a href=""#"">Sign In</a>
                                    </li>
                                    <li>
                                        <a href=""#"">View Cart</a>
                                    </li>
                                    <li>
                               ");
            WriteLiteral(@"         <a href=""#"">My Wishlist</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Track My Order</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Help</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-2 col-md-4 pt-40"">
                            <div class=""footer-widget-item"">
                                <h3 class=""footer-widget-title"">Our Service</h3>
                                <ul class=""footer-widget-list-item"">
                                    <li>
                                        <a href=""#"">Payment Methods</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Mon");
            WriteLiteral(@"ey Guarantee!</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Returns</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Shipping</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Privacy Policy</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-lg-3 pt-40"">
                            <div class=""footer-contact-info"">
                                <h3 class=""footer-widget-title"">Got Question? Call Us</h3>
                                <a class=""number"" href=""tel://123-456-789"">123 456 789</a>
                                <div class=""address"">
                                    <ul>");
            WriteLiteral(@"
                                        <li>Your Address Goes Here</li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""payment-method"">
                                <a href=""#"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d634a9221d8dc3fa0cebdabda6bb8e5c69ccddc18061", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Ap204_Pronia.Services.LayoutService layoutService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Seetting>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
