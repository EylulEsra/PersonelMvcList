#pragma checksum "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b17176407db90baa03715d0848ed05662fb7c8c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_RazorOrnek), @"mvc.1.0.view", @"/Views/Test/RazorOrnek.cshtml")]
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
#line 1 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17176407db90baa03715d0848ed05662fb7c8c0", @"/Views/Test/RazorOrnek.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_RazorOrnek : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
Write(DateTime.Now.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
  
    int x = 4;
    double d = 3.4;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>x =");
#nullable restore
#line 9 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
 Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>d<sup>2</sup> =");
#nullable restore
#line 10 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
              Write(d*d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p> ");
#nullable restore
#line 12 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
Write(x > 5 ? "X beşten büyüktür" : "x beşe eşit veya küçüktür");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
  
    for (int i = 0; i < 5; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p");
            BeginWriteAttribute("style", " style=\"", 279, "\"", 307, 3);
            WriteAttributeValue("", 287, "font-size:", 287, 10, true);
#nullable restore
#line 17 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
WriteAttributeValue("", 297, 9+i*2, 297, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 305, "px", 305, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Esra Acar</p>\r\n");
#nullable restore
#line 18 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
   
    for (int i = 0; i < 5; i++)
                {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("i\'nin değeri : ");
#nullable restore
#line 24 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    i\'nin değerini yazdırdık.\r\n    Başka değer yazdırmayacağız.\r\n    ");
            WriteLiteral("\r\n    <br />\r\n     ");
            WriteLiteral("i\'nin değeri : ");
#nullable restore
#line 29 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <hr /> \r\n");
#nullable restore
#line 31 "C:\Users\eylul\Desktop\repos\Mvc\WebApplication1\Views\Test\RazorOrnek.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Esra             Acar</p>\r\n\r\n<pre>\r\n            ocak    şubat   mart\r\nali           5        10       6\r\n\r\nayşe           8       12       7\r\n\r\nfatma          85        4         28\r\n</pre>");
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