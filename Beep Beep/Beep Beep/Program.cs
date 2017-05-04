using System;
using System.Windows.Forms;
using OpenGL;

namespace HelloTriangle
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			string envDebug = Environment.GetEnvironmentVariable("DEBUG");
			if (envDebug == "GL") {
				KhronosApi.Log += delegate(object sender, KhronosLogEventArgs e) {
					Console.WriteLine(e.ToString());
				};
				KhronosApi.LogEnabled = true;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SampleForm());
		}
	}
}