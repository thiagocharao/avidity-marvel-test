using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avidity.MarvelTest.Domain.Characters
{
    public interface ICharacterSystem
    {
        Task<List<Character>> GetCharactersByStoryAsync(string storyId);
    }
}

