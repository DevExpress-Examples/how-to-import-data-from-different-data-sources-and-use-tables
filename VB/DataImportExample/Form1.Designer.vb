Namespace DataImportExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.btnImportArrayList = New DevExpress.XtraEditors.SimpleButton()
            Me.btnUseConverter = New DevExpress.XtraEditors.SimpleButton()
            Me.btnUseFields = New DevExpress.XtraEditors.SimpleButton()
            Me.btnUseOptions = New DevExpress.XtraEditors.SimpleButton()
            Me.btnImportObject = New DevExpress.XtraEditors.SimpleButton()
            Me.btnImportList = New DevExpress.XtraEditors.SimpleButton()
            Me.btnImportArray = New DevExpress.XtraEditors.SimpleButton()
            Me.btnImportDataTable = New DevExpress.XtraEditors.SimpleButton()
            Me.spreadsheetDockManager1 = New DevExpress.XtraSpreadsheet.SpreadsheetDockManager(Me.components)
            Me.SpreadsheetFormulaBar1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar()
            Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel2.SuspendLayout()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'spreadsheetControl1
            '
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 40)
            Me.spreadsheetControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = Global.Microsoft.VisualBasic.ChrW(44)
            Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Size = New System.Drawing.Size(866, 546)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.IsSplitterFixed = True
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            '
            'splitContainerControl1.Panel1
            '
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportArrayList)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnUseConverter)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnUseFields)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnUseOptions)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportObject)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportList)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportArray)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportDataTable)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            '
            'splitContainerControl1.Panel2
            '
            Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetControl1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.SplitterControl1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.SpreadsheetFormulaBar1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(1046, 586)
            Me.splitContainerControl1.SplitterPosition = 168
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'btnImportArrayList
            '
            Me.btnImportArrayList.Location = New System.Drawing.Point(4, 150)
            Me.btnImportArrayList.Margin = New System.Windows.Forms.Padding(4)
            Me.btnImportArrayList.Name = "btnImportArrayList"
            Me.btnImportArrayList.Size = New System.Drawing.Size(157, 28)
            Me.btnImportArrayList.TabIndex = 7
            Me.btnImportArrayList.Text = "Import ArrayList"
            '
            'btnUseConverter
            '
            Me.btnUseConverter.Location = New System.Drawing.Point(4, 257)
            Me.btnUseConverter.Margin = New System.Windows.Forms.Padding(4)
            Me.btnUseConverter.Name = "btnUseConverter"
            Me.btnUseConverter.Size = New System.Drawing.Size(157, 28)
            Me.btnUseConverter.TabIndex = 6
            Me.btnUseConverter.Text = "Import Using Converter"
            '
            'btnUseFields
            '
            Me.btnUseFields.Location = New System.Drawing.Point(4, 222)
            Me.btnUseFields.Margin = New System.Windows.Forms.Padding(4)
            Me.btnUseFields.Name = "btnUseFields"
            Me.btnUseFields.Size = New System.Drawing.Size(157, 28)
            Me.btnUseFields.TabIndex = 5
            Me.btnUseFields.Text = "Import Specified Fields"
            '
            'btnUseOptions
            '
            Me.btnUseOptions.Location = New System.Drawing.Point(4, 186)
            Me.btnUseOptions.Margin = New System.Windows.Forms.Padding(4)
            Me.btnUseOptions.Name = "btnUseOptions"
            Me.btnUseOptions.Size = New System.Drawing.Size(157, 28)
            Me.btnUseOptions.TabIndex = 4
            Me.btnUseOptions.Text = "Import Using Options"
            '
            'btnImportObject
            '
            Me.btnImportObject.Location = New System.Drawing.Point(4, 114)
            Me.btnImportObject.Margin = New System.Windows.Forms.Padding(4)
            Me.btnImportObject.Name = "btnImportObject"
            Me.btnImportObject.Size = New System.Drawing.Size(157, 28)
            Me.btnImportObject.TabIndex = 3
            Me.btnImportObject.Text = "Import Object"
            '
            'btnImportList
            '
            Me.btnImportList.Location = New System.Drawing.Point(4, 79)
            Me.btnImportList.Margin = New System.Windows.Forms.Padding(4)
            Me.btnImportList.Name = "btnImportList"
            Me.btnImportList.Size = New System.Drawing.Size(157, 28)
            Me.btnImportList.TabIndex = 2
            Me.btnImportList.Text = "Import List"
            '
            'btnImportArray
            '
            Me.btnImportArray.Location = New System.Drawing.Point(4, 43)
            Me.btnImportArray.Margin = New System.Windows.Forms.Padding(4)
            Me.btnImportArray.Name = "btnImportArray"
            Me.btnImportArray.Size = New System.Drawing.Size(157, 28)
            Me.btnImportArray.TabIndex = 1
            Me.btnImportArray.Text = "Import Arrays"
            '
            'btnImportDataTable
            '
            Me.btnImportDataTable.Location = New System.Drawing.Point(4, 4)
            Me.btnImportDataTable.Margin = New System.Windows.Forms.Padding(4)
            Me.btnImportDataTable.Name = "btnImportDataTable"
            Me.btnImportDataTable.Size = New System.Drawing.Size(157, 32)
            Me.btnImportDataTable.TabIndex = 0
            Me.btnImportDataTable.Text = "Import DataTable"
            '
            'spreadsheetDockManager1
            '
            Me.spreadsheetDockManager1.Form = Me
            Me.spreadsheetDockManager1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
            '
            'SpreadsheetFormulaBar1
            '
            Me.SpreadsheetFormulaBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.SpreadsheetFormulaBar1.Location = New System.Drawing.Point(0, 0)
            Me.SpreadsheetFormulaBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.SpreadsheetFormulaBar1.MinimumSize = New System.Drawing.Size(0, 24)
            Me.SpreadsheetFormulaBar1.Name = "SpreadsheetFormulaBar1"
            Me.SpreadsheetFormulaBar1.Size = New System.Drawing.Size(866, 28)
            Me.SpreadsheetFormulaBar1.SpreadsheetControl = Me.spreadsheetControl1
            Me.SpreadsheetFormulaBar1.TabIndex = 2
            '
            'SplitterControl1
            '
            Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.SplitterControl1.Location = New System.Drawing.Point(0, 28)
            Me.SplitterControl1.MinSize = 20
            Me.SplitterControl1.Name = "SplitterControl1"
            Me.SplitterControl1.Size = New System.Drawing.Size(866, 12)
            Me.SplitterControl1.TabIndex = 1
            Me.SplitterControl1.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1046, 586)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel2.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents btnImportDataTable As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnImportArray As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnImportList As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnImportObject As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnUseOptions As DevExpress.XtraEditors.SimpleButton
        Private spreadsheetDockManager1 As DevExpress.XtraSpreadsheet.SpreadsheetDockManager
        Private WithEvents btnUseFields As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnUseConverter As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnImportArrayList As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
        Friend WithEvents SpreadsheetFormulaBar1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar
    End Class
End Namespace

