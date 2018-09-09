using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
