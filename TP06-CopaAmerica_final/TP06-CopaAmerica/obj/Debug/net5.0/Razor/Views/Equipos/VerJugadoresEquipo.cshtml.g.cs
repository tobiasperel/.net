#pragma checksum "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4241e74ddccd42ac6b5bea9837ca04bb1454171d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipos_VerJugadoresEquipo), @"mvc.1.0.view", @"/Views/Equipos/VerJugadoresEquipo.cshtml")]
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
#line 1 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\_ViewImports.cshtml"
using TP06_CopaAmericaV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\_ViewImports.cshtml"
using TP06_CopaAmericaV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4241e74ddccd42ac6b5bea9837ca04bb1454171d", @"/Views/Equipos/VerJugadoresEquipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"751b7d417e05d1719cb45c11534f4690bcfffb3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipos_VerJugadoresEquipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
  
    ViewData["Title"] = "verJugadores";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
  
    string claseColumna = "col-md-4";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 9 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
      
        int contador = 0;
        string linkWiki = "";
        string linkBase = "https://es.wikipedia.org/wiki/";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
     for (int i = 0; i < ViewBag.Formacion.Length; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row justify-content-center mb-3\">\r\n\r\n");
#nullable restore
#line 18 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
             for (int j = 0; j < ViewBag.Formacion[i]; j++)
            {
                {
                    int col = 12 / ViewBag.Formacion[i];
                    if (col >= 3)
                    {
                        col = 3;
                    }
                    claseColumna = "col-md-" + col.ToString();
                    string jugadorLink = ViewBag.Jugadores[contador].Replace(' ', '_');
                    linkWiki = linkBase + jugadorLink;
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 894, "\"", 915, 1);
#nullable restore
#line 31 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
WriteAttributeValue("", 902, claseColumna, 902, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card my-3 mx-1\" id=\"cardJugador\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title text-center\"><a");
            BeginWriteAttribute("href", " href=\"", 1100, "\"", 1116, 1);
#nullable restore
#line 34 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
WriteAttributeValue("", 1107, linkWiki, 1107, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                            target=\"_blank\">");
#nullable restore
#line 35 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                                       Write(ViewBag.Jugadores[contador]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                            <p class=\"card-text text-center\" style=\"color: gray\">\r\n                                ");
#nullable restore
#line 37 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                           Write(ViewBag.EquiposJugadores[contador]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 43 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                { contador += 1; }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 46 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"container-fluid pb-5 \">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4 my-3\">\r\n            <div class=\"card\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=", 1728, "", 1775, 1);
#nullable restore
#line 53 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
WriteAttributeValue("", 1733, "../img/dts/" + ViewBag.DT_IMG + ".png", 1733, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 55 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                                      Write(ViewBag.DT);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                </div>
            </div>
        </div>
        <div class=""col-md-4 my-3"" style=""height: 5fw;"">

            <div class=""card"" id=""ul-card-campeon"">
                <h3 class=""text-center"">Campeón en:</h3>
                <div class=""justify-content-center"">
                <ul class=""list-group list-group-flush cardScroll justify-content-center"">
");
#nullable restore
#line 65 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                      
                        int contadorCampeonatos = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                     foreach(KeyValuePair<string, string> campeon in ViewBag.Campeones){
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                         if (campeon.Value == ViewBag.CurrentTeam){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"list-group-item li-hover\">");
#nullable restore
#line 70 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                                                            Write(campeon.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 71 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                            {contadorCampeonatos += 1;}
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                           
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                     if (contadorCampeonatos==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2 class=\"text-center\">Uy! Este equipo nunca salió campeón...</h2>\r\n");
#nullable restore
#line 76 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4 my-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 3060, "", 3113, 1);
#nullable restore
#line 83 "E:\Programacion\WEB\TP06-CopaAmerica_final\TP06-CopaAmerica\Views\Equipos\VerJugadoresEquipo.cshtml"
WriteAttributeValue("", 3065, "../img/flag/" + ViewBag.CurrentTeam + ".png", 3065, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\">\r\n        </div>\r\n    </div>\r\n</div>");
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
