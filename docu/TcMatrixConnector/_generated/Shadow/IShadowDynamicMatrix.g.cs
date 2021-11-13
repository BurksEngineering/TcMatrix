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
	public partial interface IShadowDynamicMatrix : Vortex.Connector.IVortexShadowObject, TcMatrix.IShadowMatrix
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt Rows_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt Cols_
		{
			get;
		}

		new TcMatrix.PlainDynamicMatrix CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainDynamicMatrix source);
	}
}