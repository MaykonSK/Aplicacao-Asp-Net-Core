#pragma checksum "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e398734e7dfb0ff329630e4d4bafe9c992dbc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e398734e7dfb0ff329630e4d4bafe9c992dbc4", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5200951b578265d5d6ccc50a38cf6b49023e2553", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
  
    //aqui pode colocar codigo c#
    //mas não é uma boa prática
    int valor = 20;
    ViewData["Title"] = "About"+valor;

#line default
#line hidden
            BeginContext(136, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(141, 17, false);
#line 7 "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(158, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(170, 19, false);
#line 8 "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(189, 34, true);
            WriteLiteral("</h3>\r\n<br/>\r\n<h4>Seja bem vindo, ");
            EndContext();
            BeginContext(224, 17, false);
#line 10 "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
               Write(ViewData["Aluno"]);

#line default
#line hidden
            EndContext();
            BeginContext(241, 19, true);
            WriteLiteral("!</h4>\r\n<p>E-mail: ");
            EndContext();
            BeginContext(261, 17, false);
#line 11 "C:\Users\maycon.oliveira\source\repos\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
      Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(278, 41, true);
            WriteLiteral("</p> <!--chamando view do controller-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
