using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
///		<summary>
///			<see cref="MatrixAccessor">See Matrix accessor</see>
///			Allows access to a rectangular subset of the parent matrix as if it were a standalone matrix
///		</summary>			
///<seealso cref="PlcSubMatrixAccessor"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "SubMatrixAccessor", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class SubMatrixAccessor : MatrixAccessor, Vortex.Connector.IVortexObject, ISubMatrixAccessor, IShadowSubMatrixAccessor, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _RowStart_;
		public Vortex.Connector.ValueTypes.OnlinerUInt RowStart_
		{
			get
			{
				return _RowStart_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ISubMatrixAccessor.RowStart_
		{
			get
			{
				return RowStart_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowSubMatrixAccessor.RowStart_
		{
			get
			{
				return RowStart_;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _RowCount_;
		public Vortex.Connector.ValueTypes.OnlinerUInt RowCount_
		{
			get
			{
				return _RowCount_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ISubMatrixAccessor.RowCount_
		{
			get
			{
				return RowCount_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowSubMatrixAccessor.RowCount_
		{
			get
			{
				return RowCount_;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _ColStart_;
		public Vortex.Connector.ValueTypes.OnlinerUInt ColStart_
		{
			get
			{
				return _ColStart_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ISubMatrixAccessor.ColStart_
		{
			get
			{
				return ColStart_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowSubMatrixAccessor.ColStart_
		{
			get
			{
				return ColStart_;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _ColCount_;
		public Vortex.Connector.ValueTypes.OnlinerUInt ColCount_
		{
			get
			{
				return _ColCount_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt ISubMatrixAccessor.ColCount_
		{
			get
			{
				return ColCount_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowSubMatrixAccessor.ColCount_
		{
			get
			{
				return ColCount_;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			RowStart_.Shadow = RowStart_.LastValue;
			RowCount_.Shadow = RowCount_.LastValue;
			ColStart_.Shadow = ColStart_.LastValue;
			ColCount_.Shadow = ColCount_.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			RowStart_.Cyclic = RowStart_.Shadow;
			RowCount_.Cyclic = RowCount_.Shadow;
			ColStart_.Cyclic = ColStart_.Shadow;
			ColCount_.Cyclic = ColCount_.Shadow;
		}

		public new PlainSubMatrixAccessor CreatePlainerType()
		{
			var cloned = new PlainSubMatrixAccessor();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainSubMatrixAccessor CreatePlainerType(PlainSubMatrixAccessor cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(TcMatrix.PlainSubMatrixAccessor source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainSubMatrixAccessor source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainSubMatrixAccessor source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public SubMatrixAccessor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_RowStart_ = @Connector.Online.Adapter.CreateUINT(this, "", "RowStart_");
			_RowCount_ = @Connector.Online.Adapter.CreateUINT(this, "", "RowCount_");
			_ColStart_ = @Connector.Online.Adapter.CreateUINT(this, "", "ColStart_");
			_ColCount_ = @Connector.Online.Adapter.CreateUINT(this, "", "ColCount_");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public SubMatrixAccessor(): base ()
		{
			PexPreConstructorParameterless();
			_RowStart_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			_RowCount_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			_ColStart_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			_ColCount_ = Vortex.Connector.IConnectorFactory.CreateUINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSubMatrixAccessor
	{
		public void CopyPlainToCyclic(TcMatrix.SubMatrixAccessor target)
		{
			base.CopyPlainToCyclic(target);
			target.RowStart_.Cyclic = RowStart_;
			target.RowCount_.Cyclic = RowCount_;
			target.ColStart_.Cyclic = ColStart_;
			target.ColCount_.Cyclic = ColCount_;
		}

		public void CopyPlainToCyclic(TcMatrix.ISubMatrixAccessor target)
		{
			this.CopyPlainToCyclic((TcMatrix.SubMatrixAccessor)target);
		}

		public void CopyPlainToShadow(TcMatrix.SubMatrixAccessor target)
		{
			base.CopyPlainToShadow(target);
			target.RowStart_.Shadow = RowStart_;
			target.RowCount_.Shadow = RowCount_;
			target.ColStart_.Shadow = ColStart_;
			target.ColCount_.Shadow = ColCount_;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowSubMatrixAccessor target)
		{
			this.CopyPlainToShadow((TcMatrix.SubMatrixAccessor)target);
		}

		public void CopyCyclicToPlain(TcMatrix.SubMatrixAccessor source)
		{
			base.CopyCyclicToPlain(source);
			RowStart_ = source.RowStart_.LastValue;
			RowCount_ = source.RowCount_.LastValue;
			ColStart_ = source.ColStart_.LastValue;
			ColCount_ = source.ColCount_.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.ISubMatrixAccessor source)
		{
			this.CopyCyclicToPlain((TcMatrix.SubMatrixAccessor)source);
		}

		public void CopyShadowToPlain(TcMatrix.SubMatrixAccessor source)
		{
			base.CopyShadowToPlain(source);
			RowStart_ = source.RowStart_.Shadow;
			RowCount_ = source.RowCount_.Shadow;
			ColStart_ = source.ColStart_.Shadow;
			ColCount_ = source.ColCount_.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowSubMatrixAccessor source)
		{
			this.CopyShadowToPlain((TcMatrix.SubMatrixAccessor)source);
		}
	}
}