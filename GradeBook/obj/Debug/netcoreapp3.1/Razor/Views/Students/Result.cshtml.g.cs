#pragma checksum "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6dbc8ccd1af487277929c48602d8531c5f9c083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Result), @"mvc.1.0.view", @"/Views/Students/Result.cshtml")]
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
#line 1 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
using iitu.web.example.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
using Microsoft.AspNetCore.Server.Kestrel.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6dbc8ccd1af487277929c48602d8531c5f9c083", @"/Views/Students/Result.cshtml")]
    public class Views_Students_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
  
    ViewData["Title"] = "Student Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"title is-1\">");
#nullable restore
#line 8 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
                  Write(ViewData["action"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h2 class=\"subtitle is-2\">");
#nullable restore
#line 9 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
                     Write(ViewData["firstNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
                                              Write(ViewData["mark"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
                                                                Write(ViewData["secondNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 9 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
                                                                                            Write(ViewData["result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 10 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
  
    var student = ViewData["student"] as Student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
 if (student != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 15 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
   Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h3>");
#nullable restore
#line 16 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
   Write(student.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>");
#nullable restore
#line 17 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
   Write(student.GroupNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>");
#nullable restore
#line 18 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
   Write(student.GetCode());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 19 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>NOT FOUND</h2>\n");
#nullable restore
#line 23 "/home/zfazylz/RiderProjects/GradeBook/GradeBook/Views/Students/Result.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
