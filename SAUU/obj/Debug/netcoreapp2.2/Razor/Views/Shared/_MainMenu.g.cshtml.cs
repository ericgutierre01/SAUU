#pragma checksum "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Shared\_MainMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678333890fb3f914626cecca4e9e880e066aaa90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MainMenu), @"mvc.1.0.view", @"/Views/Shared/_MainMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MainMenu.cshtml", typeof(AspNetCore.Views_Shared__MainMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678333890fb3f914626cecca4e9e880e066aaa90", @"/Views/Shared/_MainMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d423af3ef592bc32fbb21265cf81e627697dc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MainMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 713, true);
            WriteLiteral(@"

<div id=""main-menu"" role=""navigation"">
    <div class=""slimScrollDiv"" style=""position: relative; overflow: hidden; width: auto; height: 100%;"">
        <div id=""main-menu-inner"" style=""overflow: hidden; width: auto; height: 100%;"">
            <div class=""menu-content top animated fadeIn"" id=""menu-content-demo"">
                <!-- Menu custom content demo
                     CSS:        styles/pixel-admin-less/demo.less or styles/pixel-admin-scss/_demo.scss
                     Javascript: html/assets/demo/demo.js
                 -->
                <div class=""text-bg"">
                    <span class=""text-slim"">Bienvenido</span> <br />
                    <span class=""text-semibold"">");
            EndContext();
            BeginContext(714, 18, false);
#line 13 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Shared\_MainMenu.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(732, 865, true);
            WriteLiteral(@"</span>
                </div>
            </div>
            <ul class=""navigation"">

              <!-- <li class=""mm-dropdown mm-dropdown-root"">
                    <a href=""#""><i class=""menu-icon fa fa-table""></i><span class=""mm-text mmc-dropdown-delay animated fadeIn"">Formularios</span></a>
                    <ul class=""mmc-dropdown-delay animated fadeInLeft"">
                        <li>
                            <a tabindex=""-1"" id=""Ticket"" style=""display: block"" asp-controller=""Ticket"" asp-action=""Index"">
                                <i class=""menu-icon fa fa-users""></i>
                                <span class=""mm-text"">Tickets</span>
                            </a>
                        </li>

                    </ul>
                </li>

                <li class=""mm-dropdown mm-dropdown-root"" style=""display: ");
            EndContext();
            BeginContext(1599, 70, false);
#line 31 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Shared\_MainMenu.cshtml"
                                                                     Write(User.FindFirst(x => x.Type == "idRol").Value == "1" ? "none" : "block");

#line default
#line hidden
            EndContext();
            BeginContext(1670, 1370, true);
            WriteLiteral(@" ;"">
                    <a href=""#""><i class=""menu-icon fa fa-sliders""></i><span class=""mm-text mmc-dropdown-delay animated fadeIn"">Configuración</span></a>
                    <ul class=""mmc-dropdown-delay animated fadeInLeft"">
                        <li>
                            <a tabindex=""-1"" asp-controller=""Estado"" asp-action=""Index"">
                                <i class=""menu-icon fa fa-code-fork""></i>
                                <span class=""mm-text"">Estados</span>
                            </a>
                        </li>

                        <li>
                            <a tabindex=""-1"" asp-controller=""TipoPersonas"" asp-action=""Index"">
                                <i class=""menu-icon fa fa-code-fork""></i>
                                <span class=""mm-text"">Tipos de Usuario</span>
                            </a>
                        </li>
                        <li>
                            <a tabindex=""-1"" asp-controller=""Servicios"" asp-action=""");
            WriteLiteral(@"Index"">
                                <i class=""menu-icon fa fa-code-fork""></i>
                                <span class=""mm-text"">Servicios</span>
                            </a>
                        </li>
                    </ul>
                </li>

                <li class=""mm-dropdown mm-dropdown-root"" style=""display: ");
            EndContext();
            BeginContext(3042, 70, false);
#line 56 "C:\Users\Eric Gutierrez\source\repos\Web\SAUU\SAUU\SAUU\Views\Shared\_MainMenu.cshtml"
                                                                     Write(User.FindFirst(x => x.Type == "idRol").Value == "1" ? "none" : "block");

#line default
#line hidden
            EndContext();
            BeginContext(3113, 1357, true);
            WriteLiteral(@" ;"">
                    <a href=""#""><i class=""menu-icon fa fa-table""></i><span class=""mm-text mmc-dropdown-delay animated fadeIn"">Usuarios</span></a>
                    <ul class=""mmc-dropdown-delay animated fadeInLeft"">
                        
                        <li>
                            <a tabindex=""-1"" id=""Usuario"" style=""display: block"" asp-controller=""Persona"" asp-action=""Index"">
                                <i class=""menu-icon fa fa-users""></i>
                                <span class=""mm-text"">Personas</span>
                            </a>
                        </li>

                    </ul>
                </li> -->

                <li class=""mm-dropdown mm-dropdown-root"">
                    <a href=""#""><i class=""menu-icon fa fa-table""></i><span class=""mm-text mmc-dropdown-delay animated fadeIn"">Formularios</span></a>
                    <ul class=""mmc-dropdown-delay animated fadeInLeft"" id=""prueba"">


                    </ul>
                </li>
  ");
            WriteLiteral(@"              <li class=""mm-dropdown mm-dropdown-root"">
                    <a href=""#""><i class=""menu-icon fa fa-coffee""></i><span class=""mm-text mmc-dropdown-delay animated fadeIn"">About</span></a>
                    <ul class=""mmc-dropdown-delay animated fadeInLeft"">
                        <li>
                            ");
            EndContext();
            BeginContext(4470, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678333890fb3f914626cecca4e9e880e066aaa9010817", async() => {
                BeginContext(4554, 186, true);
                WriteLiteral("\r\n                                <i class=\"menu-icon fa fa-users\"></i>\r\n                                <span class=\"mm-text\">Sobre el desarrollador</span>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("i", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4744, 600, true);
            WriteLiteral(@"
                        </li>

                    </ul>
                </li>
            </ul> <!-- / .navigation -->
        </div>
        <div class=""slimScrollBar"" style=""background: rgb(0, 0, 0); width: 7px; position: absolute; top: 0px; opacity: 0.4; display: none; border-radius: 7px; z-index: 99; right: 1px; height: 582px;""></div><div class=""slimScrollRail"" style=""width: 7px; height: 100%; position: absolute; top: 0px; display: none; border-radius: 7px; background: rgb(51, 51, 51); opacity: 0.2; z-index: 90; right: 1px;""></div>
    </div> <!-- / #main-menu-inner -->
</div>
");
            EndContext();
            BeginContext(5344, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "678333890fb3f914626cecca4e9e880e066aaa9013665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5399, 862, true);
            WriteLiteral(@"
<script>
    $(function () {
        cargarMenu('#prueba');
    });
    function cargarMenu(classSelect) {
        $.ajax({
            url: ""/account/GetModulosJson"",
            success: function (result) {
                var li = $(classSelect);
                if (result.length > 0) {
                    li.find('li').remove();
                    $.each(result, function (i, itema) {
                        // li.append('<li>' + itema.nombre + '</li>');
                        li.append('<li><a tabindex=""-1"" href=""../../'+ itema.nombreModulo + '/Index""><i class=""menu-icon fa fa-users""></i><span class=""mm-text"">' + itema.nombreModulo +'</span></a></li>');
                    });
                }
                else {
                    //li.find('tr').remove();
                }
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
