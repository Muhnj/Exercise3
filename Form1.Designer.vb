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
        btnCount = New Button()
        txtNumber = New TextBox()
        lblDisplaysNo1to10 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtNum1 = New TextBox()
        btnCounting = New Button()
        SuspendLayout()
        ' 
        ' btnCount
        ' 
        btnCount.Location = New Point(210, 63)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(75, 23)
        btnCount.TabIndex = 0
        btnCount.Text = "Count"
        btnCount.UseVisualStyleBackColor = True
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(304, 64)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(119, 23)
        txtNumber.TabIndex = 1
        ' 
        ' lblDisplaysNo1to10
        ' 
        lblDisplaysNo1to10.AutoSize = True
        lblDisplaysNo1to10.Location = New Point(254, 27)
        lblDisplaysNo1to10.Name = "lblDisplaysNo1to10"
        lblDisplaysNo1to10.Size = New Size(107, 15)
        lblDisplaysNo1to10.TabIndex = 2
        lblDisplaysNo1to10.Text = "Displays No 1 to 10"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(216, 206)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 15)
        Label1.TabIndex = 3
        Label1.Text = "Asks number and then counts  down to  zero"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(156, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 4
        Label2.Text = "Enter Number"
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(254, 240)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(189, 23)
        txtNum1.TabIndex = 5
        ' 
        ' btnCounting
        ' 
        btnCounting.Location = New Point(238, 282)
        btnCounting.Name = "btnCounting"
        btnCounting.Size = New Size(75, 23)
        btnCounting.TabIndex = 6
        btnCounting.Text = "COUNTING"
        btnCounting.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCounting)
        Controls.Add(txtNum1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblDisplaysNo1to10)
        Controls.Add(txtNumber)
        Controls.Add(btnCount)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCount As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblDisplaysNo1to10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents btnCounting As Button

End Class
