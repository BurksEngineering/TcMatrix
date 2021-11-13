using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainShrunkMatrixAccessor : TcMatrix.PlainMatrixAccessor
	{
		System.UInt16 _RowRemoved_;
		public System.UInt16 RowRemoved_
		{
			get
			{
				return _RowRemoved_;
			}

			set
			{
				if (_RowRemoved_ != value)
				{
					_RowRemoved_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(RowRemoved_)));
				}
			}
		}

		System.UInt16 _ColRemoved_;
		public System.UInt16 ColRemoved_
		{
			get
			{
				return _ColRemoved_;
			}

			set
			{
				if (_ColRemoved_ != value)
				{
					_ColRemoved_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ColRemoved_)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainShrunkMatrixAccessor()
		{
		}
	}
}