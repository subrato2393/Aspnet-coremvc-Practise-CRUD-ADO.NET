#pragma checksum "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf9935c36ac32d8da7ea52ea10e8355e31f5b02e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Add), @"mvc.1.0.view", @"/Views/Student/Add.cshtml")]
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
#line 1 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\_ViewImports.cshtml"
using COREMVCCrudAppADO.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\_ViewImports.cshtml"
using COREMVCCrudAppADO.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9935c36ac32d8da7ea52ea10e8355e31f5b02e", @"/Views/Student/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daf915709ad433912e8705b3b20665dbbf301e9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COREMVCCrudAppADO.NET.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
 using (Html.BeginForm("Add", "Student", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 5 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
   Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 7 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Name, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
   Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 13 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Email, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 17 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
   Write(Html.LabelFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 19 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Address, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 23 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
   Write(Html.Label("Department Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div>\r\n            ");
#nullable restore
#line 25 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
       Write(Html.DropDownListFor(x => x.DepartmentId, new SelectList(ViewBag.Departments, "Id", "Name"), "---Select----", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Save\" class=\"btn btn-success\"/>\r\n    </div>\r\n");
#nullable restore
#line 31 "F:\Dev Skill Full Stack ASP.NET Core MVC Trainning\Aspnet-coremvc-Practise-CRUD-ADO.NET\Web Practise\COREMVCCrudAppADO.NET\Views\Student\Add.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COREMVCCrudAppADO.NET.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
