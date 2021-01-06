Module Classwork1
	Sub Main()
		Dim numbers(100) As Integer
		For i As Integer = 0 To 99
			Console.Write("Input number {0}: ", i)
			Dim input As Integer = Console.ReadLine()
			numbers(i) = input
		Next
		For i As Integer = 0 To 99
			Console.WriteLine(numbers(i))
		Next
		Console.ReadKey()
	End Sub
End Module
