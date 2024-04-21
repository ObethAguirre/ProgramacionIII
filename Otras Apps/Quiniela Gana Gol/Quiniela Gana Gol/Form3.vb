
Public Class Form3
    Public Sub New(aciertos As Integer, premio As String)
        InitializeComponent()
        lblAciertos.Text = "Número de aciertos: " & aciertos
        lblPremio.Text = "Premio: " & premio

        ' Determinar qué imagen mostrar basada en el premio
        If premio <> "Nada" Then
            ' Mostrar la imagen de ganar
            picResultado.Visible = True
            picPierde.Visible = False
        Else
            ' Mostrar la imagen de perder
            picPierde.Visible = True
            picResultado.Visible = False
        End If
    End Sub

End Class