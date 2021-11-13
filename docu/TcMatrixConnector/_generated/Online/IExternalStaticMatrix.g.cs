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
	public partial interface IExternalStaticMatrix : Vortex.Connector.IVortexOnlineObject, TcMatrix.IStaticMatrix
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUInt Length_
		{
			get;
		}

		new TcMatrix.PlainExternalStaticMatrix CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainExternalStaticMatrix source);
		void FlushOnlineToPlain(TcMatrix.PlainExternalStaticMatrix source);
	}
}