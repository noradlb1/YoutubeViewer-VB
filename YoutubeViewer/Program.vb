Imports System
Imports System.Windows.Forms

Namespace YoutubeViewer
    Friend Module Program
        ''' <summary>
        ''' Ponto de entrada principal para o aplicativo.
        ''' </summary>
        <STAThread>
        Private Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New frmVideos())
        End Sub
    End Module
End Namespace
