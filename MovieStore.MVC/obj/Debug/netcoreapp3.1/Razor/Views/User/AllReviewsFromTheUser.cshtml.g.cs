#pragma checksum "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\User\AllReviewsFromTheUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90cdcdd9dd21a9238e195f4ef9e9f3680fe7a5e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AllReviewsFromTheUser), @"mvc.1.0.view", @"/Views/User/AllReviewsFromTheUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90cdcdd9dd21a9238e195f4ef9e9f3680fe7a5e9", @"/Views/User/AllReviewsFromTheUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa387f5e615eecbf69936df9de009cac81cba1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AllReviewsFromTheUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieStore.Core.Entities.Review>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h3>Reviews you made</h3>\r\n</div>\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 7 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\User\AllReviewsFromTheUser.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"list-group-item\">\r\n            <p>Movie: ");
#nullable restore
#line 10 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\User\AllReviewsFromTheUser.cshtml"
                 Write(item.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Review text: ");
#nullable restore
#line 11 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\User\AllReviewsFromTheUser.cshtml"
                       Write(item.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <small>Rating: ");
#nullable restore
#line 12 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\User\AllReviewsFromTheUser.cshtml"
                      Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\Marti\OneDrive\Documents\Antra Training\Code\projects\Solution1\MovieStore.MVC\Views\User\AllReviewsFromTheUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieStore.Core.Entities.Review>> Html { get; private set; }
    }
}
#pragma warning restore 1591