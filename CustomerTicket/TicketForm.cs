using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace CustomerTicket {
  public partial class TicketForm : Form {
    public TicketForm() {
      InitializeComponent();
    }

    async void Submit( object sender, EventArgs e ) {
      if (String.IsNullOrWhiteSpace(SubjectBox.Text) || String.IsNullOrWhiteSpace( DescriptionBox.Text ) ) {
        Error();
        return;
      }

      string priority;
      if ( Priority1.Checked ) {
        priority = "1";
      } else if (Priority2.Checked) {
        priority = "2";

      } else if (Priority3.Checked) {
        priority = "3";
      } else {
        Error();
        return;
      }

      Ticket ticket = new( SubjectBox.Text, DescriptionBox.Text, priority);

      SubmitButton.Text = "Submitting...";
      Success.Text = "";

      var result = await Task.Run( () => Main.post( ticket ) );

      if (result) {
        Success.Text = "Success";
        Success.ForeColor = Color.Green;
      } else {
        Success.Text = "Failure: Please check the error log.";
        Success.ForeColor = Color.Red;
      }

      SubmitButton.Text = "Submit";
    }

    void Error() {
      MessageBox.Show( "Please fill all empty fields" );
    }
  }
}