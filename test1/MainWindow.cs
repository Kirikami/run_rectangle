using System;
using Gtk;
using System.Threading;
using System.Diagnostics;

public partial class MainWindow: Gtk.Window
{

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
		
	protected void OnRunRectangleClicked (object sender, EventArgs e)
	{
		int timeToRun;
		timeToRun = Convert.ToInt32(timeForRunning.Text);

		//Create process
		System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

		//strCommand is path and file name of command to run
		pProcess.StartInfo.FileName = "/Users/Kami-sama/Documents/study/test1/rectangle";

		pProcess.StartInfo.UseShellExecute = false;

		//Set output of program to be written to process output 
		pProcess.StartInfo.RedirectStandardOutput = true;

		//Start the process
		pProcess.Start();

		pProcess.BeginOutputReadLine();



		for (int i = timeToRun; i > 0; i = i - 1) 
		{
			System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(pProcess.ProcessName);
			if (processes.Length > 0) {
				Thread.Sleep (1000);
			} else {
				break;
			}
			pProcess.OutputDataReceived += new DataReceivedEventHandler((senderr, args) =>
				{
					if (!String.IsNullOrEmpty(args.Data))
					{
						Console.WriteLine("received from process: " + args.Data);
					}
				});
		}
		try
		{
			pProcess.StandardOutput.ReadToEnd(); 
			pProcess.Kill();
		}
		catch (InvalidOperationException err)
		{
			Console.WriteLine("process already finished");
		}
	}
		
}
