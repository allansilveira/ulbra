#pragma checksum "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40996c33a00d09988f40687d8c88580f215d71c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_Edit), @"mvc.1.0.view", @"/Views/Conta/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conta/Edit.cshtml", typeof(AspNetCore.Views_Conta_Edit))]
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
#line 1 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/_ViewImports.cshtml"
using contaluz;

#line default
#line hidden
#line 2 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/_ViewImports.cshtml"
using contaluz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40996c33a00d09988f40687d8c88580f215d71c8", @"/Views/Conta/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846c8b02cdeda8902a080338a663e4fe3034f982", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<contaluz.Models.Light>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 35, true);
            WriteLiteral("\n<div class=\"form-horizontal\">\n    ");
            EndContext();
            BeginContext(64, 1386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40996c33a00d09988f40687d8c88580f215d71c83958", async() => {
                BeginContext(98, 126, true);
                WriteLiteral("\n\n        <div class=\"form-group\">\n            <label>ID</label>\n            <input class=\"form-control\" type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 224, "\"", 241, 1);
#line 8 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml"
WriteAttributeValue("", 232, Model.id, 232, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(242, 163, true);
                WriteLiteral("/>\n        </div>\n\n         <div class=\"form-group\">\n            <label>Data Leitura</label>\n            <input class=\"form-control\" type=\"text\" name=\"dataLeitura\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 405, "\"", 431, 1);
#line 13 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml"
WriteAttributeValue("", 413, Model.dataLeitura, 413, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(432, 162, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>N. Leitura</label>\n            <input class=\"form-control\" type=\"text\" name=\"numeroLeitura\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 594, "\"", 622, 1);
#line 18 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml"
WriteAttributeValue("", 602, Model.numeroLeitura, 602, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(623, 149, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Kw Gasto</label>\n            <input class=\"form-control\" type=\"text\" name=\"kw\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 772, "\"", 789, 1);
#line 23 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml"
WriteAttributeValue("", 780, Model.kw, 780, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(790, 157, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Valor a Pagar</label>\n            <input class=\"form-control\" type=\"text\" name=\"valor\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 947, "\"", 967, 1);
#line 28 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml"
WriteAttributeValue("", 955, Model.valor, 955, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(968, 166, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Data Pagamento</label>\n            <input class=\"form-control\" type=\"text\" name=\"dataPagamento\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1134, "\"", 1162, 1);
#line 33 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml"
WriteAttributeValue("", 1142, Model.dataPagamento, 1142, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1163, 157, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Média Consumo</label>\n            <input class=\"form-control\" type=\"text\" name=\"media\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1320, "\"", 1340, 1);
#line 38 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/contaluz/Views/Conta/Edit.cshtml"
WriteAttributeValue("", 1328, Model.media, 1328, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1341, 102, true);
                WriteLiteral("/>\n        </div>\n\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Salvar\"/>\n        \n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1450, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<contaluz.Models.Light> Html { get; private set; }
    }
}
#pragma warning restore 1591