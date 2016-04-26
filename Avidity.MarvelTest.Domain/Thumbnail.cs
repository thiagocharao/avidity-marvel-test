using System;
using Newtonsoft.Json;

namespace Avidity.MarvelTest.Domain
{
	public class Thumbnail : EntityBase
	{
		[JsonProperty ("path")]
		public string Path { 
			get; 
			set; 
		}

		[JsonProperty ("extension")]
		public string Extension { 
			get; 
			set; 
		}

		[JsonIgnore()]
		public string CompletePath {
			get { 
				return string.Format ("{0}.{1}", Path, Extension);
			}
		}

	}
}

