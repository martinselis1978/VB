Module Module1

    Sub Main()

        Dim a As Integer = 1

        For i = 2 To 21 Step 1

            If i <> 21 Then

                Console.Write(a & ", ")

            Else

                Console.WriteLine(a)

            End If

            a = a + i

        Next

        Console.ReadKey()
    End Sub
End Module
