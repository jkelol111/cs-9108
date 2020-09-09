Module ConvertTemp
	Sub Main()
		Dim tempF As Single
		Console.Write("Temp in degrees F: ")
		tempF = Console.ReadLine()
		
		Dim tempC As Single
		tempC = (5 / 9) * (tempF - 32)
		Console.WriteLine("Temp in degrees C: {0}", tempC)
		Console.ReadLine()
	End Sub
End Module
