Module OneDArrayQ9
	Sub Main()
		Dim Planets() As String = {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"}
		Console.Write("Input a planet number: ")
		Dim Selection As Byte = Console.ReadLine()
		Console.WriteLine(Planets(Selection - 1))
	End Sub
End Module
