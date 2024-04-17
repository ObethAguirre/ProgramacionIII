Public Class frmHistCortes
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        ' Validar que se haya seleccionado un rango de fechas
        If DateTimePickerInicio.Value > DateTimePickerFin.Value Then
            MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Consultar el historial de ventas entre las fechas seleccionadas
        Dim historialVentas As New ClassLibraryHistVentas.HistVentas
        Dim dt As DataTable = historialVentas.ConsultarHistorialCitasEntreFechas(DateTimePickerInicio.Value, DateTimePickerFin.Value)

        ' Mostrar los resultados en el dataGridViewHistorial
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            DGVhistorialC.DataSource = dt
        Else
            MessageBox.Show("No se encontraron ventas para el rango de fechas seleccionado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class