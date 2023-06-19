Imports System
Imports System.Globalization
Imports System.Windows.Forms

Namespace YoutubeViewer
    Public Partial Class frmVideos
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub frmVideos_Load(ByVal sender As Object, ByVal e As EventArgs)
            'Exibição em detalhes
            lvlVideos.View = View.Details
            'Permite selecionar a linha toda
            lvlVideos.FullRowSelect = True
            'Exibir as linhas de grade
            lvlVideos.GridLines = True

            lvlVideos.Columns.Add("Vídeos", 400, HorizontalAlignment.Left)
            lvlVideos.Columns.Add("Horário", 200, HorizontalAlignment.Right)

            txtUrl.Select()
        End Sub

        Private Sub btnCarregar_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Verificar se o campo URL foi preenchido
            If txtUrl.Text.Trim().Equals(String.Empty) Then
                MessageBox.Show("Você deve informar a URL do vídeo!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'Adiciona na listview
            Dim lvi As ListViewItem = New ListViewItem(txtUrl.Text.Trim())
            lvi.SubItems.Add(Date.Now.ToString("dd/MM/yyyy 'às' HH:mm:ss", New CultureInfo("pt-BR")))
            lvlVideos.Items.Add(lvi)

            'Exibir o vídeo
            Dim html = "<html><head>"
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"
            html += "<center><iframe id='video' src='https://www.youtube.com/embed/{0}?autoplay={1}' width='{2}' height='{3}' frameborder='0' allowfullscreen='true'></iframe></center>"
            html += "</body></html>"

            wbVideo.DocumentText = String.Format(html, txtUrl.Text.Trim().Split("="c)(1), If(chkAutoplay.Checked, "1", "0"), wbVideo.Width - 30, wbVideo.Height - 30)

            txtUrl.Text = String.Empty
            chkAutoplay.Checked = False
        End Sub
    End Class
End Namespace
