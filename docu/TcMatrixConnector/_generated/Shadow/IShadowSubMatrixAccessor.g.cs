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
	public partial interface IShadowSubMatrixAccessor : Vortex.Connector.IVortexShadowObject, TcMatrix.IShadowMatrixAccessor
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt RowStart_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt RowCount_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt ColStart_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt ColCount_
		{
			get;
		}

		new TcMatrix.PlainSubMatrixAccessor CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainSubMatrixAccessor source);
	}
}