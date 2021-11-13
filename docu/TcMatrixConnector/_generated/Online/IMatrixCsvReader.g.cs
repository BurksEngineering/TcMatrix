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
	public partial interface IMatrixCsvReader : Vortex.Connector.IVortexOnlineObject
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt nHeaderLines
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt nRows
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt nCols
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt nVals
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt hFile
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool readEOF
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt bytesRead
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt bytesParsed
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString buffer
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt step
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt Hi
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

		TcMatrix.PlainMatrixCsvReader CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(TcMatrix.PlainMatrixCsvReader source);
		void FlushOnlineToPlain(TcMatrix.PlainMatrixCsvReader source);
	}
}