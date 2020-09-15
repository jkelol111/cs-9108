Module CompareNumbers
	Sub Main()
		Console.Write("Input int1: ")
		Dim int1 As Integer = Console.ReadLine()
		Console.Write("Input int2: ")
		Dim int2 As Integer = Console.ReadLine()
		If (int1 > int2) Then
			Console.WriteLine(int1)
		Else 
			Console.WriteLine(int2)
		End If
		Console.ReadKey()
	End Sub
End Module
