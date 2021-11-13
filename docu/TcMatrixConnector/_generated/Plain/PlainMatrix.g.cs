using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMatrix : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
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

		System.UInt16 _I;
		public System.UInt16 I
		{
			get
			{
				return _I;
			}

			set
			{
				if (_I != value)
				{
					_I = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(I)));
				}
			}
		}

		System.Double _ZeroReference_;
		public System.Double ZeroReference_
		{
			get
			{
				return _ZeroReference_;
			}

			set
			{
				if (_ZeroReference_ != value)
				{
					_ZeroReference_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ZeroReference_)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMatrix()
		{
		}
	}
}