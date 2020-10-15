Module RevisionExercise4
	Sub Main()
		Dim i, j As Integer
		i = 1
		j = 1

		While (i <= 5)
			While (j <= 5)
				Console.Write("* ")
				j += 1
			End While
			i += 1
			j = 1
			Console.WriteLine()
		End While

		Console.ReadKey()
	End Sub
End Module