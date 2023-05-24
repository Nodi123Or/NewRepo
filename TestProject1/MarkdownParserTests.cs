

namespace TestProject1
{
	[TestClass]
	public class MarkdownParserTests
	{
		[TestMethod]
		public void TestGetHtml_ReturnsHtmlHeaderWithProperFormatting_WhenInputIsHeader_And_1_hashtag()
		{
			// Arrange
			string markdownText = "# Header";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("<h1>Header</h1>", result);
		}


		[TestMethod]
		public void TestGetHtml_ReturnsHtmlHeaderWithProperFormatting_WhenInputIsHeader_And_2_hashtag()
		{
			// Arrange
			string markdownText = "## Header";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("<h2>Header</h2>", result);
		}


		[TestMethod]
		public void TestGetHtml_RReturnsHtmlHeaderWithProperFormatting_WhenInputIsHeader_And_3_hashtag()
		{
			// Arrange
			string markdownText = "### Header";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("<h3>Header</h3>", result);
		}


		[TestMethod]
		public void TestGetHtml_ReturnsHtmlHeaderWithProperFormatting_WhenInputIsHeader_And_4_hashtag()
		{
			// Arrange
			string markdownText = "#### Header";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("<h4>Header</h4>", result);
		}


		[TestMethod]
		public void TestGetHtml_ReturnsHtmlHeaderWithProperFormatting_WhenInputIsHeader_And_5_hashtag()
		{
			// Arrange
			string markdownText = "##### Header";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("<h5>Header</h5>", result);
		}

		[TestMethod]
		public void TestGetHtml_ReturnsHtmlHeaderWithProperFormatting_WhenInputIsHeader_And_6_hashtag()
		{
			// Arrange
			string markdownText = "###### Header";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("<h6>Header</h6>", result);
		}

		[TestMethod]
		public void TestGetHtml_ReturnsHtmlHeaderWithProperFormatting_WhenInputIsHeader()
		{
			// Arrange
			string markdownText = "   ## Header   ";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("   <h2>Header</h2>   ", result);
		}

		[TestMethod]
		public void TestGetHtml_ReturnsInputText_WhenInputIsNotAValidHeader()
		{
			// Arrange
			string markdownText = "   ##  Header   ";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("   ##  Header   ", result);
		}


		[TestMethod]
		public void TestGetHtml_ReturnsInputText_WhenInputIsNotAHeader()
		{
			// Arrange
			string markdownText = "Some text";

			// Act
			string result = MarkdownParser.GetHtml(markdownText);

			// Assert
			Assert.AreEqual("Some text", result);
		}
	}
}
