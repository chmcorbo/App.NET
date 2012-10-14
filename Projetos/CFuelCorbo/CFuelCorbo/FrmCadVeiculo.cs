using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CFuelCorboLib.dominio.veiculo;
using CFuelCorboLib.dao.BD.veiculo;

namespace CFuelCorbo
{
    public partial class FrmCadVeiculo : FormsBase.Cadastro.FrmCadBase
    {
        private Veiculo veiculo;
        private DAOVeiculo daoVeiculo;

        public FrmCadVeiculo()
        {
            veiculo = new Veiculo();
            daoVeiculo = new DAOVeiculo();
            InitializeComponent();
        }

        protected override void setData()
        {
            base.setData();
            veiculo.ID = Convert.ToInt32(txtID.Text);
            veiculo.placa = txtPlaca.Text;
            veiculo.marca = txtMarca.Text;
            veiculo.modelo = txtModelo.Text;
            veiculo.cor = txtCor.Text;
            veiculo.renavan = txtRenavam.Text;
        }

        protected override void getData()
        {
            base.getData();
            txtPlaca.Text = veiculo.placa;
            txtMarca.Text = veiculo.marca;
            txtModelo.Text = veiculo.modelo;
            txtCor.Text = veiculo.cor;
            txtRenavam.Text = veiculo.renavan;
        }

        protected override bool Novo()
        {
            veiculo.novo();
            return base.Novo();
        }


        protected override bool Abrir()
        {
            Boolean erro = !base.Abrir();
            Boolean encontrado = false;
            veiculo.ID = Convert.ToInt32(txtID.Text);
            encontrado = daoVeiculo.buscarID(veiculo);
            if (!encontrado)
            {
                MessageBox.Show("Veículo não encontrado",
                    "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veiculo.editar();
                getData();
            }
            return encontrado;
        }


        protected override bool Excluir()
        {
            Boolean erro = false;

            veiculo.deletar();
            try
            {
                veiculo.aplicar(daoVeiculo);
                erro = base.Excluir();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Não foi possível excluir esse registro. " + Ex.Message,
                    "Erro na gravação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = true;
            }
            return erro;
        }

        protected override bool Salvar()
        {
            Boolean erro = false;
            setData();
            try
            {
                veiculo.aplicar(daoVeiculo);
                erro = base.Salvar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Não foi possível gravar o registro. "+Ex.Message,
                    "Erro na gravação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = true;
            }

            return erro;
        }
    }
}
