
Imports System

Namespace YoutubeViewer
    Partial Class frmVideos
        ''' <summary>
        ''' Variável de designer necessária.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Limpar os recursos que estão sendo usados.
        ''' </summary>
        ''' <paramname="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Código gerado pelo Windows Form Designer"

        ''' <summary>
        ''' Método necessário para suporte ao Designer - não modifique 
        ''' o conteúdo deste método com o editor de código.
        ''' </summary>
        Private Sub InitializeComponent()
            tableLayoutPanel1 = New Windows.Forms.TableLayoutPanel()
            tableLayoutPanel2 = New Windows.Forms.TableLayoutPanel()
            txtUrl = New Windows.Forms.TextBox()
            chkAutoplay = New Windows.Forms.CheckBox()
            btnCarregar = New Windows.Forms.Button()
            lvlVideos = New Windows.Forms.ListView()
            wbVideo = New Windows.Forms.WebBrowser()
            tableLayoutPanel1.SuspendLayout()
            tableLayoutPanel2.SuspendLayout()
            SuspendLayout()
            ' 
            ' tableLayoutPanel1
            ' 
            tableLayoutPanel1.ColumnCount = 1
            tableLayoutPanel1.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 100.0F))
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0)
            tableLayoutPanel1.Controls.Add(lvlVideos, 0, 1)
            tableLayoutPanel1.Controls.Add(wbVideo, 0, 2)
            tableLayoutPanel1.Dock = Windows.Forms.DockStyle.Fill
            tableLayoutPanel1.Location = New Drawing.Point(0, 0)
            tableLayoutPanel1.Name = "tableLayoutPanel1"
            tableLayoutPanel1.RowCount = 3
            tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 10.0F))
            tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 20.0F))
            tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 70.0F))
            tableLayoutPanel1.Size = New Drawing.Size(855, 523)
            tableLayoutPanel1.TabIndex = 0
            ' 
            ' tableLayoutPanel2
            ' 
            tableLayoutPanel2.ColumnCount = 3
            tableLayoutPanel2.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 67.96117F))
            tableLayoutPanel2.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 19.41748F))
            tableLayoutPanel2.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 12.62136F))
            tableLayoutPanel2.Controls.Add(txtUrl, 0, 0)
            tableLayoutPanel2.Controls.Add(chkAutoplay, 1, 0)
            tableLayoutPanel2.Controls.Add(btnCarregar, 2, 0)
            tableLayoutPanel2.Dock = Windows.Forms.DockStyle.Fill
            tableLayoutPanel2.Location = New Drawing.Point(3, 3)
            tableLayoutPanel2.Name = "tableLayoutPanel2"
            tableLayoutPanel2.RowCount = 1
            tableLayoutPanel2.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 100.0F))
            tableLayoutPanel2.Size = New Drawing.Size(849, 46)
            tableLayoutPanel2.TabIndex = 0
            ' 
            ' txtUrl
            ' 
            txtUrl.Dock = Windows.Forms.DockStyle.Fill
            txtUrl.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            txtUrl.Location = New Drawing.Point(3, 3)
            txtUrl.Multiline = True
            txtUrl.Name = "txtUrl"
            txtUrl.Size = New Drawing.Size(570, 40)
            txtUrl.TabIndex = 0
            ' 
            ' chkAutoplay
            ' 
            chkAutoplay.AutoSize = True
            chkAutoplay.Dock = Windows.Forms.DockStyle.Fill
            chkAutoplay.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            chkAutoplay.Location = New Drawing.Point(579, 3)
            chkAutoplay.Name = "chkAutoplay"
            chkAutoplay.Size = New Drawing.Size(158, 40)
            chkAutoplay.TabIndex = 1
            chkAutoplay.Text = "Autoplay"
            chkAutoplay.UseVisualStyleBackColor = True
            ' 
            ' btnCarregar
            ' 
            btnCarregar.Dock = Windows.Forms.DockStyle.Fill
            btnCarregar.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            btnCarregar.Location = New Drawing.Point(743, 3)
            btnCarregar.Name = "btnCarregar"
            btnCarregar.Size = New Drawing.Size(103, 40)
            btnCarregar.TabIndex = 2
            btnCarregar.Text = "Carregar"
            btnCarregar.UseVisualStyleBackColor = True
            AddHandler btnCarregar.Click, New EventHandler(AddressOf btnCarregar_Click)
            ' 
            ' lvlVideos
            ' 
            lvlVideos.Dock = Windows.Forms.DockStyle.Fill
            lvlVideos.Font = New Drawing.Font("Microsoft Sans Serif", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 0)
            lvlVideos.HideSelection = False
            lvlVideos.Location = New Drawing.Point(3, 55)
            lvlVideos.Name = "lvlVideos"
            lvlVideos.Size = New Drawing.Size(849, 98)
            lvlVideos.TabIndex = 1
            lvlVideos.UseCompatibleStateImageBehavior = False
            ' 
            ' wbVideo
            ' 
            wbVideo.Dock = Windows.Forms.DockStyle.Fill
            wbVideo.Location = New Drawing.Point(3, 159)
            wbVideo.MinimumSize = New Drawing.Size(20, 20)
            wbVideo.Name = "wbVideo"
            wbVideo.Size = New Drawing.Size(849, 361)
            wbVideo.TabIndex = 2
            ' 
            ' frmVideos
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(855, 523)
            Controls.Add(tableLayoutPanel1)
            Name = "frmVideos"
            Text = "Visualizador de Vídeos"
            AddHandler Load, New EventHandler(AddressOf frmVideos_Load)
            tableLayoutPanel1.ResumeLayout(False)
            tableLayoutPanel2.ResumeLayout(False)
            tableLayoutPanel2.PerformLayout()
            ResumeLayout(False)

        End Sub

#End Region

        Private tableLayoutPanel1 As Windows.Forms.TableLayoutPanel
        Private tableLayoutPanel2 As Windows.Forms.TableLayoutPanel
        Private txtUrl As Windows.Forms.TextBox
        Private chkAutoplay As Windows.Forms.CheckBox
        Private btnCarregar As Windows.Forms.Button
        Private lvlVideos As Windows.Forms.ListView
        Private wbVideo As Windows.Forms.WebBrowser
    End Class
End Namespace
