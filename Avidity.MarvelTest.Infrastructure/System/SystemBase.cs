using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Avidity.MarvelTest.Domain;
using Newtonsoft.Json;
using Microsoft.CSharp;
using Newtonsoft.Json.Linq;

namespace Avidity.MarvelTest.Utils
{

    public abstract class SystemBase<TEntity> where TEntity : IEntityBase
    {

        protected string BASE_URL = "http://gateway.marvel.com/v1/public/";

        HttpClient Connection
        {
            get;
            set;
        }
			
        public SystemBase()
        {
			Connection = new HttpClient	{ BaseAddress = new Uri(BASE_URL) };
        }
			
        public async Task<List<TEntity>> GetResposeAsync(string relativeUrl, IDictionary<string, object> parameters = null)
        {
            var response = await Connection.GetAsync(string.Concat(relativeUrl, StringfyUrlParams(parameters)));

            return await ConvertResponseObject(response);
        }
			
        async Task<List<TEntity>> ConvertResponseObject(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            JObject tempObj = JObject.Parse(content);

            try
            {
				var obj = JsonConvert.DeserializeObject<List<TEntity>>(tempObj["data"]["results"].ToString());
				obj.ForEach(x => x.AttributionText = tempObj["attributionText"].ToString());
				return obj;
            }
            catch (JsonReaderException ex)
            {
                throw ex;
            }
        }
			
        string StringfyUrlParams(IDictionary<string, object> parameters)
        {
            IEnumerable<string> urlParams = new List<string>();
            string result = string.Empty;
			if (parameters != null) {
				if (parameters.Count > 0) {
					urlParams = parameters.Select (p => {
						if (p.Value is Array) {
							var array = (Array)p.Value;
							return string.Join ("&", array.Cast<object> ().Select (e => p.Key + "=" + e));
						}

						return p.Key + "=" + p.Value;
					});

					result = string.Concat ("?", string.Join ("&", urlParams), GetAuthQueryKey ());
				}
			}
            else
            {
                result = string.Concat("?", GetAuthQueryKey());
            }

            return result;
        }
			
        public string GetAuthQueryKey()
        {
            return string.Format("ts=1&apikey={0}&hash={1}", Security.MarvelPublicKey, Security.GetMarvelHashRequestCode());
        }

    }
}

