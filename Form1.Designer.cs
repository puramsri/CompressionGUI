namespace CompressionGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnCompress;
        private Button btnDecompress;

        // Dispose the components
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize the components (Controls)
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDecompress = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtInput properties
            this.txtInput.Location = new System.Drawing.Point(20, 20);
            this.txtInput.Size = new System.Drawing.Size(250, 20);

            // btnCompress properties
            this.btnCompress.Location = new System.Drawing.Point(20, 50);
            this.btnCompress.Size = new System.Drawing.Size(100, 30);
            this.btnCompress.Text = "Compress";
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);

            // btnDecompress properties
            this.btnDecompress.Location = new System.Drawing.Point(140, 50);
            this.btnDecompress.Size = new System.Drawing.Size(100, 30);
            this.btnDecompress.Text = "Decompress";
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);

            // txtOutput properties
            this.txtOutput.Location = new System.Drawing.Point(20, 90);
            this.txtOutput.Size = new System.Drawing.Size(250, 20);
            this.txtOutput.ReadOnly = true;

            // Form1 properties
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnDecompress);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Compression App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}