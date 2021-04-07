Module OOP8
	MustInherit Class Student
		Protected Name As String
		Protected DOB As Date
		Public Function GetName() As String
			GetName = Name
		End Function
		Public Function GetDate() As Date
			GetDate = DOB
		End Function
	End Class
	Class FullTimeStudent
		Inherits Student
		Private Address As String
		Private Telephone As String
		Sub New(ByVal Name As String, ByVal DOB As Date, ByVal Address As String, ByVal Telephone As String)
			Me.Name = Name
			Me.DOB = DOB
			Me.Address = Address
			Me.Telephone = Telephone
		End Sub
		Public Function GetAddress() As String
			GetAddress = Address
		End Function
		Public Function GetTelephone() As String
			GetTelephone = Telephone
		End Function
	End Class
	Class PartTimeStudent
		Inherits Stduent
		Private NumberOfCourses As Integer
		Private Fee As Single
		Private Paid As Boolean
		Sub New(ByVal Name As String, ByVal DOB As Date, ByVal NumberOfCourses As Integer, ByVal Fee As Single, MyVal Paid As Boolean)
			Me.Name = Name
			Me.DOB = DOB
			Me.NumberOfCourses = NumberOfCourses
			Me.Fee = Fee
			Me.Paid = Paid
		End Sub
		Public Function GetNumberOfCourses() As Integer
			GetNumberOfCourses = NumberOfCourses
		End Function
		Public Function GetFee() As Single
			GetFee = Fee
		End Function
		Public Function GetPaid() As Boolean
			GetPaid = Paid
		End Function
	End Class
	Sub Main()
		Dim FullTime As New FullTimeStudent("John", #11/11/2018#, "Malaysia", "012456789")
		Dim PartTime As New PartTimeStudent("Adam", #4/12/2018#, 3, 10000, True)
	End Sub
End Module
