using System.Threading.Tasks;
using System.Web.Mvc;
using Avidity.MarvelTest.Domain.Characters;
using Avidity.MarvelTest.Domain.Stories;

namespace Avidity.MarvelTest.Controllers
{
    public class HomeController : Controller
	{
        StoryService storyService;

        public HomeController(ICharacterSystem characterSystem, IComicsSystem comicsSystem, IStorySystem storySystem)
        {
            storyService = new StoryService(characterSystem, comicsSystem, storySystem);
        }

		public ActionResult Index (string storyId = "21591")
		{
			var story = storyService.GetFullStory(storyId).Result;

			var vm = new StoryViewModel () {
				Story = story,
				Characters = story.Characters,
				Comics = story.Comics
			};

			return View (vm);
		}
	}
}

