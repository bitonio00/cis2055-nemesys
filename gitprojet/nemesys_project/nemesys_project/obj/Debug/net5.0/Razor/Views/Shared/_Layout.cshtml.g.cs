#pragma checksum "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee943993fc65c9af6521ddd4a7144e80afeab548"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using nemesys_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using nemesys_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using nemesys_project.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee943993fc65c9af6521ddd4a7144e80afeab548", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac6ff2267586b5aaab823fb1fd417debad70e28", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/navbar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee943993fc65c9af6521ddd4a7144e80afeab5486248", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\" />\r\n    <title>");
#nullable restore
#line 7 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Nemesys</title>\r\n\r\n    <!--Bibli ?? prendre ou ?? enlever-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee943993fc65c9af6521ddd4a7144e80afeab5486972", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee943993fc65c9af6521ddd4a7144e80afeab5488150", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <!--Bootstrap CDN-->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee943993fc65c9af6521ddd4a7144e80afeab54810625", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-lg navbar-dark fixed-top bg-dark text-white p-3\">\r\n            <div class=\"container-fluid\">\r\n\r\n                ");
#nullable restore
#line 25 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Nemesys", "Index", "Home", new { area = "" }, new { @class = "navbar-brand text-white" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarCollapse"">

                    <ul class=""navbar-nav  me-auto mb-2  mb-md-0"">
                        <li class=""nav-item"">");
#nullable restore
#line 32 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                        Write(Html.ActionLink(" " + "Home", "Index", "Home", new { area = "" }, new { @class = "bi bi-house nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li class=\"nav-item\">");
#nullable restore
#line 33 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                        Write(Html.ActionLink(" " + "Hall Of Fame", "HallOfFame", "AllReport", new { area = "" }, new { @class = "bi bi-trophy nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li class=\"nav-item\">");
#nullable restore
#line 34 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                        Write(Html.ActionLink(" " + "Reports", "Reports", "AllReport", new { area = "" }, new { @class = "bi bi-flag nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li class=\"nav-item\">");
#nullable restore
#line 35 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                        Write(Html.ActionLink(" " + "Maps", "Maps", "AllReport", new { area = "" }, new { @class = "bi bi-map nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    </ul>\r\n\r\n                    <div class=\"text-end\">\r\n                        <ul class=\"nav me-auto mb-2 mb-md-0\">\r\n");
#nullable restore
#line 40 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                             if (signInManager.IsSignedIn(User))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\">");
#nullable restore
#line 42 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                                Write(Html.ActionLink(" " + "Settings" , "Parameters", "Account", new { area = "" }, new { @class = "bi bi-gear btn btn-outline-light me-2 " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li class=\"nav-item\">");
#nullable restore
#line 43 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                                Write(Html.ActionLink(" " + "LogOut " + User.Identity.Name, "LogOut", "Account", new { area = "" }, new { @class = "bi bi-power btn btn-outline-light me-2 " }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 44 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"

                            }
                            else
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\">");
#nullable restore
#line 49 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                                Write(Html.ActionLink(" Login", "Login", "Account", new { area = "" }, new { @class = "bi bi-box-arrow-in-right btn btn-outline-light me-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                <li class=\"nav-item\">");
#nullable restore
#line 50 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                                Write(Html.ActionLink(" Register", "Register", "Account", new { area = "" }, new { @class = "bi bi-person-plus-fill btn btn-warning" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                             if (signInManager.IsSignedIn(User) && User.IsInRole("reporter"))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\">");
#nullable restore
#line 55 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                                Write(Html.ActionLink(" " + "My Space", "ManageReports", "ReporterSpace", new { area = "" }, new { @class = "bi bi-person-circle btn btn-warning" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 56 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                            }
                            else if (signInManager.IsSignedIn(User) && User.IsInRole("investigator"))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\">");
#nullable restore
#line 59 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                                Write(Html.ActionLink(" " + "My Space", "ManageInvestigations", "InvestigatorSpace", new { area = "" }, new { @class = "bi bi-person-circle btn btn-warning" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 60 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                            }
                            else if (signInManager.IsSignedIn(User) && User.IsInRole("admin"))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"nav-item\">");
#nullable restore
#line 63 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                                Write(Html.ActionLink(" " + "My Space", "ManageUsers", "Admin", new { area = "" }, new { @class = "bi bi-person-circle btn btn-warning" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 64 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n\r\n    \r\n        <main role=\"main\">\r\n            ");
#nullable restore
#line 74 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </main>\r\n    \r\n\r\n    <footer class=\"container-fluid border-top footer\">\r\n        <p class=\"float-end\"><a href=\"#\">Back to top</a></p>\r\n        <p class=\"text-muted\">&copy; ");
#nullable restore
#line 81 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
                                Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" MignotValla Company - Nemesys &middot; <a href=\"#\">Privacy</a></p>\r\n    </footer>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee943993fc65c9af6521ddd4a7144e80afeab54820698", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee943993fc65c9af6521ddd4a7144e80afeab54821798", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee943993fc65c9af6521ddd4a7144e80afeab54822898", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 85 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 86 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<NemesysUser> signInManager { get; private set; }
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
