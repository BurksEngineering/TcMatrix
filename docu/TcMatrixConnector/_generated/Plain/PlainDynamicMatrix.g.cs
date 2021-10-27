using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDynamicMatrix : TcMatrix.PlainMatrix
	{
		System.UInt16 _Rows_;
		public System.UInt16 Rows_
		{
			get
			{
				return _Rows_;
			}

			set
			{
				if (_Rows_ != value)
				{
					_Rows_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Rows_)));
				}
			}
		}

		System.UInt16 _Cols_;
		public System.UInt16 Cols_
		{
			get
			{
				return _Cols_;
			}

			set
			{
				if (_Cols_ != value)
				{
					_Cols_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Cols_)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainDynamicMatrix()
		{
		}
	}
}