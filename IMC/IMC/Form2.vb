
Public Class Form2

    Public Sub New(nombre As String, edad As String, nacionalidad As String, pregunta As String, sexo As String, peso As Double, estatura As Double, imc As Double)
        InitializeComponent()

        ' Mostrar los datos recibidos en los controles de Form2
        lblNombre.Text = nombre
        lblEdad.Text = edad
        lblNacionalidad.Text = nacionalidad
        lblSexo.Text = sexo
        lblPeso.Text = peso.ToString()
        lblEstatura.Text = estatura.ToString()
        lblIMC.Text = imc.ToString()
        lblPregunta.Text = pregunta

        ' Determinar la condición basada en el IMC
        If imc < 18.5 Then
            lblCondicion.Text = "Infrapeso: Usted se encuentra por debajo del IMC normal."
        ElseIf imc >= 18.5 AndAlso imc < 25 Then
            lblCondicion.Text = "Normal: Usted se encuentra en el IMC adecuado para usted."
        Else
            lblCondicion.Text = "Sobrepeso: Usted tiene sobrepeso."
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

End Class