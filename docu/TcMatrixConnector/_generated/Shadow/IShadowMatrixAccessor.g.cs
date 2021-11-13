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
	public partial interface IShadowMatrixAccessor : Vortex.Connector.IVortexShadowObject, TcMatrix.IShadowMatrix
	{
		IShadowMatrix M_
		{
			get;
		}

		new TcMatrix.PlainMatrixAccessor CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainMatrixAccessor source);
	}
}