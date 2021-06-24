<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NumPadForm
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.svgImageBox1 = New DevExpress.XtraEditors.SvgImageBox()
        CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.svgImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textEdit1
        ' 
        Me.textEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textEdit1.Location = New System.Drawing.Point(12, 12)
        Me.textEdit1.Name = "textEdit1"
        Me.textEdit1.Size = New System.Drawing.Size(214, 20)
        Me.textEdit1.TabIndex = 0
        ' 
        ' svgImageBox1
        ' 
        Me.svgImageBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.svgImageBox1.Location = New System.Drawing.Point(12, 32)
        Me.svgImageBox1.Name = "svgImageBox1"
        Me.svgImageBox1.Size = New System.Drawing.Size(214, 244)
        Me.svgImageBox1.SvgImage = Global.NumPad.VB.My.Resources.Keys
        Me.svgImageBox1.TabIndex = 1
        Me.svgImageBox1.Text = "svgImageBox1"
        ' 
        ' NumPadForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 288)
        Me.Controls.Add(Me.svgImageBox1)
        Me.Controls.Add(Me.textEdit1)
        Me.MinimumSize = New System.Drawing.Size(240, 320)
        Me.Name = "NumPadForm"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.Text = "SVG NumPad (VB)"
        CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.svgImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private WithEvents svgImageBox1 As DevExpress.XtraEditors.SvgImageBox
    Private textEdit1 As DevExpress.XtraEditors.TextEdit
End Class