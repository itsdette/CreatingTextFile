namespace WindowsFormsApp1
{
    partial class frmLab1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(87, 46);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(203, 79);
            this.txtInput.TabIndex = 0;
            // 
            // btnCrate
            // 
            this.btnCrate.BackColor = System.Drawing.Color.Honeydew;
            this.btnCrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrate.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrate.Location = new System.Drawing.Point(128, 164);
            this.btnCrate.Name = "btnCrate";
            this.btnCrate.Size = new System.Drawing.Size(121, 39);
            this.btnCrate.TabIndex = 1;
            this.btnCrate.Text = "Create";
            this.btnCrate.UseVisualStyleBackColor = false;
            this.btnCrate.Click += new System.EventHandler(this.btnCrate_Click);
            // 
            // frmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(371, 242);
            this.Controls.Add(this.btnCrate);
            this.Controls.Add(this.txtInput);
            this.Name = "frmLab1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        public System.Windows.Forms.Button btnCrate;
    }
}

