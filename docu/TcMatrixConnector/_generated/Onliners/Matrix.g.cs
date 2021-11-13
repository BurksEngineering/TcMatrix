using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
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
///<seealso cref="PlcMatrix"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "Matrix", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class Matrix : Vortex.Connector.IVortexObject, IMatrix, IShadowMatrix, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return TcMatrixTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerUInt _Ri;
		public Vortex.Connector.ValueTypes.OnlinerUInt Ri
		{
			get
			{
				return _Ri;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrix.Ri
		{
			get
			{
				return Ri;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrix.Ri
		{
			get
			{
				return Ri;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _Ci;
		public Vortex.Connector.ValueTypes.OnlinerUInt Ci
		{
			get
			{
				return _Ci;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrix.Ci
		{
			get
			{
				return Ci;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrix.Ci
		{
			get
			{
				return Ci;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _I;
		public Vortex.Connector.ValueTypes.OnlinerUInt I
		{
			get
			{
				return _I;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrix.I
		{
			get
			{
				return I;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrix.I
		{
			get
			{
				return I;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal _ZeroReference_;
		public Vortex.Connector.ValueTypes.OnlinerLReal ZeroReference_
		{
			get
			{
				return _ZeroReference_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IMatrix.ZeroReference_
		{
			get
			{
				return ZeroReference_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowMatrix.ZeroReference_
		{
			get
			{
				return ZeroReference_;
			}
		}

		public void LazyOnlineToShadow()
		{
			Ri.Shadow = Ri.LastValue;
			Ci.Shadow = Ci.LastValue;
			I.Shadow = I.LastValue;
			ZeroReference_.Shadow = ZeroReference_.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Ri.Cyclic = Ri.Shadow;
			Ci.Cyclic = Ci.Shadow;
			I.Cyclic = I.Shadow;
			ZeroReference_.Cyclic = ZeroReference_.Shadow;
		}

		public PlainMatrix CreatePlainerType()
		{
			var cloned = new PlainMatrix();
			return cloned;
		}

		protected PlainMatrix CreatePlainerType(PlainMatrix cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(TcMatrix.PlainMatrix source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainMatrix source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(TcMatrix.PlainMatrix source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return TcMatrixTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public Matrix(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Ri = @Connector.Online.Adapter.CreateUINT(this, "", "Ri");
			_Ci = @Connector.Online.Adapter.CreateUINT(this, "", "Ci");
			_I = @Connector.Online.Adapter.CreateUINT(this, "", "I");
			_ZeroReference_ = @Connector.Online.Adapter.CreateLREAL(this, "", "ZeroReference_");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Matrix()
		{
			PexPreConstructorParameterless();
			_Ri = Vortex.Connector.IConnectorFactory.CreateUINT();
			_Ci = Vortex.Connector.IConnectorFactory.CreateUINT();
			_I = Vortex.Connector.IConnectorFactory.CreateUINT();
			_ZeroReference_ = Vortex.Connector.IConnectorFactory.CreateLREAL();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMatrix
	{
		public void CopyPlainToCyclic(TcMatrix.Matrix target)
		{
			target.Ri.Cyclic = Ri;
			target.Ci.Cyclic = Ci;
			target.I.Cyclic = I;
			target.ZeroReference_.Cyclic = ZeroReference_;
		}

		public void CopyPlainToCyclic(TcMatrix.IMatrix target)
		{
			this.CopyPlainToCyclic((TcMatrix.Matrix)target);
		}

		public void CopyPlainToShadow(TcMatrix.Matrix target)
		{
			target.Ri.Shadow = Ri;
			target.Ci.Shadow = Ci;
			target.I.Shadow = I;
			target.ZeroReference_.Shadow = ZeroReference_;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowMatrix target)
		{
			this.CopyPlainToShadow((TcMatrix.Matrix)target);
		}

		public void CopyCyclicToPlain(TcMatrix.Matrix source)
		{
			Ri = source.Ri.LastValue;
			Ci = source.Ci.LastValue;
			I = source.I.LastValue;
			ZeroReference_ = source.ZeroReference_.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.IMatrix source)
		{
			this.CopyCyclicToPlain((TcMatrix.Matrix)source);
		}

		public void CopyShadowToPlain(TcMatrix.Matrix source)
		{
			Ri = source.Ri.Shadow;
			Ci = source.Ci.Shadow;
			I = source.I.Shadow;
			ZeroReference_ = source.ZeroReference_.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowMatrix source)
		{
			this.CopyShadowToPlain((TcMatrix.Matrix)source);
		}
	}
}