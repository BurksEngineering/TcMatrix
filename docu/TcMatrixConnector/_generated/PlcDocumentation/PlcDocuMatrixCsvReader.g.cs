using System;

namespace PlcDocu.TcMatrix
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class MatrixCsvReader
	{
		public object bExecute;
		public Matrix M;
		public object sPathName;
		public object tTimeout;
		public object nHeaderLines;
		public object bBusy;
		public object bError;
		public object nErrId;
		public object nErrStep;
		public object nRows;
		public object nCols;
		public object nVals;
		public object FileOpen;
		public object CsvRead;
		public object FileRead;
		public object FileSeek;
		public object FileClose;
		public object hFile;
		public object readEOF;
		public object bytesRead;
		public object bytesParsed;
		public object buffer;
		public object step;
		public object Hi;
		public object Ri;
		public object Ci;
		public object BuffCmd;
		public object bufferSize;
		public object dataSize;
		public object stepReady;
		public object stepOpenFile;
		public object stepFillBuffer;
		public object stepReadBuffer;
		public object stepMovePointer;
		public object stepCloseFile;
		public object stepDone;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public MatrixCsvReader()
		{
		}
	}
#endif
}