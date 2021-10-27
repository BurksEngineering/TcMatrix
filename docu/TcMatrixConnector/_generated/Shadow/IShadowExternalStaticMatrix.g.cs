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
	public partial interface IShadowExternalStaticMatrix : Vortex.Connector.IVortexShadowObject, TcMatrix.IShadowStaticMatrix
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt Length_
		{
			get;
		}

		new TcMatrix.PlainExternalStaticMatrix CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainExternalStaticMatrix source);
	}
}