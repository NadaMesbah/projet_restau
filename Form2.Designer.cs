namespace Projet
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAddPlat = new System.Windows.Forms.Button();
            this.tbQte = new System.Windows.Forms.TextBox();
            this.gvPlatAtt = new System.Windows.Forms.DataGridView();
            this.gvPlats = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlatAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlats)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 992);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "la quantité  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(377, 87);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 77);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "title :";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(2866, 305);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(599, 44);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1773, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Les plats disponibles :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Les plats attachés :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(1790, 1003);
            this.lblError.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 66);
            this.lblError.TabIndex = 14;
            // 
            // btnAddPlat
            // 
            this.btnAddPlat.Location = new System.Drawing.Point(74, 1095);
            this.btnAddPlat.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnAddPlat.Name = "btnAddPlat";
            this.btnAddPlat.Size = new System.Drawing.Size(238, 65);
            this.btnAddPlat.TabIndex = 13;
            this.btnAddPlat.Text = "ajouter plat";
            this.btnAddPlat.UseVisualStyleBackColor = true;
            this.btnAddPlat.Click += new System.EventHandler(this.btnAddPlat_Click);
            // 
            // tbQte
            // 
            this.tbQte.Location = new System.Drawing.Point(321, 984);
            this.tbQte.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbQte.Name = "tbQte";
            this.tbQte.Size = new System.Drawing.Size(308, 44);
            this.tbQte.TabIndex = 12;
            this.tbQte.TextChanged += new System.EventHandler(this.tbQte_TextChanged);
            // 
            // gvPlatAtt
            // 
            this.gvPlatAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlatAtt.Location = new System.Drawing.Point(74, 403);
            this.gvPlatAtt.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gvPlatAtt.Name = "gvPlatAtt";
            this.gvPlatAtt.ReadOnly = true;
            this.gvPlatAtt.RowHeadersWidth = 123;
            this.gvPlatAtt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPlatAtt.Size = new System.Drawing.Size(1613, 504);
            this.gvPlatAtt.TabIndex = 11;
            this.gvPlatAtt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPlatAtt_CellContentClick);
            // 
            // gvPlats
            // 
            this.gvPlats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlats.Location = new System.Drawing.Point(1780, 403);
            this.gvPlats.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gvPlats.Name = "gvPlats";
            this.gvPlats.ReadOnly = true;
            this.gvPlats.RowHeadersWidth = 123;
            this.gvPlats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPlats.Size = new System.Drawing.Size(1685, 504);
            this.gvPlats.TabIndex = 10;
            this.gvPlats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPlats_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2735, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Search";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3511, 1588);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAddPlat);
            this.Controls.Add(this.tbQte);
            this.Controls.Add(this.gvPlatAtt);
            this.Controls.Add(this.gvPlats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPlatAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAddPlat;
        private System.Windows.Forms.TextBox tbQte;
        private System.Windows.Forms.DataGridView gvPlatAtt;
        private System.Windows.Forms.DataGridView gvPlats;
        private System.Windows.Forms.Label label4;
    }
}