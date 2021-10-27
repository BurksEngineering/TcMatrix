using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	
///		<summary>
///			This abstract FB is the basis for all other matrix FBs. It represents a 2D array of LREAL elements. 
///			It provides dozens of methods and properties useful for manipulating itself, calculating values, and comparing to other matricies.
///			Critically, this base class does not actually contain any mechanism for storing the values of the matrix (that is the responsibility of the specific inheriting sub-class).
///			<remarks>			
///					<note type="info">
///						Because Matrix is an abstract FB it cannot be assigned (:=) directly. 
///						Instead, each Matrix is always passed in and out of a function AS REFERENCE.
///					 	This also allows interactions with inhereted sub-classes of Matrix more easily.	
///					</note>
///				</remarks>	
///		</summary>

	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Matrix
	{
		
///		<summary>
///			Resets the value of every element in this matrix to zero
///			Sets the value of every element to 0.0
///		</summary>			
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<returns>Plc type VOID; Twin type: <see cref="void"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public void Clear()
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Copy the value from each element in the source matrix to each corresponding element in this matrix
///			Prerequisites:
///			 - This matrix is the same size as the source matrix
///			 - Neither matrix is empty
///		</summary>			
///		<param name="M">Source of the copy operation</param>
///		<returns>Returns true if the prerequisites were met and the data was copied, false otherwise</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic CopyFrom(dynamic M)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			For each element in this matrix, calculate a new value by Subtracting the value of the corresponding element of the supplied matrix from the value in this matrix
///			THIS := THIS - M
///			:Prerequisites:
///			 - This matrix is the same size as the supplied matrix
///			 - Neither matrix is empty
///		</summary>			
///		<param name="M">The subtrahend in the subtraction</param>
///		<returns>TRUE if the operation completes successfully, false if the prerequisites are not met</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic ElementDifference(dynamic M)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///		For each element in this matrix, calculate a new value by Multiplying the value of the corresponding element of the supplied matrix with the value in this matrix
///		THIS := THIS .* M
///		:Prerequisites:
///		 - This matrix is the same size as the supplied matrix
///		 - Neither matrix is empty
///		</summary>			
///		<param name="M">the supplied matrix to be multiplied element-by-element to this matrix</param>
///		<returns>TRUE if the operation completes successfully, false if the prerequisites are not met</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic ElementProduct(dynamic M)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			For each element in this matrix, calculate a new value by Adding the value of the corresponding element of the supplied matrix with the value in this matrix
///			THIS := THIS + M
///			Prerequisites:
///			 - This matrix is the same size as the supplied matrix
///			 - Neither matrix is empty
///		</summary>			
///		<param name="M">The supplied matrix to be added to this matrix</param>
///		<returns>TRUE if the operation completes successfully, false if the prerequisites are not met</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic ElementSum(dynamic M)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			For every element that exist in both this matrix and the source matrix, copy the value from the source matrix into this matrix
///		</summary>			
///		<param name="M">source matrix for element copy operation</param>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<returns>Plc type VOID; Twin type: <see cref="void"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public void FillFrom(dynamic M)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Fills all elements of this matrix based on which of three zones it is located into when considered as a trapezoidal matrix
///		</summary>			
///		<param name="Diagonal">Every element on the main diagonal of the matrix is set to this value.</param>
///		<param name="UpperRight">Every element above or to the right of the main diagonal is set to this value</param>
///		<param name="LowerLeft">Every element below or to the left of the main diagonal is set to this value</param>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
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

///<returns>Plc type VOID; Twin type: <see cref="void"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public void FillTrapezoidal(dynamic Diagonal, dynamic UpperRight, dynamic LowerLeft)
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
///			Returns the value of the element of this matrix at the specified row and column.
///			Prerequisites:
///				- Row &lt; Rows
///				- Col &lt; Cols
///				- Matrix is not empty
///			<remarks>			
///				<note type="important">
///					If the supplied or or column is out of bounds then a warning message is generated in the Error List and the value 0 is returned
///				</note>
///				<note type="important">
///					The value of the element at the specified row and column, or 0 if an invalid index is supplied
///				</note>
///			</remarks>
///		</summary>			
///		<param name="Row">The row of the element to fetch</param>
///		<param name="Col">The column of the element to fetch</param>
///		<returns>Returns the value of the element at the specified (0-indexed) position within the matrix</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Row">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Col">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type LREAL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic GetRC(dynamic Row, dynamic Col)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Returns the length of the matrix in the specified dimension
///			<example>
///				GetSize(0) is equivalent to Rows	
///				GetSize(1) is equivalent to Cols
///			</example>
///			<remarks>			
///				<note type="important">
///					If an invalid dimension is supplied then a warning is generated in the Error List and the value 0 is returned 
///				</note>
///				<note type="important">
///					The length of the matrix in the specified dimension, or 0 if the dimension specified is invalid
///				</note>
///			</remarks>
///		</summary>	
///		<param name="Dim">The dimension of the matrix for which the size should be returned. 0=Rows, 1=Cols</param>		
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Dim">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type UINT; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic GetSize(dynamic Dim)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Calcualtes the vector magnitude of this matrix (square root of the sum of the squares), assuming it is a vector.
///			:Prerequisites:
///			 - This matrix is not empty and is a vector
///			 <remarks>			
///				<note type="important">
///					 If this matrix is empty or is not a vector, 0 is returned
///				</note>
///			</remarks>
///		</summary>
///		<returns>The vector magnitude of this matrix if it is a vector, otherwise 0</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<returns>Plc type LREAL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic GetVectorMagnitude()
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Inverts the matrix. May fail if the matrix is too close to being singular. Use the tolerance input to specify how close to go (1E-6 to 1E-9 is porbably good).
///			:Prerequisites:
///				- This matrix is square
///				- This matrix is not empty
///		</summary>			
///		<param name="Tolerance">The smallest magnitude of number that is allowed to be used as a denominator in the calculation of the inverse</param>		
///		<returns>True if the inverse has been calculated. False if a precondition was not met, or a near-singularity was detected (data may be malformed).</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Tolerance">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic InvertSquare(dynamic Tolerance)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Returns TRUE if IsEqualSize is true AND every element in this matrix is equal to its corresponding element in the supplied matrix
///			Checks if this matrix is the same size (number of rows and number of columns match) as the supplied matrix.
///			<remarks>			
///				<note type="note">
///					two empty matricies are considered the same size.
///				</note>
///			</remarks>
///		</summary>			
///		<param name="M">The matrix which should have its size compared to the size of this matrix</param>
///		<returns>True if this matrix is the same size as the supplied matrix</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic IsEqualSize(dynamic M)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Determines if this matrix is *nearly* equal to a supplied matrix, based on a supplied precision.
///			Two matricies are considered nearly equal if they are the same size and every set of corresponding elements are equal to within the supplied precision.
///			<remarks>			
///				<note type="note">
///					Note that two empty matricies are considered equal
///				</note>
///			</remarks>
///		</summary>			
///		<param name="M">The other matrix to compare to this one</param>
///		<param name="Precision">Deviation between two elements larger than this value makes them unequal</param>
///		<returns>TRUE if the two matricies are nearly equal, FALSE if they are not</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="M">
///<para>Plc type : Matrix [VAR_INPUT]; Twin type : <see cref="Matrix"/></para>
///<para></para>
///</param>

///<param name="Precision">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic IsNearlyEqual(dynamic M, dynamic Precision)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Raises every element of the matrix to the supplied power
///			<remarks>			
///				<note type="important">
///					Many values of exponent could easily cause all of the elements to turn into NaN!
///				</note>
///			</remarks>
///		</summary>			
///		<param name="Exponent">Power with which to raise every element of the matrix</param>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Exponent">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type VOID; Twin type: <see cref="void"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public void Power(dynamic Exponent)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///		Scales every element of this matrix by the supplied value
///		</summary>			
///		<param name="Scalar">Value with which to scale every element of this matrix</param>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Scalar">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type VOID; Twin type: <see cref="void"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public void Scale(dynamic Scalar)
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
///			Sets the element specified by the supplied row and column to the suppleid value
///			Prerequisites:
///				- Row &lt; Rows
///				- Col &lt; Cols
///				- Matrix is not empty
///			<remarks>			
///				<note type="important">
///					If the supplied or or column is out of bounds then a warning message is generated in the Error List and the value 0 is returned
///					The value of the element at the specified row and column, or 0 if an invalid index is supplied
///				</note>
///			</remarks>
///		</summary>	
///	<param name="Row">The row of the element to set</param>
///	<param name="Col">The column of the element to set</param>
///	<param name="Val">The value to copy into the specified element</param>
///	<returns>TRUE if the specified row and column are valid and the data is copied. FALSE otherwise</returns>		
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="Row">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Col">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<param name="Val">
///<para>Plc type : LREAL [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic SetRC(dynamic Row, dynamic Col, dynamic Val)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///		 	Sorts the matrix by swapping entire rows around until the specified column is in ascending order. The relative position of equal rows will remain unchanged so as to allow tiered sorting.
///			In-place bubble sort of rows by the specified col, into ascending order
///			algorithm is 'stable', meaning that two equivalent rows will maintain their relative position after
///			This is nice because it lets you sort by secondary/tertiary/etc columns (if you do them in reverse)
///		</summary>			
///		<param name="Row">The row of the element to fetch</param>
///		<param name="Col">The column of the element to fetch</param>
///		<returns>Returns the value of the element at the specified (0-indexed) position within the matrix</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<param name="SortCol">
///<para>Plc type : UINT [VAR_INPUT]; Twin type : <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></para>
///<para></para>
///</param>

///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic SortByColAsc(dynamic SortCol)
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Transposes the matrix.    
///			:Prerequisites:           
///			- This matrix is square   
///			- This matrix is not empty
///		</summary>			
///		<returns>TRUE if the operation completes successfully, false if the prerequisites are not met</returns>
///<summary><note type="note">This is PLC method. This method is invokable only from the PLC code.</note></summary>
///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic TransposeSquare()
		{
			throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
		}

		
///		<summary>
///			Returns the average value of all elements
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type LREAL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Average
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///	<summary>
///		Returns the number of columns in the matrix
///	</summary>			
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

		
///		<summary>
///			Returns true if the matrix does not have any addresible elements
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type Bool; Twin type: <see cref="Bool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic IsEmpty
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///		<summary>
///			Returns true if this matrix is not empty, and the number of columns is equal to the number of rows
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic IsSquare
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///		<summary>
///			Returns true if this matrix is not empty, and at least one dimension has a size of 1 (row vector or column vector).
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type BOOL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerBool"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic IsVector
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///		<summary>
///			Total number of elements in this matrix
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type UINT; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerUInt"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Length
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///		<summary>
///			Returns the maximum value from all elements
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type LREAL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic MaxVal
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///		<summary>
///			Returns the minimum value from all elements
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type LREAL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic MinVal
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		
///		<summary>
///			Total number of rows in this matrix
///		</summary>			
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

		
///		<summary>
///			Returns the sum of all elements
///		</summary>			
///<summary><note type="note">This is PLC property. This method is accessible only from the PLC code.</note></summary>
///<returns>Plc type LREAL; Twin type: <see cref="Vortex.Connector.ValueTypes.OnlinerLReal"/></returns>

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced), Vortex.Connector.IgnoreReflectionAttribute()]
		public dynamic Sum
		{
			get
			{
				throw new NotImplementedException("This is PLC member; not invokable form the PC side.");
			}
		}

		public object sPath_;
		public object Ri;
		public object Ci;
		public object I;
		public object ZeroReference_;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Matrix()
		{
		}
	}
#endif
}