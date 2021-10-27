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
	public partial interface IShrunkMatrixAccessor : Vortex.Connector.IVortexOnlineObject, TcMatrix.IMatrixAccessor
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUInt RowRemoved_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ColRemoved_
		{
			get;
		}

		new TcMatrix.PlainShrunkMatrixAccessor CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainShrunkMatrixAccessor source);
		void FlushOnlineToPlain(TcMatrix.PlainShrunkMatrixAccessor source);
	}
}