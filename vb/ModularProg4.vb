Module ModularProg4
	Sub Main()
		Console.WriteLine("The volume in the cube ")
		Console.WriteLine("is: " & CubeVolume(5))
		Console.ReadLine()
	End Sub
	Function CubeVolume(ByVal x As Double) As Double
		Dim result As Double = 0
		result = x * x * x
		Return result
	End Function
End Module
