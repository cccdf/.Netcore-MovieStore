#pragma checksum "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48b51c833c5aa35b4170b40184c0c23ee749277"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48b51c833c5aa35b4170b40184c0c23ee749277", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa387f5e615eecbf69936df9de009cac81cba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieStore.Core.Models.Response.MovieDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/user/deletefavorite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/user/addfavorite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/Purchase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<style>\r\n    #overview p{\r\n        color:white;\r\n    }\r\n</style>\r\n\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\" style=\"background-color:black\" id=\"overview\">\r\n            <div class=\"col-2 pl-lg-0 offset-lg-2\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 353, "\"", 381, 1);
#nullable restore
#line 14 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 359, Model.Movie.PosterUrl, 359, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 400, "\"", 424, 1);
#nullable restore
#line 14 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 406, Model.Movie.Title, 406, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n            </div>\r\n            <div class=\"col-5 offset-lg-1 px-xl-5\"");
            BeginWriteAttribute("style", " style=\"", 502, "\"", 661, 6);
            WriteAttributeValue("\r\n                ", 510, "background-image:", 528, 35, true);
            WriteAttributeValue(" ", 545, "url(", 546, 5, true);
#nullable restore
#line 18 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 550, Model.Movie.BackdropUrl, 550, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 574, ");", 574, 2, true);
            WriteAttributeValue("\r\n                ", 576, "background-repeat:no-repeat;", 594, 46, true);
            WriteAttributeValue("\r\n                ", 622, "background-size:cover", 640, 39, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"row\">\r\n                    <h1 class=\"text-white\">");
#nullable restore
#line 22 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                      Write(Model.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                </div>\r\n                <div class=\"row\">\r\n                    <p>");
#nullable restore
#line 26 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                  Write(Model.Movie.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col pl-lg-0\">\r\n                        <span>");
#nullable restore
#line 30 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                         Write(Model.Movie.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m | ");
#nullable restore
#line 30 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                  Write(Model.Movie.ReleaseDate.Value.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <p>\r\n");
#nullable restore
#line 34 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                             foreach (var item in Model.Movie.MovieGenres)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-pill badge-secondary\">");
#nullable restore
#line 36 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                      Write(item.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 37 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\r\n\r\n                    </div> \r\n                </div>\r\n                <div class=\"row\">\r\n                    <span class=\"badge badge-warning\">");
#nullable restore
#line 43 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                 Write(Model.Movie.Rating.Value.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <p class=\"small\">");
#nullable restore
#line 46 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                Write(Model.Movie.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-2 pt-lg-3\">\r\n");
#nullable restore
#line 50 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                 if (Model.CheckFavorite)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48b51c833c5aa35b4170b40184c0c23ee74927710771", async() => {
                WriteLiteral("\r\n\r\n                        <div class=\"row pb-xl-2\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2094, "\"", 2117, 1);
#nullable restore
#line 55 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2102, Model.Movie.Id, 2102, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"movieId\" />\r\n                            <button type=\"submit\" class=\"btn btn-dark btn-sm\" value=\"UnFavorate\"><i class=\"fas fa-heart\"></i></button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48b51c833c5aa35b4170b40184c0c23ee74927713343", async() => {
                WriteLiteral("\r\n                        <div class=\"row pb-xl-2\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2563, "\"", 2586, 1);
#nullable restore
#line 64 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2571, Model.Movie.Id, 2571, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"movieId\" />\r\n                            <button type=\"submit\" class=\"btn btn-dark btn-sm\"><i class=\"far fa-heart\"></i></button>\r\n\r\n\r\n\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"row pb-xl-2 pr-xl-4\">\r\n                    <a class=\"btn btn-dark btn-block\"");
            BeginWriteAttribute("href", " href=\"", 2916, "\"", 2951, 2);
            WriteAttributeValue("", 2923, "/User/Review/", 2923, 13, true);
