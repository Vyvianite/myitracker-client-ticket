using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;

namespace CustomerTicket {

  public class TrayContext : ApplicationContext {
    private static readonly string DefaultTooltip = "Report an Issue";
    private IContainer components;  // a list of components to dispose when the context is disposed
    private NotifyIcon notifyIcon;  // the icon that sits in the system tray
    private Form ticketForm;

    /// <summary>
		/// This class should be created and passed into Application.Run()
		/// </summary>
		public TrayContext() {
      components = new Container();
      notifyIcon = new NotifyIcon( components ) {
        ContextMenuStrip = new(),
        Icon = Properties.Resources.MyItIcon,
        Text = DefaultTooltip,
        Visible = true
      };
      notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;
      notifyIcon.DoubleClick += notifyIcon_DoubleClick;
    }

    #region the child forms
    
    private void ShowForm() {
      if ( ticketForm is null ) {
        ticketForm = new TicketForm();
        ticketForm.Closed += ticketFormClosed; // avoid reshowing a disposed form
        ticketForm.Show();
      }
      else { 
        ticketForm.Activate(); 
      }
    }

    private void notifyIcon_DoubleClick( object sender, EventArgs e ) { ShowForm(); }

    private void ContextMenuStrip_Opening( object sender, CancelEventArgs e ) {
      e.Cancel = false;
      notifyIcon.ContextMenuStrip.Items.Add( "Exit", null, exitItem_Click );
    }

    // null out the forms so we know to create a new one.
    private void ticketFormClosed( object sender, EventArgs e ) { ticketForm = null; }

    #endregion the child forms

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
