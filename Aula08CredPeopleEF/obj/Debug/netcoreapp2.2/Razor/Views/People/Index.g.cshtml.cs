#pragma checksum "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b00187cc2d36e7affbce1f458d123bdd4cd7903a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Index.cshtml", typeof(AspNetCore.Views_People_Index))]
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
#line 1 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/_ViewImports.cshtml"
using Aula08CredPeopleEF;

#line default
#line hidden
#line 2 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/_ViewImports.cshtml"
using Aula08CredPeopleEF.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00187cc2d36e7affbce1f458d123bdd4cd7903a", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8cd583e23789590d4392c01a733cb6de43b8845", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aula08CredPeopleEF.Models.Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 216, true);
            WriteLiteral("    \n</br></br>\n<a href=\"People/Create\" class=\"btn btn-primary\">Nova Pessoa</a>\n</br></br>\n\n<div class=\"container\">\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
            EndContext();
            BeginContext(270, 132, false);
#line 12 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(Html.ActionLink("ID", "Index", new { sortField = "id", currentSortField = ViewBag.SortField, currentSortOrder = ViewBag.SortOrder }));

#line default
#line hidden
            EndContext();
            BeginContext(402, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(467, 136, false);
#line 15 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(Html.ActionLink("Nome", "Index", new { sortField = "name", currentSortField = ViewBag.SortField, currentSortOrder = ViewBag.SortOrder }));

#line default
#line hidden
            EndContext();
            BeginContext(603, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(668, 143, false);
#line 18 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(Html.ActionLink("Endereço", "Index", new { sortField = "address", currentSortField = ViewBag.SortField, currentSortOrder = ViewBag.SortOrder }));

#line default
#line hidden
            EndContext();
            BeginContext(811, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(876, 137, false);
#line 21 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(Html.ActionLink("Fone", "Index", new { sortField = "phone", currentSortField = ViewBag.SortField, currentSortOrder = ViewBag.SortOrder }));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 129, true);
            WriteLiteral("\n                </th>\n                <th></th>\n                <th></th>\n            </tr>\n            </tr>\n        </thead>\n\n");
            EndContext();
#line 29 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(1188, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(1226, 7, false);
#line 32 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1260, 9, false);
#line 33 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1269, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1296, 12, false);
#line 34 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(item.address);

#line default
#line hidden
            EndContext();
            BeginContext(1308, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1335, 10, false);
#line 35 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
               Write(item.phone);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 51, true);
            WriteLiteral("</td>\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\n                    href=\"", 1396, "\"", 1445, 2);
            WriteAttributeValue("", 1423, "People/Delete/", 1423, 14, true);
#line 37 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
WriteAttributeValue("", 1437, item.id, 1437, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1446, 64, true);
            WriteLiteral(">Delete</a> </td>\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \n                    href=\"", 1510, "\"", 1558, 2);
            WriteAttributeValue("", 1538, "People/Edit/", 1538, 12, true);
#line 39 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
WriteAttributeValue("", 1550, item.id, 1550, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1559, 36, true);
            WriteLiteral(">Editar</a> </td>\n            </tr>\n");
            EndContext();
#line 41 "/Users/allansilvasilveira/Documents/VSCODE/ulbra/Aula08CredPeopleEF/Views/People/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1605, 19, true);
            WriteLiteral("    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aula08CredPeopleEF.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
