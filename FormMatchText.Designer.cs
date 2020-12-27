
namespace SentMessagesSave
{
    partial class FormMatchText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCurrentMatchText = new System.Windows.Forms.TextBox();
            this.lblMatchText = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMatchTextMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrentMatchText
            // 
            this.txtCurrentMatchText.Location = new System.Drawing.Point(115, 66);
            this.txtCurrentMatchText.Name = "txtCurrentMatchText";
            this.txtCurrentMatchText.Size = new System.Drawing.Size(322, 20);
            this.txtCurrentMatchText.TabIndex = 0;
            // 
            // lblMatchText
            // 
            this.lblMatchText.AutoSize = true;
            this.lblMatchText.Location = new System.Drawing.Point(45, 69);
            this.lblMatchText.Name = "lblMatchText";
            this.lblMatchText.Size = new System.Drawing.Size(64, 13);
            this.lblMatchText.TabIndex = 1;
            this.lblMatchText.Text = "Match Text:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMatchTextMessage
            // 
            this.lblMatchTextMessage.AutoSize = true;
            this.lblMatchTextMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMatchTextMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMatchTextMessage.Name = "lblMatchTextMessage";
            this.lblMatchTextMessage.Size = new System.Drawing.Size(482, 13);
            this.lblMatchTextMessage.TabIndex = 4;
            this.lblMatchTextMessage.Text = "Please fill in this option if you wish to only save messages where a subject matc" +
    "hes the text specified.";
            this.lblMatchTextMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMatchText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 181);
            this.Controls.Add(this.lblMatchTextMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMatchText);
            this.Controls.Add(this.txtCurrentMatchText);
            this.Name = "FormMatchText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Match Text";
            this.Load += new System.EventHandler(this.FormMatchText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentMatchText;
        private System.Windows.Forms.Label lblMatchText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMatchTextMessage;
    }
}