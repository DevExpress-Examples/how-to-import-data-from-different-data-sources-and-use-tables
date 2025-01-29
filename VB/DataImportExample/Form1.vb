Imports System.Data
Imports System.IO
Imports DevExpress.Spreadsheet

Namespace DataImportExample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private imageBytes1() As Byte = File.ReadAllBytes("images//img.png")
        Private imageBytes2() As Byte = File.ReadAllBytes("images//x-docserver.png")
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnImportDataTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportDataTable.Click
            Dim workbook As New Workbook()
            workbook.BeginUpdate()
            Try
                Dim worksheet As Worksheet = workbook.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                ImportDataTable(worksheet)
                CreateTable(worksheet)
            Finally
                workbook.EndUpdate()
                workbook.SaveDocument("result.xlsx")
                Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            End Try
            workbook.Dispose()
        End Sub

        Private Sub btnImportArray_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportArray.Click
            Dim workbook As New Workbook()
            workbook.BeginUpdate()
            Try
                Dim worksheet As Worksheet = workbook.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                worksheet.Cells("A1").ColumnWidthInCharacters = 35
                worksheet.Cells("A1").Value = "Import an array horizontally:"
                worksheet.Cells("A3").Value = "Import a two-dimensional array:"
                worksheet.Cells("A5").Value = "Import image data:"
                ImportArrays(worksheet)
            Finally
                workbook.EndUpdate()
                workbook.SaveDocument("result.xlsx")
                Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            End Try
            workbook.Dispose()
        End Sub

        Private Sub btnImportList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportList.Click
            Dim workbook As New Workbook()
            workbook.BeginUpdate()
            Try
                Dim worksheet As Worksheet = workbook.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                worksheet.Cells("A1").ColumnWidthInCharacters = 35
                worksheet.Cells("A1").Value = "Import data from List vertically:"
                ImportList(worksheet)
            Finally
                workbook.EndUpdate()
                workbook.SaveDocument("result.xlsx")
                Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            End Try
            workbook.Dispose()
        End Sub

        Private Sub btnArrayList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportArrayList.Click
            Dim workbook As New Workbook()
            workbook.BeginUpdate()
            Try
                Dim worksheet As Worksheet = workbook.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                ImportArrayList(worksheet)
            Finally
                workbook.EndUpdate()
                workbook.SaveDocument("result.xlsx")
                Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            End Try
        End Sub

#Region "#ImportDataTable"
        Private Sub ImportDataTable(ByVal worksheet As Worksheet)
            ' Create a "Products" DataTable object with four columns.
            Dim sourceTable As New DataTable("Products")
            sourceTable.Columns.Add("Product", GetType(String))
            sourceTable.Columns.Add("Price", GetType(Single))
            sourceTable.Columns.Add("Quantity", GetType(Int32))
            sourceTable.Columns.Add("Discount", GetType(Single))
            sourceTable.Columns.Add("Image", GetType(Byte()))

            sourceTable.Rows.Add("Chocolade", 5, 15, 0.03, imageBytes1)
            sourceTable.Rows.Add("Konbu", 9, 55, 0.1, imageBytes1)
            sourceTable.Rows.Add("Geitost", 15, 70, 0.07, imageBytes2)

            ' Import data from the data table into the worksheet and insert it, starting with the B2 cell.
            worksheet.Import(sourceTable, True, 1, 1)
        End Sub
#End Region ' #ImportDataTable

#Region "#CreateTable"
        Private Sub CreateTable(ByVal worksheet As Worksheet)
            ' Insert a table in the worksheet.
            Dim table As Table = worksheet.Tables.Add(worksheet("B2:G5"), True)

            ' Format the table by applying a built-in table style.
            table.Style = worksheet.Workbook.TableStyles(BuiltInTableStyleId.TableStyleMedium27)

            ' Access table columns.
            Dim productColumn As TableColumn = table.Columns(0)
            Dim priceColumn As TableColumn = table.Columns(1)
            Dim quantityColumn As TableColumn = table.Columns(2)
            Dim discountColumn As TableColumn = table.Columns(3)
            Dim imageColumn As TableColumn = table.Columns(4)
            Dim amountColumn As TableColumn = table.Columns(5)

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

