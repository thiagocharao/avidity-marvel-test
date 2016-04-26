using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avidity.MarvelTest.Domain.Stories;
using Avidity.MarvelTest.Utils;

namespace Avidity.MarvelTest.Infrastructure.System
{
    public class ComicsSystem : SystemBase<Comics>, IComicsSystem
    {
        const string RemoteEntityName = "comics";

        public async Task<Comics> GetComicsAsync(string id)
        {
            var result = await GetResposeAsync(string.Format("{0}/{1}", RemoteEntityName, id));
            return result.FirstOrDefault();
        }

		public async Task<List<Comics>> GetComicsByStoryAsync(string storyId)
		{
			var result = await GetResposeAsync(string.Format("stories/{0}/{1}", storyId, RemoteEntityName));
			return result;
		}

    }
}