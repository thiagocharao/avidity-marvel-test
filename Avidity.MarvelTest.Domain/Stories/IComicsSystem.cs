using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avidity.MarvelTest.Domain.Stories
{
    public interface IComicsSystem
    {
        Task<Comics> GetComicsAsync(string id);
        Task<List<Comics>> GetComicsByStoryAsync(string storyId);
    }
}

