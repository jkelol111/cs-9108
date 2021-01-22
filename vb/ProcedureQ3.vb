Module ProcedureQ3
	Function EncryptString(ByVal PlainText As String, ByVal Lookup() As Char) As String
		Dim EncryptedString As String = ""
		For Each PlainChar as Char in PlainText
			EncryptedString = EncryptedString & Lookup(Asc(PlainChar))
		Next
		Return EncryptedString
	End Function

	Sub Main()
		Dim Lookup() As Char = {"o","j","D","a","W","f","i","A","N","S","Y","8","o","v","H","I","Q","2","G","4","Y","Z","h","N","Z","J","P","I","G","1","U","L","P","Z","2","5","t","n","l","j","I","b","E","b","a","m","f","S","X","q","h","Q","p","q","f","w","m","S","5","4","N","H","3","5","l","r","b","C","a","V","k","H","N","v","c","c","K","l","K","3","f","S","B","O","9","4","1","R","0","s","D","8","9","Y","G","c","1","J","T","3","O","C","b","l","H","M","A","P","f","r","M","X","0","Y","p","3","t","w","X","a","D","l","3","b","N","j","Q"	}

		Console.WriteLine("Enter string to encrypt:")
		Dim PlainText As String = Console.ReadLine()
		
		Console.WriteLine("")
		Console.WriteLine("Encrypted:")
		Console.WriteLine(EncryptString(PlainText, Lookup))
		Console.ReadLine()
	End Sub
End Module