#Region "#ImportArrays"
        Private Sub ImportArrays(ByVal worksheet As Worksheet)
            ' Create an array containing string values.
            Dim array() As String = {"AAA", "BBB", "CCC", "DDD"}

            ' Import the array into the worksheet and insert it horizontally, starting with the B1 cell.
            worksheet.Import(array, 0, 1, False)

            ' Create a two-dimensional array containing string values.
            Dim names(,) As String = {
                {"Ann", "Edward", "Angela", "Alex"},
                {"Rachel", "Bruce", "Barbara", "George"}
            }

            ' Import the two-dimensional array into the worksheet and insert it, starting with the B3 cell.
            worksheet.Import(names, 2, 1)
        End Sub
#End Region ' #ImportArrays

#Region "#ImportList"
        Private Sub ImportList(ByVal worksheet As Worksheet)
            ' Create a List object containing string values.
            Dim cities As New List(Of String) From {"New York", "Rome", "Beijing", "Delhi"}

            Dim images As New List(Of Byte()) From {imageBytes1, imageBytes2}

            ' Import the list into the worksheet and insert it vertically, starting with the B1 cell.
            worksheet.Import(cities, 0, 1, True)
            worksheet.Import(images, 2, 1)
        End Sub
#End Region ' #ImportList

#Region "#ImportArrayList"
        Private Sub ImportArrayList(ByVal worksheet As Worksheet)
            Dim listDataSource As New ArrayList() From {
    New TestObject(1, "Jane", True, imageBytes1),
    New TestObject(2, "Joe", False, imageBytes2),
    New TestObject(3, "Bill", True, imageBytes1),
    New TestObject(4, "Michael", False, imageBytes2)
}
            worksheet.Import(listDataSource, 0, 0)
        End Sub
#End Region ' #ImportArrayList


        Private Sub btnImportObject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportObject.Click
            '			#Region "#ImportObject"
            Dim workbook As New Workbook()
            Dim worksheet = workbook.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())

            worksheet.Import(New TestObject(1, "1", True, imageBytes1), 0, 0)

            workbook.SaveDocument("result.xlsx")
            Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            '			#End Region ' #ImportObject
        End Sub


        Private Sub btnUseOptions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUseOptions.Click
            '			#Region "#ImportUsingOptions"
            Dim workbook As New Workbook()
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())

            Dim arrayR1C1() As String = {"a", "b", "=R1C1&R1C2"}
            worksheet.Import(arrayR1C1, 0, 0, False, New DataImportOptions() With {
                .ImportFormulas = True,
                .ReferenceStyle = ReferenceStyle.R1C1
            })

            Dim arrayLocalized() As String = {"a", "=1,2+1"}
            worksheet.Import(arrayLocalized, 1, 0, False, New DataImportOptions() With {
                .ImportFormulas = True,
                .FormulaCulture = New System.Globalization.CultureInfo("de-DE")
            })
            workbook.SaveDocument("result.xlsx")
            Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            '			#End Region ' #ImportUsingOptions
        End Sub

        Private Sub btnUseFields_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUseFields.Click
            '			#Region "#ImportSpecifiedFields"
            Dim workbook As New Workbook()
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())

            Dim list As List(Of TestObject) = New List(Of TestObject) From {
    New TestObject(1, "1", True, imageBytes1),
    New TestObject(2, "2", False, imageBytes2)
}
            worksheet.Import(list, 0, 0, New DataSourceImportOptions() With {
                .PropertyNames = New String() {"BoolValue", "ImageValue"}
            })
            workbook.SaveDocument("result.xlsx")
            Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            '			#End Region ' #ImportSpecifiedFields
        End Sub

        Private Sub btnUseConverter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUseConverter.Click
            '			#Region "#ImportUsingConverter"
            Dim workbook As New Workbook()
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())

            Dim imageBase64 As String = Convert.ToBase64String(imageBytes1)

            Dim list As List(Of TestObject) = New List(Of TestObject) From {
    New TestObject(1, "1", True, imageBytes1),
    New TestObject(2, "2", False, imageBytes2)
}
            worksheet.Import(list, 0, 0, New DataSourceImportOptions() With {
                .Converter = New TestDataValueConverter(),
                .PropertyNames = New String() {"IntValue", "Value", "BoolValue", "ImageBase64"}
            })

            workbook.SaveDocument("result.xlsx")
            Process.Start(New ProcessStartInfo("result.xlsx") With {.UseShellExecute = True})
            '			#End Region ' #ImportUsingConverter
        End Sub
    End Class
End Namespace
