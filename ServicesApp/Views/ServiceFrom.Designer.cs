
namespace ServicesApp.Views
{
    partial class ServiceFrom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.txtGps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServisF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServisN = new System.Windows.Forms.TextBox();
            this.btnAdd_S = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwService = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwService)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnUpdateS);
            this.groupBox1.Controls.Add(this.btnDeleteS);
            this.groupBox1.Controls.Add(this.txtGps);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServisF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServisN);
            this.groupBox1.Controls.Add(this.btnAdd_S);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 516);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni servis ekle";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox1.Location = new System.Drawing.Point(161, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 30);
            this.textBox1.TabIndex = 19;
            // 
            // txtColor
            // 
            this.txtColor.AutoSize = true;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(9, 267);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(119, 25);
            this.txtColor.TabIndex = 18;
            this.txtColor.Text = "Servis renki ";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtModel.Location = new System.Drawing.Point(161, 217);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(265, 30);
            this.txtModel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Servis model";
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateS.Location = new System.Drawing.Point(249, 339);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(170, 55);
            this.btnUpdateS.TabIndex = 10;
            this.btnUpdateS.Text = "Guncele";
            this.btnUpdateS.UseVisualStyleBackColor = false;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteS.Location = new System.Drawing.Point(249, 426);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(170, 55);
            this.btnDeleteS.TabIndex = 15;
            this.btnDeleteS.Text = "Sil";
            this.btnDeleteS.UseVisualStyleBackColor = false;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // txtGps
            // 
            this.txtGps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtGps.Location = new System.Drawing.Point(161, 162);
            this.txtGps.Name = "txtGps";
            this.txtGps.Size = new System.Drawing.Size(265, 30);
            this.txtGps.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Servis GPS ";
            // 
            // txtServisF
            // 
            this.txtServisF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtServisF.Location = new System.Drawing.Point(161, 100);
            this.txtServisF.Name = "txtServisF";
            this.txtServisF.Size = new System.Drawing.Size(265, 30);
            this.txtServisF.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Servis flaka";
            // 
            // txtServisN
            // 
            this.txtServisN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtServisN.Location = new System.Drawing.Point(161, 48);
            this.txtServisN.Name = "txtServisN";
            this.txtServisN.Size = new System.Drawing.Size(265, 30);
            this.txtServisN.TabIndex = 3;
            // 
            // btnAdd_S
            // 
            this.btnAdd_S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd_S.Location = new System.Drawing.Point(6, 339);
            this.btnAdd_S.Name = "btnAdd_S";
            this.btnAdd_S.Size = new System.Drawing.Size(170, 55);
            this.btnAdd_S.TabIndex = 1;
            this.btnAdd_S.Text = "Ekle";
            this.btnAdd_S.UseVisualStyleBackColor = false;
            this.btnAdd_S.Click += new System.EventHandler(this.btnAdd_S_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servis Numarasi";
            // 
            // dgwService
            // 
            this.dgwService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwService.Location = new System.Drawing.Point(460, 23);
            this.dgwService.Name = "dgwService";
            this.dgwService.RowHeadersWidth = 62;
            this.dgwService.RowTemplate.Height = 28;
            this.dgwService.Size = new System.Drawing.Size(1164, 774);
            this.dgwService.TabIndex = 16;
            this.dgwService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDriver_CellClick);
            // 
            // ServiceFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 828);
            this.Controls.Add(this.dgwService);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServiceFrom";
            this.Text = "ServisFrom";
            this.Load += new System.EventHandler(this.ServisFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateS;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.TextBox txtServisN;
        private System.Windows.Forms.Button btnAdd_S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServisF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwService;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
    }
}