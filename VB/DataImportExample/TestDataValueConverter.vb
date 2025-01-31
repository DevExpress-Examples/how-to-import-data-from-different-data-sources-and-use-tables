Imports DevExpress.Drawing
Imports DevExpress.Spreadsheet
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Namespace DataImportExample
#Region "#converter"
    Friend Class TestDataValueConverter
        Implements IDataValueConverter
        Private Function IDataValueConverter_TryConvert(value As Object, index As Integer, ByRef result As CellValue) As Boolean Implements IDataValueConverter.TryConvert
            If TypeOf value Is String Then
                Dim strValue As String = TryCast(value, String)

                Try
                    result = DXImage.FromBase64String(strValue)
                Catch
                    Dim str2int As Integer = 0

                    If Int32.TryParse(strValue, str2int) Then
                        result = str2int
                    Else
                        result = strValue
                    End If
                End Try

                Return True
            End If

            result = DevExpress.Spreadsheet.CellValue.TryCreateFromObject(value)
            Return True
        End Function

    End Class
#End Region ' #converter
End Namespace
