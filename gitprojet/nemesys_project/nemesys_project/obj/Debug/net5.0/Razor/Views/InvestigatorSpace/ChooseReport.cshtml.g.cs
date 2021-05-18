#pragma checksum "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be7fa934251fa2f428ad83e0e541f82fc2b62bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvestigatorSpace_ChooseReport), @"mvc.1.0.view", @"/Views/InvestigatorSpace/ChooseReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be7fa934251fa2f428ad83e0e541f82fc2b62bf", @"/Views/InvestigatorSpace/ChooseReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac6ff2267586b5aaab823fb1fd417debad70e28", @"/Views/_ViewImports.cshtml")]
    public class Views_InvestigatorSpace_ChooseReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Report>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateInvestigation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InvestigatorSpace", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
  
    ViewData["Title"] = "ManageReports";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ManageReports</h1>\r\n");
#nullable restore
#line 9 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
 if (Model.Any())
{

    foreach (var report in Model)
    {
        if(@report.Reporter!=null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-3\">\r\n    <div class=\"card-header\">\r\n        Report Date ");
#nullable restore
#line 18 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
               Write(report.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body\">\r\n        Hazard Location : ");
#nullable restore
#line 21 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                     Write(report.HazardLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Hazard Type : ");
#nullable restore
#line 22 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                 Write(report.HazardType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Date of the Hazard : ");
#nullable restore
#line 23 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                        Write(report.HazardDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Description : ");
#nullable restore
#line 24 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                 Write(report.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Status : ");
#nullable restore
#line 25 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
            Write(report.Status.StatusOfReport);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Reporter Mail : ");
#nullable restore
#line 26 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                   Write(report.Reporter.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Reporter Mobile : ");
#nullable restore
#line 27 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                     Write(report.Reporter.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be7fa934251fa2f428ad83e0e541f82fc2b62bf8275", async() => {
                WriteLiteral("\r\n            Create Investigation\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                                                                                 WriteLiteral(report.ReportId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 36 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
                    }
        
    }

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            You have no reports yet\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 48 "C:\Users\alex_\Documents\GitHub\cis2055-nemesys\gitprojet\nemesys_project\nemesys_project\Views\InvestigatorSpace\ChooseReport.cshtml"
       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Report>> Html { get; private set; }
    }
}
#pragma warning restore 1591
