#pragma checksum "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fdce24ec9ba1336cca83ba5bb5198a2c93e54a1"
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
#line 1 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\_ViewImports.cshtml"
using eKino;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\_ViewImports.cshtml"
using eKino.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
using Podaci.EntityModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fdce24ec9ba1336cca83ba5bb5198a2c93e54a1", @"/Views/Ponuda/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6389742b6eb56452126cf8f2709477a138e9e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Ponuda_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PonudaPrikazVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
 if (Model.Ponuda.Count <= 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 id=\"prazan-dan\">Nema zakazanih projekcija na odabrani dan!</h3>\r\n");
#nullable restore
#line 16 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
     foreach (var f in Model.Ponuda)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"film-ponuda\">\r\n            <div class=\"film-ponuda-desno\">\r\n                <div class=\"film-ponuda-slika\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 686, "", 702, 1);
#nullable restore
#line 24 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
WriteAttributeValue("", 691, f.SlikaUrl, 691, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"film-ponuda-podaci\">\r\n                    <div>\r\n                        <h2>");
#nullable restore
#line 28 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                       Write(f.Film);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p><b>Godina: </b>");
#nullable restore
#line 29 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                                     Write(f.Godina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Reditelj: </b>");
#nullable restore
#line 30 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                                       Write(f.Reditelj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Uloge: </b>");
#nullable restore
#line 31 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                                    Write(f.Glumci);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Žanr: </b>");
#nullable restore
#line 32 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                                   Write(f.Zanr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Trajanje: </b>");
#nullable restore
#line 33 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                                       Write(f.Trajanje);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</p>\r\n                    </div>\r\n                    <div class=\"film-ponuda-opsirnije\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1253, "\"", 1286, 2);
            WriteAttributeValue("", 1260, "/Home/Filmovi?ID=", 1260, 17, true);
#nullable restore
#line 36 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
WriteAttributeValue("", 1277, f.FilmID, 1277, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>Opširnije...</h3></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"film-ponuda-lijevo\">\r\n                <div class=\"film-ponuda-termini\">\r\n                    <h3>");
#nullable restore
#line 42 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                   Write(f.Datum.ToString("d.M.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h3>\r\n");
#nullable restore
#line 43 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                     foreach (var t in Model.Termini)
                    {
                        if (t.FilmID == f.FilmID)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 47 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                          Write(t.Vrijeme.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"film-ponuda-rezervisi\">\r\n");
#nullable restore
#line 54 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                 if (!SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"/Identity/Account/Login\">Kupi kartu</a>\r\n");
#nullable restore
#line 57 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2142, "\"", 2176, 3);
            WriteAttributeValue("", 2152, "rezervisiSjedista(", 2152, 18, true);
#nullable restore
#line 60 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
WriteAttributeValue("", 2170, f.ID, 2170, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2175, ")", 2175, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Kupi kartu</button>\r\n");
#nullable restore
#line 61 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 65 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\0FIT\RS1\eKino FINALNO\webapp\eKino\Views\Ponuda\Prikaz.cshtml"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Korisnik> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Korisnik> SignInManager { get; private set; }
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