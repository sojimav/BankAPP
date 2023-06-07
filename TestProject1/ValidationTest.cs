using BankAPP;
using System.Data.SqlTypes;



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
            var expected = true;
            Assert.That(expected, Is.EqualTo(Validation.InitialPromptValidation("q")));
        }

        [Test]
        public void NameValidationTest()
        {
            var expected = true;
            Assert.That(expected, Is.EqualTo(Validation.NameValidation("Victor")));

        }

        [Test]
        public void EmailValidationTest()
        {
            var expected = true;
            Assert.That(expected, Is.EqualTo(Validation.EmailValidation("mashayete@gmail.com")));
        }

        [Test]
        public void PasswordValidation()
        {
            var expected = true;
            Assert.That(expected, Is.EqualTo(Validation.PasswordValidation("@Mashayete1")));
        }


        [Test]
        public void LoginEmailValidationTest()
        {
            var expected = false;
            Assert.That(expected, Is.EqualTo(Validation.LoginEmailValidation("mashayete@gmail.com", "adesojimav@gmail.com")));
        }

        [Test]
        [TestCase("@Mashayete1", "@Mashayete1", true)]
        [TestCase("@Mashayete1", "@adesoji1", false)]
        [TestCase("@Mashayete1", "@Mashayete", false)]
        public void LoginPasswordValidationTest(string passwordFromCreate, string passwordFromLogining, bool expected)
        {
            bool actual = Validation.LoginPasswordValidation(passwordFromCreate, passwordFromLogining);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        [TestCase("1", false)]
        [TestCase("3", true)]
        [TestCase("4", true)]
        [TestCase("5", true)]
        [TestCase("6", true)]
        [TestCase("7", true)]
        [TestCase("8", true)]
        [TestCase("9", true)]
        [TestCase("C", true)]
        [TestCase("Q", true)]
        public void PromptTest(string value, bool expected)
        {
            bool actual = Validation.Prompt(value);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        [TestCase("2", true)]
        [TestCase("Q", true)]
        [TestCase("a", false)]
        [TestCase("q", true)]
        public void AfterAccPromptTest(string value, bool expected)
        {
            bool actual = Validation.AfterAccPrompt(value);
            Assert.That(expected, Is.EqualTo((bool)actual));
        }

        [Test]
        //[TestCase("12345678789", "Invalid Input, Account number does not exist!")]
        public void CheckAccountNoTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Validation.checkAccountNo("12234345566");
                string expected = "Invalid Input, Account number does not exist!";
                Assert.AreEqual(expected, sw.ToString());
            }

        }

       K

    }
}