#pragma checksum "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6fcbaede3d30f351a3270580199c44e6de9bc3c3646102dd57df706704bbf01f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6fcbaede3d30f351a3270580199c44e6de9bc3c3646102dd57df706704bbf01f", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"86e252d44ace7c1dc40836fa50eaff6b60c2d9868de5142c2cdf07c170285a2b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d9226a6e00703e69d0274369389b9acd2a5321bd627a7165a93985137d518e71", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden

            BeginContext(98, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(105, 17, false);
            Write(
#line 7 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
     ViewData["Title"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(122, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 8 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden

            BeginContext(183, 29, true);
            WriteLiteral("<p>\r\n    <a id=\"confirm-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 212, "\"", 246, 1);
            WriteAttributeValue("", 219, 
#line 12 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                                Model.EmailConfirmationUrl

#line default
#line hidden
            , 219, 27, false);
            EndWriteAttribute();
            BeginContext(247, 47, true);
            WriteLiteral(">Click here to confirm your account</a>\r\n</p>\r\n");
            EndContext();
#line 14 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden

            BeginContext(318, 69, true);
            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
            EndContext();
#line 20 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
