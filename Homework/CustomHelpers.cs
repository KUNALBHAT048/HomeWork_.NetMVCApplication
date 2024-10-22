using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Microsoft.AspNetCore.Html;

namespace Homework
{
    public static class CustomHelpers
    {
        private const string urlRegEx = @"((http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?)";

        // Main method to display content with hyperlinks
        public static HtmlString DisplayWithLinksFor(string content)
        {
            if (string.IsNullOrEmpty(content)) // Add null/empty check
            {
                return new HtmlString(string.Empty); // Return an empty HtmlString if content is null/empty
            }

            string result = ReplaceUrlsWithLinks(content); // Process URL replacements
            TagBuilder tb = new TagBuilder("p");
            tb.Attributes.Add("style", "white-space: pre-wrap;");
            return new HtmlString(tb.ToString(TagRenderMode.StartTag) + result + tb.ToString(TagRenderMode.EndTag));
        }

        // Helper method to replace URLs in the string with hyperlinks
        private static string ReplaceUrlsWithLinks(string input)
        {
            if (string.IsNullOrEmpty(input)) // Null/empty check to avoid exceptions
            {
                return input; // Return input as it is (null or empty)
            }

            Regex rx = new Regex(urlRegEx);
            string result = rx.Replace(input, match =>
            {
                string url = match.ToString();
                return $"<a target=\"_blank\" href=\"{url}\">{url}</a>";
            });

            return result;
        }

        // Helper to get content from a model using expression
        private static string GetContent<TModel, TProperty>(HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            var model = htmlHelper.ViewData.Model;

            if (model == null)
            {
                return string.Empty; // Return empty string if the model is null
            }

            Func<TModel, TProperty> func = expression.Compile();
            TProperty result = func(model);
            return result?.ToString() ?? string.Empty; // Handle null results
        }
    }
}
