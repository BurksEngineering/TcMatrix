# TcMatrix

## Description

A TwinCAT 3 library for manipulating 2D data sets of LREAL.

Features include:

* Element-wise setting, getting, summing, scaling, and power functions
* Initialization as copies, zeros, trapezoidal, and other pre-defined matrix types
* Matrix operations like multiplication, transposition, and inversion
* Vector operations for 1D matricies like dot/cross product and normalization
* Complex access operations similar to ['slicing'](https://en.wikipedia.org/wiki/Array_slicing)
* Options to use static or dynamically allocated memory
* Reading/Writing with CSV files, output to the ADS message logger

Compare to:

* [CODESYS Matrix Library](https://us.store.codesys.com/matrix-library.html) ([docs](https://store.codesys.com/media/n98_media_assets/files/2111000003-D/4/Matrix%20Bibliothek_en.pdf))
* [Siemens Library of General Functions](https://support.industry.siemens.com/cs/document/109479728/library-of-general-functions-(lgf)-for-simatic-step-7-(tia-portal)-and-simatic-s7-1200-s7-1500) ([docs](https://cache.industry.siemens.com/dl/files/728/109479728/att_1019474/v3/109479728_LGF_TIAV16_DOC_V5_0_0_en.pdf))

## Contents

* [Installation](#twincat-3-installation)
* [Usage](#usage)
   * [Matrix](#base-matrix-class)
   * [DynamicMatrix](#dynamicmatrix-class)
   * [StaticMatrix](#static-memory-matrix)
   * [MatrixAccessor](#matrix-accessors)
* [Examples](#examples)
   * [Projects](#projects-with-implementations)

## TwinCAT 3 Installation

### From Binary

1. Go to the [releases page](https://github.com/BurksEngineering/TcMatrix/releases) and download the *.library file from the latest release, saving it to a temporary directory somewhere on the computer running TwinCAT.
1. Follow the [library installation instructions](https://infosys.beckhoff.com/english.php?content=../content/1033/tc3_plc_intro/4189333259.html) from Beckhoff, using the 'Install' option and browsing for the local copy you had just downloaded.
1. After installtion, you may delete the local copy of the library that you had downloaded. Beckhoff has likely copied it to a version-specific folder in `C:\TwinCAT\3.1\Components\Plc\Managed Libraries\Burks Engineering\TcMatrix\`

### From Source

Preconditions:

* TwinCAT 3.1.4024 XAE
* TwinCAT 3.1.4024 XAR, ideally configured with an isolated core
* Visual Studio Community or Shell, 2019 or higher
* [TcUnit](https://github.com/tcunit/TcUnit) v1.2 or higher

Compilation:

1. Clone the repository to a computer running TwinCAT 3
1. Open the [main solution file](TcMatrix.sln) in Visual Studio
1. Within the Visual Studio *TcMatrix* project, right click on the *TcMatrix/TcMatrix Project* item and select *Rebuild*
   1. There should be no compile errors, although there may be warnings
1. Right click on the *TcMatrix/TcMatrix Project* item again and select *Save as library and install*
   1. The file can be saved anywhere, but a local *Builds* folder is always a good choice

Test:

1. Within the Visual Studio *TcMatrixTest* project, right click on the *PLC/TcMatrixTest/TcMatrixTest Project* item and select *Rebuild*
   1. There should be no compile errors, although there may be warnings
1. Open the *SYSTEM/Real-Time* item and click *Read From Target*, then assign all tasks to an isolated core from your system
1. In the Visual Studio toolbar (or TwinCAT file menu) click *Activate Configuration*
1. When prompted, agree to start the project in run mode and auto-start the boot project
1. After a few seconds the TcUnit results should be visible in the Error List window. Verify that all tests have passed.

## Usage

### Base Matrix Class

This abstract FB is the basis for all other matrix FBs.
It represents a 2D array of LREAL elements.
It provides dozens of methods and properties useful for manipulating itself, calculating values, and comparing to other matricies.
Critically, this base class does not actually contain any mechanism for storing the values of the matrix (that is the responsibility of the specific inheriting sub-class).

---
**NOTE**

Because *Matrix* is an abstract FB it cannot be assigned (`:=`) directly. 
Instead, each *Matrix* is always passed in and out of a function *AS REFERENCE*.
This also allows interactions with inhereted sub-classes of *Matrix* more easily.

---

Below are some (but not all) of the functions and methods within the base Matrix FB. All functions and methods are documented within the library and can be explored within TwinCAT.

#### Element Access

Fundamentally the matrix is just a 2D array of LREAL data. These simple methods and functions form the backbone of the entire class.

* __Rows__ : returns the number of rows in the matrix
* __Cols__ : Returns the number of columns in the matrix
* __Size(dim)__ : Returns the length of the matrix in the specified dimension (0=rows, 1=cols)
* __GetRC(R,C)__ : Returns the value of the element at the specified (0-indexed) position within the matrix
* __SetRC(R,C,Val)__ : Sets the value of the element at the specified (0-indexed) position within the matrix
* __IsEmpty__ : Returns TRUE if *Rows*=0 OR *Cols*=0
* __IsSquare__ : Returns TRUE if *Rows*=*Cols* and the matrix is not empty
* __IsVector__ : Returns TRUE if *Rows*=1 OR *Cols*=1 and the matrix is not empty

Every *Matrix* is considered as a 1D array of LREAL data types under the hood.
This 1D view of data can be particularly useful when considering the matrix as a vector, but not caring whether it is a row vector or column vector.

* __Length__ : The length of the 1D array (equal to *Rows* x *Cols*)
* __GetI(I)__ : Returns the value of the element at the specified (0-based) position in the 1D array 
* __SetI(I,Val)__ : Sets the value of the element at the specified (0-based) position in the 1D array 

#### Initializers

* __Clear()__ : Sets the value of every element to 0.0
* __CopyFrom(Matrix)__ : Only if the supplied matrix is exactly the same size as this matrix, copy all elements to this matrix
* __FillFrom(Matrix)__ : Copy every element from the supplied matrix which exists in both this amtrix and the supplied matrix
* __FillTrapezoidal(D,UR,LL)__ : Copy one value into the main diagonal of this matrix, copy another value into all elements to the upper-right of the main diagonal, and copy another value into all elements to the lower-left of the main diagonal

#### Modifiers

* __ElementSum(Matrix)__ : Sets each element of this matrix to the value of its sum with the corresponding element in the supplied matrix
* __ElementDifference(Matrix)__ : Sets each element of this matrix (as subtrahend) to the value of its difference with the corresponding element in the supplied matrix (as minuend)
* __ElementProduct(Matrix)__ : Sets each element of this matrix to the value of its product with the corresponding element in the supplied matrix
* __Scale(Scalar)__ : Sets each element of this matrix to the value of its product with the specified scalar
* __Power(Exponent)__ : Sets each element of this matrix to the value of itsself raised to the supplied exponent
* __TransposeSquare()__ : (Works on square matricies only) Swaps each element at (R,C) with a corresponding element at (C,R)
* __InvertSquare(Tolerance)__ : Transforms this matrix into its inverse, if possible. The supplied Tolerance is used as a limit for any number used as a denominator (1E-12 is a good value to use).
* __SortByColAsc(C)__ : Sorts the matrix by swapping entire rows around until the specified column is in ascending order. The relative position of equal rows will remain unchanged so as to allow tiered sorting.

#### Comparators

* __IsEqualSize__ : Returns TRUE if this matrix is the same size (*Rows* and *Cols*) as the supplied matrix
* __IsEqual__ : Returns TRUE if *IsEqualSize* is true AND every element in this matrix is equal to its corresponding element in the supplied matrix
* __IsNearlyEqual(Tolerance)__ : Returns TRUE if *IsEqualSize* AND every element in this matrix is equal (within the specified tolerance) to its corresponding element in the supplied matrix

#### Calculators

* __Sum__ : A property that returns the sum of every element in the matrix
* __MaxVal__ : A property that returns the maximum value contained in the matrix
* __MinVal__ : A property that returns the minimum value contained in the matrix
* __Average__ : A property that returns the average of all values contained in the matrix
* __GetDeterminate()__ : Calculates the determinate of the matrix if it is square
* __GetVectorMagnitude()__ : Calculates the magnitude (square root of the sum of the squares) of the matrix if it is a vector

#### External Functions

These functions compartmentalize simple matrix operations outside of any specific FB. 
For some operations, like matrix multiplication, the dimensions of every *Matrix* involved can be different which makes using an external function more convenient for non-resizeable matricies.
They all take in *REFERENCE TO Matrix* as both the inputs and outputs to their arithmatic operation.
Be careful when using a reference to the same *Matrix* instance as both an input and an output!

A non-exhaustive list of included external functions (see documentation within TwinCAT for the full list):

* __Matrix_Product__
* __Matrix_Transpose__
* __Matrix_Grow__
* __Matrix_Shrink__
* __Matrix_SubMatrix__
* __Vector_CrossProduct__

#### Inheritance Guide

To make a concrete matrix class as a sub-class of the *Matrix* FB the following properties and methods must be implemented:

* __Rows__ : *UINT*
* __Cols__ : *UINT*
* __GetI(I)__ : *LREAL*
* __SetI(I,Val)__ : *BOOL*

Because everything comes back to representing a 1D array of LREALs as a 2D array of LREALs all you need are these four functions.
The *Rows* and *Cols* together define the length of the 1D array and the size of the 2D array.
The *GetI* and *SetI* functions define the transformation between the 1D and 2D array, as well as access to the source of the 1D data.
This type of interface also allows for a *Matrix* itself to be the source data for another *Matrix*! (see [Matrix Accessors](#matrix-accessors))

Example Inheritance:
 * __*DynamicMatrix*__ uses a *POINTER TO LREAL* assigned from dynamic memory allocation to track the 1D data
 * __*ExternalStaticMatrix*__ uses a *POINTER TO LREAL* assigned at initialization based on some external *ARRAY [] OF LREAL*
 * __*MatrixAccessor*__ uses a *REFERENCE TO Matrix* assigned at runtime as the basis for the memory and structure

#### CSV File Interaction

The *MatrixCsvReader* and *MatrixCsvWriter* FBs exist to help read/write data from/to CSV files on the disk of the local IPC.
Headers must be supplied externally when writing, and are ignored when reading.
When reading a CSV file the destination matrix must be large enough to fit the entire contents of the file.
The functions take multiple PLC cycles to complete, and work like a standard multi-cylce FB (bExecute, bError, etc).
See the included documentaiton within TwinCAT for details.

### DynamicMatrix Class

The *DynamicMatrix* class uses the *FB_DynMem_Manager2* to dynamically allocate as much memory as required for the given operation.
This amazing flexibility comes at the cost of some restrictions on use in order to avoid memory leaks.

---
**WARNING**

Using the assignment operator (`:=`) to copy a *DynamicMatrix* will result in the new matrix retaining a pointer to the data of the old matrix!
For this reason, the pragma `{attribute 'no_assign'}` is used to block assignment at compile-time, but inheriting sub-classes will need to include this pragma themselves.
Note that using *DynamicMatrix* as the return value of a function is essentially an assignment operation and will also not work.
Therefore, it is recommended to always pass *DynamicMatrix* objects in and out of functions using the *REFERENCE TO* keyword.
To alleviate the pain of these assignment rules there are a ton of '[Resultant](#resultants)' helper functions available to use which initialize a new *DynamicMatrix* as the result of some operation on other matrix objects.

---

The *DynamicMatrix* FB will automatically free its memory when an instance of the class is created, or goes out of scope.
This prevents memory leaks and page faults, but it also prevents you from instantiating a *DynamicMatrix* inside of a function and then passing a *REFERENCE TO* it back up the call chain.
Another consequnce is that a *DynamicMatrix* cannot be retained after power-loss.
A *DynamicMatrix* within a GVL will free its memory when the program terminates.

#### Initializers

All of these functions destroy any data already in the matrix and replace it with the new data.

* __Free()__ : Frees all dynamically allocated memory and resets the size of the matrix to 0x0
* __Init(R,C)__ : Initializes a *R*x*C* matrix, with potentially random non-zero values
* __InitZeros(R,C)__ : Initializes a *R*x*C* matrix where every element is equal to 0.0
* __InitVector(L,Val,Inc)__ : Initializes an *L*x1 column vector where the 0th element is equal to *Val* and every subsequent element is *Inc* larger than the previous
* __InitCopy(Matrix)__ : Initializes a matrix with the exact size and contents of the supplied matrix
* __InitIdentity(L)__ : Initializes a square identity matrix of size *L*x*L*
* __InitConstant(R,C,Val)__ : Initializes a *R*x*C* matrix where every element is equal to the supplied value
* __InitTrapezoidal(R,C,D,UR,LL)__ : Initializes a *R*x*C* matrix then fills is using *FillTrapezoidal()*

#### Dynamic Modifiers

All of these function change the dimensions *Rows* and *Cols*) of the matrix without destroying the data within the matrix.

* __Resize(R,C,Retain?,Init?)__ : Changes the total number of *Rows* and *Cols* in the matrix. 
If Retain is seleced then any element within the bounds of both the initial and resulting matrix will have its value retained.
If Init is selected then any newly created element will have its value set to zero.
* __Transpose()__ : Similar to *TransposeSquare()*, however it works on rectangular matricies (swapping *Rows* and *Cols*)
* __Shrink(R,C)__ : Removes the specified Row and Column from the matrix, resuling in a new size of (*Rows*-1,*Cols*-1). No dimension can be shrunk from 1 to 0 (therefore vectors only shrink in one direction).
* __Grow(R,C,Dval,Rval,Cval)__ : Adds a row and column in the specified positions. The value of the new element at the intersection is specified by DVal, while the values in the newly created Row and Column are specified by Rval and Cval, respectively.

#### Resultants

There are many functions available that initialzie the size and contents of a *DynamicMatrix* to the result of another function (typically a [modifier](#modifiers) or an [external function](#external-functions))

A non-exhaustive list of resultant functions (see documentation within TwinCAT for the full list):

* __AsElementSum__
* __AsInverse__
* __AsMatrixProduct__
* __AsVectorCrossProduct__
* __AsSubMatrix__
* __AsRowVector__
* __AsColVector__

### Static Memory Matrix

This type of matrix has the number of rows and columns set during initialization and then they cannot be changed.

#### Base StaticMatrix Class

This simple abstract class sets the rules for all static memory matricies by creating a protected *Init_(R,C)* method that must be called to set the initial size of the matrix.
It also implements the required *Rows* and *Cols* properties to return the values that were set during initialization.

#### ExternalStaticMatrix Class

This simple concrete derivative of the StaticMatrix class uses an external *ARRAY OF LREAL* as the memory source for the matrix data.
It is accessed in row-major order based on the logic in the *GetI* and *SetI* functions.
It is most useful when someone doesn't trust dynamically allocated memory, but also doesn't want to make multiple size-specific custom derived FBs just to set up a single complex matrix operation.

* __Init(R,C,pD)__ : Must be called in order to setup the matrix (it will be empty until this method is called).

---
**WARNING**

It is the callers responsibility to ensure that the pointer provided to the initializer is valid:

* The length of the data structure pointed to (probably an array of LREAL) is at least as long as *Rows* x *Cols*
* The scope of the data structure pointed to is the same as the scope of the corresponding *ExternalStaticMatrix* (probably declared adjacent to eachother as a VAR or GVL)

Additionally, direct assignment (`:=`) should not be used with this type of matrix because a second copy of the Matrix, but with a pointer to the original's data source, would be created.
For this reason, the pragma `{attribute 'no_assign'}` is used to block assignment at compile-time.
Keep in mind that returning a value from a function is also a form of assignment and is not allowed.

---

### Matrix Accessors

Matrix accessors are a way of interacting with the data of a parent *Matrix* through a special lens, without copying the data into a new *Matrix* and then back again.
This type of *Matrix* works by creating a function that converts the I-based indexing of the accessor matrix into the I-based indexing of the parent matrix, then using it to intercept calls to *GetI* and *SetI*.
Concrete Matrix Accessor Classes can be easily created from the parent MatrixAccessor abstract class by implementing the This2Parent method in order to define the index conversion.
Note that matrix accessor allow **both read and write access** to the parent matrix!

Included Matrix Accessors:

* __SubMatrixAccessor__ : Allows access to a rectangular subset of the parent matrix as if it were a standalone matrix
* __TransposeMatrixAccessor__ : Allows access to the elements of the parent matrix as if it were transposed
* __ShrunkMatrixAccessor__ : Allows access to the parent matrix as if the [*Shrink* function](#dynamic-modifiers) had been called

---
**WARNING**

Matrix Accessors inherently store a pointer (*BY REFERENCE*) to their parent matrix. 
If the parent matrix goes out of scope (through function return) or is moved (through an online change) then the Matrix Accessor will no longer work.
Therefore, they are best used quickly then destroyed, all within the scope of a single F or FB.

---

## Examples

### Projects With Implementations

* [TcTransform](https://github.com/BurksEngineering/TcTransform):  Static memory 3x1, 3x3, and 4x4 matricies for common 3D coordinate system transformations
* The unit tests within this project provide a large number of simple examples and usages
* The ExternalStaticMatrix is one example of how to implement the StaticMatrix base class