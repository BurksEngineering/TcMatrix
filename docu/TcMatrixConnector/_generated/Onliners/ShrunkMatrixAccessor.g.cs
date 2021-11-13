using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
///		<summary>
///		 	 <see cref="TcMatrix.MatrixAccessor">See Matrix accessor</see>
///			  Allows access to the parent matrix as if the <see cref="DynamicMatrix.Shrink">Shrink</see> function had been called
///		</summary>			
///<seealso cref="PlcShrunkMatrixAccessor"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "ShrunkMatrixAccessor", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class ShrunkMatrixAccessor : MatrixAccessor, Vortex.Connector.IVortexObject, IShrunkMatrixAccessor, IShadowShrunkMatrixAccessor, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _RowRemoved_;
		public Vortex.Connector.ValueTypes.OnlinerUInt RowRemoved_
		{
			get
			{
				return _RowRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IShrunkMatrixAccessor.RowRemoved_
		{
			get
			{
				return RowRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowShrunkMatrixAccessor.RowRemoved_
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IShrunkMatrixAccessor.ColRemoved_
		{
			get
			{
				return ColRemoved_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowShrunkMatrixAccessor.ColRemoved_
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

		public new PlainShrunkMatrixAccessor CreatePlainerType()
		{
			var cloned = new PlainShrunkMatrixAccessor();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainShrunkMatrixAccessor CreatePlainerType(PlainShrunkMatrixAccessor cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(TcMatrix.PlainShrunkMatrixAccessor source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainShrunkMatrixAccessor source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainShrunkMatrixAccessor source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public ShrunkMatrixAccessor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
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

		public ShrunkMatrixAccessor(): base ()
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
	public partial class PlainShrunkMatrixAccessor
	{
		public void CopyPlainToCyclic(TcMatrix.ShrunkMatrixAccessor target)
		{
			base.CopyPlainToCyclic(target);
			target.RowRemoved_.Cyclic = RowRemoved_;
			target.ColRemoved_.Cyclic = ColRemoved_;
		}

		public void CopyPlainToCyclic(TcMatrix.IShrunkMatrixAccessor target)
		{
			this.CopyPlainToCyclic((TcMatrix.ShrunkMatrixAccessor)target);
		}

		public void CopyPlainToShadow(TcMatrix.ShrunkMatrixAccessor target)
		{
			base.CopyPlainToShadow(target);
			target.RowRemoved_.Shadow = RowRemoved_;
			target.ColRemoved_.Shadow = ColRemoved_;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowShrunkMatrixAccessor target)
		{
			this.CopyPlainToShadow((TcMatrix.ShrunkMatrixAccessor)target);
		}

		public void CopyCyclicToPlain(TcMatrix.ShrunkMatrixAccessor source)
		{
			base.CopyCyclicToPlain(source);
			RowRemoved_ = source.RowRemoved_.LastValue;
			ColRemoved_ = source.ColRemoved_.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.IShrunkMatrixAccessor source)
		{
			this.CopyCyclicToPlain((TcMatrix.ShrunkMatrixAccessor)source);
		}

		public void CopyShadowToPlain(TcMatrix.ShrunkMatrixAccessor source)
		{
			base.CopyShadowToPlain(source);
			RowRemoved_ = source.RowRemoved_.Shadow;
			ColRemoved_ = source.ColRemoved_.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowShrunkMatrixAccessor source)
		{
			this.CopyShadowToPlain((TcMatrix.ShrunkMatrixAccessor)source);
		}
	}
}