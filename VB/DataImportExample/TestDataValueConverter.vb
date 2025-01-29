Imports DevExpress.Drawing
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DataImportExample
	#Region "#converter"
	Friend Class TestDataValueConverter
		Implements DevExpress.Spreadsheet.IDataValueConverter

		Public Function TryConvert(ByVal value As Object, ByVal columnIndex As Integer, <System.Runtime.InteropServices.Out()> ByRef result As DevExpress.Spreadsheet.CellValue) As Boolean
			Select Case value
				Case String strValue
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
				Case Integer intValue
					result = intValue
					Return True
				Case Boolean boolValue
					result = boolValue
					Return True
				Case Else
					result = If(value Is Nothing, Nothing, value.ToString())
					Return True
			End Select
		End Function
	End Class
	#End Region ' #converter
End Namespace
