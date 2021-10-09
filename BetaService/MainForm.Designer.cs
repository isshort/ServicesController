
namespace BetaService
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnService = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(89, 184);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(351, 91);
            this.btnService.TabIndex = 19;
            this.btnService.Text = "Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.Location = new System.Drawing.Point(89, 322);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(351, 91);
            this.btnKasa.TabIndex = 18;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(89, 60);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(351, 91);
            this.btnDriver.TabIndex = 17;
            this.btnDriver.Text = "Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 91);
            this.button1.TabIndex = 16;
            this.button1.Text = "DailyReport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 635);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Gunluk Rapor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

