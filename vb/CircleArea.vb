Module CircleArea
	Sub Main()
		Dim r As Single
		' I dunno how to include System.Math.Pi for the actual Pi value
		Dim pi As Single
		pi = 3.14159
		Console.Write("Input circle radius: ")
		r = Console.ReadLine()
		
		Dim area As Single
		area = pi * r * r
		Console.WriteLine("Area of circle: {0}", area)
		Console.ReadLine()
	End Sub
End Module
