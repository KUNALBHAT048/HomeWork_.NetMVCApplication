#pragma checksum "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c4f6b95778bd577facb8d54f96d91df2d1338e43bc1bfc74c39dca9bf3112713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classroom_ViewSubmissions), @"mvc.1.0.view", @"/Views/Classroom/ViewSubmissions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Classroom/ViewSubmissions.cshtml", typeof(AspNetCore.Views_Classroom_ViewSubmissions))]
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
#line 2 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\_ViewImports.cshtml"
using Homework.Models

    ;
#line 3 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
 using Homework

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c4f6b95778bd577facb8d54f96d91df2d1338e43bc1bfc74c39dca9bf3112713", @"/Views/Classroom/ViewSubmissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a8b5d9487b2f7ceacaf8e2a1d7b7708bff0a259289d566636c952d30722d58b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Classroom_ViewSubmissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Homework.Models.SubmittedAssignment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-loadPartial", "Assignments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(147, 70, true);
            WriteLiteral("\r\n<div class=\"col-sm-10\">\r\n    <h3 style=\"background-color: #5a9191;\">");
            EndContext();
            BeginContext(218, 27, false);
            Write(
#line 6 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                            ViewData["AssignmentTitle"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(245, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden

            BeginContext(291, 33, true);
            WriteLiteral("        <span class=\"text-muted\">");
            EndContext();
            BeginContext(325, 24, false);
            Write(
#line 10 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                  ViewData["EmptyMessage"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(349, 25, true);
            WriteLiteral("</span>\r\n        <br />\r\n");
            EndContext();
#line 12 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden

#line 13 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
     foreach (var item in Model)
    {
        AppUser user = await _userManager.FindByIdAsync(item.AppUserID);

#line default
#line hidden

            BeginContext(496, 53, true);
            WriteLiteral("        <div class=\"content-block\">\r\n            <h6>");
            EndContext();
            BeginContext(550, 4, false);
            Write(
#line 17 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                 user

#line default
#line hidden
            );
            EndContext();
            BeginContext(554, 39, true);
            WriteLiteral("</h6>\r\n            <hr />\r\n            ");
            EndContext();
            BeginContext(594, 51, false);
            Write(
#line 19 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
             CustomHelpers.DisplayWithLinksFor(item.Description)

#line default
#line hidden
            );
            EndContext();
            BeginContext(645, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
             if (item.Files != null)
            {
                string[] files = item.Files.Split(",");
                if (files.Count() > 1 || (files.Count() == 1 && files[0].Length != 0))
                {

#line default
#line hidden

            BeginContext(864, 28, true);
            WriteLiteral("                    <hr />\r\n");
            EndContext();
#line 26 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                }
                foreach (string file in files)
                {
                    if (file.Length == 0)
                    {
                        continue;
                    }
                    var filePath = "~/posted_assignments/" + file;
                    var filename = file.Substring(file.IndexOf("_") + 1, file.Length - file.IndexOf("_") - 1);
                    var fileUrl = "https://localhost:44300" + "/submitted_assignments/" + file;

#line default
#line hidden

            BeginContext(1379, 38, true);
            WriteLiteral("                    <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1417, "\"", 1432, 1);
            WriteAttributeValue("", 1424, 
#line 36 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                              fileUrl

#line default
#line hidden
            , 1424, 8, false);
            EndWriteAttribute();
            BeginContext(1433, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1461, 8, false);
            Write(
#line 37 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                         filename

#line default
#line hidden
            );
            EndContext();
            BeginContext(1469, 56, true);
            WriteLiteral("\r\n                    </a>\r\n                    <br />\r\n");
            EndContext();
#line 40 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                }
            }

#line default
#line hidden

            BeginContext(1559, 32, true);
            WriteLiteral("        </div>\r\n        <br />\r\n");
            EndContext();
#line 44 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden

#line 45 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
     if ((string)ViewData["Role"] == "Mentor")
    {

#line default
#line hidden

            BeginContext(1653, 87, true);
            WriteLiteral("        <br />\r\n        <div>\r\n            <h5>Students yet to submit this Assignment: ");
            EndContext();
            BeginContext(1741, 17, false);
            Write(
#line 49 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                                         ViewData["Count"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(1758, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 50 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
             foreach (ClassroomUser notSubmit in ViewBag.RemainingPeople)
            {

#line default
#line hidden

            BeginContext(1855, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(1875, 26, false);
            Write(
#line 52 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                    notSubmit.AppUser.UserName

#line default
#line hidden
            );
            EndContext();
            BeginContext(1901, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 53 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
            }

#line default
#line hidden

            BeginContext(1922, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 55 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
    }

#line default
#line hidden

            BeginContext(1945, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1949, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4f6b95778bd577facb8d54f96d91df2d1338e43bc1bfc74c39dca9bf311271311556", async() => {
                BeginContext(2038, 13, true);
                WriteLiteral("Back to Class");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 56 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                        ViewBag.ClassId

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-loadPartial", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["loadPartial"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2055, 146, true);
            WriteLiteral("\r\n</div>\r\n<style>\r\n    .content-block {\r\n        border: 1px solid #dddddd;\r\n        border-radius: 20px;\r\n        padding: 20px;\r\n    }\r\n</style>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public 
#line 2 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
        Microsoft.AspNetCore.Identity.UserManager<AppUser>

#line default
#line hidden
         
#line 2 "C:\Users\91849\tempfolder\HomeWork-dotNET_core_MVC\Homework\Views\Classroom\ViewSubmissions.cshtml"
                                                           _userManager

#line default
#line hidden
         { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Homework.Models.SubmittedAssignment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
