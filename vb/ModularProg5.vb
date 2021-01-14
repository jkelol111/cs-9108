Module ModularProg5
	Sub Main()
		Dim Side1 As Integer
		Dim Side2 As Integer
		
		Console.WriteLine("Enter side 1 of the right triangle:")
		Side1 = Console.ReadLine()
		
		Console.WriteLine("Enter side 2 of the right triangle:")
		Side2 = Console.ReadLine()
		
		Console.WriteLine("The hypotenuse is: " & hypotenuse(Side1, Side2))
		Console.ReadLine()
	End Sub
	Function hypotenuse(ByVal side1 As Single, ByVal side2 As Single) As Single
		Return Math.Sqrt((side1 ^ 2) + (side2 ^ 2))
	End Function
End Module
