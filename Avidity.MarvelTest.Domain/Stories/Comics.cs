using System;
using Newtonsoft.Json;

namespace Avidity.MarvelTest.Domain.Stories
{
	public class Comics : EntityBase
	{
		[JsonProperty ("title")]
		public string Title {
			get;
			set;
		}

		[JsonProperty ("resourceUri")]
		public string ResourceUri {
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

