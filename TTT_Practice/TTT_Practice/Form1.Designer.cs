namespace TTT_Practice
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
            this.dataGridViewSwaps = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttontblSwaps = new System.Windows.Forms.Button();
            this.buttonViewSwap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.comboBoxDt = new System.Windows.Forms.ComboBox();
            this.comboBoxCs = new System.Windows.Forms.ComboBox();
            this.comboBoxHt = new System.Windows.Forms.ComboBox();
            this.comboBoxIns = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSwaps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSwaps
            // 
            this.dataGridViewSwaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSwaps.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSwaps.MultiSelect = false;
            this.dataGridViewSwaps.Name = "dataGridViewSwaps";
            this.dataGridViewSwaps.RowHeadersWidth = 62;
            this.dataGridViewSwaps.RowTemplate.Height = 28;
            this.dataGridViewSwaps.Size = new System.Drawing.Size(1114, 643);
            this.dataGridViewSwaps.TabIndex = 0;
            this.dataGridViewSwaps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSwaps_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1188, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttontblSwaps
            // 
            this.buttontblSwaps.Location = new System.Drawing.Point(1188, 158);
            this.buttontblSwaps.Name = "buttontblSwaps";
            this.buttontblSwaps.Size = new System.Drawing.Size(121, 50);
            this.buttontblSwaps.TabIndex = 2;
            this.buttontblSwaps.Text = "btnSwaps";
            this.buttontblSwaps.UseVisualStyleBackColor = true;
            this.buttontblSwaps.Click += new System.EventHandler(this.buttontblSwaps_Click);
            // 
            // buttonViewSwap
            // 
            this.buttonViewSwap.Location = new System.Drawing.Point(1188, 95);
            this.buttonViewSwap.Name = "buttonViewSwap";
            this.buttonViewSwap.Size = new System.Drawing.Size(121, 48);
            this.buttonViewSwap.TabIndex = 3;
            this.buttonViewSwap.Text = "viewSwaps";
            this.buttonViewSwap.UseVisualStyleBackColor = true;
            this.buttonViewSwap.Click += new System.EventHandler(this.buttonViewSwap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1351, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1351, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1351, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "An";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1354, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1352, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1351, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ht";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1351, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ins";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1433, 40);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(214, 26);
            this.txtId.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1433, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 26);
            this.txtName.TabIndex = 12;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(1433, 109);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(214, 26);
            this.txtAn.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1352, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Des";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(1433, 240);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(214, 26);
            this.txtDes.TabIndex = 15;
            // 
            // comboBoxDt
            // 
            this.comboBoxDt.FormattingEnabled = true;
            this.comboBoxDt.Location = new System.Drawing.Point(1433, 150);
            this.comboBoxDt.Name = "comboBoxDt";
            this.comboBoxDt.Size = new System.Drawing.Size(214, 28);
            this.comboBoxDt.TabIndex = 16;
            // 
            // comboBoxCs
            // 
            this.comboBoxCs.FormattingEnabled = true;
            this.comboBoxCs.Location = new System.Drawing.Point(1433, 198);
            this.comboBoxCs.Name = "comboBoxCs";
            this.comboBoxCs.Size = new System.Drawing.Size(214, 28);
            this.comboBoxCs.TabIndex = 17;
            // 
            // comboBoxHt
            // 
            this.comboBoxHt.FormattingEnabled = true;
            this.comboBoxHt.Location = new System.Drawing.Point(1433, 281);
            this.comboBoxHt.Name = "comboBoxHt";
            this.comboBoxHt.Size = new System.Drawing.Size(214, 28);
            this.comboBoxHt.TabIndex = 18;
            // 
            // comboBoxIns
            // 
            this.comboBoxIns.FormattingEnabled = true;
            this.comboBoxIns.Location = new System.Drawing.Point(1433, 321);
            this.comboBoxIns.Name = "comboBoxIns";
            this.comboBoxIns.Size = new System.Drawing.Size(214, 28);
            this.comboBoxIns.TabIndex = 19;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1452, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 40);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(1594, 381);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(104, 40);
            this.BtnDelete.TabIndex = 22;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1319, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 40);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 703);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.comboBoxIns);
            this.Controls.Add(this.comboBoxHt);
            this.Controls.Add(this.comboBoxCs);
            this.Controls.Add(this.comboBoxDt);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonViewSwap);
            this.Controls.Add(this.buttontblSwaps);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSwaps);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSwaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSwaps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttontblSwaps;
        private System.Windows.Forms.Button buttonViewSwap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.ComboBox comboBoxDt;
        private System.Windows.Forms.ComboBox comboBoxCs;
        private System.Windows.Forms.ComboBox comboBoxHt;
        private System.Windows.Forms.ComboBox comboBoxIns;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

