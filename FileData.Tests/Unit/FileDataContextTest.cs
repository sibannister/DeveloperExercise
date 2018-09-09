using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace FileData.Tests.Unit
{
    [TestFixture]
    class FileDataContextTest
    {
        [Test]
        public void ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new FileDataContext(null));
        }

        [Test]
        public void ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new FileDataContext(new string[] { }));
        }

        [Test]
        public void ShouldThrowFileDetailsOptionSetArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new FileDataContext(new string[2] { "-v", "c:/test" }, null));
        }

        [Test]
        public void ShouldWriteVersion()
        {
            const string version = "EXPECTED_VERSION";
            var filePath = "c:/test";
            var fileDetails = new Mock<IFileDetails>(MockBehavior.Strict);
            fileDetails.Setup(p => p.Version(filePath)).Returns(version);
            var fileDataContext = new FileDataContext(new string[2] { "-v", filePath }, new FileDataOptionSet(), fileDetails.Object);
            var stringWriter = new StringWriter();

            fileDataContext.Write(stringWriter);

            Assert.AreEqual(version, stringWriter.ToString());
            fileDetails.VerifyAll();
        }

        [Test]
        public void ShouldWriteSize()
        {
            const int size = 100000;
            var filePath = "c:/test";
            var fileDetails = new Mock<IFileDetails>(MockBehavior.Strict);
            fileDetails.Setup(p => p.Size(filePath)).Returns(size);
            var fileDataContext = new FileDataContext(new string[2] { "-s", filePath }, new FileDataOptionSet(), fileDetails.Object);
            var stringWriter = new StringWriter();

            fileDataContext.Write(stringWriter);

            Assert.AreEqual(size.ToString(), stringWriter.ToString());
            fileDetails.VerifyAll();
        }

        [Test]
        public void ShouldWriteHelpMessage()
        {
            var fileDataContext = new FileDataContext(new string[2] { "-z", "c:/test" });
            var stringWriter = new StringWriter();

            fileDataContext.Write(stringWriter);

            Assert.That(stringWriter.ToString().Contains(FileDataContext.HelpMessage));
        }
    }
}
