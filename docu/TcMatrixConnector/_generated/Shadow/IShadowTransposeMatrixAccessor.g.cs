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
	public partial interface IShadowTransposeMatrixAccessor : Vortex.Connector.IVortexShadowObject, TcMatrix.IShadowMatrixAccessor
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt RowRemoved_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt ColRemoved_
		{
			get;
		}

		new TcMatrix.PlainTransposeMatrixAccessor CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainTransposeMatrixAccessor source);
	}
}