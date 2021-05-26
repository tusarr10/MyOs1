Public Class accountopen3

    ' Variable declaration for product type
    Dim producttype As String

    Dim operationmode As String

    Dim actype As String

    Dim rdinst As String

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.SelectedIndex = 0 Then
            'TODO
            producttype = "Saving Account"
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            'TODO
            producttype = "Recurring Deposit"
            RadioGroup4.SelectedIndex = 4

            rdinst = Microsoft.VisualBasic.InputBox("Enter R D Installment !.", "Entry Form", "")


        ElseIf RadioGroup1.SelectedIndex = 2 Then
            'TODO
            producttype = "SS Account"
        ElseIf RadioGroup1.SelectedIndex = 3 Then
            'TODO
            producttype = "Time Deposit"
        ElseIf RadioGroup1.SelectedIndex = 4 Then
            'TODO
            producttype = "PPF Account"
        ElseIf RadioGroup1.SelectedIndex = 5 Then
            'TODO
            producttype = "NSC Account"
        End If
    End Sub

    Private Sub RadioGroup2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup2.SelectedIndexChanged
        If RadioGroup2.SelectedIndex = 0 Then
            'todo
            operationmode = "Single"

        ElseIf RadioGroup2.SelectedIndex = 1 Then
            'todo
            operationmode = "Jointa"

        ElseIf RadioGroup2.SelectedIndex = 2 Then
            'todo
            operationmode = "Jointb"

        End If
    End Sub

    Private Sub RadioGroup3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup3.SelectedIndexChanged
        If RadioGroup3.SelectedIndex = 0 Then
            'todo
            actype = "Self"
        ElseIf RadioGroup3.SelectedIndex = 1 Then
            'todo
            actype = "Minor"
        End If
    End Sub

    Private Sub RadioGroup4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup4.SelectedIndexChanged
        If RadioGroup4.SelectedIndex = 0 Then
            'TODO
            producttype = "na"
        ElseIf RadioGroup4.SelectedIndex = 1 Then
            'TODO
            producttype = "1 Year"
        ElseIf RadioGroup4.SelectedIndex = 2 Then
            'TODO
            producttype = "2 Year"
        ElseIf RadioGroup4.SelectedIndex = 3 Then
            'TODO
            producttype = "3 Year"
        ElseIf RadioGroup4.SelectedIndex = 4 Then
            'TODO
            producttype = "5 Year"

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class