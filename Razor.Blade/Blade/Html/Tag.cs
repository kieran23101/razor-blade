﻿using System;
using System.Collections.Generic;
using System.IO;
#if NET40
    using IHtmlString = System.Web.IHtmlString;
    using HtmlString = System.Web.HtmlString;
#else
using IHtmlString = Microsoft.AspNetCore.Html.IHtmlContent;
    using HtmlString = Microsoft.AspNetCore.Html.HtmlString;
    using HtmlEncoder = System.Text.Encodings.Web.HtmlEncoder;
#endif

namespace Connect.Razor.Blade.Html
{
    public class Tag: IHtmlString
    {
        /// <inheritdoc />
        public Tag() { }

        public Tag(string name)
        {
            Name = name;
        }

        internal Tag(string name = null, string attributes = null, string content = null)
        {

        }

        /// <summary>
        /// The tag name
        /// </summary>
        public string Name = "div";

        /// <summary>
        /// List of attributes of this tag
        /// </summary>
        public AttributeList Attributes { get; } = new AttributeList();

        /// <summary>
        /// The contents of this tag
        /// </summary>
        public string Content = string.Empty;

        /// <summary>
        /// Optional ID, if null, will not be generated, otherwise will be added
        /// </summary>
        public string Id = null;

        /// <summary>
        /// Optional class names - if null, will not generate the class-attribute
        /// </summary>
        public string Classes = null;

        #region ToString and ToHtml for all interfaces

        /// <summary>
        /// Gets the HTML encoded value.
        /// </summary>
        public string Value => TagBuilder.Tag(Name, attributes: Attributes, content: Content);

#if NET40
        /// <summary>
        /// This is the serialization for the old-style asp.net razor
        /// </summary>
        /// <returns></returns>
        public string ToHtmlString() => ToString();
#else

        /// <inheritdoc />
        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            // was in original file but seems unused https://github.com/aspnet/AspNetCore/blob/6cc9f6f130af4ed0e7f321b144265cfbcec0ceee/src/Html/Abstractions/src/HtmlString.cs
            //if (encoder == null)
            //{
            //    throw new ArgumentNullException(nameof(encoder));
            //}

            writer.Write(Value);
        }
#endif
        public override string ToString() => Value ?? string.Empty;

        #endregion

        #region .Open and .Close

        public HtmlString Open => new HtmlString(TagBuilder.Open(Name, attributes: Attributes, id: Id, classes: Classes));
        public HtmlString Close => new HtmlString(TagBuilder.Close(Name));

        #endregion
    }
}