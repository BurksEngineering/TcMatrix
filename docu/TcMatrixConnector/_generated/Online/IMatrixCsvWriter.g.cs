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
	public partial interface IMatrixCsvWriter : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool bExecute
		{
			get;
		}

		IMatrix M
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt cbHeaderLen
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bBusy
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool bError
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt nErrId
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt nErrStep
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt hFile
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString buffer
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt bufferOffset
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt step
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt Ri
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt Ci
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainMatrixCsvWriter CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainMatrixCsvWriter source);
		void FlushOnlineToPlain(TcMatrix.PlainMatrixCsvWriter source);
	}
}