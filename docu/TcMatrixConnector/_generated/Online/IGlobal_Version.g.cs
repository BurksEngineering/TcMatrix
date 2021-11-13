using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IGlobal_Version : Vortex.Connector.IVortexOnlineObject
	{
		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainGlobal_Version CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainGlobal_Version source);
		void FlushOnlineToPlain(TcMatrix.PlainGlobal_Version source);
	}
}