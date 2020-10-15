Module SentinelLoop
	Sub Main()
		Dim value As Integer
		Console.WriteLine("Enter a list of numbers in the range - through 10 (any other number to quit): ")
		value = Console.ReadLine()
		While (value >= 0 And value <= 10)
			If (value Mod 2 = 0) Then
				Console.WriteLine("Even number")
			Else 
				Console.WriteLine("Odd number")
			End If

			Console.WriteLine("Enter a list of numbers in the range - through 10 (any other number to quit): ")
			value = Console.ReadLine()
		End While
		Console.ReadLine()
	End Sub
End Module