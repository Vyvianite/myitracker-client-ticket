using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace CustomerTicket {

  public class TrayContext : ApplicationContext {
    // Icon graphic from http://prothemedesign.com/circular-icons/
    private static readonly string IconFileName = "route.ico";
    private static readonly string DefaultTooltip = "Route HOST entries via context menu";

    /// <summary>
		/// This class should be created and passed into Application.Run()
		/// </summary>
		public TrayContext() {
      InitializeContext();
    }

    private void ContextMenuStrip_Opening( object sender, System.ComponentModel.CancelEventArgs e ) {
      e.Cancel = false;
    }

    #region the child forms
    private Form ticketForm;

    private void ShowForm() {
      if ( ticketForm is null ) {
        ticketForm = new TicketForm();
        ticketForm.Closed += ticketFormClosed; // avoid reshowing a disposed form
        //ElementHost.EnableModelessKeyboardInterop( ticketForm );
        ticketForm.Show();
      }
      else { 
        ticketForm.Activate(); 
      }
    }

    private void notifyIcon_DoubleClick( object sender, EventArgs e ) { ShowForm(); }

    // null out the forms so we know to create a new one.
    private void ticketFormClosed( object sender, EventArgs e ) { ticketForm = null; }

    #endregion the child forms

    private System.ComponentModel.IContainer components;  // a list of components to dispose when the context is disposed
    private NotifyIcon notifyIcon;                        // the icon that sits in the system tray

    private void InitializeContext() {
      components = new System.ComponentModel.Container();
      notifyIcon = new NotifyIcon( components ) {
        ContextMenuStrip = new ContextMenuStrip(),
        Icon = new Icon( IconFileName ),
        Text = DefaultTooltip,
        Visible = true
      };
      //notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;
      notifyIcon.DoubleClick += notifyIcon_DoubleClick;
    }


    protected override void Dispose( bool disposing ) {
      if ( disposing && components != null ) { components.Dispose(); }
    }

    
    private void exitItem_Click( object sender, EventArgs e ) {
      ExitThread();
    }

    
    protected override void ExitThreadCore() {
      // before we exit, let forms clean themselves up.
      if ( ticketForm is not null ) { ticketForm.Close(); }

      notifyIcon.Visible = false; // should remove lingering tray icon
      base.ExitThreadCore();
    }
  }
}
