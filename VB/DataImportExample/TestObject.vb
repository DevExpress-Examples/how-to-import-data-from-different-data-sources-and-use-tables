Namespace DataImportExample
	#Region "#testObject"
	Friend Class TestObject
		Public Sub New(ByVal intValue As Integer, ByVal value As String, ByVal boolValue As Boolean, ByVal imageValue() As Byte)
			Me.intValue_Renamed = intValue
			Me.Value = value
			Me.BoolValue = boolValue
			Me.ImageValue = imageValue

		End Sub

		Public Sub New(ByVal intValue As Integer, ByVal value As String, ByVal boolValue As Boolean, ByVal imageBase64 As String)
			Me.intValue_Renamed = intValue
			Me.Value = value
			Me.BoolValue = boolValue
			Me.ImageBase64 = imageBase64
		End Sub
'INSTANT VB NOTE: The field intValue was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Public intValue_Renamed As Integer
		Private ReadOnly Property privateValue() As Integer
			Get
				Return 123
			End Get
		End Property
		Public ReadOnly Property IntValue() As Integer
			Get
				Return intValue_Renamed + privateValue - 123
			End Get
		End Property
		Public Property Value() As String
		Public Property BoolValue() As Boolean
		Public Property ImageValue() As Byte()
		Default Public ReadOnly Property Item(ByVal index As Integer) As Integer
			Get
				Return index
			End Get
		End Property
		Public Property ImageBase64() As String

	End Class
	#End Region ' #testObject
End Namespace
