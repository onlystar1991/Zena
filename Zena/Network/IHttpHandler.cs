using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Zena.Models;

namespace Zena.Network
{
	public interface IHttpHandler
	{
		Task LoginAsync();
		Task<List<LearnContentModel>>  GetLearnContentList();
	}
}
