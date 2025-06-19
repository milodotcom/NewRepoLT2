namespace D032310396
{
    partial class FormAuthor
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
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBirthYear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.AllowUserToAddRows = false;
            this.dataGridViewAuthor.AllowUserToDeleteRows = false;
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(117, 64);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.ReadOnly = true;
            this.dataGridViewAuthor.RowHeadersWidth = 51;
            this.dataGridViewAuthor.RowTemplate.Height = 24;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(508, 150);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // AuthorID
            // 
            this.AuthorID.AutoSize = true;
            this.AuthorID.Location = new System.Drawing.Point(261, 233);
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Size = new System.Drawing.Size(58, 16);
            this.AuthorID.TabIndex = 1;
            this.AuthorID.Text = "AuthorID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "BirthYear";
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.Location = new System.Drawing.Point(338, 233);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(127, 22);
            this.textBoxAuthorID.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(338, 274);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(127, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxBirthYear
            // 
            this.textBoxBirthYear.Location = new System.Drawing.Point(338, 325);
            this.textBoxBirthYear.Name = "textBoxBirthYear";
            this.textBoxBirthYear.Size = new System.Drawing.Size(127, 22);
            this.textBoxBirthYear.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(117, 385);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(297, 385);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(470, 385);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(602, 257);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(109, 43);
            this.buttonBook.TabIndex = 10;
            this.buttonBook.Text = "Form Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Location = new System.Drawing.Point(602, 313);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(109, 41);
            this.buttonStock.TabIndex = 11;
            this.buttonStock.Text = "Form Stock";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxBirthYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAuthorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthorID);
            this.Controls.Add(this.dataGridViewAuthor);
            this.Name = "FormAuthor";
            this.Text = "Form Author";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private System.Windows.Forms.Label AuthorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthorID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBirthYear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonStock;
    }
}

