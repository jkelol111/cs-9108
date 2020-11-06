Module DoLoop1
    Sub Main()
        ' local variable definition
        Dim a As Integer = 100
        ' do loop execution
        Do
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
        Loop Until a = 20
        Console.ReadKey()
    End Sub
End Module