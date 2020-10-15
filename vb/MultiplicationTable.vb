Module MultiplicationTable
	Sub Main()
		Dim i As Integer = 1
		Dim j As Integer = 1

		Console.WriteLine("Tables")

		While (i <= 2)
			While (j <= 10)
				Console.WriteLine(i & " * " & j & " = " & (i * j))
				j = j + 1
			End While
			i = i + 1
			Console.WriteLine()
		End While
		Console.ReadLine()
	End Sub
End Module