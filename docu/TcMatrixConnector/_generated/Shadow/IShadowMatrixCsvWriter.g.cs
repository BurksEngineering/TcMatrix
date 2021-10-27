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
	public partial interface IShadowMatrixCsvWriter : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool bExecute
		{
			get;
		}

		IShadowMatrix M
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime tTimeout
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt cbHeaderLen
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bBusy
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool bError
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt nErrId
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt nErrStep
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt hFile
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString buffer
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt bufferOffset
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt step
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt Ri
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt Ci
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		TcMatrix.PlainMatrixCsvWriter CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(TcMatrix.PlainMatrixCsvWriter source);
	}
}