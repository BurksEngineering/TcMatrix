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
	public partial interface IMatrix : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUInt Ri
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt Ci
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt I
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal ZeroReference_
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainMatrix CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainMatrix source);
		void FlushOnlineToPlain(TcMatrix.PlainMatrix source);
	}
}