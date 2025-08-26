<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        piclogo = New PictureBox()
        flowPanel = New FlowLayoutPanel()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Label2 = New Label()
        gridAnimales = New DataGridView()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(piclogo, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(gridAnimales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(-4, -1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1349, 737)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(piclogo)
        TabPage1.Controls.Add(flowPanel)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1341, 704)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Animales"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' piclogo
        ' 
        piclogo.Location = New Point(468, 78)
        piclogo.Name = "piclogo"
        piclogo.Size = New Size(387, 229)
        piclogo.TabIndex = 3
        piclogo.TabStop = False
        ' 
        ' flowPanel
        ' 
        flowPanel.AutoScroll = True
        flowPanel.Location = New Point(30, 313)
        flowPanel.Name = "flowPanel"
        flowPanel.Size = New Size(1286, 355)
        flowPanel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(249, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(824, 62)
        Label1.TabIndex = 0
        Label1.Text = "GuateAnimals tu veterinaria favorita"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(gridAnimales)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1341, 704)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Control de animales"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(333, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(695, 62)
        Label2.TabIndex = 1
        Label2.Text = "Control de animales atendidos"
        ' 
        ' gridAnimales
        ' 
        gridAnimales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridAnimales.Location = New Point(37, 119)
        gridAnimales.Name = "gridAnimales"
        gridAnimales.RowHeadersWidth = 51
        gridAnimales.Size = New Size(1290, 576)
        gridAnimales.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1345, 737)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(piclogo, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(gridAnimales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents flowPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents gridAnimales As DataGridView
    Friend WithEvents piclogo As PictureBox

End Class
