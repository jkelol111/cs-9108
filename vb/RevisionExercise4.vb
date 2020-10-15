Module RevisionExercise4
	Sub Main()
		Dim i, j As Integer
		i = 0
		j = 0

		While (i <= 4)
			While (j <= 4)
				Console.Write("* ")
				j += 1
			End While
			i += 1
			j = 0
			Console.WriteLine()
		End While

		Console.ReadKey()
	End Sub
End Module