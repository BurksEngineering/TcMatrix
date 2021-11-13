using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Global_Version
	{
		public object stLibVersion_TcMatrix;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Global_Version()
		{
		}
	}
#endif
}