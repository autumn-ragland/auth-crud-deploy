#pragma checksum "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6555132304e02e4e9856e40d0f29b0142ada5a5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book__form), @"mvc.1.0.view", @"/Views/Book/_form.cshtml")]
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
#line 1 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\_ViewImports.cshtml"
using Classwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\_ViewImports.cshtml"
using Classwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6555132304e02e4e9856e40d0f29b0142ada5a5a", @"/Views/Book/_form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608ff8d9849d6836adede9c20af7cc390cf76207", @"/Views/_ViewImports.cshtml")]
    public class Views_Book__form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Classwork.Models.BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class = \"form-group\">\r\n    ");
#nullable restore
#line 6 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.LabelFor(book => book.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 7 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.TextBoxFor(book =>book.title, new { @class = "form-control" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.ValidationMessageFor(book => book.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class = \"form-group\">\r\n    ");
#nullable restore
#line 12 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.LabelFor(book => book.author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.TextBoxFor(book =>book.author, new { @class = "form-control" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.ValidationMessageFor(book => book.author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class = \"form-group\">\r\n    ");
#nullable restore
#line 18 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.LabelFor(book => book.isbn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.TextBoxFor(book =>book.isbn, new { @class = "form-control" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 20 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.ValidationMessageFor(book => book.isbn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class = \"form-check\">\r\n    ");
#nullable restore
#line 24 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.CheckBoxFor(book =>book.isBestSeller, new { @class = "form-check-input" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\prep\auth-crud-deploy\Views\Book\_form.cshtml"
Write(Html.LabelFor(book => book.isBestSeller, new { @class = "form-check-label" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Classwork.Models.BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
