#pragma checksum "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f862e8933fed61afe98795ea0303f85807a173"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_GetEvents), @"mvc.1.0.view", @"/Views/Event/GetEvents.cshtml")]
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
#line 1 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\_ViewImports.cshtml"
using Nagarro.BookReading.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f862e8933fed61afe98795ea0303f85807a173", @"/Views/Event/GetEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20a1b69223e6b1c0b253c2fcdf9856c5d56b091", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_GetEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Nagarro.BookReading.Web.Models.EventViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NewestEventFirst", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
   
    var user = await _userManager.GetUserAsync(User);
    var email = user!= null ? user.Email : "";


#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 12 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h4 class=\"text-info\">No Events to display</h4>\r\n        </div>\r\n");
#nullable restore
#line 17 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p></p>\r\n        <p></p>\r\n");
#nullable restore
#line 22 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
         if (email == "myadmin@bookevents.com")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-primary\">All Events</h2>\r\n            <hr class=\"border-dark\" />\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 27 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                 foreach (var _event in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13f862e8933fed61afe98795ea0303f85807a1735433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 32 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-primary\">All public Events</h2>\r\n            <hr class=\"border-dark\" />\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 39 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                 foreach (var _event in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                     if (_event.eventType == "Public")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13f862e8933fed61afe98795ea0303f85807a1738173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 43 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                     


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 49 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
         if (_signInManager.IsSignedIn(User))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
             if (email != "myadmin@bookevents.com")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""container"">
                    <div class=""container"">
                        <p></p>
                        <h4>You are invited in the Events below : </h4>
                        <hr />
                        <h3 class=""text-success"">Upcoming Events</h3>
                        <hr class=""border-dark"" />
                        <p></p>
                        <p></p>
                        <div class=""row"">

");
#nullable restore
#line 68 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                             foreach (var _event in Model)
                            {
                                if (@_event.invitees.Split(',').Contains(email) && _event.eventType == "Private" && _event.date > DateTime.Now)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13f862e8933fed61afe98795ea0303f85807a17311850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 73 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                                }


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""container"">
                        <h3 class=""text-success"">Past Events</h3>
                        <hr class=""border-dark"" />
                        <p></p>
                        <p></p>
                        <div class=""row"">

");
#nullable restore
#line 88 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                             foreach (var _event in Model)
                            {
                                if (@_event.invitees.Split(',').Contains(email) && _event.eventType == "Private" && _event.date < DateTime.Now)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13f862e8933fed61afe98795ea0303f85807a17314540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 93 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = _event;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 102 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\Practice\Book-Reading-Event\Nagarro.BookReading.Web\Views\Event\GetEvents.cshtml"
         


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Nagarro.BookReading.Web.Models.EventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
