Public Class Form2
    Public Santos, America, CruzAzul, Leon, Mty, Atlas, Pachuca, Tigres, UDEG, Monarcas, UNAM, Jaguares, Chivas, Puebla As Boolean
    Dim equiposGanadores As New List(Of String) From {"América", "Cruz Azul", "Atlas", "Tigres", "U. de G.", "UNAM", "Puebla"}
    Private Sub btnResultados_Click(sender As Object, e As EventArgs) Handles btnResultados.Click
        Dim aciertos As Integer = 0

        ' Comprobar cada equipo seleccionado y si está en la lista de ganadores
        If Santos AndAlso equiposGanadores.Contains("Santos") Then
            aciertos += 1
        End If
        If America AndAlso equiposGanadores.Contains("América") Then
            aciertos += 1
        End If
        If CruzAzul AndAlso equiposGanadores.Contains("Cruz Azul") Then
            aciertos += 1
        End If
        If Leon AndAlso equiposGanadores.Contains("León") Then
            aciertos += 1
        End If
        If Mty AndAlso equiposGanadores.Contains("Monterrey") Then
            aciertos += 1
        End If
        If Atlas AndAlso equiposGanadores.Contains("Atlas") Then
            aciertos += 1
        End If
        If Pachuca AndAlso equiposGanadores.Contains("Pachuca") Then
            aciertos += 1
        End If
        If Tigres AndAlso equiposGanadores.Contains("Tigres") Then
            aciertos += 1
        End If
        If UDEG AndAlso equiposGanadores.Contains("U. de G.") Then
            aciertos += 1
        End If
        If Monarcas AndAlso equiposGanadores.Contains("Monarcas") Then
            aciertos += 1
        End If
        If UNAM AndAlso equiposGanadores.Contains("UNAM") Then
            aciertos += 1
        End If
        If Jaguares AndAlso equiposGanadores.Contains("Jaguares") Then
            aciertos += 1
        End If
        If Chivas AndAlso equiposGanadores.Contains("Chivas") Then
            aciertos += 1
        End If
        If Puebla AndAlso equiposGanadores.Contains("Puebla") Then
            aciertos += 1
        End If

        ' Determinar el premio basado en el número de aciertos
        Dim premio As String
        Select Case aciertos
            Case 7
                premio = "5 millones de pesos"
            Case 6
                premio = "50 mil pesos"
            Case 5
                premio = "500 pesos"
            Case Else
                premio = "Nada"
        End Select

        Dim form3 As New Form3(aciertos, premio)
        form3.ShowDialog()

    End Sub
    Private Sub rbtSantos_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSantos.CheckedChanged
        Santos = rbtSantos.Checked
    End Sub

    Private Sub rbtAmerica_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAmerica.CheckedChanged
        America = rbtAmerica.Checked
    End Sub

    Private Sub rbtCruzAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCruzAzul.CheckedChanged
        CruzAzul = rbtCruzAzul.Checked
    End Sub

    Private Sub rbtLeon_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLeon.CheckedChanged
        Leon = rbtLeon.Checked
    End Sub

    Private Sub rbtMty_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMty.CheckedChanged
        Mty = rbtMty.Checked
    End Sub

    Private Sub rbtAtlas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAtlas.CheckedChanged
        Atlas = rbtAtlas.Checked
    End Sub

    Private Sub rbtPachuca_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPachuca.CheckedChanged
        Pachuca = rbtPachuca.Checked
    End Sub

    Private Sub rbtTigres_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTigres.CheckedChanged
        Tigres = rbtTigres.Checked
    End Sub
    Private Sub rbtUDEG_CheckedChanged(sender As Object, e As EventArgs) Handles rbtUDEG.CheckedChanged
        UDEG = rbtUDEG.Checked
    End Sub

    Private Sub rbtMonarcas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMonarcas.CheckedChanged
        Monarcas = rbtMonarcas.Checked
    End Sub
    Private Sub rbtUNAM_CheckedChanged(sender As Object, e As EventArgs) Handles rbtUNAM.CheckedChanged
        UNAM = rbtUNAM.Checked
    End Sub

    Private Sub rbtJaguares_CheckedChanged(sender As Object, e As EventArgs) Handles rbtJaguares.CheckedChanged
        Jaguares = rbtJaguares.Checked
    End Sub
    Private Sub rbtChivas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtChivas.CheckedChanged
        Chivas = rbtChivas.Checked
    End Sub

    Private Sub rbtPuebla_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPuebla.CheckedChanged
        Puebla = rbtPuebla.Checked
    End Sub

End Class