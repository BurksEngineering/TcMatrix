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
	public partial interface IShadowMatrix : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt Ri
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt Ci
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt I
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal ZeroReference_
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainMatrix CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainMatrix source);
	}
}