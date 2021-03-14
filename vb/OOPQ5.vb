Module OOPQ5
	Class PassengerVehicle
		Private RegNo As String
		Private NoOfSeats As Integer
		
		Sub New(ByVal RegNo As String, ByVal NoOfSeats As Integer)
			Me.RegNo = RegNo
			Me.NoOfSeats = NoOfSeats
		End Sub
		
		Public Sub GetRegNo()
			Return Me.RegNo
		End Sub

		Public Sub GetNoOfSeats()
			Return Me.NoOfSeats
		End Sub
	End Class

	Sub Main()
		Dim v As New PassengerVehicle("ABCD1234", 15)
	End Sub
End Module
