using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMatrixAccessor : TcMatrix.PlainMatrix
	{
		PlainMatrix _M_;
		public PlainMatrix M_
		{
			get
			{
				return _M_;
			}

			set
			{
				if (_M_ != value)
				{
					_M_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(M_)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMatrixAccessor()
		{
			_M_ = new PlainMatrix();
		}
	}
}