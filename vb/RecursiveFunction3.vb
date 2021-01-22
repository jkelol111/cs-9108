Module ResursiveFunction3
	Sub Main()
		Dim n As Integer
		Console.WriteLine("How many letters in the word?")
		n = Console.ReadLine()
		Call Reverse(n)
		Console.ReadLine()
	End Sub
	Sub Reverse(N As Integer)
		Dim NewChar As Char
		If N = 1 Then
			NewChar = Console.ReadLine()
			Console.Write(NewChar)
		Else 
			NewChar = Console.ReadLine()
			Call Reverse(N - 1)
			Console.Write(NewChar)
		End If
	End Sub
End Module
