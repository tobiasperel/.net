#pragma checksum "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Final.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd812437a726dd95578018e3cc51ce207adb1fe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juego_Final), @"mvc.1.0.view", @"/Views/Juego/Final.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd812437a726dd95578018e3cc51ce207adb1fe8", @"/Views/Juego/Final.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a9266163398eb47a68fbd4217438e774f1f0101", @"/Views/_ViewImports.cshtml")]
    public class Views_Juego_Final : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/elonMuskBTC.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row justify-content-center mt-3 mb-3\">\r\n    <h2 class=\"display-4 texto-deal\">??Felicidades, ganaste $");
#nullable restore
#line 2 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Final.cshtml"
                                                       Write(ViewBag.PrecioFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ! </h2>\r\n</div>\r\n\r\n<div class=\"container-fluid\">\r\n  <main role=\"main\" class=\"pb-3\">\r\n    <h1 class=\"text-center\">");
#nullable restore
#line 7 "C:\Users\46501954\OneDrive - Asociacion ORT Argentina\ORT_2021\Programacion\Backend\dealOrNoDeal\Views\Juego\Final.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n      <div class=\"col-md-3 my-3\">\r\n        <div class=\"embed-responsive embed-responsive-16by9\">\r\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd812437a726dd95578018e3cc51ce207adb1fe85265", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
      </div>
      <div class=""col-md-6 my-3"">
        <div class=""embed-responsive embed-responsive-16by9"">
          <iframe class=""embed-responsive-item"" src=""https://www.youtube.com/embed/dQw4w9WgXcQ?autoplay=1""
            allow=""autoplay"" allowfullscreen></iframe> 
        </div>
        <div class=""embed-responsive my-3 embed-responsive-16by9"">
          <iframe class=""embed-responsive-item"" src=""https://www.youtube.com/embed/T2lXnH5gq9I?autoplay=1""
            allow=""autoplay"" allowfullscreen></iframe>  
        </div>
      </div>
      <div class=""col-md-3 my-3 mt-3"" id=""vertical-center"">
        <div class=""embed-responsive embed-responsive-16by9 "">
          <iframe class=""embed-responsive-item"" src=""https://www.youtube.com/embed/MFjSwrr4BrA"" 
            allowfullscreen></iframe>
        </div>
      </div>
    </div>

  </main>
</div>
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
