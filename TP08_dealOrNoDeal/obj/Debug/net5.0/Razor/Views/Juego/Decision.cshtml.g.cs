#pragma checksum "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1670c950120678e99f36ddfd5759f301d0806ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_Decision), @"mvc.1.0.view", @"/Views/Juego/Decision.cshtml")]
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
#line 1 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\_ViewImports.cshtml"
using dealOrNoDeal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\_ViewImports.cshtml"
using dealOrNoDeal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1670c950120678e99f36ddfd5759f301d0806ba", @"/Views/Juego/Decision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a9266163398eb47a68fbd4217438e774f1f0101", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_Decision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
  
    ViewData["Title"] = "Decision";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-center mt-5\">\r\n    <h2 class=\"display-4 texto-deal text-center\">LA OFERTA ES $");
#nullable restore
#line 5 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
                                                          Write(ViewBag.oferta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 col-12 order-lg-2 mb-5\">\r\n        <div class=\"position-relative row justify-content-between\">\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 341, "\'", 403, 1);
#nullable restore
#line 10 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
WriteAttributeValue("", 348, Url.Action("DecisionOferta","Juego",new{aceptar=true}), 348, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"mx-3 btn btn-oferta btn-large align-right\">ACEPTAR</button></a>\r\n          \r\n                <a");
            BeginWriteAttribute("href", " href=\'", 515, "\'", 578, 1);
#nullable restore
#line 12 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
WriteAttributeValue("", 522, Url.Action("DecisionOferta","Juego",new{aceptar=false}), 522, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"mx-3 btn btn-oferta btn-large float-left\">RECHAZAR</button></a>\r\n        </div> \r\n    </div>\r\n    <div class=\"col-md-2 col-6 order-lg-1\">\r\n");
#nullable restore
#line 16 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
         for (int i = 0; i < ViewBag.nombreCriptos.Length / 2; i++)
        {
            bool existe = false;
            var imageName = ViewBag.nombreCriptos[i].Replace(" ", "_");
            foreach(var item in ViewBag.IndexYCripto){
                if(item.Value == ViewBag.nombreCriptos[i]){
                    existe = true;
                    break;
                }
                
            }
            if(existe){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row justify-content-center\">\r\n                    <a style=\"opacity: 40%;\"><img class=\"py-1 cartelWidth\"");
            BeginWriteAttribute("src", " src=", 1311, "", 1358, 1);
#nullable restore
#line 29 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
WriteAttributeValue("", 1316, "../img/carteles/" + imageName + ".png", 1316, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n");
#nullable restore
#line 31 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row justify-content-center\">\r\n                        <img class=\"py-1 cartelWidth\"");
            BeginWriteAttribute("src", " src=", 1538, "", 1585, 1);
#nullable restore
#line 34 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
WriteAttributeValue("", 1543, "../img/carteles/" + imageName + ".png", 1543, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 36 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
                }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-2 col-6 order-lg-3 mt-4\">\r\n");
#nullable restore
#line 40 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
         for (int i = ViewBag.nombreCriptos.Length/2; i < ViewBag.nombreCriptos.Length; i++)
        {
            bool existe = false;
            var imageName = ViewBag.nombreCriptos[i].Replace(" ", "_");
            foreach(var item in ViewBag.IndexYCripto){
                if(item.Value == ViewBag.nombreCriptos[i]){
                    existe = true;
                    break;
                }
                
            }
            if(existe){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row justify-content-center\">\r\n                    <a style=\"opacity: 40%;\"><img class=\"py-1 cartelWidth\"");
            BeginWriteAttribute("src", " src=", 2310, "", 2357, 1);
#nullable restore
#line 53 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
WriteAttributeValue("", 2315, "../img/carteles/" + imageName + ".png", 2315, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n");
#nullable restore
#line 55 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row justify-content-center\">\r\n                        <img class=\"py-1 cartelWidth\"");
            BeginWriteAttribute("src", " src=", 2537, "", 2584, 1);
#nullable restore
#line 58 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
WriteAttributeValue("", 2542, "../img/carteles/" + imageName + ".png", 2542, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 60 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Decision.cshtml"
                }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
