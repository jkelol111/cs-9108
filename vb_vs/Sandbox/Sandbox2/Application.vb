Imports System
Imports Microsoft.VisualBasic

Public Class Application
    Private Shared Lookup() As String = {"y","V",",","q","#","r","V",">","-","l","A","#","w","$","F","L","#","H","j","B","#","r","K","<","x","9",":","7","n","N","5","D","F","L","X","g","v",".","@","I","Q","K","B","0","i","D","j","f","!","-","Y","]",".","f","(","w","z","`","P","9","3","R","s",",","G","~","+","E","$","G","j","h","Y","<","1","$","M","6","p","C","_","!","(","B","e","'",":","f","Z",";",")","u","|","o","9",".","0","1","s","x","_",":","G","h",";","G","F","}","L","R","k","D","D",":","6","*","=","\","P","e","V","v","q",".","W","f","&","M"}
    Private Shared Function EncryptString(ByVal PlainText As String) As String
        Dim EncryptedText As String = ""
        For Each PlainChar as String in PlainText
            EncryptedText = EncryptedText & Lookup(Asc(PlainChar))
        Next
        Return EncryptedText
    End Function

    Private Shared Function DecryptString(ByVal EncryptedText As String) As String
        Dim PlainText As String = ""
        For Each EncryptedChar As String in EncryptedText
            Console.WriteLine("{0} -> {1}", EncryptedChar, Array.IndexOf(Lookup, EncryptedChar))
            PlainText = PlainText & Chr(Array.IndexOf(Lookup, EncryptedChar))
        Next
        Return PlainText        
    End Function

	Public Shared Sub Main()

        Console.Write("Choose mode (1: Encrypt, 2: Decrypt, Else: Exit): ")
        Dim mode As Integer = Console.ReadLine()

        Select Case mode
            Case 1
                Console.WriteLine("Enter string to encrypt:")
                Dim PlainText As String = Console.ReadLine()
        
                Console.WriteLine("")
                Console.WriteLine("Encrypted Text:")
                Console.WriteLine(EncryptString(PlainText))
            Case 2
                Console.WriteLine("Enter string to decrypt:")
                Dim EncryptedText As String = Console.ReadLine()
                Console.WriteLine("")
                Console.WriteLine("Plain Text:")
                Console.WriteLine(DecryptString(EncryptedText))
            Case Else
                Console.WriteLine("Press return to exit.")
        End Select
        Console.ReadLine()
	End Sub
End Class
