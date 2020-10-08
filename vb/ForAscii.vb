Module ForAscii
	Sub Main()
		Dim x As Integer
		
		For x = 1 To 5
			Console.WriteLine(Chr(64 + x))
		Next
		
		Console.ReadKey()
	End Sub
End Module
