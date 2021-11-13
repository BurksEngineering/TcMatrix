using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
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
///<seealso cref="PlcExternalStaticMatrix"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ExternalStaticMatrix", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class ExternalStaticMatrix : StaticMatrix, Vortex.Connector.IVortexObject, IExternalStaticMatrix, IShadowExternalStaticMatrix, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _Length_;
		public Vortex.Connector.ValueTypes.OnlinerUInt Length_
		{
			get
			{
				return _Length_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IExternalStaticMatrix.Length_
		{
			get
			{
				return Length_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowExternalStaticMatrix.Length_
		{
			get
			{
				return Length_;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Length_.Shadow = Length_.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Length_.Cyclic = Length_.Shadow;
		}

		public new PlainExternalStaticMatrix CreatePlainerType()
		{
			var cloned = new PlainExternalStaticMatrix();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainExternalStaticMatrix CreatePlainerType(PlainExternalStaticMatrix cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(TcMatrix.PlainExternalStaticMatrix source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainExternalStaticMatrix source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainExternalStaticMatrix source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public ExternalStaticMatrix(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Length_ = @Connector.Online.Adapter.CreateUINT(this, "", "Length_");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public ExternalStaticMatrix(): base ()
		{
			PexPreConstructorParameterless();
			_Length_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainExternalStaticMatrix
	{
		public void CopyPlainToCyclic(TcMatrix.ExternalStaticMatrix target)
		{
			base.CopyPlainToCyclic(target);
			target.Length_.Cyclic = Length_;
		}

		public void CopyPlainToCyclic(TcMatrix.IExternalStaticMatrix target)
		{
			this.CopyPlainToCyclic((TcMatrix.ExternalStaticMatrix)target);
		}

		public void CopyPlainToShadow(TcMatrix.ExternalStaticMatrix target)
		{
			base.CopyPlainToShadow(target);
			target.Length_.Shadow = Length_;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowExternalStaticMatrix target)
		{
			this.CopyPlainToShadow((TcMatrix.ExternalStaticMatrix)target);
		}

		public void CopyCyclicToPlain(TcMatrix.ExternalStaticMatrix source)
		{
			base.CopyCyclicToPlain(source);
			Length_ = source.Length_.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.IExternalStaticMatrix source)
		{
			this.CopyCyclicToPlain((TcMatrix.ExternalStaticMatrix)source);
		}

		public void CopyShadowToPlain(TcMatrix.ExternalStaticMatrix source)
		{
			base.CopyShadowToPlain(source);
			Length_ = source.Length_.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowExternalStaticMatrix source)
		{
			this.CopyShadowToPlain((TcMatrix.ExternalStaticMatrix)source);
		}
	}
}