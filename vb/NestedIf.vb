Module NestedIf
	Sub Main()
		Dim a As Integer = 100
		Dim b As Integer = 200
		
		If (a = 100) Then
			' if condition is true then check the following 
			If (b = 200) Then
				' if statement is true then print the following
				Console.WriteLine("Value of a is 100 and b is 200.")
			End If
		End If
		Console.WriteLine("Exact value of a is: {0}", a)
		Console.WriteLine("Exact value of b is: {0}", b)
		Console.ReadKey()
	End Sub
End Module
