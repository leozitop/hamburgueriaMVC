#pragma checksum "C:\Users\45684686800\Documents\ProjetoHamburgueriaMVC\hamburgueriaMVC\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab6f1c5ce75b47dbf95684774cde04e6118b2cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderNavBar), @"mvc.1.0.view", @"/Views/Shared/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_Shared__HeaderNavBar))]
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
#line 1 "C:\Users\45684686800\Documents\ProjetoHamburgueriaMVC\hamburgueriaMVC\Views\_ViewImports.cshtml"
using ProjetoHamburgueriaMVC;

#line default
#line hidden
#line 2 "C:\Users\45684686800\Documents\ProjetoHamburgueriaMVC\hamburgueriaMVC\Views\_ViewImports.cshtml"
using ProjetoHamburgueriaMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab6f1c5ce75b47dbf95684774cde04e6118b2cb", @"/Views/Shared/_HeaderNavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb2d9705668c8afec8aacaaecaafeeb6ec5ac37f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-ction", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bt-peca_ja"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 86, true);
            WriteLiteral("<nav>\r\n        <div class=\"section-container\">\r\n            <ul>\r\n                <li>");
            EndContext();
            BeginContext(86, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65552393cd80459bb15f799dc29ab9eb", async() => {
                BeginContext(144, 9, true);
                WriteLiteral("Principal");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 29, true);
            WriteLiteral("</li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 186, "\'", 234, 2);
#line 5 "C:\Users\45684686800\Documents\ProjetoHamburgueriaMVC\hamburgueriaMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 193, Url.Action("Index", "home"), 193, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 221, "#hamburgueres", 221, 13, true);
            EndWriteAttribute();
            BeginContext(235, 46, true);
            WriteLiteral(">Hamburgueres</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 281, "\'", 323, 2);
#line 6 "C:\Users\45684686800\Documents\ProjetoHamburgueriaMVC\hamburgueriaMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 288, Url.Action("Index", "Home"), 288, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 316, "#shakes", 316, 7, true);
            EndWriteAttribute();
            BeginContext(324, 40, true);
            WriteLiteral(">Shakes</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 364, "\'", 408, 2);
#line 7 "C:\Users\45684686800\Documents\ProjetoHamburgueriaMVC\hamburgueriaMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 371, Url.Action("Index", "Home"), 371, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 399, "#historia", 399, 9, true);
            EndWriteAttribute();
            BeginContext(409, 42, true);
            WriteLiteral(">História</a></li>\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 451, "\'", 492, 2);
#line 8 "C:\Users\45684686800\Documents\ProjetoHamburgueriaMVC\hamburgueriaMVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 458, Url.Action("Index", "Home"), 458, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 486, "#local", 486, 6, true);
            EndWriteAttribute();
            BeginContext(493, 37, true);
            WriteLiteral(">Local</a></li>\r\n                <li>");
            EndContext();
            BeginContext(530, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dbcc01b4f82422f8d68cf6287383823", async() => {
                BeginContext(591, 8, true);
                WriteLiteral("Peça já!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(603, 60, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n\r\n    ");
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
