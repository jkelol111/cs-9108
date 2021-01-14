Module ModularProg3
	Function Area(ByVal radius As Double) As Double
		Return Math.PI * Math.Pow(radius, 2)
	End Function

	Sub Main()
		Dim a As Double
		Console.WriteLine("Enter the radius of the circle: ")
		a = Console.ReadLine()
		Console.WriteLine("The area of the circle with ")
		Console.WriteLine("radius of " & a & " is " & Area(a))
		Console.ReadLine()
	End Sub
End Module
