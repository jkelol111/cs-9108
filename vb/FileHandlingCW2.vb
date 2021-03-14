Imports System.IO

Module FileHandlingCW2
	Sub Main()
		Dim line As String
		For Each line In File.ReadLines("../vb_filehandling/MEMBERS.DAT") 
			Dim MemberDetails() As String = line.Split(" ")
			Console.WriteLine("Member ID: {0}, Member Name: {1}", MemberDetails(0), MemberDetails(1))
		Next
		Console.ReadLine()
	End Sub
End Module
