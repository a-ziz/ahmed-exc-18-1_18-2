<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstCustomers = New System.Windows.Forms.ListBox
        Me.btnAddRetail = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnAddWholesale = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstCustomers
        '
        Me.lstCustomers.FormattingEnabled = True
        Me.lstCustomers.Location = New System.Drawing.Point(13, 13)
        Me.lstCustomers.Name = "lstCustomers"
        Me.lstCustomers.Size = New System.Drawing.Size(305, 134)
        Me.lstCustomers.TabIndex = 0
        '
        'btnAddRetail
        '
        Me.btnAddRetail.Location = New System.Drawing.Point(338, 42)
        Me.btnAddRetail.Name = "btnAddRetail"
        Me.btnAddRetail.Size = New System.Drawing.Size(92, 23)
        Me.btnAddRetail.TabIndex = 1
        Me.btnAddRetail.Text = "Add Retail"
        Me.btnAddRetail.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(338, 71)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 100)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddWholesale
        '
        Me.btnAddWholesale.Location = New System.Drawing.Point(338, 13)
        Me.btnAddWholesale.Name = "btnAddWholesale"
        Me.btnAddWholesale.Size = New System.Drawing.Size(92, 23)
        Me.btnAddWholesale.TabIndex = 4
        Me.btnAddWholesale.Text = "Add Wholesale"
        Me.btnAddWholesale.UseVisualStyleBackColor = True
        '
        'frmCustomerMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 168)
        Me.Controls.Add(Me.btnAddWholesale)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddRetail)
        Me.Controls.Add(Me.lstCustomers)
        Me.Name = "frmCustomerMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Maintenance"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCustomers As System.Windows.Forms.ListBox
    Friend WithEvents btnAddRetail As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAddWholesale As System.Windows.Forms.Button

End Class
