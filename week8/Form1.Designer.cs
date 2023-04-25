namespace week8
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
            this.combobox_pilihteam = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pLAYERDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATCHDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combobox_pilihplayer = new System.Windows.Forms.ComboBox();
            this.label_chooseteam = new System.Windows.Forms.Label();
            this.label_chooseplayer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_pilihteam
            // 
            this.combobox_pilihteam.FormattingEnabled = true;
            this.combobox_pilihteam.Location = new System.Drawing.Point(12, 58);
            this.combobox_pilihteam.Name = "combobox_pilihteam";
            this.combobox_pilihteam.Size = new System.Drawing.Size(121, 21);
            this.combobox_pilihteam.TabIndex = 0;
            this.combobox_pilihteam.Visible = false;
            this.combobox_pilihteam.SelectionChangeCommitted += new System.EventHandler(this.combobox_pilihteam_SelectionChangeCommitted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLAYERDATAToolStripMenuItem,
            this.mATCHDETAILSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pLAYERDATAToolStripMenuItem
            // 
            this.pLAYERDATAToolStripMenuItem.Name = "pLAYERDATAToolStripMenuItem";
            this.pLAYERDATAToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.pLAYERDATAToolStripMenuItem.Text = "PLAYER DATA";
            this.pLAYERDATAToolStripMenuItem.Click += new System.EventHandler(this.pLAYERDATAToolStripMenuItem_Click);
            // 
            // mATCHDETAILSToolStripMenuItem
            // 
            this.mATCHDETAILSToolStripMenuItem.Name = "mATCHDETAILSToolStripMenuItem";
            this.mATCHDETAILSToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.mATCHDETAILSToolStripMenuItem.Text = "MATCH DETAILS";
            this.mATCHDETAILSToolStripMenuItem.Click += new System.EventHandler(this.mATCHDETAILSToolStripMenuItem_Click);
            // 
            // combobox_pilihplayer
            // 
            this.combobox_pilihplayer.FormattingEnabled = true;
            this.combobox_pilihplayer.Location = new System.Drawing.Point(252, 58);
            this.combobox_pilihplayer.Name = "combobox_pilihplayer";
            this.combobox_pilihplayer.Size = new System.Drawing.Size(121, 21);
            this.combobox_pilihplayer.TabIndex = 2;
            this.combobox_pilihplayer.Visible = false;
            this.combobox_pilihplayer.SelectionChangeCommitted += new System.EventHandler(this.combobox_pilihplayer_SelectionChangeCommitted);
            // 
            // label_chooseteam
            // 
            this.label_chooseteam.AutoSize = true;
            this.label_chooseteam.Location = new System.Drawing.Point(12, 33);
            this.label_chooseteam.Name = "label_chooseteam";
            this.label_chooseteam.Size = new System.Drawing.Size(85, 13);
            this.label_chooseteam.TabIndex = 3;
            this.label_chooseteam.Text = "CHOOSE TEAM";
            this.label_chooseteam.Visible = false;
            // 
            // label_chooseplayer
            // 
            this.label_chooseplayer.AutoSize = true;
            this.label_chooseplayer.Location = new System.Drawing.Point(258, 33);
            this.label_chooseplayer.Name = "label_chooseplayer";
            this.label_chooseplayer.Size = new System.Drawing.Size(97, 13);
            this.label_chooseplayer.TabIndex = 4;
            this.label_chooseplayer.Text = "CHOOSE PLAYER";
            this.label_chooseplayer.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(252, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 217);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 325);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_chooseplayer);
            this.Controls.Add(this.label_chooseteam);
            this.Controls.Add(this.combobox_pilihplayer);
            this.Controls.Add(this.combobox_pilihteam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_pilihteam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pLAYERDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATCHDETAILSToolStripMenuItem;
        private System.Windows.Forms.ComboBox combobox_pilihplayer;
        private System.Windows.Forms.Label label_chooseteam;
        private System.Windows.Forms.Label label_chooseplayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
    }
}

