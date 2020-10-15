Module AgeWhileLoop
	Sub Main()
		Dim age As Integer
		Console.Write("Enter Age: ")
		age = Console.ReadLine()
		While age > 10
			age += 1
			Console.WriteLine(age)
			If age = 50 Then
				Exit While
			End If
		End While
		Console.ReadLine()
	End Sub
End Module