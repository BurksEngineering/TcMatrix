using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMatrixCsvWriter : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
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

		System.UInt32 _cbHeaderLen;
		public System.UInt32 cbHeaderLen
		{
			get
			{
				return _cbHeaderLen;
			}

			set
			{
				if (_cbHeaderLen != value)
				{
					_cbHeaderLen = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(cbHeaderLen)));
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

		System.UInt16 _bufferOffset;
		public System.UInt16 bufferOffset
		{
			get
			{
				return _bufferOffset;
			}

			set
			{
				if (_bufferOffset != value)
				{
					_bufferOffset = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(bufferOffset)));
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

		public const System.UInt32 __conststepWriteHeader = 2;
		System.UInt32 _stepWriteHeader;
		public System.UInt32 stepWriteHeader
		{
			get
			{
				return _stepWriteHeader;
			}

			set
			{
				if (_stepWriteHeader != value)
				{
					_stepWriteHeader = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepWriteHeader)));
				}
			}
		}

		public const System.UInt32 __conststepFillBuffer = 3;
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

		public const System.UInt32 __conststepWriteBuffer = 4;
		System.UInt32 _stepWriteBuffer;
		public System.UInt32 stepWriteBuffer
		{
			get
			{
				return _stepWriteBuffer;
			}

			set
			{
				if (_stepWriteBuffer != value)
				{
					_stepWriteBuffer = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stepWriteBuffer)));
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
		public PlainMatrixCsvWriter()
		{
			_M = new PlainMatrix();
		}
	}
}