using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
