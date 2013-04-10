namespace OptiBrowser
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
            this.btnIE = new System.Windows.Forms.Button();
            this.btnFF = new System.Windows.Forms.Button();
            this.btnChrome = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslabelURL = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIE
            // 
            this.btnIE.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIE.Location = new System.Drawing.Point(68, 32);
            this.btnIE.Name = "btnIE";
            this.btnIE.Size = new System.Drawing.Size(360, 50);
            this.btnIE.TabIndex = 0;
            this.btnIE.Text = "Internet Explorer";
            this.btnIE.UseVisualStyleBackColor = true;
            this.btnIE.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFF
            // 
            this.btnFF.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFF.Location = new System.Drawing.Point(68, 88);
            this.btnFF.Name = "btnFF";
            this.btnFF.Size = new System.Drawing.Size(360, 50);
            this.btnFF.TabIndex = 1;
            this.btnFF.Text = "Firefox";
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChrome
            // 
            this.btnChrome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChrome.Location = new System.Drawing.Point(68, 144);
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.Size = new System.Drawing.Size(360, 50);
            this.btnChrome.TabIndex = 2;
            this.btnChrome.Text = "Google Chrome";
            this.btnChrome.UseVisualStyleBackColor = true;
            this.btnChrome.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslabelURL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslabelURL
            // 
            this.tslabelURL.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslabelURL.IsLink = true;
            this.tslabelURL.Name = "tslabelURL";
            this.tslabelURL.Size = new System.Drawing.Size(42, 17);
            this.tslabelURL.Text = "URL: ";
            this.tslabelURL.Click += new System.EventHandler(this.tslabelURL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnChrome);
            this.Controls.Add(this.btnFF);
            this.Controls.Add(this.btnIE);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptiBrowser";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIE;
        private System.Windows.Forms.Button btnFF;
        private System.Windows.Forms.Button btnChrome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslabelURL;
    }
}

