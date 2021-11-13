using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	
///		<summary>
///		 	 <see cref="TcMatrix.MatrixAccessor">See Matrix accessor</see>
///			  Allows access to the parent matrix as if the <see cref="DynamicMatrix.Shrink">Shrink</see> function had been called
///		</summary>			

	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class ShrunkMatrixAccessor : PlcDocu.TcMatrix.MatrixAccessor
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

		public object RowRemoved_;
		public object ColRemoved_;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public ShrunkMatrixAccessor()
		{
		}
	}
#endif
}