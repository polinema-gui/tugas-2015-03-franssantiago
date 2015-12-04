Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        problem_Bintang.MdiParent = Me
        problem_Bintang.Show()
    End Sub

    Private Sub MatrikToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MatrikToolStripMenuItem.Click
        matrik_kalkulator.MdiParent = Me
        matrik_kalkulator.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub
End Class
