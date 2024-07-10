using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmAssessment.Tests;

[TestClass]
public class InterpolationTests
{
    [TestMethod]
        public void ReplaceTokens_SimpleReplacement()
        {
            // Arrange
            IFormatter<string, Dictionary<string, string>> formatter = new Formatter();
            string input = "Hello [name], welcome to [place]!";
            var values = new Dictionary<string, string>
            {
                { "name", "John" },
                { "place", "Wonderland" }
            };
            string expected = "Hello John, welcome to Wonderland!";

            // Act
            string result = formatter.FormatInput(input, values);

            // Assert
            Assert.AreEqual(expected, result);
        }
}