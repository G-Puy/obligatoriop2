#pragma checksum "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744759c7bbec3fc4ec846754780be5cf55f3c878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compras_ComprasFechas), @"mvc.1.0.view", @"/Views/Compras/ComprasFechas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744759c7bbec3fc4ec846754780be5cf55f3c878", @"/Views/Compras/ComprasFechas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fc3a57832e9257a8a8eb82acbf2f40f0b30068", @"/Views/_ViewImports.cshtml")]
    public class Views_Compras_ComprasFechas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnSub"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div id=\"divSubmit\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744759c7bbec3fc4ec846754780be5cf55f3c8784183", async() => {
                WriteLiteral("\r\n        <label>Fecha 1:</label><br>\r\n        <input type=\"date\" name=\"f1\" id=\"f1\"><br>\r\n        <label>Fecha 2:</label><br>\r\n        <input type=\"date\" name=\"f2\" id=\"f2\"><br>\r\n        <input type=\"submit\" value=\"Aceptar\"");
                BeginWriteAttribute("id", " id=\"", 280, "\"", 285, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <p id=\"msjResult\"></p>\r\n\r\n</div>\r\n");
#nullable restore
#line 13 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
 if (ViewBag.compras != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table border=\"1\" textaling=\"center\">\r\n        <tr>\r\n            <td>Nombre Actividad</td>\r\n            <td>Cantidad Entradas</td>\r\n            <td>Total</td>\r\n            <td>Fecha y hora</td>\r\n            <td>Estado</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
         foreach (var comp in ViewBag.compras)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
               Write(comp.ActividadComprada.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
               Write(comp.CantEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
               Write(comp.PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
               Write(comp.FechaCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
               Write(comp.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <p>");
#nullable restore
#line 35 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
  Write(ViewBag.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"





}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 44 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
  Write(ViewBag.errorFechas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\ComprasFechas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<script>
    document.querySelector(""#btnSub"").addEventListener(""submit"", VerificarDAtos);
    function VerificarDAtos(evento) {
        evento.preventDefault();
        fecha1 = document.querySelector(""#f1"").value;
        fecha2 = document.querySelector(""#f2"").value;
        if (fecha1 != fecha2) {
            this.submit();
        } else {
            document.querySelector(""#msjResult"").innerHTML = 'Verifique las fechas';
        }
    }
    


</script>
");
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
