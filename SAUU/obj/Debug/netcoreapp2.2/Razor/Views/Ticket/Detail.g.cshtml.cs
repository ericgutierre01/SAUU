#pragma checksum "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6232074241577a799ce3d2c9ba56c4f1f20255a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Detail), @"mvc.1.0.view", @"/Views/Ticket/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Detail.cshtml", typeof(AspNetCore.Views_Ticket_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6232074241577a799ce3d2c9ba56c4f1f20255a", @"/Views/Ticket/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d423af3ef592bc32fbb21265cf81e627697dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SAUU.Data.Entities.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
  
    ViewData["Title"] = "Detalle de Ticket";

#line default
#line hidden
            BeginContext(89, 108, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h1>\r\n        <i class=\"fa fa-address-card page-header-icon\"></i>\r\n        ");
            EndContext();
            BeginContext(197, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6232074241577a799ce3d2c9ba56c4f1f20255a3895", async() => {
                BeginContext(219, 7, true);
                WriteLiteral("Ticket ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(230, 3, true);
            WriteLiteral(" > ");
            EndContext();
            BeginContext(234, 17, false);
#line 10 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(251, 65, true);
            WriteLiteral("\r\n    </h1>\r\n</div>\r\n\r\n<span style=\"list-style-type: none\">\r\n    ");
            EndContext();
            BeginContext(317, 24, false);
#line 15 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(341, 202, true);
            WriteLiteral("\r\n</span>\r\n\r\n<div class=\"content-wrapper\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"col-md-8\">\r\n                <h3><span class=\"well well-sm\">Ticket No.:</span> ");
            EndContext();
            BeginContext(544, 14, false);
#line 22 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                             Write(Model.idTicket);

#line default
#line hidden
            EndContext();
            BeginContext(558, 70, true);
            WriteLiteral("</h3>\r\n                <h3><span class=\"well well-sm\"> Asunto: </span>");
            EndContext();
            BeginContext(629, 12, false);
#line 23 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                          Write(Model.asunto);

#line default
#line hidden
            EndContext();
            BeginContext(641, 74, true);
            WriteLiteral("</h3>\r\n                <h3><span class=\"well well-sm\"> Comentario:</span> ");
            EndContext();
            BeginContext(716, 16, false);
#line 24 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                              Write(Model.comentario);

#line default
#line hidden
            EndContext();
            BeginContext(732, 72, true);
            WriteLiteral("</h3>\r\n                <h3> <span class=\"well well-sm\">Servicio: </span>");
            EndContext();
            BeginContext(805, 22, false);
#line 25 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                            Write(ViewBag.servicioNombre);

#line default
#line hidden
            EndContext();
            BeginContext(827, 77, true);
            WriteLiteral("</h3>\r\n                <h3><span class=\"well well-sm\">Fecha creacion:</span> ");
            EndContext();
            BeginContext(905, 52, false);
#line 26 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                                 Write(Model.fechaCreacion.ToString("h:mm tt MMMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(957, 69, true);
            WriteLiteral("</h3>\r\n                <h3><span class=\"well well-sm\">Estado:</span> ");
            EndContext();
            BeginContext(1027, 20, false);
#line 27 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                         Write(ViewBag.estadoNombre);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 513, true);
            WriteLiteral(@"</h3>

                <hr style=""color: #0056b2;"" />
                <h3>Respuestas: </h3>
                <table border=""0"" id=""respuestas"" style=""background-color:#FFFFE0;"" width=""50%""></table>
                <hr style=""color: #0056b2;"" />
            </div>
            <div class=""col-md-4"">
                <center><h3>Archivos: </h3></center>

                <table border=""0"" id=""requeridos"" width=""100%"">
                </table>

            </div>

        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1581, 305, true);
                WriteLiteral(@"
        <script>
            $(function () {
                cargar('#requeridos');
                cargarRespuestas('#respuestas');
            });
            function cargar(classSelect) {
                $.ajax({
                    
                    url: ""/ticket/GetArchivosJson?Id="" + ");
                EndContext();
                BeginContext(1887, 14, false);
#line 54 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                    Write(Model.idTicket);

#line default
#line hidden
                EndContext();
                BeginContext(1901, 1115, true);
                WriteLiteral(@",
                    success: function (result) {
                        var li = $(classSelect);
                        if (result.length > 0) {
                            li.find('tr').remove();
                            $.each(result, function (i,itema) {
                                // li.append('<li>' + itema.nombre + '</li>');
                                li.append('<tr><td><div class=""panel panel-danger panel-dark panel-body-colorful widget-profile widget-profile-centered""><img src=""../../img/no_imagen.png"" class=""widget-profile-avatar"">'
                                    + '<a href=""../../archivos/' + itema.archivo + '"" target=""_blank"">Ver Archivo </a></div></td></tr>');
                            });
                        }
                        else {
                            //li.find('tr').remove();
                        }
                    }
                });
            }

                    function cargarRespuestas(classSelect) {
                ");
                WriteLiteral("$.ajax({\r\n                    \r\n                    url: \"/ticket/GetRespuestasJson?Id=\" + ");
                EndContext();
                BeginContext(3017, 14, false);
#line 75 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Ticket\Detail.cshtml"
                                                      Write(Model.idTicket);

#line default
#line hidden
                EndContext();
                BeginContext(3031, 706, true);
                WriteLiteral(@",
                    success: function (result) {
                        var li = $(classSelect);
                        if (result.length > 0) {
                            li.find('tr').remove();
                            $.each(result, function (i,itema) {
                                // li.append('<li>' + itema.nombre + '</li>');
                                li.append('<tr><td><h4>-' + itema.mensaje + '</h4></td></tr>');
                            });
                        }
                        else {
                            //li.find('tr').remove();
                        }
                    }
                });
            }

        </script>
    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SAUU.Data.Entities.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
