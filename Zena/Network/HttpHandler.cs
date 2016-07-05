using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zena.Models.Learn;
using Zena.Models.LearnByID;
using Zena.Common;


namespace Zena.Network
{
	public class HttpHandler
	{
		HttpClient client;
		Uri server_uri;

		public HttpHandler()
		{
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
			server_uri = new Uri(Constants.SERVER + "aa221accc29edddaf523b46b96ae304e");
			client.DefaultRequestHeaders.Clear();
		}

		async public Task<LearnContentModel> GetLearnContentList()
		{
			var request = new RequestModel
			{
				requesting = "sr/getLearnContentList",
				offset = 0,
				limit = 10,
				order = "DESC"
			};

			var json = JsonConvert.SerializeObject(request);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			string result = "";
			var response = new HttpResponseMessage();

			response = await client.PostAsync(server_uri, content);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				result = response.Content.ReadAsStringAsync().Result;

				return JsonConvert.DeserializeObject<LearnContentModel>(result);
			}
			else 
			{
				return null;
			}
		}

		async public Task<LearnContentByIDModel> GetLearnContentById(int _id)
		{
			var request = new RequestModel
			{
				requesting = "sr/getLearnContentById",
				id = _id
			};

			var json = JsonConvert.SerializeObject(request);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			string result = "";
			var response = new HttpResponseMessage();

			response = await client.PostAsync(server_uri, content);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				result = response.Content.ReadAsStringAsync().Result;

				return JsonConvert.DeserializeObject<LearnContentByIDModel>(result);
			}
			else
			{
				return null;
			}
		}

		public Task LoginAsync()
		{
			return null;
		}

	}

	public class RequestModel
	{
		public string requesting { get; set; }
		public int offset { get; set; }
		public int id { get; set; }
		public int limit { get; set; }
		public string order { get; set; }
	}
}

