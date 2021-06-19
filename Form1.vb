Public Class Form1
    Dim strName As String
    Dim intAge As Integer
    Dim num As Integer
    Dim strError As String = ""

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result = MessageBox.Show(" Are you sure you want to Exit?", "University Scholarship System", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Age()
        Pass()
        If num = 1 Then
            MessageBox.Show(strError, "Sorry", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Age()
        intAge = nudAge.Value

        If intAge < 17 Then
            strError = "Too Young"
            num = 1
        ElseIf intAge > 20 Then
            strError = "Too Old"
            num = 1
        Else
            strError = ""
            num = 0
        End If
    End Sub

    Private Sub Pass()
        If radPass.Checked = True Then

            Exit Sub
        ElseIf radFail.Checked = True Then
            strError = strError & vbCrLf & "You failed BM and/or Sejarah"
            num = 1
            Exit Sub
        Else
            MessageBox.Show("Select Yes or No for Question 2", "Sorry", MessageBoxButtons.OK)
            num = 0
            Exit Sub
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
