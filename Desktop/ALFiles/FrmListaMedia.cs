using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GroupFileList.Model;
using GroupFileList.DAO;

namespace ALFiles
{
    public partial class FrmListaMedia : Form
    {
        DAOMedia daoMedia;

        public String caminho_arq_media {get; set;}

        public FrmListaMedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Media> result_media;

            lvFileList.Items.Clear();

            ListViewItem item;

            result_media = daoMedia.listaMedia();
            foreach (Media media in result_media)
            {
                item = new ListViewItem();
                item.Name = media.name;
                item.SubItems.Add(media.description);
                lvFileList.Items.Add(item);
            }
        }

        private void FrmListaMedia_Load(object sender, EventArgs e)
        {
            daoMedia = new DAOMedia(caminho_arq_media);
        }
    }
}
