<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.btnAddCustomers = New System.Windows.Forms.Button()
        Me.pbBusy = New System.Windows.Forms.PictureBox()
        Me.dgCustomers = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblBilling = New System.Windows.Forms.Label()
        Me.cboCust = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pbBusy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddCustomers
        '
        Me.btnAddCustomers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCustomers.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCustomers.Location = New System.Drawing.Point(655, 117)
        Me.btnAddCustomers.Name = "btnAddCustomers"
        Me.btnAddCustomers.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCustomers.TabIndex = 0
        Me.btnAddCustomers.Text = "Add 500 customers"
        Me.btnAddCustomers.UseVisualStyleBackColor = False
        '
        'pbBusy
        '
        Me.pbBusy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbBusy.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pbBusy.Location = New System.Drawing.Point(666, 25)
        Me.pbBusy.Name = "pbBusy"
        Me.pbBusy.Size = New System.Drawing.Size(64, 64)
        Me.pbBusy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBusy.TabIndex = 1
        Me.pbBusy.TabStop = False
        '
        'dgCustomers
        '
        Me.dgCustomers.AllowUserToAddRows = False
        Me.dgCustomers.AllowUserToDeleteRows = False
        Me.dgCustomers.AutoGenerateColumns = False
        Me.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.dgCustomers.DataSource = Me.CustomerBindingSource
        Me.dgCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCustomers.Location = New System.Drawing.Point(0, 0)
        Me.dgCustomers.Name = "dgCustomers"
        Me.dgCustomers.ReadOnly = True
        Me.dgCustomers.Size = New System.Drawing.Size(770, 262)
        Me.dgCustomers.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(RX_Data_Sample.Customer)
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(637, 166)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(0, 13)
        Me.lblCount.TabIndex = 3
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(297, 240)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(0, 13)
        Me.lblShipping.TabIndex = 4
        '
        'lblBilling
        '
        Me.lblBilling.AutoSize = True
        Me.lblBilling.Location = New System.Drawing.Point(297, 202)
        Me.lblBilling.Name = "lblBilling"
        Me.lblBilling.Size = New System.Drawing.Size(0, 13)
        Me.lblBilling.TabIndex = 4
        '
        'cboCust
        '
        Me.cboCust.FormattingEnabled = True
        Me.cboCust.Location = New System.Drawing.Point(314, 25)
        Me.cboCust.Name = "cboCust"
        Me.cboCust.Size = New System.Drawing.Size(323, 21)
        Me.cboCust.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Shipping"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Billing"
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCust)
        Me.Controls.Add(Me.lblBilling)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.pbBusy)
        Me.Controls.Add(Me.btnAddCustomers)
        Me.Controls.Add(Me.dgCustomers)
        Me.Name = "Customers"
        Me.Text = "Customers"
        CType(Me.pbBusy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddCustomers As System.Windows.Forms.Button
    Friend WithEvents pbBusy As System.Windows.Forms.PictureBox
    Friend WithEvents dgCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblShipping As System.Windows.Forms.Label
    Friend WithEvents lblBilling As System.Windows.Forms.Label
    Friend WithEvents cboCust As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
