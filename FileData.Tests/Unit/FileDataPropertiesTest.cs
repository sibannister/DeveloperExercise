using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace FileData.Tests.Unit
{
    [TestFixture]
    class FileDataPropertiesTest
    {
        [Test]
        public void ShouldNotThrowExceptionForValidFilePath()
        {
            try
            {
                new FileDataProperties("c:/test");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void ShouldThrowArgumentExceptionWhenNull()
        {
            Assert.Throws<ArgumentException>(() => new FileDataProperties(null));
        }

        [Test]
        public void ShouldThrowArgumentExceptionWhenEmpty()
        {
            Assert.Throws<ArgumentException>(() => new FileDataProperties(String.Empty));
        }

        [Test]
        public void ShouldThrowArgumentExceptionWhenWhitespacesOnly()
        {
            Assert.Throws<ArgumentException>(() => new FileDataProperties("     "));
        }

        [Test]
        public void ShouldThrowArgumentExceptionWhenItContainsIllegalPathCharacters()
        {
            Assert.Throws<ArgumentException>(() => new FileDataProperties(">"));
        }

        [Test]
        public void ShouldThrowArgumentExceptionWhenItContainsIllegalFileNameCharacters()
        {
            var ex = Assert.Throws<ArgumentException>(() => new FileDataProperties("c:/test?"));
            Assert.That(ex.Message.Contains("?"));
        }

        [Test]
        public void ShouldThrowNullArgumentExceptionWhenNullFileDetails()
        {
            Assert.Throws<ArgumentNullException>(() => new FileDataProperties("c:/test", null));
        }

        [Test]
        public void ShouldCallFileDetailsVersionWhenVersionCalled()
        {
            const string version = "EXPECTED_VERSION";
            var filePath = "c:/test";
            var fileDetails = new Mock<IFileDetails>(MockBehavior.Strict);
            fileDetails.Setup(p => p.Version(filePath)).Returns(version);

            var result = new FileDataProperties(filePath, fileDetails.Object).Version();

            Assert.AreEqual(version, result);
            fileDetails.VerifyAll();
        }

        [Test]
        public void ShouldCallFileDetailsSizeWhenSizeCalled()
        {
            const int size = 1;
            var filePath = "c:/test";
            var fileDetails = new Mock<IFileDetails>(MockBehavior.Strict);
            fileDetails.Setup(p => p.Size(filePath)).Returns(size);

            var result = new FileDataProperties(filePath, fileDetails.Object).Size();

            Assert.AreEqual(size, result);
            fileDetails.VerifyAll();
        }
    }
}
