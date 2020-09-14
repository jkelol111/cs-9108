Module Marathon
	Sub Main()
		Console.Write("Time in hh: ")
		Dim hours As Integer = Console.ReadLine()
		Console.Write("Time in mm: ")
		Dim minutes As Integer = Console.ReadLine()
		Console.Write("Time in ss: ")
		Dim seconds As Integer = Console.ReadLine()
		

		Dim total As Integer = (hours * 60 * 60) + (minutes * 60) + seconds
		Console.WriteLine("Total time in ss: {0}", total)
	End Sub
End Module
