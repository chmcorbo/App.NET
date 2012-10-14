using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GroupFileList.DAO;
using GroupFileList.Model;

namespace ALFiles
{
    public partial class FrmConsultarMusica : Form
    {
        private DAOMedia daoMedia;
        private  List<Media> result_media;

        public FrmConsultarMusica()
        {
            InitializeComponent();
        }

        public String caminho_arq_media { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            lvFileList.Items.Clear();

            ListViewItem item;

            result_media = daoMedia.localizaMusica(txtNomeMusica.Text);

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

        private void FrmConsultarMusica_Load(object sender, EventArgs e)
        {
            daoMedia = new DAOMedia(caminho_arq_media);
        }
    }
}
