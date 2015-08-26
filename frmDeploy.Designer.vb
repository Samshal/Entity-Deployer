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
        Me.lblLoca = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
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
        'lblLoca
        '
        Me.lblLoca.AutoSize = True
        Me.lblLoca.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoca.Location = New System.Drawing.Point(194, 246)
        Me.lblLoca.Name = "lblLoca"
        Me.lblLoca.Size = New System.Drawing.Size(0, 31)
        Me.lblLoca.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(599, 51)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "View"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmDeploy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 465)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblLoca)
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
    Friend WithEvents lblLoca As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
