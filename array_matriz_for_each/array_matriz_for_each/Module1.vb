Module Module1

    Sub Main()
        'corrección para que no aparezcan los ceros en las matrices

        Dim vector(2) As Integer
        Dim matriz(1, 1) As Integer

        vector(0) = 1
        vector(1) = 2
        vector(2) = 3

        matriz(0, 0) = 10
        matriz(0, 1) = 20
        matriz(1, 0) = 30
        matriz(1, 1) = 40

        For Each num As Integer In vector

            Console.Write(num & " ")

        Next

        Console.WriteLine()

        For Each num As Integer In matriz

            Console.Write(num & " ")

        Next

        Console.ReadKey()
    End Sub

End Module
