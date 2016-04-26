using NUnit.Framework;
using System;
using Avidity.MarvelTest.Infrastructure.System;
using System.Threading.Tasks;

namespace Avidity.MarvelTest.Infrastructure.FunctionalTests.System
{
    [TestFixture()]
    public class StorySystemTests
    {
		StorySystem m_system;

        [SetUp]
        public void Setup()
        {
			m_system = new StorySystem();
        }

        [Test()]
        public async Task GetResposeAsync_ComicsId_CommicsInfo()
        {
			var actual = await m_system.GetStoryAsync("123");
            Assert.IsNotNull(actual);
			Assert.IsNotNull(actual.Id);
			Assert.IsNotNull(actual.Description);
        }
    }
}

