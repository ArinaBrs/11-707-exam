#pragma checksum "C:\Users\User\Documents\Exam\File\File\Views\AllFiles\AllFiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3b5857f688254b8ee9b843814801f376883698"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllFiles_AllFiles), @"mvc.1.0.view", @"/Views/AllFiles/AllFiles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AllFiles/AllFiles.cshtml", typeof(AspNetCore.Views_AllFiles_AllFiles))]
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
#line 1 "C:\Users\User\Documents\Exam\File\File\Views\_ViewImports.cshtml"
using File;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\Exam\File\File\Views\_ViewImports.cshtml"
using File.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3b5857f688254b8ee9b843814801f376883698", @"/Views/AllFiles/AllFiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3c56a973364d4cc3639ce09064dc1deae10a8b", @"/Views/_ViewImports.cshtml")]
    public class Views_AllFiles_AllFiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<File.Models.FileModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Documents\Exam\File\File\Views\AllFiles\AllFiles.cshtml"
  
    ViewData["Title"] = "Список файлов";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\User\Documents\Exam\File\File\Views\AllFiles\AllFiles.cshtml"
  
    foreach (var i in Model)
    {

#line default
#line hidden
            BeginContext(135, 181, true);
            WriteLiteral("        <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n\r\n            <div class=\"thumbnail\">\r\n                <div class=\"caption\">\r\n                    <h3>\r\n                        <a>");
            EndContext();
            BeginContext(317, 6, false);
#line 14 "C:\Users\User\Documents\Exam\File\File\Views\AllFiles\AllFiles.cshtml"
                      Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(323, 86, true);
            WriteLiteral("</a>\r\n                    </h3>\r\n                    <h3>\r\n                        <a>");
            EndContext();
            BeginContext(410, 18, false);
#line 17 "C:\Users\User\Documents\Exam\File\File\Views\AllFiles\AllFiles.cshtml"
                      Write(i.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(428, 93, true);
            WriteLiteral("</a>\r\n                    </h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\User\Documents\Exam\File\File\Views\AllFiles\AllFiles.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<File.Models.FileModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
