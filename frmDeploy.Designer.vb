<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeploy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PoliceDeploymentDataSet = New Police_Deployment.PoliceDeploymentDataSet()
        Me.ProfileTableAdapter = New Police_Deployment.PoliceDeploymentDataSetTableAdapters.ProfileTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoliceDeploymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "Profile"
        Me.ProfileBindingSource.DataSource = Me.PoliceDeploymentDataSet
        '
        'PoliceDeploymentDataSet
        '
        Me.PoliceDeploymentDataSet.DataSetName = "PoliceDeploymentDataSet"
        Me.PoliceDeploymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your unique ID to check the location you've been deployed to"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(190, 51)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(402, 20)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(427, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "You've Been Deployed To Kaduna"
        '
        'frmDeploy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 465)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDeploy"
        Me.Text = "frmView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoliceDeploymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PoliceDeploymentDataSet As Police_Deployment.PoliceDeploymentDataSet
    Friend WithEvents ProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfileTableAdapter As Police_Deployment.PoliceDeploymentDataSetTableAdapters.ProfileTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
