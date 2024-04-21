Imports IMC.Form2

Public Class Form1
    Public Edad, Nombre, Nacionalidad, Pregunta, Sexo As String
    Public Estatura As Integer
    Public Peso As Double


    Public Sub grpQuestion_Enter(sender As Object, e As EventArgs) Handles grpQuestion.Enter
        Pregunta = chkPregunta.SelectedItems.ToString()
    End Sub

    Public Sub grpSexo_Enter(sender As Object, e As EventArgs) Handles rbtnFemenino.CheckedChanged, rbtnMasculino.CheckedChanged
        Dim rbtnSeleccionado As RadioButton = CType(sender, RadioButton)

        If rbtnSeleccionado.Checked Then
            Sexo = rbtnSeleccionado.Text
        End If
    End Sub

    Public Sub grpNacionalidad_Enter(sender As Object, e As EventArgs) Handles grpNacionalidad.Enter
        If cmbNacionalidad.SelectedItem IsNot Nothing Then
            Nacionalidad = cmbNacionalidad.SelectedItem.ToString()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub grpDatos_Enter(sender As Object, e As EventArgs) Handles grpDatos.Enter
        Nombre = txbNombre.Text
        If Integer.TryParse(txbEstatura.Text, Estatura) AndAlso
            Double.TryParse(txbPeso.Text, Peso) AndAlso
            cmbEdad.SelectedItem IsNot Nothing Then
            Edad = cmbEdad.SelectedItem.ToString()
        End If
    End Sub

    Private Function ObtenerElementosSeleccionados(checkedListBox As CheckedListBox) As String
        Dim elementosSeleccionados As New List(Of String)

        ' Iterar a través de los elementos seleccionados y agregarlos a la lista
        For Each item As Object In checkedListBox.CheckedItems
            elementosSeleccionados.Add(item.ToString())
        Next

        ' Unir los elementos seleccionados en una cadena separada por comas
        Dim resultado As String = String.Join(", ", elementosSeleccionados)

        Return resultado
    End Function

    Public Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim peso As Double
        Dim estatura As Double

        If Double.TryParse(txbPeso.Text, peso) AndAlso Double.TryParse(txbEstatura.Text, estatura) Then
            ' Calcular el IMC solo si los valores de peso y estatura son válidos
            Dim imc As Double = CalcularIMC(peso, estatura)

            ' Abrir el formulario de resultado y pasar los datos llenados por el usuario
            Dim form2 As New Form2(txbNombre.Text, cmbEdad.SelectedItem.ToString(), cmbNacionalidad.SelectedItem.ToString(),
                               ObtenerElementosSeleccionados(chkPregunta), If(rbtnFemenino.Checked, rbtnFemenino.Text, rbtnMasculino.Text),
                               peso, estatura, imc)
            form2.ShowDialog()
        Else
            MessageBox.Show("Por favor, ingrese valores válidos para el peso y la estatura.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Public Function CalcularIMC(peso As Integer, estatura As Integer) As Double
        'Convertir estatura de cm a metros
        Dim estaturaMetros As Double = estatura / 100.0

        ' Formula
        Return peso / (estaturaMetros * estaturaMetros)
    End Function



End Class


