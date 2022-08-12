Public Class Calculadora

    Private Sub Sumar_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Matematica.sumar(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text))
        TextBox1.Text = "0"
        TextBox2.Text = "0"
    End Sub

    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = Matematica.restar(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text))
        TextBox1.Text = "0"
        TextBox2.Text = "0"
    End Sub

    Private Sub Multiplicar_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = Matematica.multiplicar(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text))
        TextBox1.Text = "0"
        TextBox2.Text = "0"
    End Sub

    Private Sub Dividir_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = Matematica.dividir(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text))
        TextBox1.Text = "0"
        TextBox2.Text = "0"
    End Sub

    Private Sub Potenciar_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Text = Matematica.potenciar(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text))
        TextBox1.Text = "0"
        TextBox2.Text = "0"
    End Sub


End Class
