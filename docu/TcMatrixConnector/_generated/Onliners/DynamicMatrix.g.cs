using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
	
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
///<seealso cref="PlcDynamicMatrix"/>
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "DynamicMatrix", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class DynamicMatrix : Matrix, Vortex.Connector.IVortexObject, IDynamicMatrix, IShadowDynamicMatrix, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _Rows_;
		public Vortex.Connector.ValueTypes.OnlinerUInt Rows_
		{
			get
			{
				return _Rows_;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IDynamicMatrix.Rows_
		{
			get
			{
				return Rows_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowDynamicMatrix.Rows_
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IDynamicMatrix.Cols_
		{
			get
			{
				return Cols_;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowDynamicMatrix.Cols_
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

		public new PlainDynamicMatrix CreatePlainerType()
		{
			var cloned = new PlainDynamicMatrix();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainDynamicMatrix CreatePlainerType(PlainDynamicMatrix cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(TcMatrix.PlainDynamicMatrix source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainDynamicMatrix source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainDynamicMatrix source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public DynamicMatrix(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
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

		public DynamicMatrix(): base ()
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
	public partial class PlainDynamicMatrix
	{
		public void CopyPlainToCyclic(TcMatrix.DynamicMatrix target)
		{
			base.CopyPlainToCyclic(target);
			target.Rows_.Cyclic = Rows_;
			target.Cols_.Cyclic = Cols_;
		}

		public void CopyPlainToCyclic(TcMatrix.IDynamicMatrix target)
		{
			this.CopyPlainToCyclic((TcMatrix.DynamicMatrix)target);
		}

		public void CopyPlainToShadow(TcMatrix.DynamicMatrix target)
		{
			base.CopyPlainToShadow(target);
			target.Rows_.Shadow = Rows_;
			target.Cols_.Shadow = Cols_;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowDynamicMatrix target)
		{
			this.CopyPlainToShadow((TcMatrix.DynamicMatrix)target);
		}

		public void CopyCyclicToPlain(TcMatrix.DynamicMatrix source)
		{
			base.CopyCyclicToPlain(source);
			Rows_ = source.Rows_.LastValue;
			Cols_ = source.Cols_.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.IDynamicMatrix source)
		{
			this.CopyCyclicToPlain((TcMatrix.DynamicMatrix)source);
		}

		public void CopyShadowToPlain(TcMatrix.DynamicMatrix source)
		{
			base.CopyShadowToPlain(source);
			Rows_ = source.Rows_.Shadow;
			Cols_ = source.Cols_.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowDynamicMatrix source)
		{
			this.CopyShadowToPlain((TcMatrix.DynamicMatrix)source);
		}
	}
}