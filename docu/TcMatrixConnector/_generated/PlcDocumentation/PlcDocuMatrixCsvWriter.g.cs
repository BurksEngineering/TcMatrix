using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class MatrixCsvWriter
	{
		public object bExecute;
		public Matrix M;
		public object sPathName;
		public object tTimeout;
		public object pHeader;
		public object cbHeaderLen;
		public object bBusy;
		public object bError;
		public object nErrId;
		public object nErrStep;
		public object FileOpen;
		public object CsvWrite;
		public object FileWrite;
		public object FileClose;
		public object hFile;
		public object buffer;
		public object bufferOffset;
		public object step;
		public object Ri;
		public object Ci;
		public object BuffCmd;
		public object bufferSize;
		public object dataSize;
		public object stepReady;
		public object stepOpenFile;
		public object stepWriteHeader;
		public object stepFillBuffer;
		public object stepWriteBuffer;
		public object stepCloseFile;
		public object stepDone;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public MatrixCsvWriter()
		{
		}
	}
#endif
}