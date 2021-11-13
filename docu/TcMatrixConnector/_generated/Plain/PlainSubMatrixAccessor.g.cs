using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSubMatrixAccessor : TcMatrix.PlainMatrixAccessor
	{
		System.UInt16 _RowStart_;
		public System.UInt16 RowStart_
		{
			get
			{
				return _RowStart_;
			}

			set
			{
				if (_RowStart_ != value)
				{
					_RowStart_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(RowStart_)));
				}
			}
		}

		System.UInt16 _RowCount_;
		public System.UInt16 RowCount_
		{
			get
			{
				return _RowCount_;
			}

			set
			{
				if (_RowCount_ != value)
				{
					_RowCount_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(RowCount_)));
				}
			}
		}

		System.UInt16 _ColStart_;
		public System.UInt16 ColStart_
		{
			get
			{
				return _ColStart_;
			}

			set
			{
				if (_ColStart_ != value)
				{
					_ColStart_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ColStart_)));
				}
			}
		}

		System.UInt16 _ColCount_;
		public System.UInt16 ColCount_
		{
			get
			{
				return _ColCount_;
			}

			set
			{
				if (_ColCount_ != value)
				{
					_ColCount_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ColCount_)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainSubMatrixAccessor()
		{
		}
	}
}