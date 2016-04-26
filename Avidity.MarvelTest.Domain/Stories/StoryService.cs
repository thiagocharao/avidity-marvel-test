using System;
using System.Threading.Tasks;
using Avidity.MarvelTest.Domain.Characters;

namespace Avidity.MarvelTest.Domain.Stories
{
    public class StoryService
    {
        ICharacterSystem m_characterSystem;
        IComicsSystem m_comicsSystem;
        IStorySystem m_storySystem;

        public StoryService(ICharacterSystem characterSystem, IComicsSystem comicsSystem, IStorySystem storySystem)
        {
            m_characterSystem = characterSystem;
            m_comicsSystem = comicsSystem;
            m_storySystem = storySystem;
        }

        public async Task<Story> GetFullStory(string storyId)
        {
            var story = await m_storySystem.GetStoryAsync(storyId);
            story.Characters = await m_characterSystem.GetCharactersByStoryAsync(storyId);
            story.Comics = await m_comicsSystem.GetComicsByStoryAsync(storyId);

            return story;
        }
    }
}

