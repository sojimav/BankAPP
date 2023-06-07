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
    }
}