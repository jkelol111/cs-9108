Module GolfClub
	Sub AddNewScores()
		Dim ScoreDate As String
		Dim MembershipNumber As String
		Dim Score As String 
		While true
			Console.Write("Input score date (DDMMYY): ")
			ScoreDate = Console.ReadLine()
			Console.Write("Input membership number (XXXX): ")
			MembershipNumber = Console.ReadLine()
			If MembershipNumber = "" Then
				Exit While
			Else
				While Len(Score) <> 2
					Console.Write("Input score (XX): ")
					Score = Console.ReadLine()
				End While
				PrintLine(1, MembershipNumber & ScoreDate & Score)
			End If
		End While
	End Sub
	Sub Main()
		FileOpen(1, "../vb_filehandling/ScoreDetails.txt", OpenMode.Append)
		Call AddNewScores()
		FileClose(1)
	End Sub
End Module
