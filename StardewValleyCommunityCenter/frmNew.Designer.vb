<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNew))
        Me.lblNewTitle = New System.Windows.Forms.Label()
        Me.btnNormal = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNewTitle
        '
        Me.lblNewTitle.AutoSize = True
        Me.lblNewTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblNewTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewTitle.Location = New System.Drawing.Point(163, 71)
        Me.lblNewTitle.Name = "lblNewTitle"
        Me.lblNewTitle.Size = New System.Drawing.Size(159, 39)
        Me.lblNewTitle.TabIndex = 1
        Me.lblNewTitle.Text = "New File"
        '
        'btnNormal
        '
        Me.btnNormal.BackgroundImage = CType(resources.GetObject("btnNormal.BackgroundImage"), System.Drawing.Image)
        Me.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNormal.Location = New System.Drawing.Point(200, 151)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(84, 33)
        Me.btnNormal.TabIndex = 2
        Me.btnNormal.Text = "Normal"
        Me.btnNormal.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(182, 125)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(120, 20)
        Me.txtFileName.TabIndex = 4
        '
        'frmNew
        '
        Me.AcceptButton = Me.btnNormal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 356)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnNormal)
        Me.Controls.Add(Me.lblNewTitle)
        Me.DoubleBuffered = True
        Me.Name = "frmNew"
        Me.Text = "Stardew Valley Community Center Helper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewTitle As Label
    Friend WithEvents btnNormal As Button
    Friend WithEvents txtFileName As TextBox
End Class
