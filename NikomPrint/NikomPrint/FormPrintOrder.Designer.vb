<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrintOrder
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEditPartsReq = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButtonPartReq = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonbodyCheck = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButtonPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEditBodyCheck = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEditOrder = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButtonGDPR = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CheckEditGDPR = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEditPartsReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditBodyCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEditGDPR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEditGDPR)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonGDPR)
        Me.LayoutControl1.Controls.Add(Me.CheckEditPartsReq)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonPartReq)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonbodyCheck)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonOrder)
        Me.LayoutControl1.Controls.Add(Me.SimpleButtonPrint)
        Me.LayoutControl1.Controls.Add(Me.CheckEditBodyCheck)
        Me.LayoutControl1.Controls.Add(Me.CheckEditOrder)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(874, 433, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(307, 261)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEditPartsReq
        '
        Me.CheckEditPartsReq.Location = New System.Drawing.Point(12, 64)
        Me.CheckEditPartsReq.Name = "CheckEditPartsReq"
        Me.CheckEditPartsReq.Properties.Caption = "Заявка за части"
        Me.CheckEditPartsReq.Size = New System.Drawing.Size(140, 19)
        Me.CheckEditPartsReq.StyleController = Me.LayoutControl1
        Me.CheckEditPartsReq.TabIndex = 11
        '
        'SimpleButtonPartReq
        '
        Me.SimpleButtonPartReq.Location = New System.Drawing.Point(156, 64)
        Me.SimpleButtonPartReq.Name = "SimpleButtonPartReq"
        Me.SimpleButtonPartReq.Size = New System.Drawing.Size(139, 22)
        Me.SimpleButtonPartReq.StyleController = Me.LayoutControl1
        Me.SimpleButtonPartReq.TabIndex = 10
        Me.SimpleButtonPartReq.Text = "Печат"
        '
        'SimpleButtonbodyCheck
        '
        Me.SimpleButtonbodyCheck.Location = New System.Drawing.Point(156, 38)
        Me.SimpleButtonbodyCheck.Name = "SimpleButtonbodyCheck"
        Me.SimpleButtonbodyCheck.Size = New System.Drawing.Size(139, 22)
        Me.SimpleButtonbodyCheck.StyleController = Me.LayoutControl1
        Me.SimpleButtonbodyCheck.TabIndex = 8
        Me.SimpleButtonbodyCheck.Text = "Печат"
        '
        'SimpleButtonOrder
        '
        Me.SimpleButtonOrder.Location = New System.Drawing.Point(156, 12)
        Me.SimpleButtonOrder.Name = "SimpleButtonOrder"
        Me.SimpleButtonOrder.Size = New System.Drawing.Size(139, 22)
        Me.SimpleButtonOrder.StyleController = Me.LayoutControl1
        Me.SimpleButtonOrder.TabIndex = 7
        Me.SimpleButtonOrder.Text = "Печат"
        '
        'SimpleButtonPrint
        '
        Me.SimpleButtonPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButtonPrint.Appearance.Options.UseFont = True
        Me.SimpleButtonPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopRight
        Me.SimpleButtonPrint.Location = New System.Drawing.Point(12, 227)
        Me.SimpleButtonPrint.Name = "SimpleButtonPrint"
        Me.SimpleButtonPrint.Size = New System.Drawing.Size(283, 22)
        Me.SimpleButtonPrint.StyleController = Me.LayoutControl1
        Me.SimpleButtonPrint.TabIndex = 6
        Me.SimpleButtonPrint.Text = "Печат избрани"
        '
        'CheckEditBodyCheck
        '
        Me.CheckEditBodyCheck.Location = New System.Drawing.Point(12, 38)
        Me.CheckEditBodyCheck.Name = "CheckEditBodyCheck"
        Me.CheckEditBodyCheck.Properties.Caption = "Протокол Body Check"
        Me.CheckEditBodyCheck.Size = New System.Drawing.Size(140, 19)
        Me.CheckEditBodyCheck.StyleController = Me.LayoutControl1
        Me.CheckEditBodyCheck.TabIndex = 5
        '
        'CheckEditOrder
        '
        Me.CheckEditOrder.EditValue = True
        Me.CheckEditOrder.Location = New System.Drawing.Point(12, 12)
        Me.CheckEditOrder.Name = "CheckEditOrder"
        Me.CheckEditOrder.Properties.Caption = "Поръчка"
        Me.CheckEditOrder.Size = New System.Drawing.Size(140, 19)
        Me.CheckEditOrder.StyleController = Me.LayoutControl1
        Me.CheckEditOrder.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem1, Me.LayoutControlItem8, Me.LayoutControlItem6, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(307, 261)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 104)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(287, 111)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CheckEditBodyCheck
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(144, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButtonPrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 215)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(287, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButtonOrder
        Me.LayoutControlItem4.Location = New System.Drawing.Point(144, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(143, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButtonbodyCheck
        Me.LayoutControlItem5.Location = New System.Drawing.Point(144, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(143, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButtonPartReq
        Me.LayoutControlItem7.Location = New System.Drawing.Point(144, 52)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(81, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(143, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CheckEditOrder
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(144, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEditPartsReq
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(144, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'SimpleButtonGDPR
        '
        Me.SimpleButtonGDPR.Location = New System.Drawing.Point(155, 90)
        Me.SimpleButtonGDPR.Name = "SimpleButtonGDPR"
        Me.SimpleButtonGDPR.Size = New System.Drawing.Size(140, 22)
        Me.SimpleButtonGDPR.StyleController = Me.LayoutControl1
        Me.SimpleButtonGDPR.TabIndex = 12
        Me.SimpleButtonGDPR.Text = "Печат"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButtonGDPR
        Me.LayoutControlItem6.Location = New System.Drawing.Point(143, 78)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(144, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'CheckEditGDPR
        '
        Me.CheckEditGDPR.Location = New System.Drawing.Point(12, 90)
        Me.CheckEditGDPR.Name = "CheckEditGDPR"
        Me.CheckEditGDPR.Properties.Caption = "Форма GDPR"
        Me.CheckEditGDPR.Size = New System.Drawing.Size(139, 19)
        Me.CheckEditGDPR.StyleController = Me.LayoutControl1
        Me.CheckEditGDPR.TabIndex = 13
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.CheckEditGDPR
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(143, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'FormPrintOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 261)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FormPrintOrder"
        Me.Text = "Печат поръчка"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEditPartsReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditBodyCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEditGDPR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButtonPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEditBodyCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEditOrder As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButtonbodyCheck As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButtonPartReq As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEditPartsReq As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEditGDPR As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButtonGDPR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
End Class
