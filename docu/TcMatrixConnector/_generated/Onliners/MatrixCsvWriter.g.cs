using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MatrixCsvWriter", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class MatrixCsvWriter : Vortex.Connector.IVortexObject, IMatrixCsvWriter, IShadowMatrixCsvWriter, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _bExecute;
		public Vortex.Connector.ValueTypes.OnlinerBool bExecute
		{
			get
			{
				return _bExecute;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMatrixCsvWriter.bExecute
		{
			get
			{
				return bExecute;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMatrixCsvWriter.bExecute
		{
			get
			{
				return bExecute;
			}
		}

		Matrix _M;
		public Matrix M
		{
			get
			{
				return _M;
			}
		}

		IMatrix IMatrixCsvWriter.M
		{
			get
			{
				return M;
			}
		}

		IShadowMatrix IShadowMatrixCsvWriter.M
		{
			get
			{
				return M;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _tTimeout;
		public Vortex.Connector.ValueTypes.OnlinerTime tTimeout
		{
			get
			{
				return _tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime IMatrixCsvWriter.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowMatrixCsvWriter.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _cbHeaderLen;
		public Vortex.Connector.ValueTypes.OnlinerUDInt cbHeaderLen
		{
			get
			{
				return _cbHeaderLen;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvWriter.cbHeaderLen
		{
			get
			{
				return cbHeaderLen;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvWriter.cbHeaderLen
		{
			get
			{
				return cbHeaderLen;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bBusy;
		public Vortex.Connector.ValueTypes.OnlinerBool bBusy
		{
			get
			{
				return _bBusy;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMatrixCsvWriter.bBusy
		{
			get
			{
				return bBusy;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMatrixCsvWriter.bBusy
		{
			get
			{
				return bBusy;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _bError;
		public Vortex.Connector.ValueTypes.OnlinerBool bError
		{
			get
			{
				return _bError;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMatrixCsvWriter.bError
		{
			get
			{
				return bError;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMatrixCsvWriter.bError
		{
			get
			{
				return bError;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _nErrId;
		public Vortex.Connector.ValueTypes.OnlinerUDInt nErrId
		{
			get
			{
				return _nErrId;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvWriter.nErrId
		{
			get
			{
				return nErrId;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvWriter.nErrId
		{
			get
			{
				return nErrId;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _nErrStep;
		public Vortex.Connector.ValueTypes.OnlinerUDInt nErrStep
		{
			get
			{
				return _nErrStep;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvWriter.nErrStep
		{
			get
			{
				return nErrStep;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvWriter.nErrStep
		{
			get
			{
				return nErrStep;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _hFile;
		public Vortex.Connector.ValueTypes.OnlinerUInt hFile
		{
			get
			{
				return _hFile;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvWriter.hFile
		{
			get
			{
				return hFile;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvWriter.hFile
		{
			get
			{
				return hFile;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _buffer;
		public Vortex.Connector.ValueTypes.OnlinerString buffer
		{
			get
			{
				return _buffer;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IMatrixCsvWriter.buffer
		{
			get
			{
				return buffer;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowMatrixCsvWriter.buffer
		{
			get
			{
				return buffer;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _bufferOffset;
		public Vortex.Connector.ValueTypes.OnlinerUInt bufferOffset
		{
			get
			{
				return _bufferOffset;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvWriter.bufferOffset
		{
			get
			{
				return bufferOffset;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvWriter.bufferOffset
		{
			get
			{
				return bufferOffset;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _step;
		public Vortex.Connector.ValueTypes.OnlinerUDInt step
		{
			get
			{
				return _step;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvWriter.step
		{
			get
			{
				return step;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvWriter.step
		{
			get
			{
				return step;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _Ri;
		public Vortex.Connector.ValueTypes.OnlinerUInt Ri
		{
			get
			{
				return _Ri;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvWriter.Ri
		{
			get
			{
				return Ri;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvWriter.Ri
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvWriter.Ci
		{
			get
			{
				return Ci;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvWriter.Ci
		{
			get
			{
				return Ci;
			}
		}

		public const System.UInt32 __constbufferSize = 1024;
		Vortex.Connector.ValueTypes.OnlinerUDInt _bufferSize;
		public Vortex.Connector.ValueTypes.OnlinerUDInt bufferSize
		{
			get
			{
				return _bufferSize;
			}
		}

		public const System.UInt32 __constdataSize = 16;
		Vortex.Connector.ValueTypes.OnlinerUDInt _dataSize;
		public Vortex.Connector.ValueTypes.OnlinerUDInt dataSize
		{
			get
			{
				return _dataSize;
			}
		}

		public const System.UInt32 __conststepReady = 0;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepReady;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepReady
		{
			get
			{
				return _stepReady;
			}
		}

		public const System.UInt32 __conststepOpenFile = 1;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepOpenFile;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepOpenFile
		{
			get
			{
				return _stepOpenFile;
			}
		}

		public const System.UInt32 __conststepWriteHeader = 2;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepWriteHeader;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepWriteHeader
		{
			get
			{
				return _stepWriteHeader;
			}
		}

		public const System.UInt32 __conststepFillBuffer = 3;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepFillBuffer;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepFillBuffer
		{
			get
			{
				return _stepFillBuffer;
			}
		}

		public const System.UInt32 __conststepWriteBuffer = 4;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepWriteBuffer;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepWriteBuffer
		{
			get
			{
				return _stepWriteBuffer;
			}
		}

		public const System.UInt32 __conststepCloseFile = 5;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepCloseFile;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepCloseFile
		{
			get
			{
				return _stepCloseFile;
			}
		}

		public const System.UInt32 __conststepDone = 6;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepDone;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepDone
		{
			get
			{
				return _stepDone;
			}
		}

		public void LazyOnlineToShadow()
		{
			bExecute.Shadow = bExecute.LastValue;
			M.LazyOnlineToShadow();
			tTimeout.Shadow = tTimeout.LastValue;
			cbHeaderLen.Shadow = cbHeaderLen.LastValue;
			bBusy.Shadow = bBusy.LastValue;
			bError.Shadow = bError.LastValue;
			nErrId.Shadow = nErrId.LastValue;
			nErrStep.Shadow = nErrStep.LastValue;
			hFile.Shadow = hFile.LastValue;
			buffer.Shadow = buffer.LastValue;
			bufferOffset.Shadow = bufferOffset.LastValue;
			step.Shadow = step.LastValue;
			Ri.Shadow = Ri.LastValue;
			Ci.Shadow = Ci.LastValue;
		}

		public void LazyShadowToOnline()
		{
			bExecute.Cyclic = bExecute.Shadow;
			M.LazyShadowToOnline();
			tTimeout.Cyclic = tTimeout.Shadow;
			cbHeaderLen.Cyclic = cbHeaderLen.Shadow;
			bBusy.Cyclic = bBusy.Shadow;
			bError.Cyclic = bError.Shadow;
			nErrId.Cyclic = nErrId.Shadow;
			nErrStep.Cyclic = nErrStep.Shadow;
			hFile.Cyclic = hFile.Shadow;
			buffer.Cyclic = buffer.Shadow;
			bufferOffset.Cyclic = bufferOffset.Shadow;
			step.Cyclic = step.Shadow;
			Ri.Cyclic = Ri.Shadow;
			Ci.Cyclic = Ci.Shadow;
		}

		public PlainMatrixCsvWriter CreatePlainerType()
		{
			var cloned = new PlainMatrixCsvWriter();
			cloned.M = M.CreatePlainerType();
			return cloned;
		}

		protected PlainMatrixCsvWriter CreatePlainerType(PlainMatrixCsvWriter cloned)
		{
			cloned.M = M.CreatePlainerType();
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

		public void FlushPlainToOnline(TcMatrix.PlainMatrixCsvWriter source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainMatrixCsvWriter source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainMatrixCsvWriter source)
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

		public MatrixCsvWriter(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_bExecute = @Connector.Online.Adapter.CreateBOOL(this, "", "bExecute");
			_M = new Matrix(this, "", "M");
			_tTimeout = @Connector.Online.Adapter.CreateTIME(this, "", "tTimeout");
			_cbHeaderLen = @Connector.Online.Adapter.CreateUDINT(this, "", "cbHeaderLen");
			_bBusy = @Connector.Online.Adapter.CreateBOOL(this, "", "bBusy");
			_bError = @Connector.Online.Adapter.CreateBOOL(this, "", "bError");
			_nErrId = @Connector.Online.Adapter.CreateUDINT(this, "", "nErrId");
			_nErrStep = @Connector.Online.Adapter.CreateUDINT(this, "", "nErrStep");
			_hFile = @Connector.Online.Adapter.CreateUINT(this, "", "hFile");
			_buffer = @Connector.Online.Adapter.CreateSTRING(this, "", "buffer");
			_bufferOffset = @Connector.Online.Adapter.CreateUINT(this, "", "bufferOffset");
			_step = @Connector.Online.Adapter.CreateUDINT(this, "", "step");
			_Ri = @Connector.Online.Adapter.CreateUINT(this, "", "Ri");
			_Ci = @Connector.Online.Adapter.CreateUINT(this, "", "Ci");
			_bufferSize = @Connector.Online.Adapter.CreateUDINT(this, "", "bufferSize");
			bufferSize.MakeReadOnly();
			_dataSize = @Connector.Online.Adapter.CreateUDINT(this, "", "dataSize");
			dataSize.MakeReadOnly();
			_stepReady = @Connector.Online.Adapter.CreateUDINT(this, "", "stepReady");
			stepReady.MakeReadOnly();
			_stepOpenFile = @Connector.Online.Adapter.CreateUDINT(this, "", "stepOpenFile");
			stepOpenFile.MakeReadOnly();
			_stepWriteHeader = @Connector.Online.Adapter.CreateUDINT(this, "", "stepWriteHeader");
			stepWriteHeader.MakeReadOnly();
			_stepFillBuffer = @Connector.Online.Adapter.CreateUDINT(this, "", "stepFillBuffer");
			stepFillBuffer.MakeReadOnly();
			_stepWriteBuffer = @Connector.Online.Adapter.CreateUDINT(this, "", "stepWriteBuffer");
			stepWriteBuffer.MakeReadOnly();
			_stepCloseFile = @Connector.Online.Adapter.CreateUDINT(this, "", "stepCloseFile");
			stepCloseFile.MakeReadOnly();
			_stepDone = @Connector.Online.Adapter.CreateUDINT(this, "", "stepDone");
			stepDone.MakeReadOnly();
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MatrixCsvWriter()
		{
			PexPreConstructorParameterless();
			_bExecute = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_M = new Matrix();
			_tTimeout = Vortex.Connector.IConnectorFactory.CreateTIME();
			_cbHeaderLen = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_bBusy = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_bError = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_nErrId = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_nErrStep = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_hFile = Vortex.Connector.IConnectorFactory.CreateUINT();
			_buffer = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_bufferOffset = Vortex.Connector.IConnectorFactory.CreateUINT();
			_step = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_Ri = Vortex.Connector.IConnectorFactory.CreateUINT();
			_Ci = Vortex.Connector.IConnectorFactory.CreateUINT();
			_bufferSize = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_dataSize = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepReady = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepOpenFile = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepWriteHeader = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepFillBuffer = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepWriteBuffer = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepCloseFile = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepDone = Vortex.Connector.IConnectorFactory.CreateUDINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMatrixCsvWriter
	{
		public void CopyPlainToCyclic(TcMatrix.MatrixCsvWriter target)
		{
			target.bExecute.Cyclic = bExecute;
			M.CopyPlainToCyclic(target.M);
			target.tTimeout.Cyclic = tTimeout;
			target.cbHeaderLen.Cyclic = cbHeaderLen;
			target.bBusy.Cyclic = bBusy;
			target.bError.Cyclic = bError;
			target.nErrId.Cyclic = nErrId;
			target.nErrStep.Cyclic = nErrStep;
			target.hFile.Cyclic = hFile;
			target.buffer.Cyclic = buffer;
			target.bufferOffset.Cyclic = bufferOffset;
			target.step.Cyclic = step;
			target.Ri.Cyclic = Ri;
			target.Ci.Cyclic = Ci;
			target.bufferSize.Cyclic = bufferSize;
			target.dataSize.Cyclic = dataSize;
			target.stepReady.Cyclic = stepReady;
			target.stepOpenFile.Cyclic = stepOpenFile;
			target.stepWriteHeader.Cyclic = stepWriteHeader;
			target.stepFillBuffer.Cyclic = stepFillBuffer;
			target.stepWriteBuffer.Cyclic = stepWriteBuffer;
			target.stepCloseFile.Cyclic = stepCloseFile;
			target.stepDone.Cyclic = stepDone;
		}

		public void CopyPlainToCyclic(TcMatrix.IMatrixCsvWriter target)
		{
			this.CopyPlainToCyclic((TcMatrix.MatrixCsvWriter)target);
		}

		public void CopyPlainToShadow(TcMatrix.MatrixCsvWriter target)
		{
			target.bExecute.Shadow = bExecute;
			M.CopyPlainToShadow(target.M);
			target.tTimeout.Shadow = tTimeout;
			target.cbHeaderLen.Shadow = cbHeaderLen;
			target.bBusy.Shadow = bBusy;
			target.bError.Shadow = bError;
			target.nErrId.Shadow = nErrId;
			target.nErrStep.Shadow = nErrStep;
			target.hFile.Shadow = hFile;
			target.buffer.Shadow = buffer;
			target.bufferOffset.Shadow = bufferOffset;
			target.step.Shadow = step;
			target.Ri.Shadow = Ri;
			target.Ci.Shadow = Ci;
			target.bufferSize.Shadow = bufferSize;
			target.dataSize.Shadow = dataSize;
			target.stepReady.Shadow = stepReady;
			target.stepOpenFile.Shadow = stepOpenFile;
			target.stepWriteHeader.Shadow = stepWriteHeader;
			target.stepFillBuffer.Shadow = stepFillBuffer;
			target.stepWriteBuffer.Shadow = stepWriteBuffer;
			target.stepCloseFile.Shadow = stepCloseFile;
			target.stepDone.Shadow = stepDone;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowMatrixCsvWriter target)
		{
			this.CopyPlainToShadow((TcMatrix.MatrixCsvWriter)target);
		}

		public void CopyCyclicToPlain(TcMatrix.MatrixCsvWriter source)
		{
			bExecute = source.bExecute.LastValue;
			M.CopyCyclicToPlain(source.M);
			tTimeout = source.tTimeout.LastValue;
			cbHeaderLen = source.cbHeaderLen.LastValue;
			bBusy = source.bBusy.LastValue;
			bError = source.bError.LastValue;
			nErrId = source.nErrId.LastValue;
			nErrStep = source.nErrStep.LastValue;
			hFile = source.hFile.LastValue;
			buffer = source.buffer.LastValue;
			bufferOffset = source.bufferOffset.LastValue;
			step = source.step.LastValue;
			Ri = source.Ri.LastValue;
			Ci = source.Ci.LastValue;
			bufferSize = source.bufferSize.LastValue;
			dataSize = source.dataSize.LastValue;
			stepReady = source.stepReady.LastValue;
			stepOpenFile = source.stepOpenFile.LastValue;
			stepWriteHeader = source.stepWriteHeader.LastValue;
			stepFillBuffer = source.stepFillBuffer.LastValue;
			stepWriteBuffer = source.stepWriteBuffer.LastValue;
			stepCloseFile = source.stepCloseFile.LastValue;
			stepDone = source.stepDone.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.IMatrixCsvWriter source)
		{
			this.CopyCyclicToPlain((TcMatrix.MatrixCsvWriter)source);
		}

		public void CopyShadowToPlain(TcMatrix.MatrixCsvWriter source)
		{
			bExecute = source.bExecute.Shadow;
			M.CopyShadowToPlain(source.M);
			tTimeout = source.tTimeout.Shadow;
			cbHeaderLen = source.cbHeaderLen.Shadow;
			bBusy = source.bBusy.Shadow;
			bError = source.bError.Shadow;
			nErrId = source.nErrId.Shadow;
			nErrStep = source.nErrStep.Shadow;
			hFile = source.hFile.Shadow;
			buffer = source.buffer.Shadow;
			bufferOffset = source.bufferOffset.Shadow;
			step = source.step.Shadow;
			Ri = source.Ri.Shadow;
			Ci = source.Ci.Shadow;
			bufferSize = source.bufferSize.Shadow;
			dataSize = source.dataSize.Shadow;
			stepReady = source.stepReady.Shadow;
			stepOpenFile = source.stepOpenFile.Shadow;
			stepWriteHeader = source.stepWriteHeader.Shadow;
			stepFillBuffer = source.stepFillBuffer.Shadow;
			stepWriteBuffer = source.stepWriteBuffer.Shadow;
			stepCloseFile = source.stepCloseFile.Shadow;
			stepDone = source.stepDone.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowMatrixCsvWriter source)
		{
			this.CopyShadowToPlain((TcMatrix.MatrixCsvWriter)source);
		}
	}
}