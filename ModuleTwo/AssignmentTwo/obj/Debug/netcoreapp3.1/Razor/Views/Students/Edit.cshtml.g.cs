#pragma checksum "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c363f3851a397b95676ff750adbe4116fe33e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
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
#line 1 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c363f3851a397b95676ff750adbe4116fe33e1a", @"/Views/Students/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecad10167ff3f672f4915b95532897b676a5cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
  
	ViewData["Title"] = "Edit Student";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Student</h1>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
 using (Html.BeginForm()) {
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"form-horizontal\">\r\n\t\t");
#nullable restore
#line 13 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 15 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
       Write(Html.LabelFor(model => model.Item.FirstName, htmlAttributes: new {
		   @class = "control-label col-md-2"
	   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t");
#nullable restore
#line 19 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(model => model.Item.FirstName, new {
			   htmlAttributes = new {
				   @class = "form-control"
			   }
		   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 27 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
       Write(Html.LabelFor(model => model.Item.LastName, htmlAttributes: new {
		   @class = "control-label col-md-2"
	   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t");
#nullable restore
#line 31 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(model => model.Item.LastName, new {
			   htmlAttributes = new {
				   @class = "form-control"
			   }
		   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 39 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
       Write(Html.LabelFor(model => model.Item.Email, htmlAttributes: new {
		   @class = "control-label col-md-2"
	   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t");
#nullable restore
#line 43 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(model => model.Item.Email, new {
			   htmlAttributes = new {
				   @class = "form-control"
			   }
		   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"form-group\">\r\n\t\t\t");
#nullable restore
#line 51 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
       Write(Html.LabelFor(model => model.Item.Phone, htmlAttributes: new {
		   @class = "control-label col-md-2"
	   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-md-10\">\r\n\t\t\t\t");
#nullable restore
#line 55 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(model => model.Item.Phone, new {
			   htmlAttributes = new {
				   @class = "form-control"
			   }
		   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<div class=\"form-group\">\r\n\t\t\t<div class=\"col-md-offset-2 col-md-10\">\r\n\t\t\t\t<input type=\"submit\" value=\"Save\" class=\"btn btn-outline-primary\" />\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 69 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h4>Registered in:</h4>\r\n<table class=\"table table-bordered\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>Course Number/Name</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n\t\t");
#nullable restore
#line 81 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
   Write(Html.Hidden("item-to-drop", "", new {
			id = "item-to-drop"
		}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
         foreach (var sc in Model.CurrentCourses) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
#nullable restore
#line 86 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
               Write(sc.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 88 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
               Write(Html.ActionLink("Drop Course", "", new {
						id = sc.Id
					},
					new {
						@class = "drop",
						data_toggle = "modal",
						data_target = "#dropModal",
						data_id = sc.Id,
						data_name = sc.CourseName
					}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 100 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n<div>\r\n\t");
#nullable restore
#line 105 "C:\Online FSD Course\March 23rd Batch\ASP.Net Core MVC\Assignment2\April\ModuleTwo\AssignmentTwo\Views\Students\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<!--Drop Course Modal -->
<div class=""modal fade"" id=""dropModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""dropModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog"" role=""document"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h5 class=""modal-title"" id=""dropModalLabel"">Drop Course</h5>
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
			</div>
			<div class=""modal-body"">
			</div>
			<div class=""modal-footer"">
				<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
				<button type=""button"" class=""btn btn-primary"" id=""confirm-drop"" data-dismiss=""modal"" data-controller=""Students"">Drop Course</button>
			</div>
		</div>
	</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
