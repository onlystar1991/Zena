using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zena.Models;

namespace Zena.Network
{
	public class HttpManager
	{
		IHttpHandler httpHandler;
		public HttpManager( IHttpHandler _httpHandler)
		{
			httpHandler = _httpHandler;
		}

		async public Task<List<LearnContentModel>> GetLearnContentList() 
		{
			return await httpHandler.GetLearnContentList();
		}
	}
}

