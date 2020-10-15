Module SentinelLoop2
	Sub Main()
		Dim Mark As Integer
		Dim Total As Integer
		Dim Average As Integer
		Dim Count As Integer

		Console.Write("Enter the mark (between 0 to 100): ")
		Mark = Console.ReadLine()

		While (Mark >= 0 And Mark <= 100)
			Total += Mark
			Count += 1
			Console.Write("Enter the mark (between 0 to 100): ")
			Mark = Console.ReadLine()
		End While

		Average = Total / Count
		Console.WriteLine("The average mark for the class is {0}", Average)
		Console.ReadLine()
	End Sub
End Module