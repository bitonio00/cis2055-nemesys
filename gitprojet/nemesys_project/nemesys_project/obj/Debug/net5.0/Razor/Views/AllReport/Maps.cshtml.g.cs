#pragma checksum "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "975cb313674f36dacaa2cac2f343db938de8d2d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllReport_Maps), @"mvc.1.0.view", @"/Views/AllReport/Maps.cshtml")]
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
#line 1 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using nemesys_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using nemesys_project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using nemesys_project.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975cb313674f36dacaa2cac2f343db938de8d2d3", @"/Views/AllReport/Maps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac6ff2267586b5aaab823fb1fd417debad70e28", @"/Views/_ViewImports.cshtml")]
    public class Views_AllReport_Maps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Report>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"

    ViewData["Title"] = "Maps";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
 if (Model.Any())
{
    int i = -1;
    string lat = "lat";
    string lng = "lng";
    string hazardDate = "HazardDate";
    string reporterEmail = "reporterEmail";
    string status = "status";
    string HazardLocation = "HazardLocation";
    string Description = "Description";
    string HazardType = "HazardType";

    foreach (var report in Model)
    {
        i++;
        var iString = i.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d34819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 23 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.LatitudeLocation);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 651, lat, 651, 4, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 655, iString, 655, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d37271", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 26 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.LongitudeLocation);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 796, lng, 796, 4, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 800, iString, 800, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d39724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.HazardDate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 934, hazardDate, 934, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 945, iString, 945, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d312178", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 32 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.Reporter.Email);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1083, reporterEmail, 1083, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1097, iString, 1097, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d314644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 35 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.Status.StatusOfReport);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1242, status, 1242, 7, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1249, iString, 1249, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d317109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.HazardLocation);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1387, HazardLocation, 1387, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1402, iString, 1402, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d319576", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 41 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.Description);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1537, Description, 1537, 12, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1549, iString, 1549, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975cb313674f36dacaa2cac2f343db938de8d2d322037", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => report.HazardType);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1683, HazardType, 1683, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
AddHtmlAttributeValue("", 1694, iString, 1694, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\AllReport\Maps.cshtml"
    }

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #map {
        height: 800px;
        width: 1400px;
    }
</style>
<br />
<div class=""row"">
    <div id=""map""> </div>
    <script>
        var map;
        function initMap() {
            var options = {
                center: { lat: 46, lng: 2 },
                zoom: 8
            }
            var map = new google.maps.Map(document.getElementById('map'), options);
            for (var i = 0; i < 100; i++) {
                var iString = i.toString();
                var Lat = parseFloat(document.getElementById(""lat"" + iString).value.replace("","", "".""));
                var Lng = parseFloat(document.getElementById(""lng"" + iString).value.replace("","", "".""));
                var Status = document.getElementById(""status"" + iString).value;
                var Email = document.getElementById(""reporterEmail"" + iString).value;
                var HazardDate = document.getElementById(""HazardDate"" + iString).value;
                var HazardLocation = document.getElementById(""Haz");
            WriteLiteral(@"ardLocation"" + iString).value;
                var Description = document.getElementById(""Description"" + iString).value;
                var HazardType = document.getElementById(""HazardType"" + iString).value;
                var contentS = ""Hazard Location:"" + HazardLocation + ""\r\n"" + ""Hazard Date:"" + HazardDate + ""\r\n"" + ""Hazard Type:"" + HazardType + ""\r\n"" + ""Status of Report:"" + Status + ""\r\n"" + ""Reporter Email:"" + Email + ""\r\n"" + ""Report Description:"" + Description;
                addMarker(Lat, Lng, contentS);
            }

            function addMarker(Lat, Lng, contentS) {
                var marker = new google.maps.Marker({
                    position: { lat: Lat, lng: Lng },
                    map: map,
                    //icon:props.iconImage
                });


                var infoWindow = new google.maps.InfoWindow({
                    content: `<form> \
                           <h4>${contentS}</h4> \
                          </form>`
                });
");
            WriteLiteral(@"
                marker.addListener('click', function () {
                    infoWindow.open(map, marker);
                });

            }
        }
    </script>
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAwIWe9dzbs3yOMx89_XQ8BCb-rAUFjXx4&callback=initMap"" async defer></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Report>> Html { get; private set; }
    }
}
#pragma warning restore 1591
