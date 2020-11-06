Module Cricket
	Sub Main()
		Console.Write("Home team name: ")
		Dim HomeTeamName As String = Console.ReadLine()
		Console.Write("Home runs: ")
		Dim HomeRuns As Integer = Console.ReadLine()
		Console.Write("Away team name: ")
		Dim AwayTeamName As String = Console.ReadLine()
		Console.Write("Away runs: ")
		Dim AwayRuns As Integer = Console.ReadLine()

		Dim RunDifference As Integer = Math.Abs(HomeRuns - AwayRuns)
		Dim WinningTeamName As String

		If HomeRuns > AwayRuns Then
			WinningTeamName = HomeTeamName
		Else
			WinningTeamName = AwayTeamName
		End If
		Console.WriteLine("Winning team: {0}", WinningTeamName)
		Console.WriteLine("Run difference: {0}", RunDifference)
		Console.ReadKey()
	End Sub
End Module
