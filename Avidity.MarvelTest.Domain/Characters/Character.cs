using System;
using Newtonsoft.Json;

namespace Avidity.MarvelTest.Domain.Characters
{
	public class Character : EntityBase
	{
		[JsonProperty ("id")]
		public int Id {
			get;
			set;
		}

		[JsonProperty ("name")]
		public string Name {
			get;
			set;
		}

		[JsonProperty ("description")]
		public string Description {
			get;
			set;
		}

		[JsonProperty ("thumbnail")]
		public Thumbnail Thumbnail {
			get;
			set;
		}
	}
}

