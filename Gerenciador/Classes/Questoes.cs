using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Classes
{
    public class Pergunta
    {
        private bd_top bd;
        private tb_pergunta _perg;

        public int IDPergunta { get; private set; }
        public string DescricaoPergunta { get; private set; }
        
        public Pergunta(string descricaoPergunta)
        {
            DescricaoPergunta = descricaoPergunta;
        }

        public Pergunta(){}

        public void CriarPergunta(string pergunta)
        {
            bd = new bd_top();

            int cmpPerg = 0;

            foreach (var iPerg in from perg in bd.tb_pergunta
                                  .Where(p => p.perg_st_desc.Contains(pergunta))
                                  select perg)
            {
                cmpPerg = iPerg.perg_st_desc.Count();
            }

            try
            {
                if(cmpPerg > 0)
                {
                    return;
                } else
                {
                    _perg = new tb_pergunta()
                    {
                        perg_st_desc = pergunta
                    };

                    bd.tb_pergunta.Add(_perg);
                    bd.SaveChanges();
                }

            } catch(EntitySqlException entitySqlEx)
            {
                MessageBox.Show("Erro: " + entitySqlEx.Message + "\nGerador do erro: " + entitySqlEx.Source);
            }
            catch (EntityException entityEx)
            {
                MessageBox.Show("Erro: " + entityEx.Message + "\nGerador do erro: " + entityEx.Source);
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Erro: " + sqlEx.Message + "\nGerador do erro: " + sqlEx.Source);
            }
            finally { bd.Dispose(); }
        }
    }

    public class Resposta
    {
        private bd_top bd;
        private tb_resposta _tbResp;

        public int IDResposta { get; set; }
        public string DescricaoResposta { get;  set; }
        public float ValorExatas { get; set; }
        public float ValorHumanas { get; set; }
        public float ValorBiologicas { get; set; }

        public Resposta(string descricaoResposta, float valorExatas, float valorhumanas, float valorBiologicas)
        {
            this.DescricaoResposta = descricaoResposta;
            this.ValorExatas = valorExatas;
            this.ValorHumanas = valorhumanas;
            this.ValorBiologicas = valorBiologicas;
        }

        public Resposta(){}
        
        public async void GerarRespostas(Resposta resp,string pergunta)
        {
            bd = new bd_top();

            int id = (from idPerg in bd.tb_pergunta.Where(p=>p.perg_st_desc.Equals(pergunta))select idPerg.perg_in_id).FirstOrDefault();
            
            try
            {
                if (id == 0)
                {
                    throw new Exception("Não foi possivel criar uma resposta, pois não encontramos nenhuma pergunta igual.");
                } else
                {
                    bd.sp_inserirResposta(id, resp.DescricaoResposta, resp.ValorExatas, resp.ValorHumanas, resp.ValorBiologicas);
                    await bd.SaveChangesAsync();
                }
            }
            catch (EntitySqlException entitySqlEx)
            {
                MessageBox.Show("Erro: " + entitySqlEx.Message + "\nGerador do erro: " + entitySqlEx.Source);
            }
            catch (EntityException entityEx)
            {
                MessageBox.Show("Erro: " + entityEx.Message + "\nGerador do erro: " + entityEx.Source);
            }
            finally
            { bd.Dispose(); }
        }

    }
}
