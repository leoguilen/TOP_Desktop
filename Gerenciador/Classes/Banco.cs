using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gerenciador.Entity;

namespace Gerenciador.Classes.ObjetosBanco
{
    public class Banco
    {
        private bd_top bd;
        public string Database { get; private set; }
        public string ServerVersion { get; private set; }
        public ConnectionState stateCnn { get; private set; }

        public Banco()
        {
            bd = new bd_top();
        }

        public Banco(bd_top bd)
        {
            this.bd = bd;
        }
        
        public string abrirConexao()
        {
            string sts = "";

            try
            {
                bd.Database.Connection.Open();
                this.Database = bd.Database.Connection.Database;
                this.ServerVersion = bd.Database.Connection.ServerVersion;
                this.stateCnn = bd.Database.Connection.State;
                sts = "Conexão estabelecida com sucesso";
            }
            catch (InvalidOperationException invalidOp)
            {
                sts = string.Format("Erro!\nDetalhes: {0}\nLink de ajuda: {1}", invalidOp.Message, invalidOp.HelpLink);
                fecharConexao();
            }
            catch (SqlException sqlEx)
            {
                sts = string.Format("Erro!\nDetalhes: {0}\nProcedure: {1}\nLink de ajuda: {2}", sqlEx.Message, sqlEx.Procedure, sqlEx.HelpLink);
                fecharConexao();
            }
            catch (EntitySqlException entitySqlEx)
            {
                sts = string.Format("Erro!\nDetalhes: {0}\nLink de ajuda: {1}", entitySqlEx.Message,entitySqlEx.HelpLink);
                fecharConexao();
            }
            catch (EntityException entityEx)
            {
                sts = string.Format("Erro!\nDetalhes: {0}\nLink de ajuda: {1}", entityEx.Message,entityEx.HelpLink);
                fecharConexao();
            }
            return sts;
        }

        public void fecharConexao()
        {
            bd.SaveChanges();
            bd.Database.Connection.Close();
        }

        public string detalhesConexao()
        {
            return string.Format("Database: {0}\nServer Version: {1}\nEstado: {2}", Database, ServerVersion, stateCnn);
        }

        public List<v_relatorioUsuario> viewUsuario()
        {
            List<v_relatorioUsuario> listViewUs = new List<v_relatorioUsuario>(); 

            foreach (var us in bd.v_relatorioUsuario)
            {
                listViewUs.Add(us);
            }

            return listViewUs;
        }

        public List<v_RelatorioCurso> viewCurso()
        {
            List<v_RelatorioCurso> listViewCur = new List<v_RelatorioCurso>();

            foreach (var cur in bd.v_RelatorioCurso)
            {
                listViewCur.Add(cur);
            }

            return listViewCur;
        }

        public List<v_relatorioFaculdades> viewFaculdade()
        {
            List<v_relatorioFaculdades> listViewFac = new List<v_relatorioFaculdades>();

            foreach (var fac in bd.v_relatorioFaculdades)
            {
                listViewFac.Add(fac);
            }

            return listViewFac;
        }

        public List<v_relatorioNotaMec> viewNotaMec()
        {
            List<v_relatorioNotaMec> listViewNtMec = new List<v_relatorioNotaMec>();

            foreach (var nt in bd.v_relatorioNotaMec)
            {
                listViewNtMec.Add(nt);
            }

            return listViewNtMec;
        }

        public List<v_relatorioResultado> viewResultado()
        {
            List<v_relatorioResultado> listViewRes = new List<v_relatorioResultado>();

            foreach (var res in bd.v_relatorioResultado)
            {
                listViewRes.Add(res);
            }

            return listViewRes;
        }

    }
}

namespace Gerenciador.Classes.ObjetosDataSet
{
    class BancoDesconectado
    {
        private string strCnn = string.Empty;
        
        public DataSet dataSet = new DataSet("bd_top");

        public SqlDataAdapter usTbAdapt { get; private set; }
        public SqlDataAdapter facTbAdapt { get; private set; }
        public SqlDataAdapter curTbAdapt { get; private set; }
        public SqlDataAdapter tipoContFacTbAdapt { get; private set; }
        public SqlDataAdapter tipoContTbAdapt { get; private set; }
        public SqlDataAdapter tesTbAdapt { get; private set; }
        public SqlDataAdapter resTbAdapt { get; private set; }
        public SqlDataAdapter pergTbAdapt { get; private set; }
        public SqlDataAdapter ntMecTbAdapt { get; private set; }
        public SqlDataAdapter nivelTbAdapt { get; private set; }
        public SqlDataAdapter emailTbAdapt { get; private set; }
        public SqlDataAdapter detResTbAdapt { get; private set; }
        public SqlDataAdapter contFacTbAdapt { get; private set; }
        public SqlDataAdapter contTbAdapt { get; private set; }
        public SqlDataAdapter avaliaTbAdapt { get; private set; }
        public SqlDataAdapter areaTbAdapt { get; private set; }

        private SqlCommandBuilder sqlCBUs;
        private SqlCommandBuilder sqlCBFac;
        private SqlCommandBuilder sqlCBCur;
        private SqlCommandBuilder sqlCBTipoContFac;
        private SqlCommandBuilder sqlCBTipoCont;
        private SqlCommandBuilder sqlCBTes;
        private SqlCommandBuilder sqlCBRes;
        private SqlCommandBuilder sqlCBPerg;
        private SqlCommandBuilder sqlCBNtMec;
        private SqlCommandBuilder sqlCBNivel;
        private SqlCommandBuilder sqlCBEmail;
        private SqlCommandBuilder sqlCBDetRes;
        private SqlCommandBuilder sqlCBContFac;
        private SqlCommandBuilder sqlCBCont;
        private SqlCommandBuilder sqlCBAvalia;
        private SqlCommandBuilder sqlCBArea;


