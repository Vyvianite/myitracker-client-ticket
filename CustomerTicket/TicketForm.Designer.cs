
namespace CustomerTicket {
  partial class TicketForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing ) {
      if ( disposing && ( components != null ) ) {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.SubjectLabel = new System.Windows.Forms.Label();
      this.SubjectBox = new System.Windows.Forms.TextBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.DescriptionBox = new System.Windows.Forms.TextBox();
      this.Priority1 = new System.Windows.Forms.RadioButton();
      this.PriorityGroup = new System.Windows.Forms.GroupBox();
      this.Priority3 = new System.Windows.Forms.RadioButton();
      this.Priority2 = new System.Windows.Forms.RadioButton();
      this.SubmitButton = new System.Windows.Forms.Button();
      this.Success = new System.Windows.Forms.Label();
      this.PriorityGroup.SuspendLayout();
      this.SuspendLayout();
      // 
      // SubjectLabel
      // 
      this.SubjectLabel.AutoSize = true;
      this.SubjectLabel.Location = new System.Drawing.Point(12, 9);
      this.SubjectLabel.Name = "SubjectLabel";
      this.SubjectLabel.Size = new System.Drawing.Size(49, 15);
      this.SubjectLabel.TabIndex = 0;
      this.SubjectLabel.Text = "Subject:";
      // 
      // SubjectBox
      // 
      this.SubjectBox.Location = new System.Drawing.Point(12, 27);
      this.SubjectBox.Name = "SubjectBox";
      this.SubjectBox.Size = new System.Drawing.Size(407, 23);
      this.SubjectBox.TabIndex = 1;
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(13, 79);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(133, 15);
      this.DescriptionLabel.TabIndex = 2;
      this.DescriptionLabel.Text = "Description of the issue:";
      // 
      // DescriptionBox
      // 
      this.DescriptionBox.Location = new System.Drawing.Point(12, 97);
      this.DescriptionBox.Multiline = true;
      this.DescriptionBox.Name = "DescriptionBox";
      this.DescriptionBox.Size = new System.Drawing.Size(407, 256);
      this.DescriptionBox.TabIndex = 3;
      // 
      // Priority1
      // 
      this.Priority1.AutoSize = true;
      this.Priority1.Location = new System.Drawing.Point(6, 22);
      this.Priority1.Name = "Priority1";
      this.Priority1.Size = new System.Drawing.Size(167, 19);
      this.Priority1.TabIndex = 4;
      this.Priority1.TabStop = true;
      this.Priority1.Text = "Cannot work until resolved";
      this.Priority1.UseVisualStyleBackColor = true;
      // 
      // PriorityGroup
      // 
      this.PriorityGroup.Controls.Add(this.Priority3);
      this.PriorityGroup.Controls.Add(this.Priority2);
      this.PriorityGroup.Controls.Add(this.Priority1);
      this.PriorityGroup.Location = new System.Drawing.Point(12, 372);
      this.PriorityGroup.Name = "PriorityGroup";
      this.PriorityGroup.Size = new System.Drawing.Size(282, 103);
      this.PriorityGroup.TabIndex = 6;
      this.PriorityGroup.TabStop = false;
      this.PriorityGroup.Text = "Priority";
      // 
      // Priority3
      // 
      this.Priority3.AutoSize = true;
      this.Priority3.Location = new System.Drawing.Point(6, 73);
      this.Priority3.Name = "Priority3";
      this.Priority3.Size = new System.Drawing.Size(165, 19);
      this.Priority3.TabIndex = 6;
      this.Priority3.TabStop = true;
      this.Priority3.Text = "Can work in the meantime";
      this.Priority3.UseVisualStyleBackColor = true;
      // 
      // Priority2
      // 
      this.Priority2.AutoSize = true;
      this.Priority2.Location = new System.Drawing.Point(6, 47);
      this.Priority2.Name = "Priority2";
      this.Priority2.Size = new System.Drawing.Size(261, 19);
      this.Priority2.TabIndex = 5;
      this.Priority2.TabStop = true;
      this.Priority2.Text = "Urgent, but can work around for a short time";
      this.Priority2.UseVisualStyleBackColor = true;
      // 
      // SubmitButton
      // 
      this.SubmitButton.Location = new System.Drawing.Point(12, 493);
      this.SubmitButton.Name = "SubmitButton";
      this.SubmitButton.Size = new System.Drawing.Size(170, 35);
      this.SubmitButton.TabIndex = 7;
      this.SubmitButton.Text = "Submit";
      this.SubmitButton.UseVisualStyleBackColor = true;
      this.SubmitButton.Click += new System.EventHandler(this.Submit);
      // 
      // Success
      // 
      this.Success.AutoSize = true;
      this.Success.Location = new System.Drawing.Point(189, 502);
      this.Success.Name = "Success";
      this.Success.Size = new System.Drawing.Size(0, 15);
      this.Success.TabIndex = 8;
      // 
      // TicketForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(432, 646);
      this.Controls.Add(this.Success);
      this.Controls.Add(this.SubmitButton);
      this.Controls.Add(this.PriorityGroup);
      this.Controls.Add(this.DescriptionBox);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.SubjectBox);
      this.Controls.Add(this.SubjectLabel);
      this.Name = "TicketForm";
      this.Text = "MyItracker";
      this.PriorityGroup.ResumeLayout(false);
      this.PriorityGroup.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label SubjectLabel;
    private System.Windows.Forms.TextBox SubjectBox;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.TextBox DescriptionBox;
    private System.Windows.Forms.RadioButton Priority1;
    private System.Windows.Forms.GroupBox PriorityGroup;
    private System.Windows.Forms.RadioButton Priority3;
    private System.Windows.Forms.RadioButton Priority2;
    private System.Windows.Forms.Button SubmitButton;
    private System.Windows.Forms.Label Success;
  }
}

