Module OOP5
	Class Person
		Public Name As String
		Private Age As Byte
		Public Function GetAge() As Byte
			Return Me.Age
		End Function
		Public Sub SetAge(ByVal Age As Byte)
			Me.Age = Age
		End Sub
	End Class
	Sub Main()
		Dim p As New Person
		p.Name = "Jane"
		p.SetAge(17)
		Console.WriteLine("{0} is {1} years old", p.Name, p.GetAge())
		Console.ReadKey()
	End Sub
End Module
