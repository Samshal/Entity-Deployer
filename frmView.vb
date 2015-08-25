Imports System.Data.OleDb
Public Class frmView

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SamshalTechs\Documents\PoliceDeployment.accdb;")
    Dim cmd As New OleDbCommand
    Private Sub frmNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PoliceDeploymentDataSet.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.PoliceDeploymentDataSet.Profile)
        Me.MdiParent = frmHome

        con.Open()
        cmd.Connection = con
        Me.Dock = DockStyle.Fill

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs)

    End Sub
End Class