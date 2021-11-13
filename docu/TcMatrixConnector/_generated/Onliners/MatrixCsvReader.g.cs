using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace TcMatrix
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MatrixCsvReader", "TcMatrix", TypeComplexityEnum.Complex)]
	public partial class MatrixCsvReader : Vortex.Connector.IVortexObject, IMatrixCsvReader, IShadowMatrixCsvReader, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMatrixCsvReader.bExecute
		{
			get
			{
				return bExecute;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMatrixCsvReader.bExecute
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

		IMatrix IMatrixCsvReader.M
		{
			get
			{
				return M;
			}
		}

		IShadowMatrix IShadowMatrixCsvReader.M
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

		Vortex.Connector.ValueTypes.Online.IOnlineTime IMatrixCsvReader.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowMatrixCsvReader.tTimeout
		{
			get
			{
				return tTimeout;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _nHeaderLines;
		public Vortex.Connector.ValueTypes.OnlinerUDInt nHeaderLines
		{
			get
			{
				return _nHeaderLines;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvReader.nHeaderLines
		{
			get
			{
				return nHeaderLines;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvReader.nHeaderLines
		{
			get
			{
				return nHeaderLines;
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMatrixCsvReader.bBusy
		{
			get
			{
				return bBusy;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMatrixCsvReader.bBusy
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

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMatrixCsvReader.bError
		{
			get
			{
				return bError;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMatrixCsvReader.bError
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvReader.nErrId
		{
			get
			{
				return nErrId;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvReader.nErrId
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvReader.nErrStep
		{
			get
			{
				return nErrStep;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvReader.nErrStep
		{
			get
			{
				return nErrStep;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _nRows;
		public Vortex.Connector.ValueTypes.OnlinerUInt nRows
		{
			get
			{
				return _nRows;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvReader.nRows
		{
			get
			{
				return nRows;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvReader.nRows
		{
			get
			{
				return nRows;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _nCols;
		public Vortex.Connector.ValueTypes.OnlinerUInt nCols
		{
			get
			{
				return _nCols;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvReader.nCols
		{
			get
			{
				return nCols;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvReader.nCols
		{
			get
			{
				return nCols;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _nVals;
		public Vortex.Connector.ValueTypes.OnlinerUInt nVals
		{
			get
			{
				return _nVals;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvReader.nVals
		{
			get
			{
				return nVals;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvReader.nVals
		{
			get
			{
				return nVals;
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvReader.hFile
		{
			get
			{
				return hFile;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvReader.hFile
		{
			get
			{
				return hFile;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _readEOF;
		public Vortex.Connector.ValueTypes.OnlinerBool readEOF
		{
			get
			{
				return _readEOF;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IMatrixCsvReader.readEOF
		{
			get
			{
				return readEOF;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowMatrixCsvReader.readEOF
		{
			get
			{
				return readEOF;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _bytesRead;
		public Vortex.Connector.ValueTypes.OnlinerDInt bytesRead
		{
			get
			{
				return _bytesRead;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt IMatrixCsvReader.bytesRead
		{
			get
			{
				return bytesRead;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowMatrixCsvReader.bytesRead
		{
			get
			{
				return bytesRead;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _bytesParsed;
		public Vortex.Connector.ValueTypes.OnlinerDInt bytesParsed
		{
			get
			{
				return _bytesParsed;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt IMatrixCsvReader.bytesParsed
		{
			get
			{
				return bytesParsed;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowMatrixCsvReader.bytesParsed
		{
			get
			{
				return bytesParsed;
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

		Vortex.Connector.ValueTypes.Online.IOnlineString IMatrixCsvReader.buffer
		{
			get
			{
				return buffer;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowMatrixCsvReader.buffer
		{
			get
			{
				return buffer;
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

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IMatrixCsvReader.step
		{
			get
			{
				return step;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowMatrixCsvReader.step
		{
			get
			{
				return step;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _Hi;
		public Vortex.Connector.ValueTypes.OnlinerUInt Hi
		{
			get
			{
				return _Hi;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvReader.Hi
		{
			get
			{
				return Hi;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvReader.Hi
		{
			get
			{
				return Hi;
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvReader.Ri
		{
			get
			{
				return Ri;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvReader.Ri
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMatrixCsvReader.Ci
		{
			get
			{
				return Ci;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMatrixCsvReader.Ci
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

		public const System.UInt32 __conststepFillBuffer = 2;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepFillBuffer;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepFillBuffer
		{
			get
			{
				return _stepFillBuffer;
			}
		}

		public const System.UInt32 __conststepReadBuffer = 3;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepReadBuffer;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepReadBuffer
		{
			get
			{
				return _stepReadBuffer;
			}
		}

		public const System.UInt32 __conststepMovePointer = 4;
		Vortex.Connector.ValueTypes.OnlinerUDInt _stepMovePointer;
		public Vortex.Connector.ValueTypes.OnlinerUDInt stepMovePointer
		{
			get
			{
				return _stepMovePointer;
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
			nHeaderLines.Shadow = nHeaderLines.LastValue;
			bBusy.Shadow = bBusy.LastValue;
			bError.Shadow = bError.LastValue;
			nErrId.Shadow = nErrId.LastValue;
			nErrStep.Shadow = nErrStep.LastValue;
			nRows.Shadow = nRows.LastValue;
			nCols.Shadow = nCols.LastValue;
			nVals.Shadow = nVals.LastValue;
			hFile.Shadow = hFile.LastValue;
			readEOF.Shadow = readEOF.LastValue;
			bytesRead.Shadow = bytesRead.LastValue;
			bytesParsed.Shadow = bytesParsed.LastValue;
			buffer.Shadow = buffer.LastValue;
			step.Shadow = step.LastValue;
			Hi.Shadow = Hi.LastValue;
			Ri.Shadow = Ri.LastValue;
			Ci.Shadow = Ci.LastValue;
		}

		public void LazyShadowToOnline()
		{
			bExecute.Cyclic = bExecute.Shadow;
			M.LazyShadowToOnline();
			tTimeout.Cyclic = tTimeout.Shadow;
			nHeaderLines.Cyclic = nHeaderLines.Shadow;
			bBusy.Cyclic = bBusy.Shadow;
			bError.Cyclic = bError.Shadow;
			nErrId.Cyclic = nErrId.Shadow;
			nErrStep.Cyclic = nErrStep.Shadow;
			nRows.Cyclic = nRows.Shadow;
			nCols.Cyclic = nCols.Shadow;
			nVals.Cyclic = nVals.Shadow;
			hFile.Cyclic = hFile.Shadow;
			readEOF.Cyclic = readEOF.Shadow;
			bytesRead.Cyclic = bytesRead.Shadow;
			bytesParsed.Cyclic = bytesParsed.Shadow;
			buffer.Cyclic = buffer.Shadow;
			step.Cyclic = step.Shadow;
			Hi.Cyclic = Hi.Shadow;
			Ri.Cyclic = Ri.Shadow;
			Ci.Cyclic = Ci.Shadow;
		}

		public PlainMatrixCsvReader CreatePlainerType()
		{
			var cloned = new PlainMatrixCsvReader();
			cloned.M = M.CreatePlainerType();
			return cloned;
		}

		protected PlainMatrixCsvReader CreatePlainerType(PlainMatrixCsvReader cloned)
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

		public void FlushPlainToOnline(TcMatrix.PlainMatrixCsvReader source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(TcMatrix.PlainMatrixCsvReader source)
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

		public void FlushOnlineToPlain(TcMatrix.PlainMatrixCsvReader source)
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

		public MatrixCsvReader(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_nHeaderLines = @Connector.Online.Adapter.CreateUDINT(this, "", "nHeaderLines");
			_bBusy = @Connector.Online.Adapter.CreateBOOL(this, "", "bBusy");
			_bError = @Connector.Online.Adapter.CreateBOOL(this, "", "bError");
			_nErrId = @Connector.Online.Adapter.CreateUDINT(this, "", "nErrId");
			_nErrStep = @Connector.Online.Adapter.CreateUDINT(this, "", "nErrStep");
			_nRows = @Connector.Online.Adapter.CreateUINT(this, "", "nRows");
			_nCols = @Connector.Online.Adapter.CreateUINT(this, "", "nCols");
			_nVals = @Connector.Online.Adapter.CreateUINT(this, "", "nVals");
			_hFile = @Connector.Online.Adapter.CreateUINT(this, "", "hFile");
			_readEOF = @Connector.Online.Adapter.CreateBOOL(this, "", "readEOF");
			_bytesRead = @Connector.Online.Adapter.CreateDINT(this, "", "bytesRead");
			_bytesParsed = @Connector.Online.Adapter.CreateDINT(this, "", "bytesParsed");
			_buffer = @Connector.Online.Adapter.CreateSTRING(this, "", "buffer");
			_step = @Connector.Online.Adapter.CreateUDINT(this, "", "step");
			_Hi = @Connector.Online.Adapter.CreateUINT(this, "", "Hi");
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
			_stepFillBuffer = @Connector.Online.Adapter.CreateUDINT(this, "", "stepFillBuffer");
			stepFillBuffer.MakeReadOnly();
			_stepReadBuffer = @Connector.Online.Adapter.CreateUDINT(this, "", "stepReadBuffer");
			stepReadBuffer.MakeReadOnly();
			_stepMovePointer = @Connector.Online.Adapter.CreateUDINT(this, "", "stepMovePointer");
			stepMovePointer.MakeReadOnly();
			_stepCloseFile = @Connector.Online.Adapter.CreateUDINT(this, "", "stepCloseFile");
			stepCloseFile.MakeReadOnly();
			_stepDone = @Connector.Online.Adapter.CreateUDINT(this, "", "stepDone");
			stepDone.MakeReadOnly();
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MatrixCsvReader()
		{
			PexPreConstructorParameterless();
			_bExecute = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_M = new Matrix();
			_tTimeout = Vortex.Connector.IConnectorFactory.CreateTIME();
			_nHeaderLines = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_bBusy = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_bError = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_nErrId = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_nErrStep = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_nRows = Vortex.Connector.IConnectorFactory.CreateUINT();
			_nCols = Vortex.Connector.IConnectorFactory.CreateUINT();
			_nVals = Vortex.Connector.IConnectorFactory.CreateUINT();
			_hFile = Vortex.Connector.IConnectorFactory.CreateUINT();
			_readEOF = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_bytesRead = Vortex.Connector.IConnectorFactory.CreateDINT();
			_bytesParsed = Vortex.Connector.IConnectorFactory.CreateDINT();
			_buffer = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_step = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_Hi = Vortex.Connector.IConnectorFactory.CreateUINT();
			_Ri = Vortex.Connector.IConnectorFactory.CreateUINT();
			_Ci = Vortex.Connector.IConnectorFactory.CreateUINT();
			_bufferSize = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_dataSize = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepReady = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepOpenFile = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepFillBuffer = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepReadBuffer = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_stepMovePointer = Vortex.Connector.IConnectorFactory.CreateUDINT();
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
	public partial class PlainMatrixCsvReader
	{
		public void CopyPlainToCyclic(TcMatrix.MatrixCsvReader target)
		{
			target.bExecute.Cyclic = bExecute;
			M.CopyPlainToCyclic(target.M);
			target.tTimeout.Cyclic = tTimeout;
			target.nHeaderLines.Cyclic = nHeaderLines;
			target.bBusy.Cyclic = bBusy;
			target.bError.Cyclic = bError;
			target.nErrId.Cyclic = nErrId;
			target.nErrStep.Cyclic = nErrStep;
			target.nRows.Cyclic = nRows;
			target.nCols.Cyclic = nCols;
			target.nVals.Cyclic = nVals;
			target.hFile.Cyclic = hFile;
			target.readEOF.Cyclic = readEOF;
			target.bytesRead.Cyclic = bytesRead;
			target.bytesParsed.Cyclic = bytesParsed;
			target.buffer.Cyclic = buffer;
			target.step.Cyclic = step;
			target.Hi.Cyclic = Hi;
			target.Ri.Cyclic = Ri;
			target.Ci.Cyclic = Ci;
			target.bufferSize.Cyclic = bufferSize;
			target.dataSize.Cyclic = dataSize;
			target.stepReady.Cyclic = stepReady;
			target.stepOpenFile.Cyclic = stepOpenFile;
			target.stepFillBuffer.Cyclic = stepFillBuffer;
			target.stepReadBuffer.Cyclic = stepReadBuffer;
			target.stepMovePointer.Cyclic = stepMovePointer;
			target.stepCloseFile.Cyclic = stepCloseFile;
			target.stepDone.Cyclic = stepDone;
		}

		public void CopyPlainToCyclic(TcMatrix.IMatrixCsvReader target)
		{
			this.CopyPlainToCyclic((TcMatrix.MatrixCsvReader)target);
		}

		public void CopyPlainToShadow(TcMatrix.MatrixCsvReader target)
		{
			target.bExecute.Shadow = bExecute;
			M.CopyPlainToShadow(target.M);
			target.tTimeout.Shadow = tTimeout;
			target.nHeaderLines.Shadow = nHeaderLines;
			target.bBusy.Shadow = bBusy;
			target.bError.Shadow = bError;
			target.nErrId.Shadow = nErrId;
			target.nErrStep.Shadow = nErrStep;
			target.nRows.Shadow = nRows;
			target.nCols.Shadow = nCols;
			target.nVals.Shadow = nVals;
			target.hFile.Shadow = hFile;
			target.readEOF.Shadow = readEOF;
			target.bytesRead.Shadow = bytesRead;
			target.bytesParsed.Shadow = bytesParsed;
			target.buffer.Shadow = buffer;
			target.step.Shadow = step;
			target.Hi.Shadow = Hi;
			target.Ri.Shadow = Ri;
			target.Ci.Shadow = Ci;
			target.bufferSize.Shadow = bufferSize;
			target.dataSize.Shadow = dataSize;
			target.stepReady.Shadow = stepReady;
			target.stepOpenFile.Shadow = stepOpenFile;
			target.stepFillBuffer.Shadow = stepFillBuffer;
			target.stepReadBuffer.Shadow = stepReadBuffer;
			target.stepMovePointer.Shadow = stepMovePointer;
			target.stepCloseFile.Shadow = stepCloseFile;
			target.stepDone.Shadow = stepDone;
		}

		public void CopyPlainToShadow(TcMatrix.IShadowMatrixCsvReader target)
		{
			this.CopyPlainToShadow((TcMatrix.MatrixCsvReader)target);
		}

		public void CopyCyclicToPlain(TcMatrix.MatrixCsvReader source)
		{
			bExecute = source.bExecute.LastValue;
			M.CopyCyclicToPlain(source.M);
			tTimeout = source.tTimeout.LastValue;
			nHeaderLines = source.nHeaderLines.LastValue;
			bBusy = source.bBusy.LastValue;
			bError = source.bError.LastValue;
			nErrId = source.nErrId.LastValue;
			nErrStep = source.nErrStep.LastValue;
			nRows = source.nRows.LastValue;
			nCols = source.nCols.LastValue;
			nVals = source.nVals.LastValue;
			hFile = source.hFile.LastValue;
			readEOF = source.readEOF.LastValue;
			bytesRead = source.bytesRead.LastValue;
			bytesParsed = source.bytesParsed.LastValue;
			buffer = source.buffer.LastValue;
			step = source.step.LastValue;
			Hi = source.Hi.LastValue;
			Ri = source.Ri.LastValue;
			Ci = source.Ci.LastValue;
			bufferSize = source.bufferSize.LastValue;
			dataSize = source.dataSize.LastValue;
			stepReady = source.stepReady.LastValue;
			stepOpenFile = source.stepOpenFile.LastValue;
			stepFillBuffer = source.stepFillBuffer.LastValue;
			stepReadBuffer = source.stepReadBuffer.LastValue;
			stepMovePointer = source.stepMovePointer.LastValue;
			stepCloseFile = source.stepCloseFile.LastValue;
			stepDone = source.stepDone.LastValue;
		}

		public void CopyCyclicToPlain(TcMatrix.IMatrixCsvReader source)
		{
			this.CopyCyclicToPlain((TcMatrix.MatrixCsvReader)source);
		}

		public void CopyShadowToPlain(TcMatrix.MatrixCsvReader source)
		{
			bExecute = source.bExecute.Shadow;
			M.CopyShadowToPlain(source.M);
			tTimeout = source.tTimeout.Shadow;
			nHeaderLines = source.nHeaderLines.Shadow;
			bBusy = source.bBusy.Shadow;
			bError = source.bError.Shadow;
			nErrId = source.nErrId.Shadow;
			nErrStep = source.nErrStep.Shadow;
			nRows = source.nRows.Shadow;
			nCols = source.nCols.Shadow;
			nVals = source.nVals.Shadow;
			hFile = source.hFile.Shadow;
			readEOF = source.readEOF.Shadow;
			bytesRead = source.bytesRead.Shadow;
			bytesParsed = source.bytesParsed.Shadow;
			buffer = source.buffer.Shadow;
			step = source.step.Shadow;
			Hi = source.Hi.Shadow;
			Ri = source.Ri.Shadow;
			Ci = source.Ci.Shadow;
			bufferSize = source.bufferSize.Shadow;
			dataSize = source.dataSize.Shadow;
			stepReady = source.stepReady.Shadow;
			stepOpenFile = source.stepOpenFile.Shadow;
			stepFillBuffer = source.stepFillBuffer.Shadow;
			stepReadBuffer = source.stepReadBuffer.Shadow;
			stepMovePointer = source.stepMovePointer.Shadow;
			stepCloseFile = source.stepCloseFile.Shadow;
			stepDone = source.stepDone.Shadow;
		}

		public void CopyShadowToPlain(TcMatrix.IShadowMatrixCsvReader source)
		{
			this.CopyShadowToPlain((TcMatrix.MatrixCsvReader)source);
		}
	}
}