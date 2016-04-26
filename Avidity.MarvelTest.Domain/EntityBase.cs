using System;
using Newtonsoft.Json;

namespace Avidity.MarvelTest.Domain
{
	public class EntityBase : IEntityBase
	{
		[JsonProperty("attributionText")]
		public string AttributionText {
			get;
			set;
		}
	}
}

