#pragma checksum "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2d6455629fd6db27d8259393b6943ce19d516f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Index), @"mvc.1.0.view", @"/Views/Hello/Index.cshtml")]
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
#line 1 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml"
using iitu.web.example.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d6455629fd6db27d8259393b6943ce19d516f7", @"/Views/Hello/Index.cshtml")]
    public class Views_Hello_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h1 class=\"title is-1\">Hello from view with style</h1>\n<ul class=\"list\">\n");
#nullable restore
#line 6 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml"
     foreach (var std in (IList<Student>) ViewData["students"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-item\">\n            <h2>Name: ");
#nullable restore
#line 9 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml"
                 Write(std.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n            <h3>DOB: ");
#nullable restore
#line 10 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml"
                Write(std.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <h3>Group number: ");
#nullable restore
#line 11 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml"
                         Write(std.GroupNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            ");
#nullable restore
#line 12 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml"
       Write(Html.ActionLink("Code: " + @std.GetCode(), "GetStudent", "Students", new {code = "@std.GetCode()"}, new {@class = "link"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </li>\n");
#nullable restore
#line 14 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Hello/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
