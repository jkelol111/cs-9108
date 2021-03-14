Module OOP6
	Class MyFriend
		Private Born As Date
		Private Name As String
		Sub New(ByVal Name As String, ByVal Born As Date)
			Me.Name = Name
			Me.Born = Born
		End Sub
		Public Sub GetInfo()
			Console.WriteLine("{0} was born on {1}", Me.Name, Me.Born.ToShortDateString())
		End Sub
	End Class
	Sub Main()
		Dim Name As String = "Lenka"
		Dim Born As Date = #5/3/1990#
		Dim fr As MyFriend = New MyFriend(Name, Born)
		fr.GetInfo()
		Console.ReadLine()
	End Sub
End Module
