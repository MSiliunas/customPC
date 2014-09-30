using System;

namespace CustomPC
{
	[Serializable]
	abstract class CheckedPart : IPart, ISocket
	{
		abstract public bool isSocketCompatible(string socket);
	}
}
