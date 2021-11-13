using System;

namespace TcMatrix
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainExternalStaticMatrix : TcMatrix.PlainStaticMatrix
	{
		System.UInt16 _Length_;
		public System.UInt16 Length_
		{
			get
			{
				return _Length_;
			}

			set
			{
				if (_Length_ != value)
				{
					_Length_ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Length_)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainExternalStaticMatrix()
		{
		}
	}
}