#pragma checksum "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef2f783e1e174543e4a676d1b6cb1056ac702471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Index), @"mvc.1.0.view", @"/Views/Persona/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Persona/Index.cshtml", typeof(AspNetCore.Views_Persona_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef2f783e1e174543e4a676d1b6cb1056ac702471", @"/Views/Persona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d423af3ef592bc32fbb21265cf81e627697dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SAUU.Models.PersonaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
  
    ViewData["Title"] = "Personas";

#line default
#line hidden
            BeginContext(96, 87, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h1><i class=\"fa fa-bar-chart-o page-header-icon\"></i>");
            EndContext();
            BeginContext(184, 17, false);
#line 8 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                                                     Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(201, 438, true);
            WriteLiteral(@"</h1>
</div> <!-- / .page-header -->
<!--<p>
    <a class=""btn btn-info btn-labeled"" asp-action=""Create""><span class=""btn-label icon fa fa-plus""></span>Agregar Nuevo</a>
</p>-->

<div class=""panel-body"">
    <div class=""table-primary"">
        <table cellpadding=""0"" cellspacing=""0"" border=""0"" class=""table table-striped"" id=""tableJs"">
            <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(640, 49, false);
#line 20 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.nombrePersona));

#line default
#line hidden
            EndContext();
            BeginContext(689, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(769, 51, false);
#line 23 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.apellidoPersona));

#line default
#line hidden
            EndContext();
            BeginContext(820, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(900, 49, false);
#line 26 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.idTipoPersona));

#line default
#line hidden
            EndContext();
            BeginContext(949, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1029, 44, false);
#line 29 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1153, 42, false);
#line 32 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1275, 52, false);
#line 35 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.direccionPersona));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1518, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1603, 48, false);
#line 45 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.nombrePersona));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1743, 50, false);
#line 48 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.apellidoPersona));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1885, 52, false);
#line 51 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.stringTipoPersona));

#line default
#line hidden
            EndContext();
            BeginContext(1937, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2029, 43, false);
#line 54 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.telefono));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2164, 41, false);
#line 57 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.correo));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2297, 51, false);
#line 60 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.direccionPersona));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2439, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef2f783e1e174543e4a676d1b6cb1056ac70247111354", async() => {
                BeginContext(2491, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                                                   WriteLiteral(item.idPersona);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2501, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2533, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef2f783e1e174543e4a676d1b6cb1056ac70247113736", async() => {
                BeginContext(2588, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                                                      WriteLiteral(item.idPersona);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2600, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2632, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef2f783e1e174543e4a676d1b6cb1056ac70247116123", async() => {
                BeginContext(2686, 6, true);
                WriteLiteral("Borrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                                                     WriteLiteral(item.idPersona);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2696, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 68 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Persona\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2775, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2854, 247, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"div.table-caption\").html(\'<a href=\"/Persona/Nuevo\" class=\"btn btn-info btn-labeled\"><span class=\"btn-label icon fa fa-plus\"></span>Agregar Nuevo</a>\');\r\n        });</script>\r\n");
                EndContext();
            }
            );
            BeginContext(3104, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SAUU.Models.PersonaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
