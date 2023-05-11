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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnImportArrayList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUseConverter = new DevExpress.XtraEditors.SimpleButton();
            this.btnUseFields = new DevExpress.XtraEditors.SimpleButton();
            this.btnUseOptions = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportObject = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportList = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportArray = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportDataTable = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.spreadsheetFormulaBar1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar();
            this.spreadsheetDockManager1 = new DevExpress.XtraSpreadsheet.SpreadsheetDockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 40);
            this.spreadsheetControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ',';
            this.spreadsheetControl1.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Size = new System.Drawing.Size(784, 546);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.btnImportArrayList);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnUseConverter);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnUseFields);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnUseOptions);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnImportObject);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnImportList);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnImportArray);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnImportDataTable);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.spreadsheetControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitterControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.spreadsheetFormulaBar1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1088, 586);
            this.splitContainerControl1.SplitterPosition = 292;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnImportArrayList
            // 
            this.btnImportArrayList.Location = new System.Drawing.Point(6, 235);
            this.btnImportArrayList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportArrayList.Name = "btnImportArrayList";
            this.btnImportArrayList.Size = new System.Drawing.Size(280, 44);
            this.btnImportArrayList.TabIndex = 7;
            this.btnImportArrayList.Text = "Import ArrayList";
            this.btnImportArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnUseConverter
            // 
            this.btnUseConverter.Location = new System.Drawing.Point(6, 401);
            this.btnUseConverter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUseConverter.Name = "btnUseConverter";
            this.btnUseConverter.Size = new System.Drawing.Size(280, 44);
            this.btnUseConverter.TabIndex = 6;
            this.btnUseConverter.Text = "Import Using Converter";
            this.btnUseConverter.Click += new System.EventHandler(this.btnUseConverter_Click);
            // 
            // btnUseFields
            // 
            this.btnUseFields.Location = new System.Drawing.Point(6, 348);
            this.btnUseFields.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUseFields.Name = "btnUseFields";
            this.btnUseFields.Size = new System.Drawing.Size(280, 44);
            this.btnUseFields.TabIndex = 5;
            this.btnUseFields.Text = "Import Specified Fields";
            this.btnUseFields.Click += new System.EventHandler(this.btnUseFields_Click);
            // 
            // btnUseOptions
            // 
            this.btnUseOptions.Location = new System.Drawing.Point(6, 290);
            this.btnUseOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUseOptions.Name = "btnUseOptions";
            this.btnUseOptions.Size = new System.Drawing.Size(280, 44);
            this.btnUseOptions.TabIndex = 4;
            this.btnUseOptions.Text = "Import Using Options";
            this.btnUseOptions.Click += new System.EventHandler(this.btnUseOptions_Click);
            // 
            // btnImportObject
            // 
            this.btnImportObject.Location = new System.Drawing.Point(6, 178);
            this.btnImportObject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportObject.Name = "btnImportObject";
            this.btnImportObject.Size = new System.Drawing.Size(280, 44);
            this.btnImportObject.TabIndex = 3;
            this.btnImportObject.Text = "Import Object";
            this.btnImportObject.Click += new System.EventHandler(this.btnImportObject_Click);
            // 
            // btnImportList
            // 
            this.btnImportList.Location = new System.Drawing.Point(6, 124);
            this.btnImportList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportList.Name = "btnImportList";
            this.btnImportList.Size = new System.Drawing.Size(280, 44);
            this.btnImportList.TabIndex = 2;
            this.btnImportList.Text = "Import List";
            this.btnImportList.Click += new System.EventHandler(this.btnImportList_Click);
            // 
            // btnImportArray
            // 
            this.btnImportArray.Location = new System.Drawing.Point(6, 68);
            this.btnImportArray.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportArray.Name = "btnImportArray";
            this.btnImportArray.Size = new System.Drawing.Size(280, 44);
            this.btnImportArray.TabIndex = 1;
            this.btnImportArray.Text = "Import Arrays";
            this.btnImportArray.Click += new System.EventHandler(this.btnImportArray_Click);
            // 
            // btnImportDataTable
            // 
            this.btnImportDataTable.Location = new System.Drawing.Point(6, 6);
            this.btnImportDataTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImportDataTable.Name = "btnImportDataTable";
            this.btnImportDataTable.Size = new System.Drawing.Size(280, 50);
            this.btnImportDataTable.TabIndex = 0;
            this.btnImportDataTable.Text = "Import DataTable";
            this.btnImportDataTable.Click += new System.EventHandler(this.btnImportDataTable_Click);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 28);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitterControl1.MinSize = 20;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(784, 12);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // spreadsheetFormulaBar1
            // 
            this.spreadsheetFormulaBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spreadsheetFormulaBar1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetFormulaBar1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.spreadsheetFormulaBar1.MinimumSize = new System.Drawing.Size(0, 28);
            this.spreadsheetFormulaBar1.Name = "spreadsheetFormulaBar1";
            this.spreadsheetFormulaBar1.Size = new System.Drawing.Size(784, 28);
            this.spreadsheetFormulaBar1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetFormulaBar1.TabIndex = 2;
            // 
            // spreadsheetDockManager1
            // 
            this.spreadsheetDockManager1.Form = this;
            this.spreadsheetDockManager1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 586);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnImportDataTable;
        private DevExpress.XtraEditors.SimpleButton btnImportArray;
        private DevExpress.XtraEditors.SimpleButton btnImportList;
        private DevExpress.XtraEditors.SimpleButton btnImportObject;
        private DevExpress.XtraEditors.SimpleButton btnUseOptions;
        private DevExpress.XtraSpreadsheet.SpreadsheetDockManager spreadsheetDockManager1;
        private DevExpress.XtraEditors.SimpleButton btnUseFields;
        private DevExpress.XtraEditors.SimpleButton btnUseConverter;
        private DevExpress.XtraEditors.SimpleButton btnImportArrayList;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar spreadsheetFormulaBar1;
    }
}

