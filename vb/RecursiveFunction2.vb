Module RecursiveFunction2
	Sub Main()
		Dim m, n As Integer
		Dim result As Integer
		
		Console.WriteLine("Enter two numbers:")
		m = Console.ReadLine()
		n = Console.ReadLine()
		result = Multiply(m, n)
		
		Console.WriteLine("The result of multiplying {0} with {1} is {2}.", m, n, result)
		Console.ReadLine()
		
	End Sub
	
	Function Multiply(x As Integer, y As Integer) As Integer
		If y = 1 Then
			Multiply = x
		Else 
			Multiply = x + Multiply(x, y-1)
		End If
	End Function
End Module
