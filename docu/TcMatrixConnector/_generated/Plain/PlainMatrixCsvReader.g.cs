using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMatrixCsvReader : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _bExecute;
		public System.Boolean bExecute
		{
			get
			{
				return _bExecute;
			}

			set
			{
				if (_bExecute != value)
				{
					_bExecute = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bExecute)));
				}
			}
		}

		PlainMatrix _M;
		public PlainMatrix M
		{
			get
			{
				return _M;
			}

			set
			{
				if (_M != value)
				{
					_M = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(M)));
				}
			}
		}

		System.TimeSpan _tTimeout;
		public System.TimeSpan tTimeout
		{
			get
			{
				return _tTimeout;
			}

			set
			{
				if (_tTimeout != value)
				{
					_tTimeout = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(tTimeout)));
				}
			}
		}

		System.UInt32 _nHeaderLines;
		public System.UInt32 nHeaderLines
		{
			get
			{
				return _nHeaderLines;
			}

			set
			{
				if (_nHeaderLines != value)
				{
					_nHeaderLines = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(nHeaderLines)));
				}
			}
		}

		System.Boolean _bBusy;
		public System.Boolean bBusy
		{
			get
			{
				return _bBusy;
			}

			set
			{
				if (_bBusy != value)
				{
					_bBusy = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bBusy)));
				}
			}
		}

		System.Boolean _bError;
		public System.Boolean bError
		{
			get
			{
				return _bError;
			}

			set
			{
				if (_bError != value)
				{
					_bError = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bError)));
				}
			}
		}

		System.UInt32 _nErrId;
		public System.UInt32 nErrId
		{
			get
			{
				return _nErrId;
			}

			set
			{
				if (_nErrId != value)
				{
					_nErrId = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(nErrId)));
				}
			}
		}

		System.UInt32 _nErrStep;
		public System.UInt32 nErrStep
		{
			get
			{
				return _nErrStep;
			}

			set
			{
				if (_nErrStep != value)
				{
					_nErrStep = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(nErrStep)));
				}
			}
		}

		System.UInt16 _nRows;
		public System.UInt16 nRows
		{
			get
			{
				return _nRows;
			}

			set
			{
				if (_nRows != value)
				{
					_nRows = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(nRows)));
				}
			}
		}

		System.UInt16 _nCols;
		public System.UInt16 nCols
		{
			get
			{
				return _nCols;
			}

			set
			{
				if (_nCols != value)
				{
					_nCols = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(nCols)));
				}
			}
		}

		System.UInt16 _nVals;
		public System.UInt16 nVals
		{
			get
			{
				return _nVals;
			}

			set
			{
				if (_nVals != value)
				{
					_nVals = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(nVals)));
				}
			}
		}

		System.UInt16 _hFile;
		public System.UInt16 hFile
		{
			get
			{
				return _hFile;
			}

			set
			{
				if (_hFile != value)
				{
					_hFile = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(hFile)));
				}
			}
		}

		System.Boolean _readEOF;
		public System.Boolean readEOF
		{
			get
			{
				return _readEOF;
			}

			set
			{
				if (_readEOF != value)
				{
					_readEOF = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(readEOF)));
				}
			}
		}

		System.Int32 _bytesRead;
		public System.Int32 bytesRead
		{
			get
			{
				return _bytesRead;
			}

			set
			{
				if (_bytesRead != value)
				{
					_bytesRead = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bytesRead)));
				}
			}
		}

		System.Int32 _bytesParsed;
		public System.Int32 bytesParsed
		{
			get
			{
				return _bytesParsed;
			}

			set
			{
				if (_bytesParsed != value)
				{
					_bytesParsed = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bytesParsed)));
				}
			}
		}

		System.String _buffer;
		public System.String buffer
		{
			get
			{
				return _buffer;
			}

			set
			{
				if (_buffer != value)
				{
					_buffer = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(buffer)));
				}
			}
		}

		System.UInt32 _step;
		public System.UInt32 step
		{
			get
			{
				return _step;
			}

			set
			{
				if (_step != value)
				{
					_step = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(step)));
				}
			}
		}

		System.UInt16 _Hi;
		public System.UInt16 Hi
		{
			get
			{
				return _Hi;
			}

			set
			{
				if (_Hi != value)
				{
					_Hi = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Hi)));
				}
			}
		}

		System.UInt16 _Ri;
		public System.UInt16 Ri
		{
			get
			{
				return _Ri;
			}

			set
			{
				if (_Ri != value)
				{
					_Ri = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Ri)));
				}
			}
		}

		System.UInt16 _Ci;
		public System.UInt16 Ci
		{
			get
			{
				return _Ci;
			}

			set
			{
				if (_Ci != value)
				{
					_Ci = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Ci)));
				}
			}
		}

		public const System.UInt32 __constbufferSize = 1024;
		System.UInt32 _bufferSize;
		public System.UInt32 bufferSize
		{
			get
			{
				return _bufferSize;
			}

			set
			{
				if (_bufferSize != value)
				{
					_bufferSize = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bufferSize)));
				}
			}
		}

		public const System.UInt32 __constdataSize = 16;
		System.UInt32 _dataSize;
		public System.UInt32 dataSize
		{
			get
			{
				return _dataSize;
			}

			set
			{
				if (_dataSize != value)
				{
					_dataSize = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(dataSize)));
				}
			}
		}

		public const System.UInt32 __conststepReady = 0;
		System.UInt32 _stepReady;
		public System.UInt32 stepReady
		{
			get
			{
				return _stepReady;
			}

			set
			{
				if (_stepReady != value)
				{
					_stepReady = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepReady)));
				}
			}
		}

		public const System.UInt32 __conststepOpenFile = 1;
		System.UInt32 _stepOpenFile;
		public System.UInt32 stepOpenFile
		{
			get
			{
				return _stepOpenFile;
			}

			set
			{
				if (_stepOpenFile != value)
				{
					_stepOpenFile = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepOpenFile)));
				}
			}
		}

		public const System.UInt32 __conststepFillBuffer = 2;
		System.UInt32 _stepFillBuffer;
		public System.UInt32 stepFillBuffer
		{
			get
			{
				return _stepFillBuffer;
			}

			set
			{
				if (_stepFillBuffer != value)
				{
					_stepFillBuffer = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepFillBuffer)));
				}
			}
		}

		public const System.UInt32 __conststepReadBuffer = 3;
		System.UInt32 _stepReadBuffer;
		public System.UInt32 stepReadBuffer
		{
			get
			{
				return _stepReadBuffer;
			}

			set
			{
				if (_stepReadBuffer != value)
				{
					_stepReadBuffer = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepReadBuffer)));
				}
			}
		}

		public const System.UInt32 __conststepMovePointer = 4;
		System.UInt32 _stepMovePointer;
		public System.UInt32 stepMovePointer
		{
			get
			{
				return _stepMovePointer;
			}

			set
			{
				if (_stepMovePointer != value)
				{
					_stepMovePointer = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepMovePointer)));
				}
			}
		}

		public const System.UInt32 __conststepCloseFile = 5;
		System.UInt32 _stepCloseFile;
		public System.UInt32 stepCloseFile
		{
			get
			{
				return _stepCloseFile;
			}

			set
			{
				if (_stepCloseFile != value)
				{
					_stepCloseFile = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepCloseFile)));
				}
			}
		}

		public const System.UInt32 __conststepDone = 6;
		System.UInt32 _stepDone;
		public System.UInt32 stepDone
		{
			get
			{
				return _stepDone;
			}

			set
			{
				if (_stepDone != value)
				{
					_stepDone = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepDone)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMatrixCsvReader()
		{
			_M = new PlainMatrix();
		}
	}
}