#pragma checksum "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\Estadisticas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4669b203fae2ad8fd89d5ef22107ac3779ecc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compras_Estadisticas), @"mvc.1.0.view", @"/Views/Compras/Estadisticas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4669b203fae2ad8fd89d5ef22107ac3779ecc5", @"/Views/Compras/Estadisticas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fc3a57832e9257a8a8eb82acbf2f40f0b30068", @"/Views/_ViewImports.cshtml")]
    public class Views_Compras_Estadisticas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Estadisticas</h1>\r\n\r\n<p>");
#nullable restore
#line 3 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\Estadisticas.cshtml"
Write(Html.ActionLink("Compras de mayor valor", "MayorValor", "Compras"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 4 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\Estadisticas.cshtml"
Write(Html.ActionLink("Actividades por fecha y categoria", "FechaCategoria", "Actividades"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 5 "C:\Users\59891\Documents\IMPORTANTE\ORT\Segundo semestre\Programacion 2\Obligatorios\OBLIGATORIO 2\Version 23-11-2021 Hora 23-48\Obli_2_p2\Views\Compras\Estadisticas.cshtml"
Write(Html.ActionLink("Actividades por lugar", "NombreActividades", "Actividades"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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