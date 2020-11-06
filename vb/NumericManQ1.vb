Module NumericManQ1 
	Sub Main()
		Dim hours, minutes, seconds, total As Integer
		Console.Write("Hours: ")
		hours = Console.ReadLine()
		Console.Write("Minutes: ")
		minutes = Console.ReadLine()
		Console.Write("Seconds: ")
		seconds = Console.ReadLine()
		total = (hours * 60 * 60) + (minutes * 60) + seconds
		Console.WriteLine("Time in secs: {0}", total)
	End Sub
End Module
