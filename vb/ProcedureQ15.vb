Module ProcedureQ5
	Function Area(ByVal width As Single, ByVal height As Single) As Single
		Return width * height
	End Function
	Sub Main()
		Console.Write("Width: ")
		Dim width As Single = Console.ReadLine()
		Console.Write("Height: ")
		Dim height As Single = Console.ReadLine()
		Console.WriteLine("Area: {0} units", Area(width, height))
		Console.ReadLine()
	End Sub
End Module
