#pragma checksum "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81870d75f3916a79276eb04667210d41888d2fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TeacherIndex), @"mvc.1.0.view", @"/Views/Home/TeacherIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TeacherIndex.cshtml", typeof(AspNetCore.Views_Home_TeacherIndex))]
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
#line 1 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\_ViewImports.cshtml"
using VarsityManagement;

#line default
#line hidden
#line 2 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\_ViewImports.cshtml"
using VarsityManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81870d75f3916a79276eb04667210d41888d2fb5", @"/Views/Home/TeacherIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5efe6ba50d38a1db11a83953a8dd580aa724f80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TeacherIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VarsityManagement.ViewModels.TeacherInfoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeacherCreateWithCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(111, 37, true);
            WriteLiteral("\r\n    <h1>All Teachers Details</h1>\r\n");
            EndContext();
            BeginContext(148, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81870d75f3916a79276eb04667210d41888d2fb54566", async() => {
                BeginContext(239, 13, true);
                WriteLiteral("Add  Teachers");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(256, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 10 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(326, 126, true);
            WriteLiteral("        <div class=\"card m-3\">\r\n            <div class=\"card-header\">\r\n                <span class=\"text-primary\">ID: </span> ");
            EndContext();
            BeginContext(453, 22, false);
#line 15 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
                                                  Write(item.Teacher.TeacherId);

#line default
#line hidden
            EndContext();
            BeginContext(475, 67, true);
            WriteLiteral("  <br />\r\n                <span class=\"text-primary\">Name: </span> ");
            EndContext();
            BeginContext(543, 24, false);
#line 16 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
                                                    Write(item.Teacher.TeacherName);

#line default
#line hidden
            EndContext();
            BeginContext(567, 122, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5>Taking Courses</h5>\r\n                <ul>\r\n");
            EndContext();
#line 21 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
                     foreach (var course in item.Teacher.TeacherCourses)
                    {

#line default
#line hidden
            BeginContext(786, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(815, 24, false);
#line 23 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
                       Write(course.Course.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(839, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
                    }

#line default
#line hidden
            BeginContext(869, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
            BeginContext(1077, 38, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 31 "D:\CSE\Repository\Final\Final-Test\VarsityManagement\Views\Home\TeacherIndex.cshtml"
    }

#line default
#line hidden
            BeginContext(1122, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VarsityManagement.ViewModels.TeacherInfoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
