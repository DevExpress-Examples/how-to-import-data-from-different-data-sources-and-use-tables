Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports System.Collections.Generic

Namespace DataImportExample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnImportDataTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportDataTable.Click
			spreadsheetControl1.Document.BeginUpdate()
			Try
				Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
				worksheet.Clear(worksheet.GetUsedRange())
				ImportDataTable()
				CreateTable()
			Finally
				spreadsheetControl1.Document.EndUpdate()
			End Try
		End Sub

		Private Sub btnImportArray_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportArray.Click
			spreadsheetControl1.Document.BeginUpdate()
			Try
				Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
				worksheet.Clear(worksheet.GetUsedRange())
				worksheet.Cells("A1").ColumnWidthInCharacters = 35
				worksheet.Cells("A1").Value = "Import an array horizontally:"
				worksheet.Cells("A3").Value = "Import a two-dimensional array:"
				ImportArrays()
			Finally
				spreadsheetControl1.Document.EndUpdate()
			End Try
		End Sub

		Private Sub btnImportList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportList.Click
			spreadsheetControl1.Document.BeginUpdate()
			Try
				Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
				worksheet.Clear(worksheet.GetUsedRange())
				worksheet.Cells("A1").ColumnWidthInCharacters = 35
				worksheet.Cells("A1").Value = "Import data from List vertically:"
				ImportList()
			Finally
				spreadsheetControl1.Document.EndUpdate()
			End Try
		End Sub

		Private Sub btnImportArrayList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportArrayList.Click
			spreadsheetControl1.Document.BeginUpdate()
			Try
				Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
				worksheet.Clear(worksheet.GetUsedRange())
				ImportArrayList()
			Finally
				spreadsheetControl1.Document.EndUpdate()
			End Try
		End Sub

