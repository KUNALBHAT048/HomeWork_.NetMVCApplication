#pragma checksum "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\Lockout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e640d998f235c47ce4be85d674441b8813c3ce840b2b0d83ee660cfac6d6534c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Lockout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Lockout.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_Lockout), null)]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

    ;
#line 2 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\_ViewImports.cshtml"
using Homework.Areas.Identity

    ;
#line 3 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\_ViewImports.cshtml"
using Homework.Areas.Identity.Pages

    ;
#line 1 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Homework.Areas.Identity.Pages.Account

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e640d998f235c47ce4be85d674441b8813c3ce840b2b0d83ee660cfac6d6534c", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"86e252d44ace7c1dc40836fa50eaff6b60c2d9868de5142c2cdf07c170285a2b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d9226a6e00703e69d0274369389b9acd2a5321bd627a7165a93985137d518e71", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Lockout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden

            BeginContext(74, 40, true);
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(115, 17, false);
            Write(
#line 8 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\Lockout.cshtml"
                             ViewData["Title"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(132, 108, true);
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\r\n</header>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LockoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel>)PageContext?.ViewData;
        public LockoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
