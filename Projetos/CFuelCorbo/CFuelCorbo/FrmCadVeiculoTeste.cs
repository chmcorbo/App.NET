using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CFuelCorbo
{
    public partial class FrmCadVeiculoTeste : Form
    {
        private String caminho = System.Configuration.ConfigurationSettings.AppSettings["caminho"].ToString() + @"\veiculo.xml";
        private XDocument xmlDoc; 

        private void Listar()
        {
            /*
             * XElement veiculos = XElement.Load(caminho);
            var veiculo = from v in veiculos.Elements("veiculo")
                          where (string)v.Element("placa") == "LNP-0037"
                          select new
                          {
                              placa = v.Element("placa"),
                              marca = v.Element("marca"),
                              modelo = v.Element("modelo"),
                              cor = v.Element("cor")
                          };

             
             var veiculo = from v in veiculos.Elements("veiculo")
                           where (string)v.Attribute("id") == "1"
                    select new
                    {
                        placa = v.Element("placa"),
                        marca = v.Element("marca"),
                        modelo = v.Element("modelo"),
                        cor = v.Element("cor")
                    };
            */

            /*
             * var query = from v in xmlDoc.Descendants("veiculo")
                        select v;
             */

            var query = from v in xmlDoc.Descendants("veiculo")
                        select v;

            if (listView1.Items.Count > 0)
                listView1.Items.Clear();

            
            if (query.Count()>0)
            {
                foreach (XElement veiculo in query)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = veiculo.Attribute("id").Value;
                    item.SubItems.Add(veiculo.Element("placa").Value);
                    item.SubItems.Add(veiculo.Element("marca").Value);
                    item.SubItems.Add(veiculo.Element("modelo").Value);
                    item.SubItems.Add(veiculo.Element("cor").Value);
                    listView1.Items.Add(item);
                }
            }
              
        }
        public FrmCadVeiculoTeste()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            XElement novo = new XElement("veiculo", new XAttribute("id", txtID.Text),
                new XElement("placa", txtPlaca.Text), new XElement("marca", txtMarca.Text),
                new XElement("modelo", txtModelo.Text), new XElement("cor", txtCor.Text));
            xmlDoc.Element("veiculos").Add(novo);
            xmlDoc.Save(caminho);
            Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            var veiculo = xmlDoc.Descendants("veiculo").Where(x => x.Attribute("id").Value == txtID.Text).FirstOrDefault();

            ListViewItem item = new ListViewItem();

            if (veiculo != null)
            {
                veiculo.Element("placa").Value = txtPlaca.Text;
                veiculo.Element("marca").Value = txtMarca.Text;
                veiculo.Element("modelo").Value = txtModelo.Text;
                veiculo.Element("cor").Value = txtCor.Text;
                xmlDoc.Save(caminho);
                Listar();
            }

        }

        private void FrmCadVeiculo_Load(object sender, EventArgs e)
        {
            xmlDoc = XDocument.Load(caminho);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var veiculo = xmlDoc.Descendants("veiculo").Where(x => x.Attribute("id").Value == txtID.Text).FirstOrDefault();
            if (veiculo != null)
            {
                veiculo.Remove();
                xmlDoc.Save(caminho);
                Listar();
            }
            
        }
    }
}
