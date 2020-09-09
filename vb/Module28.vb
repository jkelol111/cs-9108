Module Module28
	Sub Main()
		Dim base, height As Integer
		Dim hypotenuse As Single
		Console.WriteLine("Enter the base of the triangle:")
		base = Console.ReadLine()
		Console.WriteLine("Enter the height of the triangle:")
		height = Console.ReadLine()
		hypotenuse = ((base * base) + (height * height)) ^ 0.5
		Console.WriteLine("The hypotenuse is: {0}", hypotenuse)
		Console.ReadKey()
	End Sub
End Module
