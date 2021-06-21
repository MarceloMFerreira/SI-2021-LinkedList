namespace Modelo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.listPessoas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_after = new System.Windows.Forms.Button();
            this.btn_before = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeforeAfter = new System.Windows.Forms.TextBox();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProx = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 688);
            this.panel1.TabIndex = 1;
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(0, 0);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(141, 90);
            this.btnSobre.TabIndex = 9;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(141, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 154);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Modelo.Properties.Resources.sinfo;
            this.pictureBox1.Location = new System.Drawing.Point(329, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Modelo.Properties.Resources.close;
            this.btnFechar.Location = new System.Drawing.Point(1017, -1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(132, 85);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 36);
            this.txtNome.TabIndex = 5;
            // 
            // listPessoas
            // 
            this.listPessoas.FormattingEnabled = true;
            this.listPessoas.ItemHeight = 28;
            this.listPessoas.Location = new System.Drawing.Point(733, 302);
            this.listPessoas.Name = "listPessoas";
            this.listPessoas.Size = new System.Drawing.Size(273, 368);
            this.listPessoas.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_after);
            this.groupBox1.Controls.Add(this.btn_before);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBeforeAfter);
            this.groupBox1.Controls.Add(this.btnAddLast);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(192, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 400);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Pessoa";
            // 
            // btn_after
            // 
            this.btn_after.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_after.FlatAppearance.BorderSize = 0;
            this.btn_after.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_after.Image = global::Modelo.Properties.Resources.icon;
            this.btn_after.Location = new System.Drawing.Point(278, 298);
            this.btn_after.Name = "btn_after";
            this.btn_after.Size = new System.Drawing.Size(112, 96);
            this.btn_after.TabIndex = 16;
            this.btn_after.Text = "Add Depois";
            this.btn_after.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_after.UseVisualStyleBackColor = true;
            this.btn_after.Click += new System.EventHandler(this.btn_after_Click);
            // 
            // btn_before
            // 
            this.btn_before.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_before.FlatAppearance.BorderSize = 0;
            this.btn_before.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_before.Image = global::Modelo.Properties.Resources.icon;
            this.btn_before.Location = new System.Drawing.Point(106, 302);
            this.btn_before.Name = "btn_before";
            this.btn_before.Size = new System.Drawing.Size(113, 92);
            this.btn_before.TabIndex = 10;
            this.btn_before.Text = "Add Antes";
            this.btn_before.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_before.UseVisualStyleBackColor = true;
            this.btn_before.Click += new System.EventHandler(this.btn_before_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(149, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add antes/depois de:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBeforeAfter
            // 
            this.txtBeforeAfter.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBeforeAfter.Location = new System.Drawing.Point(106, 239);
            this.txtBeforeAfter.Name = "txtBeforeAfter";
            this.txtBeforeAfter.Size = new System.Drawing.Size(284, 36);
            this.txtBeforeAfter.TabIndex = 14;
            // 
            // btnAddLast
            // 
            this.btnAddLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLast.FlatAppearance.BorderSize = 0;
            this.btnAddLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLast.Image = global::Modelo.Properties.Resources.icon;
            this.btnAddLast.Location = new System.Drawing.Point(303, 97);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(98, 99);
            this.btnAddLast.TabIndex = 13;
            this.btnAddLast.Text = "Add Fim";
            this.btnAddLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = global::Modelo.Properties.Resources.icon;
            this.btnAdd.Location = new System.Drawing.Point(106, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 99);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Ini";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProx
            // 
            this.lblProx.AutoSize = true;
            this.lblProx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblProx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProx.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProx.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblProx.Location = new System.Drawing.Point(447, 163);
            this.lblProx.MinimumSize = new System.Drawing.Size(500, 100);
            this.lblProx.Name = "lblProx";
            this.lblProx.Size = new System.Drawing.Size(500, 100);
            this.lblProx.TabIndex = 12;
            this.lblProx.Text = "Prox";
            this.lblProx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProx.Click += new System.EventHandler(this.lblProx_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtender.Image = global::Modelo.Properties.Resources.doctor_atend;
            this.btnAtender.Location = new System.Drawing.Point(175, 161);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(122, 109);
            this.btnAtender.TabIndex = 9;
            this.btnAtender.Text = "Atender Ini";
            this.btnAtender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.FlatAppearance.BorderSize = 0;
            this.btnRemoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveLast.Image = global::Modelo.Properties.Resources.doctor_atend;
            this.btnRemoveLast.Location = new System.Drawing.Point(303, 161);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(128, 109);
            this.btnRemoveLast.TabIndex = 15;
            this.btnRemoveLast.Text = "Atender Fim";
            this.btnRemoveLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_first.FlatAppearance.BorderSize = 0;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_first.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_first.Location = new System.Drawing.Point(965, 173);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(119, 39);
            this.btn_first.TabIndex = 16;
            this.btn_first.Text = "Primeiro";
            this.btn_first.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_last.FlatAppearance.BorderSize = 0;
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_last.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_last.Location = new System.Drawing.Point(965, 224);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(119, 39);
            this.btn_last.TabIndex = 17;
            this.btn_last.Text = "Ultimo";
            this.btn_last.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Modelo.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(1046, 111);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 43);
            this.btnSave.TabIndex = 18;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 688);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.lblProx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listPessoas);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.ListBox listPessoas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProx;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btn_after;
        private System.Windows.Forms.Button btn_before;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBeforeAfter;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btnSave;
    }
}

