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
    }
}
