using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Configuration;
using GroupFileList.Model;
using GroupFileList.DAO;
using System.Xml.Linq;
using System.Text;

namespace ALFiles
{
    public partial class FrmPrincipal : Form
    {
        private Media _media;
        private String _caminho_arq_media;
        private DAOMedia daoMedia;

        public FrmPrincipal()
        {
            InitializeComponent();
            txtDescricaoMedia.Text="ZBACKUP";
            txtCaminho.Text = @"C:\Temp\TesteMidia1\Z";

            _caminho_arq_media = ConfigurationSettings.AppSettings["pathfilemedia"];
            
            FileInfo fileinfo = new FileInfo(_caminho_arq_media);

            if (!fileinfo.Exists)
            {
                MessageBox.Show("O arquivo de configuração não foi encontrado. Você deverá configurar o caminho do arquivo para executar esse programa.",
                    "Arquivo de configuração",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            txtCaminhoArqMedia.Text = _caminho_arq_media;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fbdAbrirPasta.SelectedPath = txtCaminho.Text;
            if (fbdAbrirPasta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtCaminho.Text = fbdAbrirPasta.SelectedPath;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=(MessageBox.Show("Confirma fechar o programa?", "Sair do programa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if (txtDescricaoMedia.Text == String.Empty)
            {
                MessageBox.Show("Descrição da mídia não informada", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCaminho.Text == String.Empty)
            {
                MessageBox.Show("Caminho não informado", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Directory.Exists(txtCaminho.Text))
            {
                MessageBox.Show("Caminho informado não encontrado", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lvFileList.Items.Clear();
            ListViewItem item;

            FitterMedia fitterMedia = new FitterMedia();
            _media = fitterMedia.MountMedia(txtDescricaoMedia.Text, txtCaminho.Text);
            //dataGridView1.DataSource = media.artistList;

            

            foreach (Artist artist in _media.artistList)
            {

                foreach (Album album in artist.albumList)
                {
                    foreach (Music music in album.musicList)
                    {
                        item = new ListViewItem();
                        item.Text = _media.name;
                        item.SubItems.Add(artist.name);
                        item.SubItems.Add(album.name);
                        item.SubItems.Add(music.name);
                        lvFileList.Items.Add(item);
                    }

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TreeNode[] tnFilho = new TreeNode[1];
            tnFilho[0] = new TreeNode("Filho");

            TreeNode[] tnPai = new TreeNode[1];
            tnPai[0] = new TreeNode("Pai",tnFilho);

            TreeNode tnAvo = new TreeNode("Avô",tnPai);

            treeView1.Nodes.Add(tnAvo);

        }
        private void rotinaAntigaButton_click(object sender, EventArgs e)
        {
            lvFileList.Items.Clear();

            DirectoryInfo midia = new DirectoryInfo(txtCaminho.Text);
            DirectoryInfo[] dirList = midia.GetDirectories();

            foreach (DirectoryInfo d in dirList)
            {

                FileInfo[] fileList = d.GetFiles();
                ListViewItem item = new ListViewItem();
                item.Text = d.Name;
                item.SubItems.Add("*");
                lvFileList.Items.Add(item);

                if (fileList.Length > 0)
                {
                    foreach (FileInfo f in fileList)
                    {
                        item = new ListViewItem();
                        item.Text = d.Name;
                        item.SubItems.Add(f.Name);
                        lvFileList.Items.Add(item);
                    }
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<String> _hierarquia = new List<String>();
            _hierarquia.Add("A");
            _hierarquia.Add("B");
            _hierarquia.Add("C");
            _hierarquia.Add("D");

            lvFileList.Items.Clear();
            ListViewItem item;

            foreach (String str in _hierarquia)
            {
                item = new ListViewItem();
                item.Text = str;
                lvFileList.Items.Add(item);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            lvFileList.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DriveInfo driveInfo = new DriveInfo(txtCaminho.Text);
            //lbDriverName.Text = driveInfo.VolumeLabel;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Music music = new Music();
            music.ord=1;
            music.name = "01 No Coração de Deus.mp3";

            Album album = new Album();
            album.musicList = new List<Music>();
            album.name = "sonhos";
            album.path = "angelo torres";
            album.musicList.Add(music);

            music = new Music();
            music.ord = 2;
            music.name = "02 Nação de Adoradores.mp3";
            album.musicList.Add(music);

            music = new Music();
            music.ord = 3;
            music.name = "03 Chegar aTi.mp3";
            album.musicList.Add(music);

            Artist artist = new Artist();
            artist.name = "angelo torres";
            artist.path = "teste_media";
            artist.albumList.Add(album);

            Media media = new Media();
            media.name = "teste_media";
            media.description = "media criada somente para fazer um teste de inserção";
            media.artistList.Add(artist);

            DAOMedia daoMedia = new DAOMedia(_caminho_arq_media);
            daoMedia.inserir(media);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DAOMedia daoMedia = new DAOMedia(_caminho_arq_media);
            daoMedia.inserir(_media);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DAOMedia daoMedia = new DAOMedia(_caminho_arq_media);
            daoMedia.excluir(_media);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            DAOMedia daoMedia = new DAOMedia(_caminho_arq_media);
            List<Media> result_media;

            lvFileList.Items.Clear();

            ListViewItem item;

            result_media = daoMedia.localizaMusica("Love");

            foreach (Media media in result_media)
            {
                foreach (Artist artist in media.artistList)
                {
                    foreach (Album album in artist.albumList)
                    {
                        foreach (Music music in album.musicList)
                        {
                            item = new ListViewItem();
                            item.Name = media.name;
                            item.SubItems.Add(artist.name);
                            item.SubItems.Add(album.name);
                            item.SubItems.Add(music.name);
                            lvFileList.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Album> listaAlbum = new List<Album>();
            Album album = new Album();
            Album find_album = new Album();
            album.name = "A change of the heart";
            album.path = "David Sanbord";
            listaAlbum.Add(album);

            album = new Album();
            album.name = "The windows";
            album.path = "Marc Russo";
            listaAlbum.Add(album);

            album = new Album();
            album.name = "Lost and found";
            album.path = "Spyro gyra";
            listaAlbum.Add(album);

            find_album = listaAlbum.Where(x => x.name.ToUpper() == "LOST AND FOUND").FirstOrDefault();

            if (find_album == null)
                MessageBox.Show("Objeto não encontrado");
            //listaAlbum.IndexOf(
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmConsultarMusica frmConsultarMusica = new FrmConsultarMusica();
            frmConsultarMusica.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmListaMedia frmListaMedia = new FrmListaMedia();
            frmListaMedia.caminho_arq_media = _caminho_arq_media;
            frmListaMedia.ShowDialog();
        }

        private void btnLocalizarMusica_Click(object sender, EventArgs e)
        {
            FrmConsultarMusica frmConsultarMusica = new FrmConsultarMusica();
            frmConsultarMusica.caminho_arq_media = _caminho_arq_media;
            frmConsultarMusica.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListarArtistas_Click(object sender, EventArgs e)
        {
            List<Artist> result_artist;
            Media media = new Media();
            media.name = "MP3_SECULAR05";

            cbLista.Items.Clear();

            result_artist = daoMedia.listaArtista(media);
            foreach (Artist artist in result_artist)
            {
                cbLista.Items.Add(artist.name);
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            daoMedia = new DAOMedia(_caminho_arq_media);
        }

        private void btnListarAlbuns_Click(object sender, EventArgs e)
        {
            List<Album> result_album;
            Artist artist = new Artist();
            artist.name = "Roxette";

            cbLista.Items.Clear();

            result_album = daoMedia.listaAlbum(artist);
            foreach (Album album in result_album)
            {
                cbLista.Items.Add(album.name);
            }

        }

        private void btnListarMusicas_Click(object sender, EventArgs e)
        {
            List<Music> result_music;
            Album album = new Album();
            album.name = "Greatest Hits";

            cbLista.Items.Clear();

            result_music = daoMedia.listaMusica(album);
            foreach (Music music in result_music)
            {
                cbLista.Items.Add(music.name);
            }

        }

        private void btnAlterarConfig_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["pathfilemedia1"].Value = @"C:\App\VS\Desktop\ALFiles";
            config.AppSettings.Settings["pathfilemedia2"].Value = @"c:\BD";
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            //ConfigurationManager.AppSettings["pathfilemedia1"]=@"c:\App";
            //ConfigurationManager.AppSettings["pathfilemedia2"]=@"c:\BD";
                        
            //pathfilemedia1.Save(ConfigurationSaveMode.Full);

            //pathfilemedia1.AppSettings..Set("pathfilemedia1", @"c:\App");

            //ConfigurationSettings.AppSettings["pathfilemedia2"] = @"c:\BD";
            


        }

        private void btnCopiarArqFTP_Click(object sender, EventArgs e)
        {
            DirectoryInfo pasta = new DirectoryInfo(ConfigurationSettings.AppSettings["pathfilemedia1"]);
            WebClient wcFTP = new WebClient();
            NetworkCredential wcFTPCredential = new NetworkCredential("henrique","nqbx2009");

            var fileList = pasta.GetFiles().OrderByDescending(l => l.LastWriteTime).FirstOrDefault();

            label3.Text=fileList.Name.ToString();

            wcFTP.Credentials = wcFTPCredential;
            wcFTP.UploadFile("ftp://192.168.0.115/"+fileList.Name.ToString(), ConfigurationSettings.AppSettings["pathfilemedia1"] + @"\" + fileList.Name.ToString());

        }
    }
}
