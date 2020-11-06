Module DoLoop
    Sub Main()
        Dim index As Integer = 1
        Do
            Console.WriteLine(index)
            index += 1
        Loop Until index > 10
        Console.ReadLine()
    End Sub
End Module