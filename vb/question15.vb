Module Riders
	Sub Main()
		Console.Write("Number of minutes: ")
		Dim minutes As Integer = Console.ReadLine()
		Console.Write("Number of seconds: ")
		Dim seconds As Integer = Console.ReadLine()
		Console.Write("Position: ")
		Dim position As Integer = Console.ReadLine()
		
		Dim total As Integer = (minutes * 60) + seconds
		If position = 1 Then
			total -= 20
		ElseIf position = 2 Then
			total -= 10
		ElseIf position = 3 Then
			total -= 5
		End If

		Console.WriteLine("Race time: {0} seconds", total)
		Console.ReadLine()
	End Sub
End Module
