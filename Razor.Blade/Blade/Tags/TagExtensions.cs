﻿// ReSharper disable RedundantArgumentDefaultValue

namespace Connect.Razor.Blade
{
    /// <summary>
    /// Helper commands to enable fluid coding with tags.
    /// This allows you to do things like Tag.Div().Id("myId")
    /// </summary>
    public static class TagExtensions
    {
        /// <summary>
        /// Quickly add an attribute
        /// it always returns the tag itself again, allowing chaining of multiple add-calls
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="name">the attribute name, or a complete value like "name='value'"</param>
        /// <param name="value">optional value - if the attribute already exists, it will be appended</param>
        /// <param name="appendSeparator">attribute appendSeparator in case the value is appended</param>
        /// <returns></returns>
        public static T Attr<T>(this T tag, string name, object value = null, string appendSeparator = null)
            where T: Html.Tag
        {
            tag.TagAttributes.Add(name, value, appendSeparator);
            return tag;
        }


        /// <summary>
        /// ID - set multiple times always overwrites previous ID
        /// </summary>
        public static T Id<T>(this T tag, string id) where T: Html.Tag
            => tag.Attr("id", id, null);

        /// <summary>
        /// class attribute
        /// </summary>
        public static T Class<T>(this T tag, string value) where T: Html.Tag
            => tag.Attr("class", value, " ");

        /// <summary>
        /// style attribute. If called multiple times, will append styles.
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="value">Style to add</param>
        /// <returns></returns>
        public static T Style<T>(this T tag, string value) where T: Html.Tag
            => tag.Attr("style", value, appendSeparator: ";");

        /// <summary>
        /// title attribute
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="value">new title to set</param>
        /// <returns></returns>
        public static T Title<T>(this T tag, string value) where T: Html.Tag
            => tag.Attr("title", value, null);

        /// <summary>
        /// Add a data-... attribute
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="name">the term behind data-, so "name" becomes "data-name"</param>
        /// <param name="value">string or object, objects will be json serialized</param>
        /// <returns></returns>
        public static T Data<T>(this T tag, string name, object value = null) where T: Html.Tag
            => tag.Attr("data-" + name, value, null);

        /// <summary>
        /// Add a onEventName attribute for javascript events
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="name">the term behind data-, so "name" becomes "data-name"</param>
        /// <param name="value">string or object, objects will be json serialized</param>
        /// <returns></returns>
        public static T On<T>(this T tag, string name, object value = null) where T : Html.Tag
            => tag.Attr("on" + name, value, null);


        /// <summary>
        /// Add contents to this tag - at the end of the already added contents.
        /// If you want to replace the contents, use Wrap() instead
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="child"></param>
        /// <returns></returns>
        public static T Add<T>(this T tag, object child) where T : Html.Tag
        {
            tag.TagChildren.Add(child);
            return tag;
        }

        /// <summary>
        /// Add contents to this tag - at the end of the already added contents.
        /// If you want to replace the contents, use Wrap() instead
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="children">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns></returns>
        public static T Add<T>(this T tag, params object[] children) where T : Html.Tag
        {
            tag.TagChildren.Add(children);
            return tag;
        }

        /// <summary>
        /// Wrap the tag around the new content, so this replaces all the content with what you give it
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="content">New content - can be a string, Tag or list of tags</param>
        /// <returns></returns>
        public static T Wrap<T>(this T tag, object content) where T : Html.Tag
        {
            tag.TagChildren.Replace(content);
            return tag;
        }

        /// <summary>
        /// Wrap the tag around the new content, so this replaces all the content with what you give it
        /// </summary>
        /// <param name="tag">the parent tag</param>
        /// <param name="content">a variable amount of tags / strings to add to the contents of this tag</param>
        /// <returns></returns>
        public static T Wrap<T>(this T tag, params object[] content) where T : Html.Tag
        {
            tag.TagChildren.Replace(content);
            return tag;
        }
    }
}