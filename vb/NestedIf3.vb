Module NestedIf3
	Sub Main()
		' Example of nexted if statement
		Dim a As Integer = 23
		
		If a > 0 Then
			Console.WriteLine("The number is a POSITIVE number")
			If a = 1 Then
				Console.WriteLine("The number is neither Prime or Composite")
			ElseIf a = 2 Then
				Console.WriteLine("The number is the only even prime number")
			ElseIf a = 3 Then
				Console.WriteLine("The number is the least odd prime number")
			Else
				Console.WriteLine("The number is not 0, 1, 2, 3")
			End If
		ElseIf a < 0 Then
			Console.WriteLine("The number is a NEGATIVE number")
		Else
			Console.WriteLine("The number is zero")
		End If
		Console.ReadKey()
	End Sub
End Module
