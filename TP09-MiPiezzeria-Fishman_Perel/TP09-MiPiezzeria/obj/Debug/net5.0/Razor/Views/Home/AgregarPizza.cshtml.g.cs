#pragma checksum "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f995e7c6639d01711245e8dd2d8d66f71a19ebe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AgregarPizza), @"mvc.1.0.view", @"/Views/Home/AgregarPizza.cshtml")]
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
#line 1 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\_ViewImports.cshtml"
using TP09_MiPiezzeria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\_ViewImports.cshtml"
using TP09_MiPiezzeria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f995e7c6639d01711245e8dd2d8d66f71a19ebe3", @"/Views/Home/AgregarPizza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d27031bc45bc673e41a658e74eb2b600ea1e737", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AgregarPizza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("tamano"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Chica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Mediana", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Grande", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f995e7c6639d01711245e8dd2d8d66f71a19ebe35726", async() => {
                WriteLiteral(@"
  <div class=""container"">
    <h1 class=""text-center"">Agregar Pizza</h1>
    <ul>
      <li>
        <div class=""grid grid-2 mt-4"">
          <input type=""text"" placeholder=""Nombre"" name=""nombre"" required>
          <input type=""number"" placeholder=""$0.00"" name=""precio"" required>
        </div>
      </li>
      <li>
        <div class=""grid  mt-4"">
          <input type=""url"" name=""foto"" placeholder=""Url de la foto"" required>
        </div>
      </li>
      <li>
        <select name=""tamano"">
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f995e7c6639d01711245e8dd2d8d66f71a19ebe36537", async() => {
                    WriteLiteral("-- Tamaño --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f995e7c6639d01711245e8dd2d8d66f71a19ebe38621", async() => {
                    WriteLiteral("Chica ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f995e7c6639d01711245e8dd2d8d66f71a19ebe39941", async() => {
                    WriteLiteral("Mediana");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f995e7c6639d01711245e8dd2d8d66f71a19ebe311262", async() => {
                    WriteLiteral("Grande");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select>\r\n      </li>\r\n");
#nullable restore
#line 24 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
        
        if (ViewBag.Ingredientes.Count == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <p class=\"mt-4\">Ups! No hay ingredientes cargados...</p>\r\n");
#nullable restore
#line 28 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
        }
        else
        {
          int colSize = 12 / ViewBag.Ingredientes.Count;
          string colText = "col-md-" + colSize;
          if(colSize < 4){colText = "col-md-4";}
          string widthFoto = (80 / ViewBag.Ingredientes.Count) + "%";

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Ingredientes:</label>\r\n            <div class=\"row justify-content-around mt-4\">\r\n          \r\n");
#nullable restore
#line 38 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
             for (int i = 0; i < ViewBag.Ingredientes.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li");
                BeginWriteAttribute("class", " class=\"", 1550, "\"", 1578, 2);
#nullable restore
#line 40 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
WriteAttributeValue("", 1558, colText, 1558, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1566, "text-center", 1567, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1606, "\"", 1641, 1);
#nullable restore
#line 41 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
WriteAttributeValue("", 1612, ViewBag.Ingredientes[i].Foto, 1612, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("width", " width=\"", 1642, "\"", 1660, 1);
#nullable restore
#line 41 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
WriteAttributeValue("", 1650, widthFoto, 1650, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <p>");
#nullable restore
#line 42 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
                  Write(ViewBag.Ingredientes[i].Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <input type=\"checkbox\" name=\"ingrediente\"");
                BeginWriteAttribute("value", " value=", 1787, "", 1796, 1);
#nullable restore
#line 43 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
WriteAttributeValue("", 1794, i, 1794, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </li>\r\n");
#nullable restore
#line 45 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
#nullable restore
#line 47 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
        }
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
       if (ViewBag.error)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-warning mt-2 align-items-center\" role=\"alert\">\r\n                <p>");
#nullable restore
#line 52 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
              Write(ViewBag.mensajeError);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("      <li>\r\n        <div class=\"grid grid-2\">\r\n          <a");
                BeginWriteAttribute("href", " href=\'", 2137, "\'", 2185, 1);
#nullable restore
#line 57 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
WriteAttributeValue("", 2144, Url.Action("AgregarIngredientes","Home"), 2144, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <button type=\"button\" class=\"btn btn-info mt-2\">Agregar ingredientes</button>\r\n          </a>\r\n          <a");
                BeginWriteAttribute("href", " href=\'", 2308, "\'", 2349, 1);
#nullable restore
#line 60 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
WriteAttributeValue("", 2315, Url.Action("AgregarPizza","Home"), 2315, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <button class=\"btn btn-success mt-2\" type=\"submit\" value=\"Send\">Enviar</button>\r\n          </a>\r\n        </div>\r\n      </li>\r\n    </ul>\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 1 "C:\Users\Unknow\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\TP09-MiPiezzeria\Views\Home\AgregarPizza.cshtml"
AddHtmlAttributeValue("", 74, Url.Action("AgregarPizzaForm","Home"), 74, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
