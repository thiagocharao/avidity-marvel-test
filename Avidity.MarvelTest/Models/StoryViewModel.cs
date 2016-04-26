using System.Collections.Generic;
using Avidity.MarvelTest.Domain.Stories;
using Avidity.MarvelTest.Domain.Characters;

namespace Avidity.MarvelTest
{
    public class StoryViewModel
	{
        public Story Story {
			get;
			set;
		}

		public List<Character> Characters {
			get;
			set;
		}

		public List<Comics> Comics {
			get;
			set;
		}
	}
}

