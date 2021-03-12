
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
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
      this.Header = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.PriorityGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
      this.SuspendLayout();
      // 
      // SubjectLabel
      // 
      this.SubjectLabel.AutoSize = true;
      this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.SubjectLabel.Location = new System.Drawing.Point(12, 165);
      this.SubjectLabel.Name = "SubjectLabel";
      this.SubjectLabel.Size = new System.Drawing.Size(276, 21);
      this.SubjectLabel.TabIndex = 0;
      this.SubjectLabel.Text = "Give us a brief description of the issue:";
      // 
      // SubjectBox
      // 
      this.SubjectBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.SubjectBox.Location = new System.Drawing.Point(12, 189);
      this.SubjectBox.Name = "SubjectBox";
      this.SubjectBox.Size = new System.Drawing.Size(1024, 29);
      this.SubjectBox.TabIndex = 1;
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.DescriptionLabel.Location = new System.Drawing.Point(12, 234);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(239, 21);
      this.DescriptionLabel.TabIndex = 2;
      this.DescriptionLabel.Text = "Please provide more details here:";
      // 
      // DescriptionBox
      // 
      this.DescriptionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.DescriptionBox.Location = new System.Drawing.Point(12, 258);
      this.DescriptionBox.Multiline = true;
      this.DescriptionBox.Name = "DescriptionBox";
      this.DescriptionBox.Size = new System.Drawing.Size(1024, 151);
      this.DescriptionBox.TabIndex = 3;
      // 
      // Priority1
      // 
      this.Priority1.AutoSize = true;
      this.Priority1.Location = new System.Drawing.Point(6, 22);
      this.Priority1.Name = "Priority1";
      this.Priority1.Size = new System.Drawing.Size(215, 25);
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
      this.PriorityGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.PriorityGroup.Location = new System.Drawing.Point(12, 415);
      this.PriorityGroup.Name = "PriorityGroup";
      this.PriorityGroup.Size = new System.Drawing.Size(364, 103);
      this.PriorityGroup.TabIndex = 6;
      this.PriorityGroup.TabStop = false;
      this.PriorityGroup.Text = "Let us know how this impacts your work";
      // 
      // Priority3
      // 
      this.Priority3.AutoSize = true;
      this.Priority3.Location = new System.Drawing.Point(6, 73);
      this.Priority3.Name = "Priority3";
      this.Priority3.Size = new System.Drawing.Size(211, 25);
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
      this.Priority2.Size = new System.Drawing.Size(338, 25);
      this.Priority2.TabIndex = 5;
      this.Priority2.TabStop = true;
      this.Priority2.Text = "Urgent, but can work around for a short time";
      this.Priority2.UseVisualStyleBackColor = true;
      // 
      // SubmitButton
      // 
      this.SubmitButton.BackColor = System.Drawing.Color.DodgerBlue;
      this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.SubmitButton.FlatAppearance.BorderSize = 0;
      this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.SubmitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.SubmitButton.Location = new System.Drawing.Point(319, 574);
      this.SubmitButton.Name = "SubmitButton";
      this.SubmitButton.Size = new System.Drawing.Size(408, 60);
      this.SubmitButton.TabIndex = 7;
      this.SubmitButton.Text = "Send Request";
      this.SubmitButton.UseVisualStyleBackColor = false;
      this.SubmitButton.Click += new System.EventHandler(this.Submit);
      // 
      // Success
      // 
      this.Success.AutoSize = true;
      this.Success.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Success.Location = new System.Drawing.Point(387, 588);
      this.Success.Name = "Success";
      this.Success.Size = new System.Drawing.Size(0, 21);
      this.Success.TabIndex = 8;
      // 
      // Header
      // 
      this.Header.Image = global::CustomerTicket.Properties.Resources.Header;
      this.Header.Location = new System.Drawing.Point(-16, -6);
      this.Header.Name = "Header";
      this.Header.Size = new System.Drawing.Size(1077, 122);
      this.Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.Header.TabIndex = 9;
      this.Header.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(398, 119);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(246, 25);
      this.label1.TabIndex = 10;
      this.label1.Text = "Contact Technical Support";
      // 
      // TicketForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1048, 646);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Header);
      this.Controls.Add(this.Success);
      this.Controls.Add(this.SubmitButton);
      this.Controls.Add(this.PriorityGroup);
      this.Controls.Add(this.DescriptionBox);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.SubjectBox);
      this.Controls.Add(this.SubjectLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "TicketForm";
      this.Text = "MyItracker";
      this.PriorityGroup.ResumeLayout(false);
      this.PriorityGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
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
    private System.Windows.Forms.PictureBox Header;
    private System.Windows.Forms.Label label1;
  }
}

