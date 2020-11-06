Module DoLoop2
    Sub Main()
        Dim num As Integer = 1
        Do
            Console.WriteLine(num)
            num = num + 1
            If num = 10 Then
                Exit Do
            End If
        Loop Until num > 100
        Console.ReadKey()
    End Sub
End Module