#Region "#ImportDataTable"
		Private Sub ImportDataTable()

			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)

			' Create a "Products" DataTable object with four columns.
			Dim sourceTable As New DataTable("Products")
			sourceTable.Columns.Add("Product", GetType(String))
			sourceTable.Columns.Add("Price", GetType(Single))
			sourceTable.Columns.Add("Quantity", GetType(Int32))
			sourceTable.Columns.Add("Discount", GetType(Single))

			sourceTable.Rows.Add("Chocolade", 5, 15, 0.03)
			sourceTable.Rows.Add("Konbu", 9, 55, 0.1)
			sourceTable.Rows.Add("Geitost", 15, 70, 0.07)

			' Import data from the data table into the worksheet and insert it, starting with the B2 cell.
			worksheet.Import(sourceTable, True, 1, 1)
		End Sub
		#End Region ' #ImportDataTable

		#Region "#CreateTable"
		Private Sub CreateTable()

			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)

			' Insert a table in the worksheet.
			Dim table As Table = worksheet.Tables.Add(worksheet("B2:F5"), True)

			' Format the table by applying a built-in table style.
			table.Style = spreadsheetControl1.Document.TableStyles(BuiltInTableStyleId.TableStyleMedium27)

			' Access table columns.
			Dim productColumn As TableColumn = table.Columns(0)
			Dim priceColumn As TableColumn = table.Columns(1)
			Dim quantityColumn As TableColumn = table.Columns(2)
			Dim discountColumn As TableColumn = table.Columns(3)
			Dim amountColumn As TableColumn = table.Columns(4)

			' Set the name of the last column. 
			amountColumn.Name = "Amount"

			' Set the formula to calculate the amount per product 
			' and display results in the "Amount" column.
			amountColumn.Formula = "=[Price]*[Quantity]*(1-[Discount])"

			' Display the total row in the table.
			table.ShowTotals = True

			' Set the label and function to display the sum of the "Amount" column.
			discountColumn.TotalRowLabel = "Total:"
			amountColumn.TotalRowFunction = TotalRowFunction.Sum

			' Specify the number format for each column.
			priceColumn.DataRange.NumberFormat = "$#,##0.00"
			discountColumn.DataRange.NumberFormat = "0.0%"
			amountColumn.Range.NumberFormat = "$#,##0.00;$#,##0.00;"""";@"

			' Specify horizontal alignment for header and total rows of the table.
			table.HeaderRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			table.TotalRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center

			' Specify horizontal alignment to display data in all columns except the first one.
			For i As Integer = 1 To table.Columns.Count - 1
				table.Columns(i).DataRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
			Next i

			' Set the width of table columns.
			table.Range.ColumnWidthInCharacters = 10
		End Sub
		#End Region ' #CreateTable


		Private Sub ImportArrays()
			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
#Region "#ImportArrays"
			' Create an array containing string values.
			Dim array() As String = { "AAA", "BBB", "CCC", "DDD" }

			' Import the array into the worksheet and insert it horizontally, starting with the B1 cell.
			worksheet.Import(array, 0, 1, False)

			' Create a two-dimensional array containing string values.
			Dim names(,) As String = {
				{"Ann", "Edward", "Angela", "Alex"},
				{"Rachel", "Bruce", "Barbara", "George"}
			}

			' Import the two-dimensional array into the worksheet and insert it, starting with the B3 cell.
			worksheet.Import(names, 2, 1)
#End Region ' #ImportArrays
		End Sub

		Private Sub ImportList()
			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
#Region "#ImportList"
			' Create a List object containing string values.
			Dim cities As New List(Of String)()
			cities.Add("New York")
			cities.Add("Rome")
			cities.Add("Beijing")
			cities.Add("Delhi")

			' Import the list into the worksheet and insert it vertically, starting with the B1 cell.
			worksheet.Import(cities, 0, 1, True)
#End Region ' #ImportList
		End Sub

		Private Sub ImportArrayList()
			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
#Region "#ImportArrayList"
			Dim listDataSource As New System.Collections.ArrayList()
			listDataSource.Add(New TestObject(1, "Jane", True))
			listDataSource.Add(New TestObject(2, "Joe", False))
			listDataSource.Add(New TestObject(3, "Bill", True))
			listDataSource.Add(New TestObject(4, "Michael", False))
			worksheet.Import(listDataSource, 0, 0)
#End Region ' #ImportArrayList
		End Sub

		Private Sub btnImportObject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportObject.Click
			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
			worksheet.Clear(worksheet.GetUsedRange())
#Region "#ImportObject"
			worksheet.Import(New TestObject(1, "1", True), 0, 0)
#End Region ' #ImportObject
		End Sub


		Private Sub btnUseOptions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUseOptions.Click
			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
			worksheet.Clear(worksheet.GetUsedRange())
#Region "#ImportUsingOptions"
			Dim arrayR1C1() As String = {"a", "b", "=R1C1&R1C2"}
			worksheet.Import(arrayR1C1, 0, 0, False, New DataImportOptions() With {.ImportFormulas = True, .ReferenceStyle = ReferenceStyle.R1C1})

			Dim arrayLocalized() As String = {"a", "=1,2+1"}
			worksheet.Import(arrayLocalized, 1, 0, False, New DataImportOptions() With {.ImportFormulas = True, .FormulaCulture = New System.Globalization.CultureInfo("de-DE")})
#End Region ' #ImportUsingOptions
		End Sub

		Private Sub btnUseFields_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUseFields.Click
			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
			worksheet.Clear(worksheet.GetUsedRange())
#Region "#ImportSpecifiedFields"
			Dim list As New List(Of TestObject)()
			list.Add(New TestObject(1, "1", True))
			list.Add(New TestObject(2, "2", False))
			worksheet.Import(list, 0, 0, New DataSourceImportOptions() With {
				.PropertyNames = New String() {"BoolValue", "IntValue"}
			})
#End Region ' #ImportSpecifiedFields
		End Sub

		Private Sub btnUseConverter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUseConverter.Click
			Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
			worksheet.Clear(worksheet.GetUsedRange())
#Region "#ImportUsingConverter"
			Dim list As New List(Of TestObject)()
			list.Add(New TestObject(1, "1", True))
			list.Add(New TestObject(2, "2", False))
			worksheet.Import(list, 0, 0, New DataSourceImportOptions() With {.Converter = New TestDataValueConverter()})
#End Region ' #ImportUsingConverter
		End Sub


	End Class
End Namespace
