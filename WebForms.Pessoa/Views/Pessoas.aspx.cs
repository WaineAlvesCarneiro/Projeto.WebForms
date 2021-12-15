using System;
using System.Web.UI;
using WebForms.Pessoa.Data;
using WebForms.Pessoa.Models;

namespace WebForms.Pessoa.Views
{
    public partial class Pessoas : Page
    {
        GerPessoa gerPessoas = new GerPessoa();

        private void Consultar()
        {
            gridPessoa.DataSource = gerPessoas.Consultar();
            gridPessoa.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaModel pessoas = new PessoaModel()
                {
                    Nome = txtNome.Text,
                    TipoPessoa = int.Parse(txtTipoPessoa.Text)
                };
                gerPessoas.Gravar(pessoas);
                Consultar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        protected void gridPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}