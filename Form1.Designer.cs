namespace Projet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateCmd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCmd = new System.Windows.Forms.Button();
            this.tbCmdId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvClient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuppCmd = new System.Windows.Forms.Button();
            this.gvCommande = new System.Windows.Forms.DataGridView();
            this.lblIsLoyal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateCmd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddCmd);
            this.groupBox1.Controls.Add(this.tbCmdId);
            this.groupBox1.Location = new System.Drawing.Point(174, 790);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(1011, 424);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "creation  d une commande :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateCmd
            // 
            this.dateCmd.Location = new System.Drawing.Point(279, 134);
            this.dateCmd.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dateCmd.Name = "dateCmd";
            this.dateCmd.Size = new System.Drawing.Size(625, 44);
            this.dateCmd.TabIndex = 11;
            this.dateCmd.ValueChanged += new System.EventHandler(this.dateCmd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "date :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "id commande :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAddCmd
            // 
            this.btnAddCmd.Location = new System.Drawing.Point(190, 282);
            this.btnAddCmd.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnAddCmd.Name = "btnAddCmd";
            this.btnAddCmd.Size = new System.Drawing.Size(466, 105);
            this.btnAddCmd.TabIndex = 2;
            this.btnAddCmd.Text = "add commande";
            this.btnAddCmd.UseVisualStyleBackColor = true;
            this.btnAddCmd.Click += new System.EventHandler(this.btnAddCmd_Click);
            // 
            // tbCmdId
            // 
            this.tbCmdId.Location = new System.Drawing.Point(279, 208);
            this.tbCmdId.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbCmdId.Name = "tbCmdId";
            this.tbCmdId.Size = new System.Drawing.Size(308, 44);
            this.tbCmdId.TabIndex = 4;
            this.tbCmdId.TextChanged += new System.EventHandler(this.tbCmdId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Les clients :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gvClient
            // 
            this.gvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClient.Location = new System.Drawing.Point(174, 167);
            this.gvClient.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gvClient.Name = "gvClient";
            this.gvClient.ReadOnly = true;
            this.gvClient.RowHeadersWidth = 123;
            this.gvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvClient.Size = new System.Drawing.Size(1011, 518);
            this.gvClient.TabIndex = 11;
            this.gvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvClient_CellContentClick);
            this.gvClient.SelectionChanged += new System.EventHandler(this.gvClient_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2014, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Les commandes associées :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSuppCmd
            // 
            this.btnSuppCmd.Location = new System.Drawing.Point(1388, 1035);
            this.btnSuppCmd.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSuppCmd.Name = "btnSuppCmd";
            this.btnSuppCmd.Size = new System.Drawing.Size(466, 105);
            this.btnSuppCmd.TabIndex = 14;
            this.btnSuppCmd.Text = "supprimer commande";
            this.btnSuppCmd.UseVisualStyleBackColor = true;
            this.btnSuppCmd.Click += new System.EventHandler(this.btnSuppCmd_Click);
            // 
            // gvCommande
            // 
            this.gvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCommande.Location = new System.Drawing.Point(1388, 167);
            this.gvCommande.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gvCommande.Name = "gvCommande";
            this.gvCommande.ReadOnly = true;
            this.gvCommande.RowHeadersWidth = 123;
            this.gvCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCommande.Size = new System.Drawing.Size(1658, 777);
            this.gvCommande.TabIndex = 13;
            this.gvCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCommande_CellContentClick);
            // 
            // lblIsLoyal
            // 
            this.lblIsLoyal.AutoSize = true;
            this.lblIsLoyal.ForeColor = System.Drawing.Color.Lime;
            this.lblIsLoyal.Location = new System.Drawing.Point(28, 205);
            this.lblIsLoyal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblIsLoyal.Name = "lblIsLoyal";
            this.lblIsLoyal.Size = new System.Drawing.Size(0, 37);
            this.lblIsLoyal.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3384, 1374);
            this.Controls.Add(this.lblIsLoyal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSuppCmd);
            this.Controls.Add(this.gvCommande);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvClient);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateCmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCmd;
        private System.Windows.Forms.TextBox tbCmdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuppCmd;
        private System.Windows.Forms.DataGridView gvCommande;
        private System.Windows.Forms.Label lblIsLoyal;
    }
}