#nullable restore
#line 74 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2936, Model.Movie.Id, 2936, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i>REVIEW</a>\r\n                </div>\r\n                <div class=\"row pb-xl-2 pr-xl-4\">\r\n\r\n                    <a class=\"btn btn-dark btn-block\" href=\"#\"><i class=\"fa fa-play\"></i>TRAILER</a>\r\n                </div>\r\n");
#nullable restore
#line 80 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                 if (Model.CheckBought)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row pb-xl-2 pr-xl-4\">\r\n                        <a class=\"btn btn-dark btn-block\" href=\"#\"><i class=\"fa fa-play\"></i>WATCH</a>\r\n                    </div>\r\n");
#nullable restore
#line 85 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b48b51c833c5aa35b4170b40184c0c23ee74927717489", async() => {
                WriteLiteral("\r\n                <div class=\"row pb-xl-2 pr-xl-4\">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3652, "\"", 3675, 1);
#nullable restore
#line 91 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 3660, Model.Movie.Id, 3660, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"movieId\" />\r\n\r\n                    <button class=\"btn btn-dark btn-block\" type=\"submit\">BUY ");
#nullable restore
#line 93 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                        Write(Model.Movie.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n\r\n");
                WriteLiteral("                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

                </div>
        <div class=""row pt-xl-3"">
            <div class=""col-4"" style=""background-color: #F8F9FA;"">
                <div class=""row border-bottom px-xl-2"">
                    <h5>MOVIE FACTS</h5>
                </div>
                <div class=""row border-bottom border-top px-xl-3"">
                    <p class=""my-lg-1"">
                        <i class=""fa fa-calendar""></i>
                        Release Date
                        <span class=""badge badge-pill badge-secondary""> ");
#nullable restore
#line 112 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                   Write(Model.Movie.ReleaseDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                    </p>
                </div>                
                <div class=""row border-bottom border-top px-xl-3"">
                    <p  class=""my-lg-1"">
                        <i class=""fa fa-hourglass""></i>
                        Run Time
                        <span class=""badge badge-pill badge-secondary"">  ");
#nullable restore
#line 120 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                    Write(Model.Movie.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" m</span>
                    </p>
                </div>                
                <div class=""row border-bottom border-top px-xl-3"">
                    <p  class=""my-lg-1"">
                        <i class=""fa fa-money-bill""></i>
                        Box Office
                        <span class=""badge badge-pill badge-secondary""> $");
#nullable restore
#line 127 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                    Write(Model.Movie.Revenue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </p>
                </div>                
                <div class=""row border-bottom border-top px-xl-3"">
                    <p  class=""my-lg-1"">
                        <i class=""fa fa-dollar-sign""></i>
                        Budget
                        <span class=""badge badge-pill badge-secondary""> $");
#nullable restore
#line 134 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                    Write(Model.Movie.Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </p>\r\n                </div>                \r\n                <div class=\"row border-top px-xl-3\">\r\n                    <p class=\"my-lg-1\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5880, "\"", 5907, 1);
#nullable restore
#line 139 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 5887, Model.Movie.ImdbUrl, 5887, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fab fa-imdb""></i>
                        </a>
                        
                        <i class=""fa fa-share-square""></i>
                    </p>
                   
                </div>                
            </div>
            <div class=""col-6"" style=""padding-left:150px;"">
                <div class=""row"">
                    <h5>CAST</h5>
                </div>
");
#nullable restore
#line 152 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                 foreach (var cast in Model.Movie.MovieCasts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row border-bottom border-top\">\r\n                        <div class=\"col-4\">\r\n                            <img class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 6602, "\"", 6630, 1);
#nullable restore
#line 156 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 6608, cast.Cast.ProfilePath, 6608, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6631, "\"", 6652, 1);
#nullable restore
#line 156 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 6637, cast.Cast.Name, 6637, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:60px;\"/>\r\n                        </div>                       \r\n                        <div class=\"col-4\">\r\n                            <p>");
#nullable restore
#line 159 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                          Write(cast.Cast.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            \r\n                        </div>                       \r\n                        <div class=\"col-4\">\r\n                            <p>");
#nullable restore
#line 163 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                          Write(cast.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 166 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\Movies\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
            WriteLiteral("               \r\n           \r\n\r\n");
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieStore.Core.Models.Response.MovieDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
