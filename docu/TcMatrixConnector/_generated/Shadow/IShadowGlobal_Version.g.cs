using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowGlobal_Version : Vortex.Connector.IVortexShadowObject
	{
		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainGlobal_Version CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainGlobal_Version source);
	}
}