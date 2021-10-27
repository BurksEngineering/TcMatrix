using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
///		<summary>
///		 	 <see cref="MatrixAccessor">See Matrix accessor</see>
///			 Allows access to the elements of the parent matrix as if it were transposed
///		</summary>			
///<seealso cref="PlcTransposeMatrixAccessor"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "TransposeMatrixAccessor", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class TransposeMatrixAccessor : MatrixAccessor, Vortex.Connector.IVortexObject, ITransposeMatrixAccessor, IShadowTransposeMatrixAccessor, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _RowRemoved_;
		public Vortex.Connector.ValueTypes.OnlinerUInt RowRemoved_
		{
			get
			{
				return _RowRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ITransposeMatrixAccessor.RowRemoved_
		{
			get
			{
				return RowRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowTransposeMatrixAccessor.RowRemoved_
		{
			get
			{
				return RowRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _ColRemoved_;
		public Vortex.Connector.ValueTypes.OnlinerUInt ColRemoved_
		{
			get
			{
				return _ColRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ITransposeMatrixAccessor.ColRemoved_
		{
			get
			{
				return ColRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowTransposeMatrixAccessor.ColRemoved_
		{
			get
			{
				return ColRemoved_;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			RowRemoved_.Shadow = RowRemoved_.LastValue;
			ColRemoved_.Shadow = ColRemoved_.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			RowRemoved_.Cyclic = RowRemoved_.Shadow;
			ColRemoved_.Cyclic = ColRemoved_.Shadow;
		}

		public new PlainTransposeMatrixAccessor CreatePlainerType()
		{
			var cloned = new PlainTransposeMatrixAccessor();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainTransposeMatrixAccessor CreatePlainerType(PlainTransposeMatrixAccessor cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(TcMatrix.PlainTransposeMatrixAccessor source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainTransposeMatrixAccessor source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainTransposeMatrixAccessor source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public TransposeMatrixAccessor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_RowRemoved_ = @Connector.Online.Adapter.CreateUINT(this, "", "RowRemoved_");
			_ColRemoved_ = @Connector.Online.Adapter.CreateUINT(this, "", "ColRemoved_");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public TransposeMatrixAccessor(): base ()
		{
			PexPreConstructorParameterless();
			_RowRemoved_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			_ColRemoved_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTransposeMatrixAccessor
	{
		public void CopyPlainToCyclic(TcMatrix.TransposeMatrixAccessor target)
		{
			base.CopyPlainToCyclic(target);
			target.RowRemoved_.Cyclic = RowRemoved_;
			target.ColRemoved_.Cyclic = ColRemoved_;
		}

		public void CopyPlainToCyclic(TcMatrix.ITransposeMatrixAccessor target)
		{
			this.CopyPlainToCyclic((TcMatrix.TransposeMatrixAccessor)target);
		}

		public void CopyPlainToShadow(TcMatrix.TransposeMatrixAccessor target)
		{
			base.CopyPlainToShadow(target);
			target.RowRemoved_.Shadow = RowRemoved_;
			target.ColRemoved_.Shadow = ColRemoved_;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowTransposeMatrixAccessor target)
		{
			this.CopyPlainToShadow((TcMatrix.TransposeMatrixAccessor)target);
		}

		public void CopyCyclicToPlain(TcMatrix.TransposeMatrixAccessor source)
		{
			base.CopyCyclicToPlain(source);
			RowRemoved_ = source.RowRemoved_.LastValue;
			ColRemoved_ = source.ColRemoved_.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.ITransposeMatrixAccessor source)
		{
			this.CopyCyclicToPlain((TcMatrix.TransposeMatrixAccessor)source);
		}

		public void CopyShadowToPlain(TcMatrix.TransposeMatrixAccessor source)
		{
			base.CopyShadowToPlain(source);
			RowRemoved_ = source.RowRemoved_.Shadow;
			ColRemoved_ = source.ColRemoved_.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowTransposeMatrixAccessor source)
		{
			this.CopyShadowToPlain((TcMatrix.TransposeMatrixAccessor)source);
		}
	}
}