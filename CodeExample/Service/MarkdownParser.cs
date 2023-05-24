using System.Text;
using System.Text.RegularExpressions;

namespace CodeExample.Service
{
	public static class MarkdownParser
	{
		public static string GetHtml(string markdownText)
		{
			string openTag = "<";
			string closeTag = ">";
			string rightBeginTag = "</";
			string tagName = "h";

			StringBuilder html = new StringBuilder();

			if (Regex.IsMatch(markdownText, "^\\s*#{1,6} Header\\s*$"))
			{
				var markdownSpecs = markdownText.Trim().Split(' ');

				int numSpacesAtStart = markdownText.Length - markdownText.TrimStart().Length;
				int numSpacesAtEnd = markdownText.Length - markdownText.TrimEnd().Length;

				html.Append(new string(' ', numSpacesAtStart))
					.Append(openTag + tagName + markdownSpecs[0].Length + closeTag)
					.Append( markdownSpecs[1])
					.Append( rightBeginTag + tagName + markdownSpecs[0].Length + closeTag + new string(' ', numSpacesAtEnd));

				return html.ToString();
			}
			else
			{
				return markdownText;
			}
		}
	}
}