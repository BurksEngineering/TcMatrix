using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	
///		<summary>
///			The DynamicMatrix class uses the FB_DynMem_Manager2 to dynamically allocate as much memory as required for the given operation.
///			This amazing flexibility comes at the cost of some restrictions on use in order to avoid memory leaks.
///			<remarks>			
///				<note type="warning">
///					Using the assignment operator (:=) to copy a DynamicMatrix will result in the new matrix retaining a pointer to the data of the old matrix! For this reason, the pragma {attribute 'no_assign'} is used to block assignment at compile-time, but inheriting sub-classes will need to include this pragma themselves.
///					Note that using DynamicMatrix as the return value of a function is essentially an assignment operation and will also not work. Therefore, it is recommended to always pass DynamicMatrix objects in and out of functions using the REFERENCE TO keyword. To alleviate the pain of these assignment rules there are a ton of 'Resultant' helper functions available to use which initialize a new DynamicMatrix as the result of some operation on other matrix objects.	
///				</note>
///			</remarks>	
///			The DynamicMatrix FB will automatically free its memory when an instance of the class is created, or goes out of scope.
///			This prevents memory leaks and page faults, but it also prevents you from instantiating a DynamicMatrix inside of a function and then passing a REFERENCE TO it back up the call chain.
///			Another consequnce is that a DynamicMatrix cannot be retained after power-loss. 
///			A DynamicMatrix within a GVL will free its memory when the program terminates.							
///		</summary>			

	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class DynamicMatrix : PlcDocu.TcMatrix.Matrix
	{
		
///		<summary>
///			Frees all dynamically allocated memory and resets the size of the matrix to 0x0
///		</summary>			
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<returns>Plc type VOID; Twin type: <see cref="void"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public void Free()
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
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
///			Initializes a RxC matrix, with potentially random non-zero values
///		</summary>			
///		<param name="Rows">The number of  rows to create</param>
///		<param name="Cols">The number of collumns to create</param>
///		<returns>Returns True if success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Rows">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Cols">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Init(dynamic Rows, dynamic Cols)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			  Initializes a RxC matrix where every element is equal to the supplied value
///		</summary>			
///		<param name="Rows">Number of rows to create</param>
///		<param name="Cols">Number of columns to create</param>
///		<param name="Val">The value to to initiliaze with</param>
///		<returns>Returns True if success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Rows">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Cols">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Val">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic InitConstant(dynamic Rows, dynamic Cols, dynamic Val)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			 Initializes a matrix with the exact size and contents of the supplied matrix
///		</summary>			
///		<param name="M">Supplied matrix</param>
///		<returns>Returns True if success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic InitCopy(dynamic M)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			 Initializes a square identity matrix of size Size x Size
///		</summary>			
///		<param name="Size">Size of the square matrix</param>
///		<returns>Returns True if success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Size">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic InitIdentity(dynamic Size)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			   Initializes a RxC matrix then fills is using FillTrapezoidal()
///		</summary>			
///		<param name="Rows">Number of rows to create</param>
///		<param name="Cols">Number of columns to create</param>
///		<param name="Diagonal">Every element on the main diagonal of the matrix is set to this value.</param>
///		<param name="UpperRight">Every element above or to the right of the main diagonal is set to this value</param>
///		<param name="LowerLeft">Every element below or to the left of the main diagonal is set to this value</param>
///		<returns>Returns True if success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Rows">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Cols">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Diagonal">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<param name="UpperRight">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<param name="LowerLeft">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic InitTrapezoidal(dynamic Rows, dynamic Cols, dynamic Diagonal, dynamic UpperRight, dynamic LowerLeft)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			 Initializes an Lx1 column vector where the 0th element is equal to Val and every subsequent element is Inc larger than the previous
///		</summary>			
///		<param name="Length">Length of the vector</param>
///		<param name="Value">Value of 0th element</param>
///		<param name="Increment">Value by witch every other value is incremented by</param>
///		<returns>Returns True if success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Length">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Value">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<param name="Increment">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic InitVector(dynamic Length, dynamic Value, dynamic Increment)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			 Initializes a RxC matrix where every element is equal to 0.0
///		</summary>			
///		<param name="Rows">The number of  rows to create</param>
///		<param name="Cols">The number of collumns to create</param>
///		<returns>Returns True if success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Rows">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Cols">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic InitZeros(dynamic Rows, dynamic Cols)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Changes the total number of Rows and Cols in the matrix. 
///			If Retain is seleced then any element within the bounds of both the initial and resulting matrix will have its value retained.
///			If Init is selected then any newly created element will have its value set to zero.
///		</summary>			
///		<param name="NewRows">The row of the element to fetch</param>
///		<param name="NewCols">The column of the element to fetch</param>
///		<param name="RetainVals">If  selected then  any element within the bounds of both the initial and resulting matrix will have its value retained.</param>
///		<param name="ClearVals">If  selected then any newly created element will have its value set to zero.</param>
///		<returns>Returns TRUE on success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="NewRows">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="NewCols">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="RetainVals">
///<para>Plc type : BOOL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></para>
///<para></para>
///</param>

///<param name="ClearVals">
///<para>Plc type : BOOL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Resize(dynamic NewRows, dynamic NewCols, dynamic RetainVals, dynamic ClearVals)
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

		
///		<summary>
///			 Removes the specified Row and Column from the matrix, resuling in a new size of (Rows-1,Cols-1).
///			 No dimension can be shrunk from 1 to 0 (therefore vectors only shrink in one direction).
///		</summary>			
///		<returns>Returns TRUE on success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Row">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Col">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Shrink(dynamic Row, dynamic Col)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Similar to <see cref="Matrix.TransposeSquare">TransposeSquare</see>, however it works on rectangular matricies (swapping Rows and Cols)
///		</summary>			
///		<returns>Returns TRUE on success</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Transpose()
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
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
		public object Data;
		public object MemManager;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public DynamicMatrix()
		{
		}
	}
#endif
}