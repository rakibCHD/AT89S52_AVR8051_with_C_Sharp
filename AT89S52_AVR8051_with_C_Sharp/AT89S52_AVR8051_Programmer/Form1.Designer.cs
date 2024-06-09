
namespace AT89S52_AVR8051_Programmer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Guideline_Label = new System.Windows.Forms.Label();
            this.Reconnect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.UploadHex = new System.Windows.Forms.Button();
            this.AT89S52_about = new System.Windows.Forms.Label();
            this.AT89S52Chip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AT89S52Chip)).BeginInit();
            this.SuspendLayout();
            // 
            // Guideline_Label
            // 
            this.Guideline_Label.AutoSize = true;
            this.Guideline_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guideline_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Guideline_Label.Location = new System.Drawing.Point(830, 529);
            this.Guideline_Label.Name = "Guideline_Label";
            this.Guideline_Label.Size = new System.Drawing.Size(141, 25);
            this.Guideline_Label.TabIndex = 45;
            this.Guideline_Label.Text = "@GuideLine";
            this.Guideline_Label.Click += new System.EventHandler(this.Guideline_Label_Click);
            // 
            // Reconnect
            // 
            this.Reconnect.BackColor = System.Drawing.Color.LightGray;
            this.Reconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reconnect.Location = new System.Drawing.Point(25, 263);
            this.Reconnect.Name = "Reconnect";
            this.Reconnect.Size = new System.Drawing.Size(131, 38);
            this.Reconnect.TabIndex = 43;
            this.Reconnect.Text = "Reconnect";
            this.Reconnect.UseVisualStyleBackColor = false;
            this.Reconnect.Click += new System.EventHandler(this.Reconnect_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(76, 183);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(40, 18);
            this.Port.TabIndex = 42;
            this.Port.Text = "Port";
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.Color.LightGray;
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(25, 318);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(131, 38);
            this.disconnect.TabIndex = 41;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Connected Port\r\n";
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.ForeColor = System.Drawing.Color.Black;
            this.hexLabel.Location = new System.Drawing.Point(53, 490);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(53, 25);
            this.hexLabel.TabIndex = 39;
            this.hexLabel.Text = "Hex";
            // 
            // UploadHex
            // 
            this.UploadHex.BackColor = System.Drawing.Color.LightGray;
            this.UploadHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadHex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadHex.Location = new System.Drawing.Point(414, 434);
            this.UploadHex.Name = "UploadHex";
            this.UploadHex.Size = new System.Drawing.Size(149, 38);
            this.UploadHex.TabIndex = 38;
            this.UploadHex.Text = "Upload(.hex)";
            this.UploadHex.UseVisualStyleBackColor = false;
            this.UploadHex.Click += new System.EventHandler(this.UploadHex_Click);
            // 
            // AT89S52_about
            // 
            this.AT89S52_about.AutoSize = true;
            this.AT89S52_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AT89S52_about.Location = new System.Drawing.Point(307, 24);
            this.AT89S52_about.Name = "AT89S52_about";
            this.AT89S52_about.Size = new System.Drawing.Size(364, 44);
            this.AT89S52_about.TabIndex = 34;
            this.AT89S52_about.Text = "AT89S52(AVR8051)";
            this.AT89S52_about.Click += new System.EventHandler(this.AT89S52_about_Click);
            // 
            // AT89S52Chip
            // 
            this.AT89S52Chip.BackColor = System.Drawing.Color.Transparent;
            this.AT89S52Chip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AT89S52Chip.ErrorImage = global::AT89S52_AVR8051_Programmer.Properties.Resources.At89S52Chip;
            this.AT89S52Chip.Image = global::AT89S52_AVR8051_Programmer.Properties.Resources.At89S52Chip;
            this.AT89S52Chip.InitialImage = global::AT89S52_AVR8051_Programmer.Properties.Resources.At89S52Chip;
            this.AT89S52Chip.Location = new System.Drawing.Point(213, 102);
            this.AT89S52Chip.Name = "AT89S52Chip";
            this.AT89S52Chip.Size = new System.Drawing.Size(576, 312);
            this.AT89S52Chip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AT89S52Chip.TabIndex = 46;
            this.AT89S52Chip.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 563);
            this.Controls.Add(this.AT89S52Chip);
            this.Controls.Add(this.Guideline_Label);
            this.Controls.Add(this.Reconnect);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.UploadHex);
            this.Controls.Add(this.AT89S52_about);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "89S52 Programmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AT89S52Chip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Guideline_Label;
        private System.Windows.Forms.Button Reconnect;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label AT89S52_about;
        public System.Windows.Forms.Button UploadHex;
        private System.Windows.Forms.PictureBox AT89S52Chip;
    }
}

