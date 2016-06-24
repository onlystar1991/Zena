using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zena.Network
{
	public class HttpManager
	{
		IHttpHandler httpHandler;
		public HttpManager( IHttpHandler _httpHandler)
		{
			httpHandler = _httpHandler;
		}

		public Task Login() 
		{
			return httpHandler.LoginAsync();
		}
	}
}

