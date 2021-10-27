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
	public partial interface IDynamicMatrix : Vortex.Connector.IVortexOnlineObject, TcMatrix.IMatrix
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUInt Rows_
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt Cols_
		{
			get;
		}

		new TcMatrix.PlainDynamicMatrix CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainDynamicMatrix source);
		void FlushOnlineToPlain(TcMatrix.PlainDynamicMatrix source);
	}
}