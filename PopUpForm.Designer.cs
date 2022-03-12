namespace School
{
    partial class PopUpForm
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnStart = new System.Windows.Forms.RadioButton();
            this.rbtnFinish = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(185, 75);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            // 
            // rbtnStart
            // 
            this.rbtnStart.AutoSize = true;
            this.rbtnStart.Location = new System.Drawing.Point(13, 39);
            this.rbtnStart.Name = "rbtnStart";
            this.rbtnStart.Size = new System.Drawing.Size(101, 17);
            this.rbtnStart.TabIndex = 1;
            this.rbtnStart.TabStop = true;
            this.rbtnStart.Text = "Start Homework";
            this.rbtnStart.UseVisualStyleBackColor = true;
            // 
            // rbtnFinish
            // 
            this.rbtnFinish.AutoSize = true;
            this.rbtnFinish.Location = new System.Drawing.Point(124, 39);
            this.rbtnFinish.Name = "rbtnFinish";
            this.rbtnFinish.Size = new System.Drawing.Size(106, 17);
            this.rbtnFinish.TabIndex = 2;
            this.rbtnFinish.TabStop = true;
            this.rbtnFinish.Text = "Finish Homework";
            this.rbtnFinish.UseVisualStyleBackColor = true;
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 110);
            this.Controls.Add(this.rbtnFinish);
            this.Controls.Add(this.rbtnStart);
            this.Controls.Add(this.btnOk);
            this.Name = "PopUpForm";
            this.Text = "Hw Situation Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        public System.Windows.Forms.RadioButton rbtnStart;
        public System.Windows.Forms.RadioButton rbtnFinish;
    }
}