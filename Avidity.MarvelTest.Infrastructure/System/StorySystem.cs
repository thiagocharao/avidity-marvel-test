using System.Linq;
using System.Threading.Tasks;
using Avidity.MarvelTest.Domain.Stories;
using Avidity.MarvelTest.Utils;

namespace Avidity.MarvelTest.Infrastructure.System
{
    public class StorySystem : SystemBase<Story>, IStorySystem
    {
        const string RemoteEntityName = "stories";

        public async Task<Story> GetStoryAsync(string id)
        {
            var result = await GetResposeAsync(string.Format("{0}/{1}", RemoteEntityName, id));
            return result.FirstOrDefault();
        }
    }
}