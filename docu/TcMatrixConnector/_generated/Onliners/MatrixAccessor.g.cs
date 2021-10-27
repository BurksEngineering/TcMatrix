using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
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
///<seealso cref="PlcMatrixAccessor"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MatrixAccessor", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class MatrixAccessor : Matrix, Vortex.Connector.IVortexObject, IMatrixAccessor, IShadowMatrixAccessor, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Matrix _M_;
		public Matrix M_
		{
			get
			{
				return _M_;
			}
		}

		IMatrix IMatrixAccessor.M_
		{
			get
			{
				return M_;
			}
		}

		IShadowMatrix IShadowMatrixAccessor.M_
		{
			get
			{
				return M_;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			M_.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			M_.LazyShadowToOnline();
		}

		public new PlainMatrixAccessor CreatePlainerType()
		{
			var cloned = new PlainMatrixAccessor();
			base.CreatePlainerType(cloned);
			cloned.M_ = M_.CreatePlainerType();
			return cloned;
		}

		protected PlainMatrixAccessor CreatePlainerType(PlainMatrixAccessor cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.M_ = M_.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(TcMatrix.PlainMatrixAccessor source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainMatrixAccessor source)
		{
			source.CopyPlainToShadow(this);
		}

		public new void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public new void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(TcMatrix.PlainMatrixAccessor source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public MatrixAccessor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_M_ = new Matrix(this, "", "M_");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MatrixAccessor(): base ()
		{
			PexPreConstructorParameterless();
			_M_ = new Matrix();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMatrixAccessor
	{
		public void CopyPlainToCyclic(TcMatrix.MatrixAccessor target)
		{
			base.CopyPlainToCyclic(target);
			M_.CopyPlainToCyclic(target.M_);
		}

		public void CopyPlainToCyclic(TcMatrix.IMatrixAccessor target)
		{
			this.CopyPlainToCyclic((TcMatrix.MatrixAccessor)target);
		}

		public void CopyPlainToShadow(TcMatrix.MatrixAccessor target)
		{
			base.CopyPlainToShadow(target);
			M_.CopyPlainToShadow(target.M_);
		}

		public void CopyPlainToShadow(TcMatrix.IShadowMatrixAccessor target)
		{
			this.CopyPlainToShadow((TcMatrix.MatrixAccessor)target);
		}

		public void CopyCyclicToPlain(TcMatrix.MatrixAccessor source)
		{
			base.CopyCyclicToPlain(source);
			M_.CopyCyclicToPlain(source.M_);
		}

		public void CopyCyclicToPlain(TcMatrix.IMatrixAccessor source)
		{
			this.CopyCyclicToPlain((TcMatrix.MatrixAccessor)source);
		}

		public void CopyShadowToPlain(TcMatrix.MatrixAccessor source)
		{
			base.CopyShadowToPlain(source);
			M_.CopyShadowToPlain(source.M_);
		}

		public void CopyShadowToPlain(TcMatrix.IShadowMatrixAccessor source)
		{
			this.CopyShadowToPlain((TcMatrix.MatrixAccessor)source);
		}
	}
}