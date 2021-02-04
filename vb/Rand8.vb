Module Rand8
	Dim num As Integer
	Sub Main()
		Dim index As Integer
		For index = 1 To 10
			num = Int(Rnd() * 6) + 1
		Next
		Console.ReadLine()
	End Sub
End Module
