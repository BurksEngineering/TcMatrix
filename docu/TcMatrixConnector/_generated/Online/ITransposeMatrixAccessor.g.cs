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
	public partial interface ITransposeMatrixAccessor : Vortex.Connector.IVortexOnlineObject, TcMatrix.IMatrixAccessor
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUInt RowRemoved_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ColRemoved_
		{
			get;
		}

		new TcMatrix.PlainTransposeMatrixAccessor CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainTransposeMatrixAccessor source);
		void FlushOnlineToPlain(TcMatrix.PlainTransposeMatrixAccessor source);
	}
}