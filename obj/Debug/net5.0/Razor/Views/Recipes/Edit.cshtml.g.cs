#pragma checksum "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f19448d7dc6bc3b93eab5e2b1fe782f609b2c110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Edit), @"mvc.1.0.view", @"/Views/Recipes/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19448d7dc6bc3b93eab5e2b1fe782f609b2c110", @"/Views/Recipes/Edit.cshtml")]
    public class Views_Recipes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<h4>Edit this task: ");
#nullable restore
#line 9 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
Write(Html.HiddenFor(model => model.RecipeId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
Write(Html.Label("Select Tag: "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
Write(Html.DropDownList("TagId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" required/>\r\n");
#nullable restore
#line 22 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3><strong>");
#nullable restore
#line 24 "C:\Users\ultra\desktop\RecipeBox\Views\Recipes\Edit.cshtml"
       Write(Html.ActionLink("BACK TO LIST", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
