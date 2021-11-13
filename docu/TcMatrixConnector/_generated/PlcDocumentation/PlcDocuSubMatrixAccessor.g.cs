using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	
///		<summary>
///			<see cref="MatrixAccessor">See Matrix accessor</see>
///			Allows access to a rectangular subset of the parent matrix as if it were a standalone matrix
///		</summary>			

	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class SubMatrixAccessor : PlcDocu.TcMatrix.MatrixAccessor
	{
		
///	<inheritdoc/>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type UINT; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Cols
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///		<inheritdoc/>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type UINT; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Rows
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		public object RowStart_;
		public object RowCount_;
		public object ColStart_;
		public object ColCount_;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public SubMatrixAccessor()
		{
		}
	}
#endif
}