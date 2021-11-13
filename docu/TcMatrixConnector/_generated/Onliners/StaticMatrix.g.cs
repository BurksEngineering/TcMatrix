using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
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
///<seealso cref="PlcStaticMatrix"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "StaticMatrix", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class StaticMatrix : Matrix, Vortex.Connector.IVortexObject, IStaticMatrix, IShadowStaticMatrix, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _Rows_;
		public Vortex.Connector.ValueTypes.OnlinerUInt Rows_
		{
			get
			{
				return _Rows_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IStaticMatrix.Rows_
		{
			get
			{
				return Rows_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowStaticMatrix.Rows_
		{
			get
			{
				return Rows_;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _Cols_;
		public Vortex.Connector.ValueTypes.OnlinerUInt Cols_
		{
			get
			{
				return _Cols_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IStaticMatrix.Cols_
		{
			get
			{
				return Cols_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowStaticMatrix.Cols_
		{
			get
			{
				return Cols_;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Rows_.Shadow = Rows_.LastValue;
			Cols_.Shadow = Cols_.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Rows_.Cyclic = Rows_.Shadow;
			Cols_.Cyclic = Cols_.Shadow;
		}

		public new PlainStaticMatrix CreatePlainerType()
		{
			var cloned = new PlainStaticMatrix();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainStaticMatrix CreatePlainerType(PlainStaticMatrix cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(TcMatrix.PlainStaticMatrix source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainStaticMatrix source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainStaticMatrix source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public StaticMatrix(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Rows_ = @Connector.Online.Adapter.CreateUINT(this, "", "Rows_");
			_Cols_ = @Connector.Online.Adapter.CreateUINT(this, "", "Cols_");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public StaticMatrix(): base ()
		{
			PexPreConstructorParameterless();
			_Rows_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			_Cols_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStaticMatrix
	{
		public void CopyPlainToCyclic(TcMatrix.StaticMatrix target)
		{
			base.CopyPlainToCyclic(target);
			target.Rows_.Cyclic = Rows_;
			target.Cols_.Cyclic = Cols_;
		}

		public void CopyPlainToCyclic(TcMatrix.IStaticMatrix target)
		{
			this.CopyPlainToCyclic((TcMatrix.StaticMatrix)target);
		}

		public void CopyPlainToShadow(TcMatrix.StaticMatrix target)
		{
			base.CopyPlainToShadow(target);
			target.Rows_.Shadow = Rows_;
			target.Cols_.Shadow = Cols_;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowStaticMatrix target)
		{
			this.CopyPlainToShadow((TcMatrix.StaticMatrix)target);
		}

		public void CopyCyclicToPlain(TcMatrix.StaticMatrix source)
		{
			base.CopyCyclicToPlain(source);
			Rows_ = source.Rows_.LastValue;
			Cols_ = source.Cols_.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.IStaticMatrix source)
		{
			this.CopyCyclicToPlain((TcMatrix.StaticMatrix)source);
		}

		public void CopyShadowToPlain(TcMatrix.StaticMatrix source)
		{
			base.CopyShadowToPlain(source);
			Rows_ = source.Rows_.Shadow;
			Cols_ = source.Cols_.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowStaticMatrix source)
		{
			this.CopyShadowToPlain((TcMatrix.StaticMatrix)source);
		}
	}
}