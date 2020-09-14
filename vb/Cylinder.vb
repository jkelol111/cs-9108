Module Cylinder
	Sub Main()
		Console.Write("Cylinder radius: ")
		Dim r as Single = Console.ReadLine()
		Console.Write("Cylinder height: ")
		Dim h as Single = Console.ReadLine()
		
		Dim V as Single = System.Math.Pi * (h^2) * h
		Console.WriteLine("Cylinder volume: {0}", V)
		Console.ReadLine()
	End Sub
End Module
