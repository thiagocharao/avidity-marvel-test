using System;
using System.Collections.Generic;
using Avidity.MarvelTest.Domain.Characters;
using Newtonsoft.Json;

namespace Avidity.MarvelTest.Domain.Stories
{
	public class Story : EntityBase
	{
		[JsonProperty("id")]
		public int Id {
			get;
			set;
		}

		[JsonProperty("title")]
		public string Title {
			get;
			set;
		}

		[JsonProperty("description")]
		public string Description {
			get;
			set;
		}

        [JsonIgnore]
		public List<Comics> Comics {
			get;
			set;
		}

        [JsonIgnore]
        public List<Character> Characters
        {
            get;
            set;
        }
    }
}

