Module FactorialLoop
	Sub Main()
		Dim n, i, f As Integer
		Console.Write("Enter a number: ")
		n = CInt(Console.ReadLine())
		f = 1
		If n < 0 Then
			Console.WriteLine("Factorial of negative number is not possible")
		ElseIf n = 0 or n = 1 Then
			Console.WriteLine("Factorial of {0} is 1", n)
		Else
			For i = 1 To n
				f *= i
			Next
			Console.WriteLine("Factorial of {0} is {1}", n, f)
		End If
		Console.ReadKey()
	End Sub
End Module
