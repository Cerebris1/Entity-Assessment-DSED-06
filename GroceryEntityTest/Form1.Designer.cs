namespace GroceryEntityTest
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
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnBarcodeSearch = new System.Windows.Forms.Button();
            this.btnDescriptionSearch = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAddArticle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddDesc = new System.Windows.Forms.TextBox();
            this.txtAddBarcode = new System.Windows.Forms.TextBox();
            this.txtAddStorage = new System.Windows.Forms.TextBox();
            this.txtAddDept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddSubDept = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateSubDept = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateDept = new System.Windows.Forms.TextBox();
            this.txtUpdateStorage = new System.Windows.Forms.TextBox();
            this.txtUpdateBarcode = new System.Windows.Forms.TextBox();
            this.txtUpdateDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateArticle = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(23, 414);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(176, 24);
            this.cbxDepartment.TabIndex = 0;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(23, 27);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(944, 355);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // btnBarcodeSearch
            // 
            this.btnBarcodeSearch.Location = new System.Drawing.Point(521, 422);
            this.btnBarcodeSearch.Name = "btnBarcodeSearch";
            this.btnBarcodeSearch.Size = new System.Drawing.Size(223, 40);
            this.btnBarcodeSearch.TabIndex = 2;
            this.btnBarcodeSearch.Text = "Search Barcode";
            this.btnBarcodeSearch.UseVisualStyleBackColor = true;
            this.btnBarcodeSearch.Click += new System.EventHandler(this.btnBarcodeSearch_Click);
            // 
            // btnDescriptionSearch
            // 
            this.btnDescriptionSearch.Location = new System.Drawing.Point(750, 422);
            this.btnDescriptionSearch.Name = "btnDescriptionSearch";
            this.btnDescriptionSearch.Size = new System.Drawing.Size(217, 40);
            this.btnDescriptionSearch.TabIndex = 3;
            this.btnDescriptionSearch.Text = "Search Description";
            this.btnDescriptionSearch.UseVisualStyleBackColor = true;
            this.btnDescriptionSearch.Click += new System.EventHandler(this.btnDescriptionSearch_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(521, 394);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(223, 22);
            this.txtBarcode.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(750, 394);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(217, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Department";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(23, 623);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(223, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddArticle
            // 
            this.txtAddArticle.Location = new System.Drawing.Point(23, 496);
            this.txtAddArticle.Name = "txtAddArticle";
            this.txtAddArticle.Size = new System.Drawing.Size(97, 22);
            this.txtAddArticle.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 524);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 44);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Article";
            // 
            // txtAddDesc
            // 
            this.txtAddDesc.Location = new System.Drawing.Point(126, 496);
            this.txtAddDesc.Name = "txtAddDesc";
            this.txtAddDesc.Size = new System.Drawing.Size(260, 22);
            this.txtAddDesc.TabIndex = 13;
            // 
            // txtAddBarcode
            // 
            this.txtAddBarcode.Location = new System.Drawing.Point(392, 496);
            this.txtAddBarcode.Name = "txtAddBarcode";
            this.txtAddBarcode.Size = new System.Drawing.Size(133, 22);
            this.txtAddBarcode.TabIndex = 14;
            // 
            // txtAddStorage
            // 
            this.txtAddStorage.Location = new System.Drawing.Point(531, 496);
            this.txtAddStorage.Name = "txtAddStorage";
            this.txtAddStorage.Size = new System.Drawing.Size(107, 22);
            this.txtAddStorage.TabIndex = 15;
            // 
            // txtAddDept
            // 
            this.txtAddDept.Location = new System.Drawing.Point(644, 496);
            this.txtAddDept.Name = "txtAddDept";
            this.txtAddDept.Size = new System.Drawing.Size(146, 22);
            this.txtAddDept.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Article Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Storage Bin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Department";
            // 
            // txtAddSubDept
            // 
            this.txtAddSubDept.Location = new System.Drawing.Point(796, 496);
            this.txtAddSubDept.Name = "txtAddSubDept";
            this.txtAddSubDept.Size = new System.Drawing.Size(171, 22);
            this.txtAddSubDept.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sub Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(809, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sub Department";
            // 
            // txtUpdateSubDept
            // 
            this.txtUpdateSubDept.Location = new System.Drawing.Point(796, 595);
            this.txtUpdateSubDept.Name = "txtUpdateSubDept";
            this.txtUpdateSubDept.Size = new System.Drawing.Size(171, 22);
            this.txtUpdateSubDept.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Storage Bin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 575);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Barcode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Article Description";
            // 
            // txtUpdateDept
            // 
            this.txtUpdateDept.Location = new System.Drawing.Point(644, 595);
            this.txtUpdateDept.Name = "txtUpdateDept";
            this.txtUpdateDept.Size = new System.Drawing.Size(146, 22);
            this.txtUpdateDept.TabIndex = 28;
            // 
            // txtUpdateStorage
            // 
            this.txtUpdateStorage.Location = new System.Drawing.Point(531, 595);
            this.txtUpdateStorage.Name = "txtUpdateStorage";
            this.txtUpdateStorage.Size = new System.Drawing.Size(107, 22);
            this.txtUpdateStorage.TabIndex = 27;
            // 
            // txtUpdateBarcode
            // 
            this.txtUpdateBarcode.Location = new System.Drawing.Point(392, 595);
            this.txtUpdateBarcode.Name = "txtUpdateBarcode";
            this.txtUpdateBarcode.Size = new System.Drawing.Size(133, 22);
            this.txtUpdateBarcode.TabIndex = 26;
            // 
            // txtUpdateDesc
            // 
            this.txtUpdateDesc.Location = new System.Drawing.Point(126, 595);
            this.txtUpdateDesc.Name = "txtUpdateDesc";
            this.txtUpdateDesc.Size = new System.Drawing.Size(260, 22);
            this.txtUpdateDesc.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 575);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Article";
            // 
            // txtUpdateArticle
            // 
            this.txtUpdateArticle.Location = new System.Drawing.Point(23, 595);
            this.txtUpdateArticle.Name = "txtUpdateArticle";
            this.txtUpdateArticle.Size = new System.Drawing.Size(97, 22);
            this.txtUpdateArticle.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(364, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 44);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 679);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUpdateSubDept);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUpdateDept);
            this.Controls.Add(this.txtUpdateStorage);
            this.Controls.Add(this.txtUpdateBarcode);
            this.Controls.Add(this.txtUpdateDesc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUpdateArticle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddSubDept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddDept);
            this.Controls.Add(this.txtAddStorage);
            this.Controls.Add(this.txtAddBarcode);
            this.Controls.Add(this.txtAddDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAddArticle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnDescriptionSearch);
            this.Controls.Add(this.btnBarcodeSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.cbxDepartment);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnBarcodeSearch;
        private System.Windows.Forms.Button btnDescriptionSearch;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAddArticle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddDesc;
        private System.Windows.Forms.TextBox txtAddBarcode;
        private System.Windows.Forms.TextBox txtAddStorage;
        private System.Windows.Forms.TextBox txtAddDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddSubDept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateSubDept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateDept;
        private System.Windows.Forms.TextBox txtUpdateStorage;
        private System.Windows.Forms.TextBox txtUpdateBarcode;
        private System.Windows.Forms.TextBox txtUpdateDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateArticle;
        private System.Windows.Forms.Button btnClear;
    }
}

