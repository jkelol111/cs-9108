Module Module7
	Sub Main()
		Dim ParkingPaid As Boolean = True
		Dim Parking As String
		
		Console.WriteLine("Have you paid for parking? <y/n>")
		Parking = Console.ReadLine()
		
		If Parking = "y" Then
			If ParkingPaid Then
				Console.WriteLine("Allow exit")
			End If
		Else
			Console.WriteLine("Exit denied")
		End If
		Console.ReadKey()
	End Sub
End Module
