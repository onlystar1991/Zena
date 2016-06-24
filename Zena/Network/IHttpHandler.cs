using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zena.Network
{
	public interface IHttpHandler
	{
		Task LoginAsync();
	}
}

