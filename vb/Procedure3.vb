Module Module5
	Sub Main()
		Call printyourname()
		Console.ReadLine()
	End Sub
	Sub printyourname()
		Dim n As String
		Console.Write("Enter yourname:")
		n = Console.ReadLine()
		Console.WriteLine("Welcome " & n & "!")
	End Sub
End Module
