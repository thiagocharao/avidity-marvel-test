using NUnit.Framework;
using System;
using Avidity.MarvelTest.Infrastructure.System;
using System.Threading.Tasks;

namespace Avidity.MarvelTest.Infrastructure.FunctionalTests.System
{
    [TestFixture()]
    public class ComicSystemTests
    {
        ComicsSystem m_system;

        [SetUp]
        public void Setup()
        {
            m_system = new ComicsSystem();
        }

        [Test()]
        public async Task GetResposeAsync_ComicsId_CommicsInfo()
        {
            var actual = await m_system.GetComicsAsync("69");
            Assert.IsNotNull(actual);
            Assert.IsNotNull(actual.Title);
            Assert.IsNotNull(actual.ResourceUri);
        }
    }
}

