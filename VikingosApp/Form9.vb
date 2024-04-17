Public Class FrmHistProductosVentas
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        If DateTimePickerInicio.Value > DateTimePickerFin.Value Then
            MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim historialVentas As New ClassLibraryHistVentas.HistVentas
        Dim dt As DataTable = historialVentas.ConsultarHistorialVentasEntreFechas(DateTimePickerInicio.Value, DateTimePickerFin.Value)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            DGVhistorialP.DataSource = dt
        Else
            MessageBox.Show("No se encontraron ventas para el rango de fechas seleccionado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FrmHistProductosVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class