Module RecursiveFunction4
	Sub Main()
		Dim m, n As Integer
		Dim result As Integer
		
		Console.WriteLine("Enter two integers:")
		m = Console.ReadLine()
		n = Console.ReadLine()
		result = GCD(m, n)
		Console.WriteLine(result)
		Console.ReadLine()
	End Sub
	Function GCD(X As Integer, Y As Integer) As Integer
		If (Y <= X) And (X Mod Y = 0) Then
			GCD = Y
		ElseIf X < Y Then
			GCD = GCD(Y, X)
		Else
			GCD = GCD(Y, X Mod Y)
		End If
	End Function
End Module
