#pragma checksum "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20070cbe309722d7f518d7335bdc0f978adc33d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ponuda_Prikaz), @"mvc.1.0.view", @"/Views/Ponuda/Prikaz.cshtml")]
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
#line 1 "D:\0FIT\RS1\eKino\eKino\Views\_ViewImports.cshtml"
using eKino;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\0FIT\RS1\eKino\eKino\Views\_ViewImports.cshtml"
using eKino.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20070cbe309722d7f518d7335bdc0f978adc33d9", @"/Views/Ponuda/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6389742b6eb56452126cf8f2709477a138e9e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Ponuda_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PonudaPrikazVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
 if (Model.Ponuda.Count <= 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"prazan-dan\">Nema zakazanih projekcija na odabrani dan!</h3>\r\n");
#nullable restore
#line 11 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
     foreach (var f in Model.Ponuda)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"film-ponuda\">\r\n            <div class=\"film-ponuda-desno\">\r\n                <div class=\"film-ponuda-slika\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 472, "", 488, 1);
#nullable restore
#line 19 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
WriteAttributeValue("", 477, f.SlikaUrl, 477, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                </div>\r\n                <div class=\"film-ponuda-podaci\">\r\n                    <div>\r\n                        <h2>");
#nullable restore
#line 23 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                       Write(f.Film);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>Godina: ");
#nullable restore
#line 24 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                              Write(f.Godina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Reditelj: ");
#nullable restore
#line 25 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                                Write(f.Reditelj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Uloge: ");
#nullable restore
#line 26 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                             Write(f.Glumci);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Žanr: ");
#nullable restore
#line 27 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                            Write(f.Zanr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>Trajanje: ");
#nullable restore
#line 28 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                                Write(f.Trajanje);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" min</p>
                    </div>
                    <div class=""film-ponuda-opsirnije"">
                        <a><h3>Opširnije...</h3></a>
                    </div>
                </div>
            </div>
            <div class=""film-ponuda-lijevo"">
                <div class=""film-ponuda-termini"">
                    <h3>Sala ");
#nullable restore
#line 37 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                        Write(f.Sala);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 38 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                     foreach (var t in Model.Termini)
                    {
                        if (t.FilmID ==f.FilmID)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 42 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                          Write(t.Vrijeme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 43 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"film-ponuda-rezervisi\">\r\n                <button>Kupi kartu</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 52 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\0FIT\RS1\eKino\eKino\Views\Ponuda\Prikaz.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PonudaPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
