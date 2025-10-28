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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(12, 34)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Painting", "Sculpture", "Digital Art", "Photography", "Crafts"})
        Me.cmbCategory.Location = New System.Drawing.Point(190, 161)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategory.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(190, 189)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add Artwork"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 13)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Artwork Title:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Artist Name:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(340, 63)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(73, 13)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Artwork Price:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(190, 142)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(91, 13)
        Me.lblCategory.TabIndex = 8
        Me.lblCategory.Text = "Artwork Category:"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv.Location = New System.Drawing.Point(193, 266)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(442, 150)
        Me.dgv.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Artwork Title"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Artist "
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(190, 218)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(94, 23)
        Me.btnAnalyze.TabIndex = 11
        Me.btnAnalyze.Text = "Analyze Exhibit"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(343, 82)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnAnalyze As Button
    Friend WithEvents txtPrice As TextBox
End Class
