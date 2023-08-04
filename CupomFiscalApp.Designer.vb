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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        txtNomeCliente = New TextBox()
        txtValor = New TextBox()
        txtNomeItens = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnAdicionarItem = New Button()
        btnImprimir = New Button()
        PictureBox1 = New PictureBox()
        lblCnpjEmpresa = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNomeCliente
        ' 
        txtNomeCliente.Location = New Point(166, 235)
        txtNomeCliente.Name = "txtNomeCliente"
        txtNomeCliente.Size = New Size(104, 23)
        txtNomeCliente.TabIndex = 0
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(134, 271)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(114, 23)
        txtValor.TabIndex = 1
        ' 
        ' txtNomeItens
        ' 
        txtNomeItens.Location = New Point(134, 311)
        txtNomeItens.Name = "txtNomeItens"
        txtNomeItens.Size = New Size(161, 23)
        txtNomeItens.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 238)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 3
        Label1.Text = "Nome Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 311)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 15)
        Label2.TabIndex = 4
        Label2.Text = "Valor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 274)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 5
        Label3.Text = "Itens"
        ' 
        ' btnAdicionarItem
        ' 
        btnAdicionarItem.Location = New Point(33, 398)
        btnAdicionarItem.Name = "btnAdicionarItem"
        btnAdicionarItem.Size = New Size(142, 23)
        btnAdicionarItem.TabIndex = 6
        btnAdicionarItem.Text = "Adicionar Itens"
        btnAdicionarItem.UseVisualStyleBackColor = True
        ' 
        ' btnImprimir
        ' 
        btnImprimir.Location = New Point(212, 398)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(142, 23)
        btnImprimir.TabIndex = 7
        btnImprimir.Text = "Imprimir"
        btnImprimir.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(72, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(196, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' lblCnpjEmpresa
        ' 
        lblCnpjEmpresa.AutoSize = True
        lblCnpjEmpresa.Location = New Point(77, 199)
        lblCnpjEmpresa.Name = "lblCnpjEmpresa"
        lblCnpjEmpresa.Size = New Size(28, 15)
        lblCnpjEmpresa.TabIndex = 9
        lblCnpjEmpresa.Text = "CNJ"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(372, 466)
        Controls.Add(lblCnpjEmpresa)
        Controls.Add(PictureBox1)
        Controls.Add(btnImprimir)
        Controls.Add(btnAdicionarItem)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNomeItens)
        Controls.Add(txtValor)
        Controls.Add(txtNomeCliente)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtNomeItens As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdicionarItem As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCnpjEmpresa As Label
End Class