        public BancoDesconectado(string strcnn)
        {
            this.strCnn = strcnn;

            ConfigurarAdaptador();
        }

        private void ConfigurarAdaptador()
        {
            usTbAdapt = new SqlDataAdapter("select user_in_id as 'ID', user_st_nome as 'Nome',user_st_sexo as 'Sexo',user_dt_dtNasc as 'DataNascimento'," +
                                            "user_st_username as 'Username',user_st_uf as 'UF',user_st_cidade as 'Cidade'," +
                                            "user_in_nivelAcad as 'NivelAcademico',user_dt_dtCad as 'DataCadastro' from tb_usuario", strCnn);

            facTbAdapt = new SqlDataAdapter("select facul_in_id as 'ID',facul_st_nome as 'Nome',facul_st_endereco as 'Endereço',facul_st_uf as 'UF'," +
                                            "facul_st_estado as 'Estado',facul_st_cidade as 'Cidade',facul_st_site as 'Site' from tb_faculdade", strCnn);

            curTbAdapt = new SqlDataAdapter("select * from tb_curso", strCnn);
            tipoContFacTbAdapt = new SqlDataAdapter("select * from tb_tipoContatoFaculdade", strCnn);
            tipoContTbAdapt = new SqlDataAdapter("select * from tb_tipoContato", strCnn);
            tesTbAdapt = new SqlDataAdapter("select * from tb_teste", strCnn);
            resTbAdapt = new SqlDataAdapter("select * from tb_resposta", strCnn);
            pergTbAdapt = new SqlDataAdapter("select * from tb_pergunta", strCnn);
            ntMecTbAdapt = new SqlDataAdapter("select * from tb_notaMec", strCnn);
            nivelTbAdapt = new SqlDataAdapter("select * from tb_nivelAcademico", strCnn);
            emailTbAdapt = new SqlDataAdapter("select * from tb_email", strCnn);
            detResTbAdapt = new SqlDataAdapter("select * from tb_detalhesResultado", strCnn);
            contFacTbAdapt = new SqlDataAdapter("select * from tb_contatoFaculdade", strCnn);
            contTbAdapt = new SqlDataAdapter("select * from tb_contato", strCnn);
            avaliaTbAdapt = new SqlDataAdapter("select * from tb_avaliaSis", strCnn);
            areaTbAdapt = new SqlDataAdapter("select * from tb_area", strCnn);
            

            sqlCBUs = new SqlCommandBuilder(usTbAdapt);
            sqlCBFac = new SqlCommandBuilder(facTbAdapt);
            sqlCBCur = new SqlCommandBuilder(curTbAdapt);
            sqlCBArea = new SqlCommandBuilder(areaTbAdapt);
            sqlCBAvalia = new SqlCommandBuilder(avaliaTbAdapt);
            sqlCBCont = new SqlCommandBuilder(contTbAdapt);
            sqlCBContFac = new SqlCommandBuilder(contFacTbAdapt);
            sqlCBDetRes = new SqlCommandBuilder(detResTbAdapt);
            sqlCBEmail = new SqlCommandBuilder(emailTbAdapt);
            sqlCBNivel = new SqlCommandBuilder(nivelTbAdapt);
            sqlCBNtMec = new SqlCommandBuilder(ntMecTbAdapt);
            sqlCBPerg = new SqlCommandBuilder(pergTbAdapt);
            sqlCBRes = new SqlCommandBuilder(resTbAdapt);
            sqlCBTes = new SqlCommandBuilder(tesTbAdapt);
            sqlCBTipoCont = new SqlCommandBuilder(tipoContTbAdapt);
            sqlCBTipoContFac = new SqlCommandBuilder(tipoContFacTbAdapt);


            usTbAdapt.Fill(dataSet, "Usuario");
            facTbAdapt.Fill(dataSet, "Faculdade");
            curTbAdapt.Fill(dataSet, "Curso");
            tipoContFacTbAdapt.Fill(dataSet, "TipoContFac");
            tipoContTbAdapt.Fill(dataSet, "TipoCont");
            tesTbAdapt.Fill(dataSet, "Teste");
            resTbAdapt.Fill(dataSet, "Resposta");
            pergTbAdapt.Fill(dataSet, "Pergunta");
            ntMecTbAdapt.Fill(dataSet, "NotaMec");
            nivelTbAdapt.Fill(dataSet, "Nivel");
            emailTbAdapt.Fill(dataSet, "Email");
            detResTbAdapt.Fill(dataSet, "DetalhesRes");
            contFacTbAdapt.Fill(dataSet, "ContFac");
            contTbAdapt.Fill(dataSet, "Cont");
            avaliaTbAdapt.Fill(dataSet, "Avalia");
            areaTbAdapt.Fill(dataSet, "Area");
           
        }

        public void AtualizaRegistro(SqlDataAdapter dataAdapter,DataSet ds,string tabela)
        {
            dataAdapter.Update(ds,tabela);
            dataSet.AcceptChanges();
        }

        public DataTable RetornarTabela(string dt)
        {
            return dataSet.Tables[dt];
        }
    }
}

