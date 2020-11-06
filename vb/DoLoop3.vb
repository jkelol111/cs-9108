Module DoLoop3
    Sub Main()
        Dim X As String
        Dim Count As Integer = 0
        Do 
            Console.WriteLine("Type in the password:")
            X = Console.ReadLine()
            Count += 1
        Loop Until UCase(X) = "PASSWORD"
        Console.WriteLine("Loops repeated {0}", count)
        Console.ReadLine()
    End Sub
End Module