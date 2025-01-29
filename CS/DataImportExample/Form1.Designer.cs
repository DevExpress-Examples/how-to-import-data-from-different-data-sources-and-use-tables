namespace DataImportExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            btnImportArrayList = new DevExpress.XtraEditors.SimpleButton();
            btnUseConverter = new DevExpress.XtraEditors.SimpleButton();
            btnUseFields = new DevExpress.XtraEditors.SimpleButton();
            btnUseOptions = new DevExpress.XtraEditors.SimpleButton();
            btnImportObject = new DevExpress.XtraEditors.SimpleButton();
            btnImportList = new DevExpress.XtraEditors.SimpleButton();
            btnImportArray = new DevExpress.XtraEditors.SimpleButton();
            btnImportDataTable = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btnImportArrayList
            // 
            btnImportArrayList.Location = new System.Drawing.Point(10, 367);
            btnImportArrayList.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnImportArrayList.Name = "btnImportArrayList";
            btnImportArrayList.Size = new System.Drawing.Size(480, 69);
            btnImportArrayList.TabIndex = 7;
            btnImportArrayList.Text = "Import ArrayList";
            btnImportArrayList.Click += btnArrayList_Click;
            // 
            // btnUseConverter
            // 
            btnUseConverter.Location = new System.Drawing.Point(10, 627);
            btnUseConverter.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnUseConverter.Name = "btnUseConverter";
            btnUseConverter.Size = new System.Drawing.Size(480, 69);
            btnUseConverter.TabIndex = 6;
            btnUseConverter.Text = "Import Using Converter";
            btnUseConverter.Click += btnUseConverter_Click;
            // 
            // btnUseFields
            // 
            btnUseFields.Location = new System.Drawing.Point(10, 544);
            btnUseFields.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnUseFields.Name = "btnUseFields";
            btnUseFields.Size = new System.Drawing.Size(480, 69);
            btnUseFields.TabIndex = 5;
            btnUseFields.Text = "Import Specified Fields";
            btnUseFields.Click += btnUseFields_Click;
            // 
            // btnUseOptions
            // 
            btnUseOptions.Location = new System.Drawing.Point(10, 453);
            btnUseOptions.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnUseOptions.Name = "btnUseOptions";
            btnUseOptions.Size = new System.Drawing.Size(480, 69);
            btnUseOptions.TabIndex = 4;
            btnUseOptions.Text = "Import Using Options";
            btnUseOptions.Click += btnUseOptions_Click;
            // 
            // btnImportObject
            // 
            btnImportObject.Location = new System.Drawing.Point(10, 278);
            btnImportObject.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnImportObject.Name = "btnImportObject";
            btnImportObject.Size = new System.Drawing.Size(480, 69);
            btnImportObject.TabIndex = 3;
            btnImportObject.Text = "Import Object";
            btnImportObject.Click += btnImportObject_Click;
            // 
            // btnImportList
            // 
            btnImportList.Location = new System.Drawing.Point(10, 194);
            btnImportList.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnImportList.Name = "btnImportList";
            btnImportList.Size = new System.Drawing.Size(480, 69);
            btnImportList.TabIndex = 2;
            btnImportList.Text = "Import List";
            btnImportList.Click += btnImportList_Click;
            // 
            // btnImportArray
            // 
            btnImportArray.Location = new System.Drawing.Point(10, 106);
            btnImportArray.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnImportArray.Name = "btnImportArray";
            btnImportArray.Size = new System.Drawing.Size(480, 69);
            btnImportArray.TabIndex = 1;
            btnImportArray.Text = "Import Arrays";
            btnImportArray.Click += btnImportArray_Click;
            // 
            // btnImportDataTable
            // 
            btnImportDataTable.Location = new System.Drawing.Point(10, 9);
            btnImportDataTable.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            btnImportDataTable.Name = "btnImportDataTable";
            btnImportDataTable.Size = new System.Drawing.Size(480, 78);
            btnImportDataTable.TabIndex = 0;
            btnImportDataTable.Text = "Import DataTable";
            btnImportDataTable.Click += btnImportDataTable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(519, 720);
            Controls.Add(btnImportArray);
            Controls.Add(btnImportArrayList);
            Controls.Add(btnImportDataTable);
            Controls.Add(btnImportList);
            Controls.Add(btnImportObject);
            Controls.Add(btnUseOptions);
            Controls.Add(btnUseFields);
            Controls.Add(btnUseConverter);
            Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnImportDataTable;
        private DevExpress.XtraEditors.SimpleButton btnImportArray;
        private DevExpress.XtraEditors.SimpleButton btnImportList;
        private DevExpress.XtraEditors.SimpleButton btnImportObject;
        private DevExpress.XtraEditors.SimpleButton btnUseOptions;
        private DevExpress.XtraEditors.SimpleButton btnUseFields;
        private DevExpress.XtraEditors.SimpleButton btnUseConverter;
        private DevExpress.XtraEditors.SimpleButton btnImportArrayList;
    }
}

