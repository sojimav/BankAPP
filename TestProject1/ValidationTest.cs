using BankAPP;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InitialPromptValidationTest()
        {
            var expected = false;
            Assert.That(expected, Is.EqualTo(Validation.InitialPromptValidation("q")));
        }
    }
}