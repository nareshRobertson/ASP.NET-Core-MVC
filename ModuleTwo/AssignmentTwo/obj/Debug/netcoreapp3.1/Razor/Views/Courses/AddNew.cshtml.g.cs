#pragma checksum "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3369ffa15eb6b5b289fd334cb2841b3ea6af8a1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_AddNew), @"mvc.1.0.view", @"/Views/Courses/AddNew.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\_ViewImports.cshtml"
using AssignmentTwo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\_ViewImports.cshtml"
using AssignmentTwo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3369ffa15eb6b5b289fd334cb2841b3ea6af8a1e", @"/Views/Courses/AddNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecad10167ff3f672f4915b95532897b676a5cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_AddNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
  
	ViewData["Title"] = "Add New";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add a New Course</h1>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
 using (Html.BeginForm()) {


#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"form-horizontal\">\r\n\t\t");
#nullable restore
#line 13 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 15 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
       Write(Html.LabelFor(model => model.Number, htmlAttributes: new {
		   @class = "control-label col-md-2"
	   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t");
#nullable restore
#line 19 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
           Write(Html.EditorFor(model => model.Number, new {
			   htmlAttributes = new {
				   @class = "form-control"
			   }
		   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 27 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new {
		   @class = "control-label col-md-2",
	   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t");
#nullable restore
#line 31 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
           Write(Html.EditorFor(model => model.Name, new {
			   htmlAttributes = new {
				   @class = "form-control"
			   }
		   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 39 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new {
		   @class = "control-label col-md-2"
	   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t");
#nullable restore
#line 43 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
           Write(Html.EditorFor(model => model.Description, new {
			   htmlAttributes = new {
				   @class = "form-control"
			   }
		   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t<div class=\"col-md-offset-2 col-md-10\">\r\n\t\t\t\t<input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 56 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\t");
#nullable restore
#line 58 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Courses\AddNew.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591