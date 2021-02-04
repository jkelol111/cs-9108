Module Rand2
	Sub Main()
		Dim number As Integer
		Dim Index As Integer
		For Index = 1 To 10
			Randomize()
			number = Int(Rnd() * 12) + 1
			Console.WriteLine(number)
		Next
		Console.ReadLine()
	End Sub
End Module
