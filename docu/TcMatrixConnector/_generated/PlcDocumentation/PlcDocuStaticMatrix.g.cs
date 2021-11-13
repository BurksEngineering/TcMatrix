using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	
///		<summary>
///			This type of matrix has the number of rows and columns set during initialization and then they cannot be changed.
///			Derived class must:
///				- Declare a VAR array of LREAL named Data_
///				- Call Init_ in FB_init, pointing to the local arrays, with Rows and Cols such that Rows*Cols &lt;= Length(Data_)
///			This simple abstract class sets the rules for all static memory matricies by creating a protected Init_(R,C) method that must be called to set the initial size of the matrix.
///			It also implements the required Rows and Cols properties to return the values that were set during initialization.
///			<remarks>			
///				<note type="warning">
///				It is the callers responsibility to ensure that the pointer provided to the initializer is valid:
///				 	- The length of the data structure pointed to (probably an array of LREAL) is at least as long as Rows x Cols
///					- The scope of the data structure pointed to is the same as the scope of the corresponding ExternalStaticMatrix (probably declared adjacent to eachother as a VAR or GVL)
///				Additionally, direct assignment (:=) should not be used with this type of matrix because a second copy of the Matrix, but with a pointer to the original's data source, would be created. For this reason, the pragma {attribute 'no_assign'} is used to block assignment at compile-time. Keep in mind that returning a value from a function is also a form of assignment and is not allowed.	
///				</note>
///			</remarks>
///		</summary>			
///		<param name="Row">The row of the element to fetch</param>
///		<param name="Col">The column of the element to fetch</param>
///		<returns>Returns the value of the element at the specified (0-indexed) position within the matrix</returns>

	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class StaticMatrix : PlcDocu.TcMatrix.Matrix
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

		public object Rows_;
		public object Cols_;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public StaticMatrix()
		{
		}
	}
#endif
}