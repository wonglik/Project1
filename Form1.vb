Public Class Form1
    Dim strName As String
    Dim intAge As Integer
    Dim hello As String

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result = MessageBox.Show(" Are you sure you want to Exit?", "University Scholarship System", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Call Age()





    End Sub

    Private Sub Age()
        intAge = nudAge.Value

        If intAge < 17 Then
            MessageBox.Show("haha")
        ElseIf intAge > 20 Then
            MessageBox.Show("You too old!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
