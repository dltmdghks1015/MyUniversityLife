Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iDigit1, iDigit2 As Integer

        iDigit1 = TextBox1.Text
        iDigit2 = TextBox2.Text

        TextBox3.Text = iDigit1 + iDigit2
        Label4.Text = "+"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim iDigit1, iDigit2 As Integer

        iDigit1 = TextBox1.Text
        iDigit2 = TextBox2.Text

        TextBox3.Text = iDigit1 - iDigit2
        Label4.Text = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iDigit1, iDigit2 As Integer

        iDigit1 = TextBox1.Text
        iDigit2 = TextBox2.Text

        TextBox3.Text = iDigit1 * iDigit2
        Label4.Text = "×"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iDigit1, iDigit2 As Integer

        iDigit1 = TextBox1.Text
        iDigit2 = TextBox2.Text

        TextBox3.Text = iDigit1 / iDigit2
        Label4.Text = "÷"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim iDigit1, iDigit2 As Integer

        iDigit1 = TextBox1.Text
        iDigit2 = TextBox2.Text

        TextBox3.Text = iDigit1 Mod iDigit2
        Label4.Text = "Mod"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim iDigit1, iDigit2 As Integer

        iDigit1 = TextBox1.Text
        iDigit2 = TextBox2.Text

        TextBox3.Text = iDigit1 ^ iDigit2
        Label4.Text = "승"
    End Sub
End Class
