#pragma checksum "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5b724e78a63f88aae2f7c36c54cee59415e66fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b724e78a63f88aae2f7c36c54cee59415e66fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac6ff2267586b5aaab823fb1fd417debad70e28", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/carousel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\benoi\Documents\GIT_nem\gitprojet\nemesys_project\nemesys_project\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5b724e78a63f88aae2f7c36c54cee59415e66fe4837", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 216, "\"", 226, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <title>Home</title>

    <!-- Favicons -->
    <link rel=""apple-touch-icon"" href=""/docs/5.0/assets/img/favicons/apple-touch-icon.png"" sizes=""180x180"">
    <link rel=""icon"" href=""/docs/5.0/assets/img/favicons/favicon-32x32.png"" sizes=""32x32"" type=""image/png"">
    <link rel=""icon"" href=""/docs/5.0/assets/img/favicons/favicon-16x16.png"" sizes=""16x16"" type=""image/png"">
    <link rel=""manifest"" href=""/docs/5.0/assets/img/favicons/manifest.json"">
    <link rel=""mask-icon"" href=""/docs/5.0/assets/img/favicons/safari-pinned-tab.svg"" color=""#7952b3"">
    <link rel=""icon"" href=""/docs/5.0/assets/img/favicons/favicon.ico"">
    <meta name=""theme-color"" content=""#7952b3"">


    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }
    </style>

    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css"" r");
                WriteLiteral(@"el=""stylesheet"" integrity=""sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4"" crossorigin=""anonymous""></script>
    <!-- Custom styles for this template -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5b724e78a63f88aae2f7c36c54cee59415e66fe6898", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5b724e78a63f88aae2f7c36c54cee59415e66fe8780", async() => {
                WriteLiteral(@"
    <main>

        <div id=""myCarousel"" class=""carousel slide"" data-bs-ride=""carousel"">
            <div class=""carousel-indicators"">
                <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
                <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
                <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
            </div>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img src=""https://i.ibb.co/SXGnT8R/vitre-cass-e.jpg"" alt=""vitre-cass-e"" border=""0"">

                    <div class=""container"">
                        <div class=""carousel-caption text-start"">
                            <h1>Something run down ?</h1>
                            <p>Then it’s time to report it with NEMESYS !</p>
                 ");
                WriteLiteral(@"           <p><a class=""btn btn-lg btn-danger"" href=""#"">Sign up today</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img src=""https://i.ibb.co/3yTPtWP/image-carousel-3.jpg"" alt=""image-carousel-3"" border=""0"">

                    <div class=""container"">
                        <div class=""carousel-caption"">
                            <h1>An abnormal situation ?</h1>
                            <p>Yet it’s so simple with NEMESYS</p>
                            <p><a class=""btn btn-lg btn-danger"" href=""#"">Learn more</a></p>
                        </div>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img src=""https://i.ibb.co/pK5fxT4/paperasse.jpg"" alt=""paperasse"" border=""0"">
                    <div class=""container"">
                        <div class=""carousel-caption text-end"">
                            <h1>No need");
                WriteLiteral(@" to go to the administration !</h1>
                            <p>With NEMESYS everything is done by the application !</p>
                            <p><a class=""btn btn-lg btn-danger"" href=""#"">Log In</a></p>
                        </div>
                    </div>
                </div>
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>


        <!-- Marketing messaging and featurettes
        ================================================== -->
 ");
                WriteLiteral(@"       <!-- Wrap the rest of the page in another container to center all the content. -->
        
        <div class=""container marketing"">

            <!-- Three columns of text below the carousel -->
            <div class=""row"">
                <div class=""col-lg-4"">
                    <img class=""bd-placeholder-img rounded-circle"" src=""https://i.ibb.co/ZRrw99X/NEMESYS-2.jpg"" alt=""NEMESYS-2"" width=""140"" height=""140"" role=""img"" aria-label=""Placeholder: 140x140"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
                    <h2>NEMESYS</h2>
                    <p>Join the team</p>
                    <p><a class=""btn btn-secondary"" href=""#"">View details &raquo;</a></p>
                </div><!-- /.col-lg-4 -->
                <div class=""col-lg-4"">
                    <img class=""bd-placeholder-img rounded-circle"" src=""https://i.ibb.co/ZXkxKKc/Benoit-4.jpg"" alt=""Benoit-4"" border=""0"" width=""140"" height=""140"" role=""img"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
     ");
                WriteLiteral(@"               <h2>Benoît</h2>
                    <p>Web developer</p>
                    <p><a class=""btn btn-secondary"" href=""#"">View details &raquo;</a></p>
                </div><!-- /.col-lg-4 -->
                <div class=""col-lg-4"">
                    <img class=""bd-placeholder-img rounded-circle"" src=""https://i.ibb.co/3d4mC1D/Alex-1.jpg"" alt=""Alex-1"" border=""0"" width=""140"" height=""140"" role=""img"" aria-label=""Placeholder: 140x140"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
                    <h2>Alex</h2>
                    <p>Web designer</p>
                    <p><a class=""btn btn-secondary"" href=""#"">View details &raquo;</a></p>
                </div><!-- /.col-lg-4 -->
            </div><!-- /.row -->

            <!-- START THE FEATURETTES -->

            <hr class=""featurette-divider"">

            <div class=""row featurette"">
                <div class=""col-md-7"">
                    <h2 class=""featurette-heading"">1- Want to report a problem? <span class=""te");
                WriteLiteral(@"xt-muted"">It's simple !</span></h2>
                    <p class=""lead"">Log in and create a report describing the type of problem, the place, the date and even a photo if you want.</p>
                </div>
                <div class=""col-md-5"">
                    <img class=""bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto"" width=""500"" height=""500"" src=""https://i.ibb.co/h8hLNh5/image-carousel-4.jpg"" alt=""image-carousel-4""  role=""img"" aria-label=""Placeholder: 500x500"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
                </div>
            </div>

            <hr class=""featurette-divider"">

            <div class=""row featurette"">
                <div class=""col-md-7 order-md-2"">
                    <h2 class=""featurette-heading"">2- An investigator is there to take care of your report. <span class=""text-muted"">  In less than 24 hours!</span></h2>
                    <p class=""lead"">Following his investigation, he will plan an intervention by a techn");
                WriteLiteral(@"ician or a cleaning agent.</p>
                </div>
                <div class=""col-md-5 order-md-1"">
                    <img class=""bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto"" width=""500"" height=""500"" src=""https://i.ibb.co/CmHQnsv/image-carousel-5.webp"" alt=""image-carousel-5"" role=""img"" aria-label=""Placeholder: 500x500"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
                </div>
            </div>

            <hr class=""featurette-divider"">

            <div class=""row featurette"">
                <div class=""col-md-7"">
                    <h2 class=""featurette-heading"">3- The time to solve your problem has finally arrived ! <span class=""text-muted"">An agent will take care of it.</span></h2>
                    <p class=""lead"">The investigator will keep you informed by putting a status of the report.</p>
                </div>
                <div class=""col-md-5"">
                    <img class=""bd-placeholder-img bd-placeholder-img-lg f");
                WriteLiteral(@"eaturette-image img-fluid mx-auto"" width=""500"" height=""500"" src=""https://i.ibb.co/K61Xy0T/Image-carousel-6.jpg"" alt=""Image-carousel-6"" role=""img"" aria-label=""Placeholder: 500x500"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" >
                </div>
            </div>

            <hr class=""featurette-divider"">

            <!-- /END THE FEATURETTES -->

        </div><!-- /.container -->


    </main>

    <script src=""/docs/5.0/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4"" crossorigin=""anonymous""></script>

");
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
