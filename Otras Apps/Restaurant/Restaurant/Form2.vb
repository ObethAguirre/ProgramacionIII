Public Class Form2
    'Precios
    Private precioEnchiladas As Integer = 35
    Private precioMole As Integer = 32
    Private precioPozole As Integer = 40
    Private precioFlautas As Integer = 30

    Private precioHeladoFresa As Integer = 15
    Private precioHeladoNuez As Integer = 15
    Private precioHeladoVainilla As Integer = 15
    Private precioHeladoChocolate As Integer = 15
    Private precioFlan As Integer = 25
    Private precioBuñuelos As Integer = 18

    Private precioAguaPiña As Integer = 10
    Private precioAguaLimon As Integer = 10
    Private precioAguaJamaica As Integer = 10
    Private precioCocaCola As Integer = 11
    Private precioFresca As Integer = 11
    Private precioManzanita As Integer = 11

    'Imágenes
    Private imagenEnchiladas As String = "C:/Users/obeth/source/repos/Restaurant/Restaurant/Resources/enchiladas.jpg"
    Private imagenMole As String = "C:/Users/obeth/source/repos/Restaurant/Restaurant/Resources/mole.jpg"
    Private imagenPozole As String = "C:/Users/obeth/source/repos/Restaurant/Restaurant/Resources/pozole.jpg"
    Private imagenFlautas As String = "C:/Users/obeth/source/repos/Restaurant/Restaurant/Resources/flautas.jpg"

    Private imagenHeladoFresa As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\fresa.jpg"
    Private imagenHeladoNuez As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\nuez.jpg"
    Private imagenHeladoVainilla As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\vainilla.jpg"
    Private imagenHeladoChocolate As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\chocolate.jpg"
    Private imagenFlan As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\flan.jpg"
    Private imagenBuñuelos As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\buñuelos.jpg"

    Private imagenAguaPiña As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\piña.jpg"
    Private imagenAguaLimon As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\limon.jpg"
    Private imagenAguaJamaica As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\jamaica.jpg"
    Private imagenCocaCola As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\cocacola.jpg"
    Private imagenFresca As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\fresca.jpg"
    Private imagenManzanita As String = "C:\Users\obeth\source\repos\Restaurant\Restaurant\Resources\manzanita.jpg"

    'Comidas
    Private Sub SeleccionarComida(sender As Object, e As EventArgs) Handles rbtEnchiladas.CheckedChanged, rbtMole.CheckedChanged, rbtPozole.CheckedChanged, rbtFlautas.CheckedChanged
        Dim radioButton As RadioButton = CType(sender, RadioButton)

        If radioButton.Checked Then

            Select Case radioButton.Name
                Case "rbtEnchiladas"
                    picComidas.Image = Image.FromFile(imagenEnchiladas)
                    lblPrecioComidas.Text = "$" & precioEnchiladas.ToString()
                Case "rbtMole"
                    picComidas.Image = Image.FromFile(imagenMole)
                    lblPrecioComidas.Text = "$" & precioMole.ToString()
                Case "rbtPozole"
                    picComidas.Image = Image.FromFile(imagenPozole)
                    lblPrecioComidas.Text = "$" & precioPozole.ToString()
                Case "rbtFlautas"
                    picComidas.Image = Image.FromFile(imagenFlautas)
                    lblPrecioComidas.Text = "$" & precioFlautas.ToString()
            End Select
        End If
    End Sub

    'Postres
    Private Sub SeleccionarPostre(sender As Object, e As EventArgs) Handles lstPostres.SelectedIndexChanged
        Dim listBox As ListBox = CType(sender, ListBox)

        If listBox.SelectedIndex <> -1 Then

            Select Case listBox.SelectedItem.ToString()
                Case "Helado de Fresa"
                    picPostres.Image = Image.FromFile(imagenHeladoFresa)
                    lblPrecioPostres.Text = "$" & precioHeladoFresa.ToString()
                Case "Helado de Nuez"
                    picPostres.Image = Image.FromFile(imagenHeladoNuez)
                    lblPrecioPostres.Text = "$" & precioHeladoNuez.ToString()
                Case "Helado de Vainilla"
                    picPostres.Image = Image.FromFile(imagenHeladoVainilla)
                    lblPrecioPostres.Text = "$" & precioHeladoVainilla.ToString()
                Case "Helado de Chocolate"
                    picPostres.Image = Image.FromFile(imagenHeladoChocolate)
                    lblPrecioPostres.Text = "$" & precioHeladoChocolate.ToString()
                Case "Flan"
                    picPostres.Image = Image.FromFile(imagenFlan)
                    lblPrecioPostres.Text = "$" & precioFlan.ToString()
                Case "Buñuelos"
                    picPostres.Image = Image.FromFile(imagenBuñuelos)
                    lblPrecioPostres.Text = "$" & precioBuñuelos.ToString()
            End Select
        End If
    End Sub

    'Bebidas
    Private Sub SeleccionarBebida(sender As Object, e As EventArgs) Handles cmbBebidas.SelectedIndexChanged
        Dim comboBox As ComboBox = CType(sender, ComboBox)

        If comboBox.SelectedIndex <> -1 Then

            Select Case comboBox.SelectedItem.ToString()
                Case "Agua de Piña"
                    picBebidas.Image = Image.FromFile(imagenAguaPiña)
                    lblPrecioBebidas.Text = "$" & precioAguaPiña.ToString()
                Case "Agua de Limon"
                    picBebidas.Image = Image.FromFile(imagenAguaLimon)
                    lblPrecioBebidas.Text = "$" & precioAguaLimon.ToString()
                Case "Agua de Jamaica"
                    picBebidas.Image = Image.FromFile(imagenAguaJamaica)
                    lblPrecioBebidas.Text = "$" & precioAguaJamaica.ToString()
                Case "CocaCola"
                    picBebidas.Image = Image.FromFile(imagenCocaCola)
                    lblPrecioBebidas.Text = "$" & precioCocaCola.ToString()
                Case "Fresca"
                    picBebidas.Image = Image.FromFile(imagenFresca)
                    lblPrecioBebidas.Text = "$" & precioFresca.ToString()
                Case "Manzanita"
                    picBebidas.Image = Image.FromFile(imagenManzanita)
                    lblPrecioBebidas.Text = "$" & precioManzanita.ToString()
            End Select
        End If
    End Sub
    Private Sub MostrarForm3()
        Dim form3 As New Form3()

        ' Pasar los datos seleccionados como parámetros al construir Form3
        form3.MostrarPedido(picComidas.Image, lblPrecioComidas.Text, picPostres.Image, lblPrecioPostres.Text, picBebidas.Image, lblPrecioBebidas.Text)

        ' Mostrar el Form3
        form3.ShowDialog()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        MostrarForm3()
    End Sub
End Class