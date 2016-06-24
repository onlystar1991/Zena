using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zena.Network
{
	public class HttpHandler : IHttpHandler
	{
		HttpClient client;

		public HttpHandler()
		{
			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
		}

		public Task LoginAsync()
		{
			return null;
		}
	}
}

