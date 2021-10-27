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
	public partial interface ISubMatrixAccessor : Vortex.Connector.IVortexOnlineObject, TcMatrix.IMatrixAccessor
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUInt RowStart_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt RowCount_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ColStart_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ColCount_
		{
			get;
		}

		new TcMatrix.PlainSubMatrixAccessor CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainSubMatrixAccessor source);
		void FlushOnlineToPlain(TcMatrix.PlainSubMatrixAccessor source);
	}
}