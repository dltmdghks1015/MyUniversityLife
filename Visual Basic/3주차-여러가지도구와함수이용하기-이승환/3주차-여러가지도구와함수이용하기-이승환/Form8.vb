Public Class Form8
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String
        Str = TextBox1.Text + "님은"
        If RadioButton1.Checked = True Then
            Str = Str + RadioButton1.Text
        End If

        If RadioButton2.Checked = True Then
            Str = Str + RadioButton2.Text
        End If

        Str = Str + "이고" + vbCrLf + "연령은" + ListBox1.Text + "이고" + vbCrLf + "거주지는" + ComboBox1.Text + "이고" + vbCrLf + "좋아하는 동물은" + vbCrLf

        If CheckBox1.Checked = True Then
            Str = Str + CheckBox1.Text + vbCrLf
        End If

        If CheckBox2.Checked = True Then
            Str = Str + CheckBox2.Text + vbCrLf
        End If

        If CheckBox3.Checked = True Then
            Str = Str + CheckBox3.Text + vbCrLf
        End If

        If CheckBox4.Checked = True Then
            Str = Str + CheckBox4.Text + vbCrLf
        End If

        If CheckBox5.Checked = True Then
            Str = Str + CheckBox5.Text + vbCrLf
        End If

        If CheckBox6.Checked = True Then
            Str = Str + CheckBox6.Text + vbCrLf
        End If

        If CheckBox7.Checked = True Then
            Str = Str + CheckBox7.Text + vbCrLf
        End If

        If CheckBox8.Checked = True Then
            Str = Str + CheckBox8.Text + vbCrLf
        End If

        If CheckBox9.Checked = True Then
            Str = Str + CheckBox9.Text + vbCrLf
        End If

        textBox2.Text = Str + "입니다"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class