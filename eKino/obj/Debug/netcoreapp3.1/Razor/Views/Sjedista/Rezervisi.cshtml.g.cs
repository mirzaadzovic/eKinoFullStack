#pragma checksum "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7de4fc04527d79034e9e105ca851bacf47f9370e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sjedista_Rezervisi), @"mvc.1.0.view", @"/Views/Sjedista/Rezervisi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de4fc04527d79034e9e105ca851bacf47f9370e", @"/Views/Sjedista/Rezervisi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6389742b6eb56452126cf8f2709477a138e9e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Sjedista_Rezervisi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SjedistaRezervisiVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/x-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: transparent; height: 25px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("rezervacijaZatvori()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selekcija"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("generisiRaspored(this.value)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sjedista.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
  
    ViewData["Title"] = "Rezervisi";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"seats-container-x\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7de4fc04527d79034e9e105ca851bacf47f9370e5582", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div style=\"\r\n            background-color: transparent;\r\n            color: #f4f4ef;\r\n            margin: 5px;\r\n            margin-top: 0px;\r\n            font-size: 30px;\r\n          \">\r\n    ");
#nullable restore
#line 18 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
Write(Model.Film.Film);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"seats-container-gornji-div\">\r\n    <div class=\"seats-container-slika\"\r\n         style=\"background: transparent; margin-right: 30px\">\r\n        <img height=\"170px\"\r\n             ;");
            BeginWriteAttribute("src", "\r\n             src=\"", 653, "\"", 693, 1);
#nullable restore
#line 26 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
WriteAttributeValue("", 673, Model.Film.SlikaUrl, 673, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"seats-container-odabir\">\r\n        <div class=\"seats-container-datum-rezervacije\">\r\n            ");
#nullable restore
#line 30 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
       Write(Model.Film.DanUSedmini);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 30 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
                                Write(Model.Film.Datum.ToString("d.M.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n            <br />\r\n            <label style=\"background: transparent; font-size: 18px\">\r\n                Cijena karte:\r\n                <span id=\"cijena-karte\" style=\"background: transparent\">");
#nullable restore
#line 34 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
                                                                   Write(Model.Film.Cijena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                KM\r\n            </label>\r\n        </div>\r\n        <label style=\"background: transparent\">Odaberi termin</label>\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7de4fc04527d79034e9e105ca851bacf47f9370e9011", async() => {
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 40 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TerminID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "D:\0FIT\RS1\eKino\eKino\Views\Sjedista\Rezervisi.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Termini;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <br />
        <label style=""background: transparent"">
            Odabranih sjedišta:
            <span id=""ukupno-sjedista"" style=""background: transparent"">0</span>
        </label>
    </div>
</div>
<div class=""odabir-sjedista-legenda"">
    <div class=""odabir-sjedista-legenda-red"">
        <p style=""background: #acbebe""></p>
        Slobodno
    </div>
    <div class=""odabir-sjedista-legenda-red"">
        <p style=""background: #a01d26""></p>
        Zauzeto
    </div>
    <div class=""odabir-sjedista-legenda-red"">
        <p style=""background: gold""></p>
        Odabrano
    </div>
</div>

<div id=""seats-all"" style=""background: transparent"">
");
            WriteLiteral(@"</div>
<div id=""trapezoid""></div>
<div id=""seats-container-ponisti"">
    <a onclick=""ponistiOdabranaSjedista()"">Poništi</a>
</div>
<div class=""seats-container-donji-div"">
    <div id=""ukupno-za-platiti"">
        Ukupno za platiti: <span id=""za-platiti-span"">0</span> KM
    </div>
    <div id=""rezervisi-btn"">
        <button type=""submit"" id=""btn-blocked"" ");
            WriteLiteral("disabled>\r\n            Rezerviši\r\n        </button>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7de4fc04527d79034e9e105ca851bacf47f9370e12324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SjedistaRezervisiVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
