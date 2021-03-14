Module OOP2
	Class Box
		Public length As Double
		Public breadth As Double
		Public height As Double
	End Class
	Sub Main()
		Dim Box1 As Box = New Box()
		Dim Box2 As Box = New Box()
		Dim volume As Double = 0.0
		Box1.height = 5.0
		Box1.length = 6.0
		Box1.breadth = 7.0
		Box2.height = 10.0
		Box2.length = 12.0
		Box2.breadth = 13.0
		volume = Box1.height * Box1.length * Box1.breadth
		Console.WriteLine("Volume of Box1: {0}", volume)
		volume = Box2.height * Box2.length * Box2.breadth
		Console.WriteLine("Volume of Box2: {0}", volume)
		Console.ReadLine()
	End Sub
End Module
