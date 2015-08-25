Public Class frmHome

    Private Sub NewOfficerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewOfficerToolStripMenuItem.Click
        frmNew.Show()

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        frmView.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        frmEdit.Show()
    End Sub
End Class
