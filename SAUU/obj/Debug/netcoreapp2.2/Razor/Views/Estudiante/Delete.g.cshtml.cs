#pragma checksum "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abefd5ee4ea255ca83f0d204819ee98f1bb4f5c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estudiante_Delete), @"mvc.1.0.view", @"/Views/Estudiante/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estudiante/Delete.cshtml", typeof(AspNetCore.Views_Estudiante_Delete))]
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
#line 1 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\_ViewImports.cshtml"
using SAUU;

#line default
#line hidden
#line 2 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\_ViewImports.cshtml"
using SAUU.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abefd5ee4ea255ca83f0d204819ee98f1bb4f5c0", @"/Views/Estudiante/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d423af3ef592bc32fbb21265cf81e627697dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Estudiante_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SAUU.Data.Entities.Estudiante>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
  
    ViewData["Title"] = "Borrar";

#line default
#line hidden
            BeginContext(82, 87, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h1><i class=\"fa fa-bar-chart-o page-header-icon\"></i>");
            EndContext();
            BeginContext(170, 17, false);
#line 8 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
                                                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(187, 180, true);
            WriteLiteral("</h1>\r\n</div> <!-- / .page-header -->\r\n\r\n<h3>Esta seguro que desea borrar este estudiante</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(368, 45, false);
#line 16 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.idPersona));

#line default
#line hidden
            EndContext();
            BeginContext(413, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(475, 41, false);
#line 19 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayFor(model => model.idPersona));

#line default
#line hidden
            EndContext();
            BeginContext(516, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(577, 55, false);
#line 22 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.matriculaEstudiante));

#line default
#line hidden
            EndContext();
            BeginContext(632, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(694, 51, false);
#line 25 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayFor(model => model.matriculaEstudiante));

#line default
#line hidden
            EndContext();
            BeginContext(745, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(806, 43, false);
#line 28 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Carrera));

#line default
#line hidden
            EndContext();
            BeginContext(849, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(911, 39, false);
#line 31 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Carrera));

#line default
#line hidden
            EndContext();
            BeginContext(950, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1011, 45, false);
#line 34 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.idEscuela));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1118, 41, false);
#line 37 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
       Write(Html.DisplayFor(model => model.idEscuela));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1193, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abefd5ee4ea255ca83f0d204819ee98f1bb4f5c09261", async() => {
                BeginContext(1219, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1229, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abefd5ee4ea255ca83f0d204819ee98f1bb4f5c09653", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 42 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Estudiante\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.idEstudiante);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1275, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Borrar\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1358, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abefd5ee4ea255ca83f0d204819ee98f1bb4f5c011575", async() => {
                    BeginContext(1404, 8, true);
                    WriteLiteral("Cancelar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1416, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1429, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SAUU.Data.Entities.Estudiante> Html { get; private set; }
    }
}
#pragma warning restore 1591