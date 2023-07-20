
Module moduloFunciones

    'FUNCIÓN MENU ===============================================================
    Sub fMenu()
        Console.Clear()
        Console.Write("=============================" & vbCrLf)
        Console.WriteLine("            MENÚ")
        Console.Write("=============================" & vbCrLf & vbCrLf)
        Console.WriteLine("1. Programa #1")
        Console.WriteLine("2. Programa #2")
        Console.WriteLine("3. Programa #3")
        Console.WriteLine("4. salir")
        Console.Write("______________________________" & vbCrLf & vbCrLf)

    End Sub

    'ERROR   ===============================================================
    Sub fError()
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(vbCrLf & "----------------------------------------------")
        Console.Write(vbCrLf & "ERROR: El Valor No es Válido")
        Console.Write(vbCrLf & "----------------------------------------------" & vbCrLf & vbCrLf)
        Console.ResetColor()
    End Sub

    'ENCABEZADO   ===============================================================
    Sub fEncabezado(ByVal opcion As Integer)
        Console.Clear()
        Console.Write("==============================================" & vbCrLf)
        Console.WriteLine("PROGRAMA #" & opcion)
        Console.Write("==============================================" & vbCrLf & vbCrLf)

    End Sub


    'CONVERIÓN DE MONEDAS ==================================================================================================================================

    Sub fconversionM(ByVal opcion As Integer, ByVal valor As Single)

        'VARIABLES
        Dim conversion As Single
        Dim moneda1, moneda2 As String


        Select Case opcion
            Case 1
                moneda1 = "Euros"
                moneda2 = "Dólares"
                conversion = Math.Round(valor * 1.1064, 2)
            Case 2
                moneda1 = "Dólares"
                moneda2 = "Euros"
                conversion = Math.Round(valor / 1.1064, 2)
            Case 3
                moneda1 = "Dólares"
                moneda2 = "Yenes"
                conversion = Math.Round(valor * 134.3, 2)
            Case 4
                moneda1 = "Yenes"
                moneda2 = "Dólares"
                conversion = Math.Round(valor / 134.3, 2)
            Case 5
                moneda1 = "Dólares"
                moneda2 = "Pesetas"
                conversion = Math.Round(valor * 150.4, 2)
            Case 6
                moneda1 = "Pesetas"
                moneda2 = "Dólares"
                conversion = Math.Round(valor / 150.4, 2)
            Case 7
                moneda1 = "Dólares"
                moneda2 = "Libras"
                conversion = Math.Round(valor * 0.7999, 2)
            Case 8
                moneda1 = "Libras"
                moneda2 = "Dólares"
                conversion = Math.Round(valor / 0.7999, 2)
        End Select


        'LIMPIEZA CONSOLA
        fEncabezado(3)
        Console.Write(vbCrLf & valor & " " & moneda1 & " = " & conversion & " " & moneda2 & vbCrLf & vbCrLf)

    End Sub

End Module
