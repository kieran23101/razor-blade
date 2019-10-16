using System;
using Connect.Razor.Blade;
using Connect.Razor.Html;
// ****
// ****
// This is auto-generated code - don't modify
// Re-run the generation program to recreate
// Created 16.10.2019 22:10
//
// Each tag and attributes of it prepare code, and they return an object of the same type again
// to allow fluid chaining of the commands
// ****
// ****
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
namespace Connect.Razor.Html5
{

    /// <summary>
    /// Generate a standard HTML5 &lt;button&gt; tag
    /// </summary>
    /// <returns>
    /// A Button object with all the attributes available in that tag
    /// </returns>
    public partial class Button : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;button&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Button(object content = null) : base("button", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;button&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Button object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Button(params object[] content) : base("button", null, content)
    {
    }
    
    /// <summary>
    /// Set the autofocus attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in autofocus='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Autofocus(string value) => this.Attr("autofocus", value);




    /// <summary>
    /// Activate the autofocus attribute on the &lt;button&gt; tag
    /// </summary>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Autofocus() => this.Attr("autofocus");


    /// <summary>
    /// Set the disabled attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in disabled='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Disabled(string value) => this.Attr("disabled", value);




    /// <summary>
    /// Activate the disabled attribute on the &lt;button&gt; tag
    /// </summary>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Disabled() => this.Attr("disabled");


    /// <summary>
    /// Set the form attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the formaction attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in formaction='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Formaction(string value) => this.Attr("formaction", value);




    /// <summary>
    /// Set the formenctype attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in formenctype='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Formenctype(string value) => this.Attr("formenctype", value);




    /// <summary>
    /// Set the formmethod attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in formmethod='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Formmethod(string value) => this.Attr("formmethod", value);




    /// <summary>
    /// Set the formnovalidate attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in formnovalidate='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Formnovalidate(string value) => this.Attr("formnovalidate", value);




    /// <summary>
    /// Activate the formnovalidate attribute on the &lt;button&gt; tag
    /// </summary>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Formnovalidate() => this.Attr("formnovalidate");


    /// <summary>
    /// Set the formtarget attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in formtarget='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Formtarget(string value) => this.Attr("formtarget", value);




    /// <summary>
    /// Set the name attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the type attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Type(string value) => this.Attr("type", value);




    /// <summary>
    /// Set the value attribute on the &lt;button&gt; tag
    /// </summary>
    /// <param name="value">what should be in value='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Button object to enable fluid command chaining</returns>
        public Button Value(string value) => this.Attr("value", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;datalist&gt; tag
    /// </summary>
    /// <returns>
    /// A Datalist object with all the attributes available in that tag
    /// </returns>
    public partial class Datalist : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;datalist&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Datalist(object content = null) : base("datalist", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;datalist&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Datalist object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Datalist(params object[] content) : base("datalist", null, content)
    {
    }
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;fieldset&gt; tag
    /// </summary>
    /// <returns>
    /// A Fieldset object with all the attributes available in that tag
    /// </returns>
    public partial class Fieldset : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;fieldset&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Fieldset(object content = null) : base("fieldset", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;fieldset&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Fieldset object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Fieldset(params object[] content) : base("fieldset", null, content)
    {
    }
    
    /// <summary>
    /// Set the disabled attribute on the &lt;fieldset&gt; tag
    /// </summary>
    /// <param name="value">what should be in disabled='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Fieldset object to enable fluid command chaining</returns>
        public Fieldset Disabled(string value) => this.Attr("disabled", value);




    /// <summary>
    /// Activate the disabled attribute on the &lt;fieldset&gt; tag
    /// </summary>
    /// <returns>a Fieldset object to enable fluid command chaining</returns>
        public Fieldset Disabled() => this.Attr("disabled");


    /// <summary>
    /// Set the form attribute on the &lt;fieldset&gt; tag
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Fieldset object to enable fluid command chaining</returns>
        public Fieldset Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the name attribute on the &lt;fieldset&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Fieldset object to enable fluid command chaining</returns>
        public Fieldset Name(string value) => this.Attr("name", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;form&gt; tag
    /// </summary>
    /// <returns>
    /// A Form object with all the attributes available in that tag
    /// </returns>
    public partial class Form : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;form&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Form(object content = null) : base("form", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;form&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Form object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Form(params object[] content) : base("form", null, content)
    {
    }
    
    /// <summary>
    /// Set the accept-charset attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in accept-charset='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form AcceptCharset(string value) => this.Attr("accept-charset", value);




    /// <summary>
    /// Set the action attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in action='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Action(string value) => this.Attr("action", value);




    /// <summary>
    /// Set the autocomplete attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in autocomplete='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Autocomplete(string value) => this.Attr("autocomplete", value);




    /// <summary>
    /// Set the enctype attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in enctype='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Enctype(string value) => this.Attr("enctype", value);




    /// <summary>
    /// Set the method attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in method='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Method(string value) => this.Attr("method", value);




    /// <summary>
    /// Set the name attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the novalidate attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in novalidate='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Novalidate(string value) => this.Attr("novalidate", value);




    /// <summary>
    /// Activate the novalidate attribute on the &lt;form&gt; tag
    /// </summary>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Novalidate() => this.Attr("novalidate");


    /// <summary>
    /// Set the target attribute on the &lt;form&gt; tag
    /// </summary>
    /// <param name="value">what should be in target='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Form object to enable fluid command chaining</returns>
        public Form Target(string value) => this.Attr("target", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;input&gt; tag
    /// </summary>
    /// <returns>
    /// A Input object with all the attributes available in that tag
    /// </returns>
    public partial class Input : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;input&gt; tag with optional contents
    /// </summary>
    
    public Input() : base("input", new TagOptions { Close = false })
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;input&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Input object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Input(params object[] content) : base("input", new TagOptions { Close = false }, content)
    {
    }
    
    /// <summary>
    /// Set the accept attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in accept='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Accept(string value) => this.Attr("accept", value);




    /// <summary>
    /// Set the alt attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in alt='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Alt(string value) => this.Attr("alt", value);




    /// <summary>
    /// Set the autocomplete attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in autocomplete='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Autocomplete(string value) => this.Attr("autocomplete", value);




    /// <summary>
    /// Set the autofocus attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in autofocus='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Autofocus(string value) => this.Attr("autofocus", value);




    /// <summary>
    /// Activate the autofocus attribute on the &lt;input&gt; tag
    /// </summary>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Autofocus() => this.Attr("autofocus");


    /// <summary>
    /// Set the checked attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in checked='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Checked(string value) => this.Attr("checked", value);




    /// <summary>
    /// Activate the checked attribute on the &lt;input&gt; tag
    /// </summary>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Checked() => this.Attr("checked");


    /// <summary>
    /// Set the dirname attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in dirname='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Dirname(string value) => this.Attr("dirname", value);




    /// <summary>
    /// Set the disabled attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in disabled='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Disabled(string value) => this.Attr("disabled", value);




    /// <summary>
    /// Activate the disabled attribute on the &lt;input&gt; tag
    /// </summary>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Disabled() => this.Attr("disabled");


    /// <summary>
    /// Set the form attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the formaction attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in formaction='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Formaction(string value) => this.Attr("formaction", value);




    /// <summary>
    /// Set the formenctype attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in formenctype='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Formenctype(string value) => this.Attr("formenctype", value);




    /// <summary>
    /// Set the formmethod attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in formmethod='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Formmethod(string value) => this.Attr("formmethod", value);




    /// <summary>
    /// Set the formnovalidate attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in formnovalidate='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Formnovalidate(string value) => this.Attr("formnovalidate", value);




    /// <summary>
    /// Activate the formnovalidate attribute on the &lt;input&gt; tag
    /// </summary>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Formnovalidate() => this.Attr("formnovalidate");


    /// <summary>
    /// Set the formtarget attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in formtarget='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Formtarget(string value) => this.Attr("formtarget", value);




    /// <summary>
    /// Set the height attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in height='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Height(string value) => this.Attr("height", value);




    /// <summary>
    /// Set the list attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in list='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input List(string value) => this.Attr("list", value);




    /// <summary>
    /// Set the max attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in max='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Max(string value) => this.Attr("max", value);




    /// <summary>
    /// Set the maxlength attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in maxlength='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Maxlength(string value) => this.Attr("maxlength", value);




    /// <summary>
    /// Set the min attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in min='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Min(string value) => this.Attr("min", value);




    /// <summary>
    /// Set the multiple attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in multiple='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Multiple(string value) => this.Attr("multiple", value);




    /// <summary>
    /// Activate the multiple attribute on the &lt;input&gt; tag
    /// </summary>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Multiple() => this.Attr("multiple");


    /// <summary>
    /// Set the name attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the pattern attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in pattern='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Pattern(string value) => this.Attr("pattern", value);




    /// <summary>
    /// Set the placeholder attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in placeholder='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Placeholder(string value) => this.Attr("placeholder", value);




    /// <summary>
    /// Set the readonly attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in readonly='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Readonly(string value) => this.Attr("readonly", value);




    /// <summary>
    /// Activate the readonly attribute on the &lt;input&gt; tag
    /// </summary>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Readonly() => this.Attr("readonly");


    /// <summary>
    /// Set the required attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in required='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Required(string value) => this.Attr("required", value);




    /// <summary>
    /// Activate the required attribute on the &lt;input&gt; tag
    /// </summary>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Required() => this.Attr("required");


    /// <summary>
    /// Set the size attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in size='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Size(string value) => this.Attr("size", value);




    /// <summary>
    /// Set the src attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in src='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Src(string value) => this.Attr("src", value);




    /// <summary>
    /// Set the step attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in step='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Step(string value) => this.Attr("step", value);




    /// <summary>
    /// Set the type attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in type='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Type(string value) => this.Attr("type", value);




    /// <summary>
    /// Set the value attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in value='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Value(string value) => this.Attr("value", value);




    /// <summary>
    /// Set the width attribute on the &lt;input&gt; tag
    /// </summary>
    /// <param name="value">what should be in width='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Input object to enable fluid command chaining</returns>
        public Input Width(string value) => this.Attr("width", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;label&gt; tag
    /// </summary>
    /// <returns>
    /// A Label object with all the attributes available in that tag
    /// </returns>
    public partial class Label : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;label&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Label(object content = null) : base("label", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;label&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Label object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Label(params object[] content) : base("label", null, content)
    {
    }
    
    /// <summary>
    /// Set the for attribute on the &lt;label&gt; tag
    /// </summary>
    /// <param name="value">what should be in for='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Label object to enable fluid command chaining</returns>
        public Label For(string value) => this.Attr("for", value);




    /// <summary>
    /// Set the form attribute on the &lt;label&gt; tag
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Label object to enable fluid command chaining</returns>
        public Label Form(string value) => this.Attr("form", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;legend&gt; tag
    /// </summary>
    /// <returns>
    /// A Legend object with all the attributes available in that tag
    /// </returns>
    public partial class Legend : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;legend&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Legend(object content = null) : base("legend", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;legend&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Legend object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Legend(params object[] content) : base("legend", null, content)
    {
    }
    
    }

    /// <summary>
    /// Generate a standard HTML5 &lt;optgroup&gt; tag
    /// </summary>
    /// <returns>
    /// A Optgroup object with all the attributes available in that tag
    /// </returns>
    public partial class Optgroup : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;optgroup&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Optgroup(object content = null) : base("optgroup", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;optgroup&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Optgroup object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Optgroup(params object[] content) : base("optgroup", null, content)
    {
    }
    
    /// <summary>
    /// Set the disabled attribute on the &lt;optgroup&gt; tag
    /// </summary>
    /// <param name="value">what should be in disabled='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Optgroup object to enable fluid command chaining</returns>
        public Optgroup Disabled(string value) => this.Attr("disabled", value);




    /// <summary>
    /// Activate the disabled attribute on the &lt;optgroup&gt; tag
    /// </summary>
    /// <returns>a Optgroup object to enable fluid command chaining</returns>
        public Optgroup Disabled() => this.Attr("disabled");


    /// <summary>
    /// Set the label attribute on the &lt;optgroup&gt; tag
    /// </summary>
    /// <param name="value">what should be in label='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Optgroup object to enable fluid command chaining</returns>
        public Optgroup Label(string value) => this.Attr("label", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;option&gt; tag
    /// </summary>
    /// <returns>
    /// A Option object with all the attributes available in that tag
    /// </returns>
    public partial class Option : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;option&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Option(object content = null) : base("option", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;option&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Option object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Option(params object[] content) : base("option", null, content)
    {
    }
    
    /// <summary>
    /// Set the disabled attribute on the &lt;option&gt; tag
    /// </summary>
    /// <param name="value">what should be in disabled='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Option object to enable fluid command chaining</returns>
        public Option Disabled(string value) => this.Attr("disabled", value);




    /// <summary>
    /// Activate the disabled attribute on the &lt;option&gt; tag
    /// </summary>
    /// <returns>a Option object to enable fluid command chaining</returns>
        public Option Disabled() => this.Attr("disabled");


    /// <summary>
    /// Set the label attribute on the &lt;option&gt; tag
    /// </summary>
    /// <param name="value">what should be in label='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Option object to enable fluid command chaining</returns>
        public Option Label(string value) => this.Attr("label", value);




    /// <summary>
    /// Set the selected attribute on the &lt;option&gt; tag
    /// </summary>
    /// <param name="value">what should be in selected='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Option object to enable fluid command chaining</returns>
        public Option Selected(string value) => this.Attr("selected", value);




    /// <summary>
    /// Activate the selected attribute on the &lt;option&gt; tag
    /// </summary>
    /// <returns>a Option object to enable fluid command chaining</returns>
        public Option Selected() => this.Attr("selected");


    /// <summary>
    /// Set the value attribute on the &lt;option&gt; tag
    /// </summary>
    /// <param name="value">what should be in value='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Option object to enable fluid command chaining</returns>
        public Option Value(string value) => this.Attr("value", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;output&gt; tag
    /// </summary>
    /// <returns>
    /// A Output object with all the attributes available in that tag
    /// </returns>
    public partial class Output : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;output&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Output(object content = null) : base("output", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;output&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Output object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Output(params object[] content) : base("output", null, content)
    {
    }
    
    /// <summary>
    /// Set the for attribute on the &lt;output&gt; tag
    /// </summary>
    /// <param name="value">what should be in for='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Output object to enable fluid command chaining</returns>
        public Output For(string value) => this.Attr("for", value);




    /// <summary>
    /// Set the form attribute on the &lt;output&gt; tag
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Output object to enable fluid command chaining</returns>
        public Output Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the name attribute on the &lt;output&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Output object to enable fluid command chaining</returns>
        public Output Name(string value) => this.Attr("name", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;select&gt; tag
    /// </summary>
    /// <returns>
    /// A Select object with all the attributes available in that tag
    /// </returns>
    public partial class Select : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;select&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Select(object content = null) : base("select", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;select&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Select object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Select(params object[] content) : base("select", null, content)
    {
    }
    
    /// <summary>
    /// Set the autofocus attribute on the &lt;select&gt; tag
    /// </summary>
    /// <param name="value">what should be in autofocus='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Autofocus(string value) => this.Attr("autofocus", value);




    /// <summary>
    /// Activate the autofocus attribute on the &lt;select&gt; tag
    /// </summary>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Autofocus() => this.Attr("autofocus");


    /// <summary>
    /// Set the disabled attribute on the &lt;select&gt; tag
    /// </summary>
    /// <param name="value">what should be in disabled='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Disabled(string value) => this.Attr("disabled", value);




    /// <summary>
    /// Activate the disabled attribute on the &lt;select&gt; tag
    /// </summary>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Disabled() => this.Attr("disabled");


    /// <summary>
    /// Set the form attribute on the &lt;select&gt; tag
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the multiple attribute on the &lt;select&gt; tag
    /// </summary>
    /// <param name="value">what should be in multiple='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Multiple(string value) => this.Attr("multiple", value);




    /// <summary>
    /// Activate the multiple attribute on the &lt;select&gt; tag
    /// </summary>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Multiple() => this.Attr("multiple");


    /// <summary>
    /// Set the name attribute on the &lt;select&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the required attribute on the &lt;select&gt; tag
    /// </summary>
    /// <param name="value">what should be in required='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Required(string value) => this.Attr("required", value);




    /// <summary>
    /// Activate the required attribute on the &lt;select&gt; tag
    /// </summary>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Required() => this.Attr("required");


    /// <summary>
    /// Set the size attribute on the &lt;select&gt; tag
    /// </summary>
    /// <param name="value">what should be in size='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Select object to enable fluid command chaining</returns>
        public Select Size(string value) => this.Attr("size", value);




    }

    /// <summary>
    /// Generate a standard HTML5 &lt;textarea&gt; tag
    /// </summary>
    /// <returns>
    /// A Textarea object with all the attributes available in that tag
    /// </returns>
    public partial class Textarea : Connect.Razor.Html.Tag
    {
    
    /// <summary>
    /// Generate an &lt;textarea&gt; tag with optional contents
    /// </summary>
    /// <param name="content">content which will be inside the tag</param>
    public Textarea(object content = null) : base("textarea", content)
    {
    }
    
    
    /// <summary>
    /// Generate a standard HTML5 &lt;textarea&gt; tag with optional contents
    /// </summary>
    /// <returns>
    /// A Textarea object with all the attributes available in that tag
    /// </returns>
    /// <param name="content">one or more objects (strings or tags) which will be inside the tag</param>
    public Textarea(params object[] content) : base("textarea", null, content)
    {
    }
    
    /// <summary>
    /// Set the autofocus attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in autofocus='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Autofocus(string value) => this.Attr("autofocus", value);




    /// <summary>
    /// Activate the autofocus attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Autofocus() => this.Attr("autofocus");


    /// <summary>
    /// Set the cols attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in cols='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Cols(string value) => this.Attr("cols", value);




    /// <summary>
    /// Set the dirname attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in dirname='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Dirname(string value) => this.Attr("dirname", value);




    /// <summary>
    /// Set the disabled attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in disabled='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Disabled(string value) => this.Attr("disabled", value);




    /// <summary>
    /// Activate the disabled attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Disabled() => this.Attr("disabled");


    /// <summary>
    /// Set the form attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in form='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Form(string value) => this.Attr("form", value);




    /// <summary>
    /// Set the maxlength attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in maxlength='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Maxlength(string value) => this.Attr("maxlength", value);




    /// <summary>
    /// Set the name attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in name='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Name(string value) => this.Attr("name", value);




    /// <summary>
    /// Set the placeholder attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in placeholder='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Placeholder(string value) => this.Attr("placeholder", value);




    /// <summary>
    /// Set the readonly attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in readonly='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Readonly(string value) => this.Attr("readonly", value);




    /// <summary>
    /// Activate the readonly attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Readonly() => this.Attr("readonly");


    /// <summary>
    /// Set the required attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in required='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Required(string value) => this.Attr("required", value);




    /// <summary>
    /// Activate the required attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Required() => this.Attr("required");


    /// <summary>
    /// Set the rows attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in rows='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Rows(string value) => this.Attr("rows", value);




    /// <summary>
    /// Set the wrap attribute on the &lt;textarea&gt; tag
    /// </summary>
    /// <param name="value">what should be in wrap='...'.
    /// If called multiple times, later values replace the previous value.</param>
    /// <returns>a Textarea object to enable fluid command chaining</returns>
        public Textarea Wrap(string value) => this.Attr("wrap", value);




    }
}