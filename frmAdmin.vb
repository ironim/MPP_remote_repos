Public Class frmAdmin
    Private Sub btnMasterCar_Click(sender As Object, e As EventArgs) Handles btnMasterCar.Click
        Dim frm As New frmMasterCar
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnMasterStaff_Click(sender As Object, e As EventArgs) Handles btnMasterStaff.Click
        Dim frm As New frmMasterStaff
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnMasterPhone_Click(sender As Object, e As EventArgs) Handles btnMasterPhone.Click
        Dim frm As New frmMasterPhone
        frm.ShowDialog(Me)
    End Sub

    Private Sub frmAdmin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    '閉じるボタン
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class