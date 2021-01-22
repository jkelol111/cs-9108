Module RecursiveFunction1
	Sub Main()
		Dim a, b As Integer
		Dim c As Integer

		Console.WriteLine("Enter two numbers:")
		a = Console.ReadLine()
		b = Console.ReadLine()
		c = Divide(a, b)
		Console.WriteLine("The result of {0} divided by {1} is {2}", a, b, c)
		Console.ReadLine()
	End Sub

	Function Divide(ByVal x As Integer, ByVal y As Integer)
		If x < y Then
			Divide = 0
		Else
			Divide = 1 + Divide(x - y, y)
		End If
	End Function
End Module
