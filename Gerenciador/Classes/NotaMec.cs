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
    public class NotaMec
    {
        private bd_top bd;
        private tb_notaMec _tbNota;
        
        public int ValorNotaMec { get; set; }

        public NotaMec(int nota)
        {
            ValorNotaMec = nota;
        }

        public NotaMec()
        {

        }

        public void AtribuirNotaMec(int fac,int cur, NotaMec ntMec)
        {
            bd = new bd_top();

            try
            {
                _tbNota = new tb_notaMec()
                {
                    notaMecFacul_in_id = fac,
                    notaMecCur_in_id = cur,
                    notaMec_in_valor = ntMec.ValorNotaMec
                };
                bd.tb_notaMec.Add(_tbNota);
                bd.SaveChanges();
                bd.Dispose();

            }catch(EntitySqlException entitySqlEx)
            {
                MessageBox.Show("Erro - " + entitySqlEx.ErrorDescription + "    Gerador do erro - " + entitySqlEx.Source);
            }
            catch (EntityException entityEx)
            {
                MessageBox.Show("Erro - " + entityEx.Message + "    Gerador do erro - " + entityEx.Source);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro - " + sqlEx.Message + "    Gerador do erro - " + sqlEx.Source);
            }
        }

        public List<v_relatorioNotaMec> CursoPorNotaMec(int nota)
        {
            bd = new bd_top();
            
            List<v_relatorioNotaMec> listCurso = new List<v_relatorioNotaMec>();

            foreach (var itemCur in from cur in bd.v_relatorioNotaMec
                                    .Where(c => c.valor_notaMec == nota)
                                    select cur)
            {
                listCurso.Add(itemCur);
            }       


            return listCurso;

        }



    }
}
