<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(65, 94)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(193, 60)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {2000014, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(98, 13)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit1.Size = New System.Drawing.Size(135, 20)
        Me.SpinEdit1.TabIndex = 1
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "Data Source=10.57.12.21;Initial Catalog=Store;Persist Security Info=True;User ID=" &
    "Cust_Reports"
        Me.TextEdit1.Location = New System.Drawing.Point(65, 41)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(657, 20)
        Me.TextEdit1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
