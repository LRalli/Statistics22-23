<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(525, 27)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar1.Maximum = 1000
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(114, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickFrequency = 100
        Me.TrackBar1.Value = 100
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(686, 27)
        Me.TrackBar2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(114, 45)
        Me.TrackBar2.TabIndex = 1
        Me.TrackBar2.TickFrequency = 10
        Me.TrackBar2.Value = 30
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(845, 27)
        Me.TrackBar3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TrackBar3.Maximum = 1000
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(114, 45)
        Me.TrackBar3.TabIndex = 2
        Me.TrackBar3.TickFrequency = 10
        Me.TrackBar3.Value = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "AbsoluteFreq"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 16)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 42)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "RelativeFreq"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(331, 16)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 42)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "NormalizedFreq"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(534, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "# Trials: 100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(686, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "# Trajectories: 30"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(853, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lambda : 50"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(30, 76)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(449, 462)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(497, 76)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(361, 462)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1024, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 11
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(994, 9)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(162, 61)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = "Success Probability: 50%"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(883, 76)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(292, 469)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 562)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
