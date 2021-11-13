using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	
///		<summary>
///			Matrix accessors are a way of interacting with the data of a parent Matrix through a special lens, without copying the data into a new Matrix and then back again.
///			This type of Matrix works by creating a function that converts the I-based indexing of the accessor matrix into the I-based indexing of the parent matrix, then using it to intercept calls to GetI and SetI.
///			Concrete Matrix Accessor Classes can be easily created from the parent MatrixAccessor abstract class by implementing the This2Parent method in order to define the index conversion.
///			<remarks>			
///				<note>
///					Note that matrix accessor allow both read and write access to the parent matrix!	
///				</note>
///				<note type="warning">
///					Matrix Accessors inherently store a pointer (BY REFERENCE) to their parent matrix. If the parent matrix goes out of scope (through function return) or is moved (through an online change) then the Matrix Accessor will no longer work. Therefore, they are best used quickly then destroyed, all within the scope of a single F or FB.
///				</note>
///			</remarks>
///		</summary>			

	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class MatrixAccessor : PlcDocu.TcMatrix.Matrix
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

		public Matrix M_;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public MatrixAccessor()
		{
		}
	}
#endif
}