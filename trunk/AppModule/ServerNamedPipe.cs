using System;
using System.Threading;
using System.IO;

using AppModule.InterProcessComm;
using AppModule.NamedPipes;

namespace AppModule
{

	public sealed class ServerNamedPipe : IDisposable {
		internal Thread PipeThread;
		internal ServerPipeConnection PipeConnection;
		internal bool Listen = true;
		internal DateTime LastAction;
        private PipeManager manager;
		private bool disposed = false;

		private void PipeListener() {
			CheckIfDisposed();
			try {
                Listen = manager.Listen;
				//Form1.ActivityRef.AppendText("Pipe " + this.PipeConnection.NativeHandle.ToString() + ": new pipe started" + Environment.NewLine);
				while (Listen) {
					LastAction = DateTime.Now;
					string request = PipeConnection.Read();
					LastAction = DateTime.Now;
					if (request.Trim() != "") {
                        PipeConnection.Write(manager.HandleRequest(request));
						//Form1.ActivityRef.AppendText("Pipe " + this.PipeConnection.NativeHandle.ToString() + ": request handled" + Environment.NewLine);
					}
					else {
						PipeConnection.Write("Error: bad request");
					}
					LastAction = DateTime.Now;
					PipeConnection.Disconnect();
					if (Listen) {
						//Form1.ActivityRef.AppendText("Pipe " + this.PipeConnection.NativeHandle.ToString() + ": listening" + Environment.NewLine);
						Connect();
					}
                    manager.WakeUp();
				}
			} 
			catch (System.Threading.ThreadAbortException) { }
			catch (System.Threading.ThreadStateException) { }
			catch (Exception) { 
				// Log exception
			}
			finally {
				this.Close();
			}
		}
		internal void Connect() {
			CheckIfDisposed();
			PipeConnection.Connect();
		}
		internal void Close() {
			CheckIfDisposed();
			this.Listen = false;
            manager.RemoveServerChannel(this.PipeConnection.NativeHandle);
			this.Dispose();
		}
		internal void Start() {
			CheckIfDisposed();
			PipeThread.Start();
		}
		private void CheckIfDisposed() {
			if(this.disposed) {
				throw new ObjectDisposedException("ServerNamedPipe");
			}
		}
		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		private void Dispose(bool disposing) {
			if(!this.disposed) {
				PipeConnection.Dispose();
				if (PipeThread != null) {
					try {
						PipeThread.Abort();
					} 
					catch (System.Threading.ThreadAbortException) { }
					catch (System.Threading.ThreadStateException) { }
					catch (Exception) {
						// Log exception
					}
				}
			}
			disposed = true;         
		}
		~ServerNamedPipe() {
			Dispose(false);
		}
		internal ServerNamedPipe(string name, uint outBuffer, uint inBuffer, int maxReadBytes, bool secure, PipeManager manager) {
			PipeConnection = new ServerPipeConnection(name, outBuffer, inBuffer, maxReadBytes, secure);
			PipeThread = new Thread(new ThreadStart(PipeListener));
			PipeThread.IsBackground = true;
			PipeThread.Name = "Pipe Thread " + this.PipeConnection.NativeHandle.ToString();
			LastAction = DateTime.Now;
            this.manager = manager;
		}
	}
}