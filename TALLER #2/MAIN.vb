Imports System
Imports System.Drawing

Module MAIN
    Sub Main(args As String())

        'BLOQUE DE VARIABLES  ==========================================================================================
        Dim opcion, n, x, opcionM, minutos, segundos, horas, controlIndeterminacion As Integer
        Dim numeros(), suma, resta, multi, divi, expo, mods, valorM As Double
        'VARIABLES INICIALIZADAS


        'BLOQUE DE INSTRUCCIONES ===========================================================================================

        Do While (opcion <> 4)

            'IMPRESIÓN
            moduloFunciones.fMenu()

            'CONTROL DE ENTRADA OPCIÓN
            Do While True
                Try
                    Console.Write("Opción Seleccionada: ")
                    opcion = Integer.Parse(Console.ReadLine())

                    'rangoQE
                    If (opcion >= 1 And opcion <= 4) Then
                        Exit Do
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.Write(vbCrLf & "La Opción No Exite" & vbCrLf)
                        Console.ResetColor()
                    End If

                Catch ex As Exception
                    moduloFunciones.fError()
                End Try
            Loop

            'OPCINES ---------------------------------------------------------------------------------------------------------

            Select Case opcion

                'PROGRAMA #1 ---------------------------------------------------
                Case 1

                    'IMPRESION ENCABEZADO
                    moduloFunciones.fEncabezado(opcion)

                    'ENTRADA de la cantidad de valores
                    Do While True
                        Try
                            Console.Write("Ingrese la Cantidad de Valores con los que Trabajará: ")
                            n = Integer.Parse(Console.ReadLine())
                            Exit Do
                        Catch ex As Exception
                            moduloFunciones.fError()
                        End Try
                    Loop


                    'DEFINICIÓN
                    ReDim numeros(n)

                    'ENTRADA DE NÚMEROS

                    For x = 0 To (n - 1)

                        Do While True

                            Try
                                Console.Write(vbCrLf & vbCrLf & (x + 1) & ". Ingrese el valor : ")
                                numeros(x) = Double.Parse(Console.ReadLine())

                                If x = 0 Then

                                    suma = numeros(x)
                                    resta = numeros(x)
                                    multi = numeros(x)
                                    expo = numeros(x)
                                    mods = numeros(x)
                                    divi = numeros(x)

                                Else


                                    If ((expo ^ numeros(x)) > Double.MaxValue) Or ((multi * numeros(x)) > Double.MaxValue) Or ((suma + numeros(x)) > Double.MaxValue) Then

                                        Console.ForegroundColor = ConsoleColor.Red
                                        Console.Write(vbCrLf & "EL VALOR EXCEDE LA CAPACIDAD DEL PROGRAMA (DOUBLE MAX): " & Double.MaxValue)
                                        Console.ResetColor()
                                        If x > 0 Then
                                            x -= 1
                                        End If

                                    ElseIf ((divi / numeros(x)) < Double.MinValue) Or ((resta - numeros(x)) < Double.MinValue) Or ((mods Mod numeros(x)) < Double.MinValue) Then

                                        Console.ForegroundColor = ConsoleColor.Red
                                        Console.Write(vbCrLf & "EL VALOR EXCEDE LA CAPACIDAD DEL PROGRAMA (DOUBLE MIN): " & Double.MinValue)
                                        If x > 0 Then
                                            x -= 1
                                        End If

                                    Else
                                        multi *= numeros(x)
                                        divi /= numeros(x)
                                        expo ^= numeros(x)
                                        mods = mods Mod numeros(x)
                                        suma += numeros(x)
                                        resta -= numeros(x)
                                    End If

                                End If

                                Exit Do

                            Catch ex As Exception
                                moduloFunciones.fError()

                            End Try
                        Loop

                    Next x

                    'IMPRESIÓN1

                    Console.Clear()
                    moduloFunciones.fEncabezado(opcion)

                    Console.Write(vbCrLf & "VALORES = ")

                    controlIndeterminacion = 0

                    For x = 0 To (n - 1)

                        Console.Write(numeros(x) & " , ")

                        If numeros(x) = 0 And x > 0 Then
                            controlIndeterminacion += 1
                        End If

                    Next

                    Console.Write(vbCrLf & "______________________________" & vbCrLf & vbCrLf)
                    Console.Write(vbCrLf & vbCrLf & "SUMA :          " & suma)
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write(vbCrLf & vbCrLf & "RESTA :         " & resta)
                    Console.ResetColor()
                    Console.Write(vbCrLf & vbCrLf & "MULTIPLICACIÓN: " & multi)
                    Console.ForegroundColor = ConsoleColor.Red
                    If controlIndeterminacion = 0 Then
                        Console.Write(vbCrLf & vbCrLf & "DIVISION:       " & divi)
                    Else
                        Console.Write(vbCrLf & vbCrLf & "DIVISION:       INDETERMINADO")
                    End If
                    Console.ResetColor()
                    Console.Write(vbCrLf & vbCrLf & "EXPONENTE:      " & expo)
                    Console.ForegroundColor = ConsoleColor.Red
                    If controlIndeterminacion = 0 Then
                        Console.Write(vbCrLf & vbCrLf & "MOD:            " & mods & vbCrLf & vbCrLf)
                    Else
                        Console.Write(vbCrLf & vbCrLf & "MOD:            INDETERMINADO")
                    End If
                    Console.ResetColor()

                'PROGRAMA #2 ---------------------------------------------------
                Case 2

                    'ENCABEZADO
                    moduloFunciones.fEncabezado(opcion)

                    'MENU
                    Console.WriteLine("           CONVERSIÓN DE MONEDA")
                    Console.Write("       ______________________________" & vbCrLf & vbCrLf)
                    Console.WriteLine("       1. Euro    (€)  -> Dólares  ($)")
                    Console.WriteLine("       2. Dólares ($)  -> Euro     (€)")
                    Console.WriteLine("       3. Dólares ($)  -> Yen      (¥)")
                    Console.WriteLine("       4. Yen     (¥)  -> Dólares  ($)")
                    Console.WriteLine("       5. Dólares ($)  -> Pesetas (Pst)")
                    Console.WriteLine("       6. Peseta (Pst) -> Dólares  ($)")
                    Console.WriteLine("       7. Dólares ($)  -> Libras   (£)")
                    Console.WriteLine("       8. Libras  (£)  -> Dólares  ($)")
                    Console.WriteLine("       9. salir")
                    Console.Write("       ______________________________" & vbCrLf & vbCrLf)


                    'CONTROL DE ENTRADA OPCIÓN
                    Do While True

                        Try
                            Console.Write("       Opción Seleccionada: ")
                            opcionM = Integer.Parse(Console.ReadLine())

                            'rangoQE
                            If (opcionM >= 1 And opcionM <= 9) Then

                                'ENTRADA DE VALORES
                                Do While True
                                    Try
                                        Console.Write(vbCrLf & vbCrLf & "Ingrese el Valor para la conversión: ")
                                        valorM = Double.Parse(Console.ReadLine())
                                        Exit Do
                                    Catch ex As Exception
                                        moduloFunciones.fError()
                                    End Try
                                Loop

                                moduloFunciones.fEncabezado(opcion)
                                moduloFunciones.fconversionM(opcionM, valorM)

                                Exit Do
                            Else
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(vbCrLf & "La Opción No Exite" & vbCrLf & vbCrLf)
                                Console.ResetColor()
                            End If

                        Catch ex As Exception
                            moduloFunciones.fError()
                        End Try
                    Loop


                'PROGRAMA #3 ---------------------------------------------------
                Case 3
                    moduloFunciones.fEncabezado(opcion)
                    'ENTRADA DE VALORES
                    Do While True
                        Try
                            Console.Write(vbCrLf & "Ingrese la Hora: ")
                            horas = Integer.Parse(Console.ReadLine())

                            'CONTROL   
                            If horas >= 0 And horas <= 23 Then
                                Exit Do
                            Else
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(vbCrLf & "El Valor No Se Encuentra Dentro deL Rango (0 >= valor <= 23) " & vbCrLf)
                                Console.ResetColor()
                            End If
                        Catch ex As Exception
                            moduloFunciones.fError()
                        End Try
                    Loop


                    Console.Write("______________________________________________" & vbCrLf)
                    Do While True
                        Try

                            Console.Write(vbCrLf & "Ingrese los Minuto: ")
                            minutos = Integer.Parse(Console.ReadLine())

                            'CONTROL   
                            If minutos >= 0 And minutos <= 59 Then
                                Exit Do
                            Else
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(vbCrLf & "El Valor No Se Encuentra Dentro deL Rango (0 >= valor <= 59) " & vbCrLf)
                                Console.ResetColor()
                            End If

                        Catch ex As Exception
                            moduloFunciones.fError()
                        End Try
                    Loop
                    Console.Write("______________________________________________" & vbCrLf)
                    Do While True
                        Try

                            Console.Write(vbCrLf & "Ingrese los Segundos: ")
                            segundos = Integer.Parse(Console.ReadLine())

                            'CONTROL   
                            If segundos >= 0 And segundos <= 59 Then
                                Exit Do
                            Else
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.Write(vbCrLf & "El Valor No Se Encuentra Dentro deL Rango (0 >= valor <= 59) " & vbCrLf)
                                Console.ResetColor()
                            End If

                        Catch ex As Exception
                            moduloFunciones.fError()
                        End Try
                    Loop

                    'LIMPIAR CONSOLA
                    moduloFunciones.fEncabezado(opcion)

                    'HORA =====================================================================

                    Dim hora As TimeSpan = New TimeSpan(horas, minutos, segundos)

                    Console.WriteLine(vbCrLf & "HH MM SS  | +1 SEGUNDO |  HH MM SS", hora)
                    Console.WriteLine("___________________________________________", hora)
                    Console.Write(vbCrLf & "{0}  | ---------> |", hora)


                    If (segundos + 1) = 60 Then
                        segundos = 0

                        If (minutos + 1) = 60 Then
                            minutos = 0

                            If (horas + 1) = 24 Then
                                horas = 0
                                minutos = 0
                                segundos = 0
                            Else
                                horas += 1
                            End If

                        Else
                            minutos += 1
                        End If

                    Else
                        segundos += 1
                    End If

                    hora = New TimeSpan(horas, minutos, segundos)
                    Console.Write("  {0}", hora)


                'SAIDA       ---------------------------------------------------
                Case 4
                    Exit Do

            End Select

            'PAUSA
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine(vbCrLf & vbCrLf & "Presiona Enter para continuar")
            Console.ReadLine()
            Console.ResetColor()

        Loop

    End Sub
End Module
