Module OOP7
	MustInherit Class PassengerVehicle
		Protected RegNo As String
		Protected NoOfSeats As Integer
		Public Function ShowRegNo() As String
			ShowRegNo = RegNo
		End Function
		Public Function ShowNoSeats() As Integer
			ShowNoSeats = NoOfSeats
		End Function
	End Class
	Class Bus
		Inherits PassengerVehicle
		Private MaxStanding As Integer
		Private SB As Boolean
		Public Sub New(ByVal RN As String, ByVal NOS As Integer, ByVal MS As Integer)
			Me.RegNo = RN
			Me.NoOfSeats = NOS
			Me.MaxStanding = MS
		End Sub
		Public Function ShowMaxStanding() As Integer
			ShowMaxStanding = MaxStanding
		End Function
		Public Function ShowSB() As Boolean
			ShowSB = SB
		End Function
	End Class
	Sub Main()
		Dim pv1 As New Bus("NBR 123", 51, 10)
		Console.WriteLine("Reg number: {0}", pv1.ShowRegNo())
		Console.WriteLine("No of seats: {0}", pv1.ShowNoSeats())
		Console.WriteLine("Max standing: {0}", pv1.ShowMaxStanding())
		Console.ReadKey()
	End Sub
End Module
