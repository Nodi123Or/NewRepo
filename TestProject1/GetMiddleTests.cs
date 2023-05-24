
namespace TestProject1
{
	[TestClass]
	public class GetMiddleTests
	{
		[TestMethod]
		public void TestGetMiddle_ThrowsException_WhenInputTextIsTooShort()
		{
			// Arrange
			string inputText = "";

			// Act & Assert
			Assert.ThrowsException<Exception>(() => MiddleStringFinder.GetMiddle(inputText));
		}

		[TestMethod]
		public void TestGetMiddle_ThrowsException_WhenInputTextIsTooLong()
		{
			// Arrange
			string inputText = new string('a', 1001);

			// Act & Assert
			Assert.ThrowsException<Exception>(() => MiddleStringFinder.GetMiddle(inputText));
		}

		[TestMethod]
		public void TestGetMiddle_ReturnsMiddleCharacter_WhenInputTextIsOddLength()
		{
			// Arrange
			string inputText = "testing";

			// Act
			string result = MiddleStringFinder.GetMiddle(inputText);

			// Assert
			Assert.AreEqual("t", result);
		}

		[TestMethod]
		public void TestGetMiddle_ReturnsMiddleTwoCharacters_WhenInputTextIsEvenLength()
		{
			// Arrange
			string inputText = "test";

			// Act
			string result = MiddleStringFinder.GetMiddle(inputText);

			// Assert
			Assert.AreEqual("es", result);
		}

		[TestMethod]
		public void TestGetMiddle_ReturnsMiddleTwoCharacters_WhenInputTextIsEvenLength_2()
		{
			// Arrange
			string inputText = "middle";

			// Act
			string result = MiddleStringFinder.GetMiddle(inputText);

			// Assert
			Assert.AreEqual("dd", result);
		}

		[TestMethod]
		public void TestGetMiddle_ReturnsMiddleCharacter_WhenInputTextIsOddLength_2()
		{
			// Arrange
			string inputText = "A";

			// Act
			string result = MiddleStringFinder.GetMiddle(inputText);

			// Assert
			Assert.AreEqual("A", result);
		}
	}
}
