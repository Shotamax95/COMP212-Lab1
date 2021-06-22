
namespace Question1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search = new System.Windows.Forms.Button();
            this.searchNum = new System.Windows.Forms.TextBox();
            this.arrayList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonInt = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Searching = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Lime;
            this.search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(375, 489);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(128, 59);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchNum
            // 
            this.searchNum.Location = new System.Drawing.Point(199, 525);
            this.searchNum.Name = "searchNum";
            this.searchNum.Size = new System.Drawing.Size(128, 23);
            this.searchNum.TabIndex = 2;
            // 
            // arrayList
            // 
            this.arrayList.FormattingEnabled = true;
            this.arrayList.ItemHeight = 15;
            this.arrayList.Location = new System.Drawing.Point(56, 265);
            this.arrayList.Name = "arrayList";
            this.arrayList.Size = new System.Drawing.Size(62, 184);
            this.arrayList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Number";
            // 
            // radioButtonInt
            // 
            this.radioButtonInt.AutoSize = true;
            this.radioButtonInt.Location = new System.Drawing.Point(56, 525);
            this.radioButtonInt.Name = "radioButtonInt";
            this.radioButtonInt.Size = new System.Drawing.Size(39, 19);
            this.radioButtonInt.TabIndex = 6;
            this.radioButtonInt.TabStop = true;
            this.radioButtonInt.Text = "Int";
            this.radioButtonInt.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(101, 525);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(66, 19);
            this.radioButtonStudent.TabIndex = 7;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(137, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(137, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student Number";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(297, 65);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(145, 23);
            this.txtFirst.TabIndex = 11;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(297, 112);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(145, 23);
            this.txtLast.TabIndex = 12;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(297, 162);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(145, 23);
            this.txtStudent.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Location = new System.Drawing.Point(297, 212);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 30);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(355, 184);
            this.dataGridView1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(56, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Please select ";
            // 
            // Searching
            // 
            this.Searching.AutoSize = true;
            this.Searching.BackColor = System.Drawing.Color.Lime;
            this.Searching.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Searching.Location = new System.Drawing.Point(56, 9);
            this.Searching.Name = "Searching";
            this.Searching.Size = new System.Drawing.Size(429, 41);
            this.Searching.TabIndex = 19;
            this.Searching.Text = "Searching Number and Student";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(137, 582);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(366, 33);
            this.txtResult.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(56, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Result";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 651);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Searching);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.radioButtonInt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrayList);
            this.Controls.Add(this.searchNum);
            this.Controls.Add(this.search);
            this.Name = "Main";
            this.Text = "Generics Search Method";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchNum;
        private System.Windows.Forms.ListBox arrayList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonInt;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Searching;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
    }
}

