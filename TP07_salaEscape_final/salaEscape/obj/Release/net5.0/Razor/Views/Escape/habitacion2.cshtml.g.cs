#pragma checksum "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d06f46198e27bc95d05cafe9f487b9140c98964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escape_habitacion2), @"mvc.1.0.view", @"/Views/Escape/habitacion2.cshtml")]
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
#line 1 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\_ViewImports.cshtml"
using salaEscape;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\_ViewImports.cshtml"
using salaEscape.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d06f46198e27bc95d05cafe9f487b9140c98964", @"/Views/Escape/habitacion2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04ffde7a7dfa60fcf2d8a216d265a70a1d3b0cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Escape_habitacion2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/siluetas/Mirtha_Negro.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fade-in-fwd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Personaje 2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container pt-4"">
  <div class=""row"">
    <div class=""col-md-8"">
        <p class=""fade-in-fwd"">
          El número brindado por Jorgito era el 3.
          <br>
          Este es un personaje reconocido por millones de generaciones. Es reconocido por ser una persona
          muy polémica, aunque hoy en día debido a todo lo que estamos viviendo se le tiene más compasión.
          De repente te parece recordar quien es, pero escuchas el ruido del batimóvil pasar cerca de tu
          casa y se te escapa. ¿Podrás saber quien es y cuando nació?
        </p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d06f46198e27bc95d05cafe9f487b9140c989645847", async() => {
                WriteLiteral(@"
          <input type=""date"" class=""form-control"" name=""ans"" id=""ans"" aria-describedby=""helpId"">
          <small id=""helpId"" class=""form-text text-muted"">Nombre del Personaje</small>
          <button class=""btn btn-success submit"" onclick='formValidation1(2)'>Enviar</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
AddHtmlAttributeValue("", 622, Url.Action("Respuesta","Escape", new{Sala = 2}), 622, 48, false);

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
            WriteLiteral("\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
           for (int i = 0; i < ViewBag.Pistas.Length; i++)
          {
            int imasuno = i + 1;
            Console.WriteLine(ViewBag.Pistas[i]);
            string ID = "pista" + (@imasuno).ToString();


#line default
#line hidden
#nullable disable
            WriteLiteral("            <button");
            BeginWriteAttribute("value", " value=\"", 1236, "\"", 1262, 1);
#nullable restore
#line 24 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
WriteAttributeValue("", 1244, ViewBag.Pistas[i], 1244, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=", 1263, "", 1270, 1);
#nullable restore
#line 24 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
WriteAttributeValue("", 1267, ID, 1267, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1270, "\"", 1300, 3);
            WriteAttributeValue("", 1280, "showAlert(", 1280, 10, true);
#nullable restore
#line 24 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
WriteAttributeValue("", 1290, imasuno, 1290, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1298, ");", 1298, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info mt-2 mx-2\"> Pista\r\n              ");
#nullable restore
#line 25 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
         Write(imasuno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 26 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
           for (int i = 0; i < ViewBag.Pistas.Length; i++)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-success alert-dismissible my-2"" id=""alertbox"" role=""alert"" style=""display:none;"">
              <button type=""button"" class=""close"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
              </button>
            </div>
");
#nullable restore
#line 36 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\salaEscape\Views\Escape\habitacion2.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-md-4\" id=\"fotuli\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0d06f46198e27bc95d05cafe9f487b9140c9896411524", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n  </div>\r\n</div>");
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
