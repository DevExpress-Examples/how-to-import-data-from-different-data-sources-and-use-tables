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
			btnImportArrayList = New DevExpress.XtraEditors.SimpleButton()
			btnUseConverter = New DevExpress.XtraEditors.SimpleButton()
			btnUseFields = New DevExpress.XtraEditors.SimpleButton()
			btnUseOptions = New DevExpress.XtraEditors.SimpleButton()
			btnImportObject = New DevExpress.XtraEditors.SimpleButton()
			btnImportList = New DevExpress.XtraEditors.SimpleButton()
			btnImportArray = New DevExpress.XtraEditors.SimpleButton()
			btnImportDataTable = New DevExpress.XtraEditors.SimpleButton()
			SuspendLayout()
			' 
			' btnImportArrayList
			' 
			btnImportArrayList.Location = New System.Drawing.Point(10, 367)
			btnImportArrayList.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnImportArrayList.Name = "btnImportArrayList"
			btnImportArrayList.Size = New System.Drawing.Size(480, 69)
			btnImportArrayList.TabIndex = 7
			btnImportArrayList.Text = "Import ArrayList"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnImportArrayList.Click += btnArrayList_Click;
			' 
			' btnUseConverter
			' 
			btnUseConverter.Location = New System.Drawing.Point(10, 627)
			btnUseConverter.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnUseConverter.Name = "btnUseConverter"
			btnUseConverter.Size = New System.Drawing.Size(480, 69)
			btnUseConverter.TabIndex = 6
			btnUseConverter.Text = "Import Using Converter"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnUseConverter.Click += btnUseConverter_Click;
			' 
			' btnUseFields
			' 
			btnUseFields.Location = New System.Drawing.Point(10, 544)
			btnUseFields.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnUseFields.Name = "btnUseFields"
			btnUseFields.Size = New System.Drawing.Size(480, 69)
			btnUseFields.TabIndex = 5
			btnUseFields.Text = "Import Specified Fields"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnUseFields.Click += btnUseFields_Click;
			' 
			' btnUseOptions
			' 
			btnUseOptions.Location = New System.Drawing.Point(10, 453)
			btnUseOptions.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnUseOptions.Name = "btnUseOptions"
			btnUseOptions.Size = New System.Drawing.Size(480, 69)
			btnUseOptions.TabIndex = 4
			btnUseOptions.Text = "Import Using Options"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnUseOptions.Click += btnUseOptions_Click;
			' 
			' btnImportObject
			' 
			btnImportObject.Location = New System.Drawing.Point(10, 278)
			btnImportObject.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnImportObject.Name = "btnImportObject"
			btnImportObject.Size = New System.Drawing.Size(480, 69)
			btnImportObject.TabIndex = 3
			btnImportObject.Text = "Import Object"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnImportObject.Click += btnImportObject_Click;
			' 
			' btnImportList
			' 
			btnImportList.Location = New System.Drawing.Point(10, 194)
			btnImportList.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnImportList.Name = "btnImportList"
			btnImportList.Size = New System.Drawing.Size(480, 69)
			btnImportList.TabIndex = 2
			btnImportList.Text = "Import List"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnImportList.Click += btnImportList_Click;
			' 
			' btnImportArray
			' 
			btnImportArray.Location = New System.Drawing.Point(10, 106)
			btnImportArray.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnImportArray.Name = "btnImportArray"
			btnImportArray.Size = New System.Drawing.Size(480, 69)
			btnImportArray.TabIndex = 1
			btnImportArray.Text = "Import Arrays"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnImportArray.Click += btnImportArray_Click;
			' 
			' btnImportDataTable
			' 
			btnImportDataTable.Location = New System.Drawing.Point(10, 9)
			btnImportDataTable.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			btnImportDataTable.Name = "btnImportDataTable"
			btnImportDataTable.Size = New System.Drawing.Size(480, 78)
			btnImportDataTable.TabIndex = 0
			btnImportDataTable.Text = "Import DataTable"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: btnImportDataTable.Click += btnImportDataTable_Click;
			' 
			' Form1
			' 
			AutoScaleDimensions = New System.Drawing.SizeF(12F, 25F)
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			ClientSize = New System.Drawing.Size(519, 720)
			Controls.Add(btnImportArray)
			Controls.Add(btnImportArrayList)
			Controls.Add(btnImportDataTable)
			Controls.Add(btnImportList)
			Controls.Add(btnImportObject)
			Controls.Add(btnUseOptions)
			Controls.Add(btnUseFields)
			Controls.Add(btnUseConverter)
			Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
			Name = "Form1"
			Text = "Form1"
			ResumeLayout(False)
		End Sub

		#End Region
		Private WithEvents btnImportDataTable As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportArray As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportList As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportObject As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnUseOptions As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnUseFields As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnUseConverter As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportArrayList As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

