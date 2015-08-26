Imports System.Data.OleDb
Public Class frmNew

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PoliceDeployment.accdb;")
    Dim cmd As New OleDbCommand
    Private Sub frmNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmHome
        Me.Dock = DockStyle.Fill

        con.Open()
        cmd.Connection = con
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim firstname = txtFirstName.Text
        Dim lastname = txtLastName.Text
        Dim age = txtAge.Text
        Dim joined = txtJoinDate.Text
        Dim phone = txtPhoneNumber.Text
        Dim email = txtEmail.Text
        Dim rank = txtRank.Text
        Dim id = txtIDNumber.Text
        Dim picture = pcbPhoto.ImageLocation
        Dim rand = Int(Rnd() * 10)
        MessageBox.Show(rand.ToString())
        'cmd.CommandText = "SELECT Location FROM Locations"
        'Dim reader As OleDbDataReader
        'Dim myfield As DataRow
        'Dim myProp As DataColumn
        'Dim schemaTbl As DataTable
        'reader = cmd.ExecuteReader(CommandBehavior.KeyInfo)
        'schemaTbl = reader.GetSchemaTable()
        'myfield = reader.
        'Dim holder = myfield(myProp).ToString()
        'MessageBox.Show("Record Inserted Successfully, Location: " + holder)

        cmd.CommandText = "INSERT INTO Profile (FirstName, LastName, Age, JoinDate, PhoneNumber, Email, Rank, IdentificationNumber, Picture, LocationID) VALUES ('" + firstname + "', '" + lastname + "', " + age + ", '" + joined + "', " + phone + ", '" + email + "', '" + rank + "', '" + id + "', '" + picture + "', " + rand + ")"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record Inserted Successfully")
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.InitialDirectory = "C:\"
        fd.Filter = "All files|*.*"
        If fd.ShowDialog() = DialogResult.OK Then strFileName = fd.FileName
        pcbPhoto.ImageLocation = strFileName
    End Sub
End Class