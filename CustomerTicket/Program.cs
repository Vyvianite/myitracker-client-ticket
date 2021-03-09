using MutexManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTicket {
  static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      if ( !SingleInstance.Start() ) { return; } // mutex not obtained so exit
      Application.SetHighDpiMode( HighDpiMode.SystemAware );
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault( false );
      try {
        Application.Run( new TrayContext() );
      }
      catch ( Exception ex ) {
        MessageBox.Show( ex.Message, "Program Terminated Unexpectedly",
            MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
      SingleInstance.Stop(); // all finished so release the mutex
    }
  }
}