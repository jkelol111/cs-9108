Module OOP4
	Class Circle
		Public Radius As Integer
		Public Sub SetRadius(ByVal Rad As Integer)
			Me.Radius = Rad
		End Sub
		Public Function Area() As Double
			Return Me.Radius * Me.Radius * Math.Pi
		End Function
	End Class
	Sub Main()
		Dim c As New Circle
		c.SetRadius(5)
		Console.WriteLine(c.Area())
		Console.ReadKey()
	End Sub
End Module
