
namespace WindowsForms
{
    partial class FrmEnterAlarm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblRetrunMessage = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblAlarmID = new System.Windows.Forms.Label();
            this.lblServerNumber = new System.Windows.Forms.Label();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(282, 173);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 44);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(282, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Enter Alarm";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(83, 49);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(606, 80);
            this.txtMessage.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(314, 132);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(80, 25);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "lblError";
            this.lblError.Visible = false;
            // 
            // lblRetrunMessage
            // 
            this.lblRetrunMessage.AutoSize = true;
            this.lblRetrunMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRetrunMessage.Location = new System.Drawing.Point(50, 36);
            this.lblRetrunMessage.Name = "lblRetrunMessage";
            this.lblRetrunMessage.Size = new System.Drawing.Size(52, 21);
            this.lblRetrunMessage.TabIndex = 4;
            this.lblRetrunMessage.Text = "label1";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblAlarmID);
            this.grpResult.Controls.Add(this.lblServerNumber);
            this.grpResult.Controls.Add(this.lblRetrunMessage);
            this.grpResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpResult.Location = new System.Drawing.Point(83, 245);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(606, 178);
            this.grpResult.TabIndex = 5;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            this.grpResult.Visible = false;
            // 
            // lblAlarmID
            // 
            this.lblAlarmID.AutoSize = true;
            this.lblAlarmID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlarmID.Location = new System.Drawing.Point(50, 103);
            this.lblAlarmID.Name = "lblAlarmID";
            this.lblAlarmID.Size = new System.Drawing.Size(78, 21);
            this.lblAlarmID.TabIndex = 6;
            this.lblAlarmID.Text = "Alarm ID: ";
            // 
            // lblServerNumber
            // 
            this.lblServerNumber.AutoSize = true;
            this.lblServerNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServerNumber.Location = new System.Drawing.Point(50, 70);
            this.lblServerNumber.Name = "lblServerNumber";
            this.lblServerNumber.Size = new System.Drawing.Size(124, 21);
            this.lblServerNumber.TabIndex = 5;
            this.lblServerNumber.Text = "Server Number: ";
            // 
            // FrmEnterAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmEnterAlarm";
            this.Text = "Windows Form";
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblRetrunMessage;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblAlarmID;
        private System.Windows.Forms.Label lblServerNumber;
    }
}

