Module Module1

    Sub Main()

        saludo("Martín") 'estamo realizando un ARGIMENTO y le pasamos el nombre
        saludo("Yani")

    End Sub
    Sub saludo(nom As String) 'establecer un PARAMETRO con la variable nom

        Console.WriteLine("Hola " & nom & " bienvenido(a) al mejor curso de VB .NET")

    End Sub

End Module
