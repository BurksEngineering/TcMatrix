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
	public partial interface IMatrixAccessor : Vortex.Connector.IVortexOnlineObject, TcMatrix.IMatrix
	{
		IMatrix M_
		{
			get;
		}

		new TcMatrix.PlainMatrixAccessor CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainMatrixAccessor source);
		void FlushOnlineToPlain(TcMatrix.PlainMatrixAccessor source);
	}
}