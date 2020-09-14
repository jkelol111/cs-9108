‘A Sprinter for 100m ran 9.87s
‘What is his speed in km/h?

Module Sprinter
	Sub Main()
		Dim distance As Single
		Dim time As Single
		Dim speed As Single

		' 100m is 0.1 km
		distance = 0.1
	
		' 9.87s is 9.87/60*60 h
		time = 9.87 / 3600
		speed = distance / time
	
		Console.WriteLine(“The average speed of a sprinter is {0} km/h”, speed)
		Console.ReadLine()
	End Sub
End Module
