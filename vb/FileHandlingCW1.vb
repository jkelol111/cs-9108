Module FileHandlingCW1
	Sub Main()
		Dim i As Integer
		FileOpen(1, "../vb_filehandling/MEMBERS.DAT", OpenMode.Output)
		For i = 0 To 9
			Console.Write("{0} - Enter new member number (max 4 digits): ", i)
			Dim MemberNumber As Integer = Console.ReadLine()
			Console.Write("{0} - Enter new number name: ", i)
			Dim MemberName As String = Console.ReadLine()
			PrintLine(1, MemberNumber.ToString("D4") & " " & MemberName)
		Next i
		FileClose(1)
	End Sub
End Module
