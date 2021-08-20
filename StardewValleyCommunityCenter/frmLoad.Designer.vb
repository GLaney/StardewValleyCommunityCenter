<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoad))
        Me.lblLoadTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstLoad = New System.Windows.Forms.ListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLoadTitle
        '
        Me.lblLoadTitle.AutoSize = True
        Me.lblLoadTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblLoadTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadTitle.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblLoadTitle.Location = New System.Drawing.Point(163, 53)
        Me.lblLoadTitle.Name = "lblLoadTitle"
        Me.lblLoadTitle.Size = New System.Drawing.Size(158, 37)
        Me.lblLoadTitle.TabIndex = 0
        Me.lblLoadTitle.Text = "Load File"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(170, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 177)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lstLoad
        '
        Me.lstLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lstLoad.FormattingEnabled = True
        Me.lstLoad.Location = New System.Drawing.Point(175, 129)
        Me.lstLoad.Name = "lstLoad"
        Me.lstLoad.Size = New System.Drawing.Size(140, 160)
        Me.lstLoad.TabIndex = 3
        '
        'btnLoad
        '
        Me.btnLoad.BackgroundImage = CType(resources.GetObject("btnLoad.BackgroundImage"), System.Drawing.Image)
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.Black
        Me.btnLoad.Location = New System.Drawing.Point(199, 311)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(87, 33)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 356)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstLoad)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLoadTitle)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Name = "frmLoad"
        Me.Text = "Stardew Valley Community Center Helper"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoadTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstLoad As ListBox
    Friend WithEvents btnLoad As Button
End Class
