using System;
using System.Threading.Tasks;

namespace Avidity.MarvelTest.Domain.Stories
{
    public interface IStorySystem
    {
        Task<Story> GetStoryAsync(string id);
    }
}

