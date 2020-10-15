Module RevisionExercise5
	 Sub Main()
	 	Dim Line As Integer = 0
	 	Dim Shift As Integer = 0

	 	While (Line <= 4)
	 		While (Shift <= Line)
		 		Console.Write(Chr(65 + Shift))
		 		Shift += 1
		 	End While
		 	Shift = 0
		 	Line += 1
		 	Console.WriteLine()
		End While

		Console.ReadKey()
	End Sub
End Module
