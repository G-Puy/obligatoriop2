#pragma checksum "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ae33db608db0dc4bd97e2718deddf8e3855009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compras_ComprasRealizadas), @"mvc.1.0.view", @"/Views/Compras/ComprasRealizadas.cshtml")]
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
#line 1 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\_ViewImports.cshtml"
using Obli_2_p2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\_ViewImports.cshtml"
using Obli_2_p2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ae33db608db0dc4bd97e2718deddf8e3855009", @"/Views/Compras/ComprasRealizadas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fc3a57832e9257a8a8eb82acbf2f40f0b30068", @"/Views/_ViewImports.cshtml")]
    public class Views_Compras_ComprasRealizadas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>compra</h1>
<h2>Lista Compras Realizadas</h2>
<table border=""1"" textaling=""center"">
    <tr>
        <td>Nombre Actividad</td>
        <td>Cantidad Entradas</td>
        <td>Total</td>
        <td>Fecha y hora</td>
        <td>Estado</td>
        <td></td>
    </tr>
");
#nullable restore
#line 12 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
     foreach (var comp in ViewBag.ListaComprasHechas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 15 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
   Write(comp.ActividadComprada.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 16 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
   Write(comp.CantEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 17 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
   Write(comp.PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 18 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
   Write(comp.FechaCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
   Write(comp.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65ae33db608db0dc4bd97e2718deddf8e38550096186", async() => {
                WriteLiteral("\r\n\r\n        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 589, "\"", 605, 1);
#nullable restore
#line 23 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
WriteAttributeValue("", 597, comp.Id, 597, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"idCompra\" style=\"display:none\">\r\n        <input type=\"submit\" value=\"Cancelar compra\" >\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 29 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasRealizadas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
