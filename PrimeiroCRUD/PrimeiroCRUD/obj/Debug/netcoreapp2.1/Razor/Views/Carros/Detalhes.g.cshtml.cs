#pragma checksum "D:\PROJETOS\ASP.NET CORE\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f10de8f1849e67b886b09c653d2de296c85d756a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_Detalhes), @"mvc.1.0.view", @"/Views/Carros/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carros/Detalhes.cshtml", typeof(AspNetCore.Views_Carros_Detalhes))]
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
#line 1 "D:\PROJETOS\ASP.NET CORE\PrimeiroCRUD\PrimeiroCRUD\Views\_ViewImports.cshtml"
using PrimeiroCRUD;

#line default
#line hidden
#line 2 "D:\PROJETOS\ASP.NET CORE\PrimeiroCRUD\PrimeiroCRUD\Views\_ViewImports.cshtml"
using PrimeiroCRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10de8f1849e67b886b09c653d2de296c85d756a", @"/Views/Carros/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e576a0bac9f50b21b98eee6ed13364fc36e6f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Carros_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimeiroCRUD.Models.Carro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\PROJETOS\ASP.NET CORE\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(78, 46, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
#line 9 "D:\PROJETOS\ASP.NET CORE\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(162, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(169, 36, false);
#line 10 "D:\PROJETOS\ASP.NET CORE\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(205, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(212, 35, false);
#line 11 "D:\PROJETOS\ASP.NET CORE\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(247, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimeiroCRUD.Models.Carro> Html { get; private set; }
    }
}
#pragma warning restore 1591
