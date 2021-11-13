using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	
///		<summary>
///			This simple concrete derivative of the StaticMatrix class uses an external ARRAY OF LREAL as the memory source for the matrix data.
///			It is accessed in row-major order based on the logic in the GetI and SetI functions.
///			It is most useful when someone doesn't trust dynamically allocated memory, but also doesn't want to make multiple size-specific custom derived FBs just to set up a single complex matrix operation.
///			<code>Init(R,C,pD)</code> : Must be called in order to setup the matrix (it will be empty until this method is called).
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
	public abstract class ExternalStaticMatrix : PlcDocu.TcMatrix.StaticMatrix
	{
		
///		<summary>
///			Gets the value of the element in this matrix at the supplied location as if the elements were stored in a 1D row-major array
///			Prerequisites:
///				- I &lt; Rows*Cols
///				- Matrix is not empty
///			<remarks>			
///				<note type="note">
///					If the supplied index is out of bounds the value 0 is returned and a warning is generated in the Error List
///				</note>
///			</remarks>
///		</summary>			
///		<param name="I">The index of the element which should have its value returned</param>
///		<returns>The value of the element at the specified index, or 0 if an invalid index is supplied</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="I">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type LREAL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic GetI(dynamic I)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Sets the element specified BY the supplied index TO the suppleid value, assuming the data OF the matrix is stored in a 1D row-major ARRAY
///			Prerequisites: - I &lt; Rows*Cols
///		</summary>			
///		<param name="I">The index specifying which element should be modified</param>
///		<param name="Val">The value copied to the corresponding element</param>
///		<returns>TRUE if the specified index is valid and the data is copied. FLASE otherwise</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="I">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Val">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic SetI(dynamic I, dynamic Val)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		public object Length_;
		public object Data;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public ExternalStaticMatrix()
		{
		}
	}
#endif
}