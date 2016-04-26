using System.Collections.Generic;
using System.Threading.Tasks;
using Avidity.MarvelTest.Domain.Characters;
using Avidity.MarvelTest.Utils;

namespace Avidity.MarvelTest.Infrastructure.System
{
    public class CharacterSystem : SystemBase<Character>, ICharacterSystem
    {
        const string RemoteEntityName = "characters";

		public async Task<List<Character>> GetCharactersByStoryAsync(string storyId)
        {
			var result = await GetResposeAsync(string.Format("stories/{0}/{1}", storyId, RemoteEntityName));
            return result;
        }
    }
}