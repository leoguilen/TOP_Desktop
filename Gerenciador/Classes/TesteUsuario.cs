using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Classes
{
    public class TesteUsuario
    {
        private bd_top bd;
        private tb_teste _tbTeste;

        public int IDTeste { get; private set; }
        public DateTime InicioTeste { get; set; }
        public DateTime FimTeste { get; private set; }
        public int NovoTeste { get; set; }

        public TesteUsuario(DateTime inicio)
        {
            InicioTeste = inicio;
        }

        public TesteUsuario()
        {
            InicioTeste = DateTime.Now;     
        }

        
    }

    public class DetalhesTeste
    {
        private bd_top bd;
        private tb_detalhesResultado _tbDetRes;

        public int DuraçãoTeste { get; set; }
        public float ValorExatas { get; set; }
        public float ValorHumanas { get; set; }
        public float ValorBiologicas { get; set; }

        public DetalhesTeste(int duracao,float vE,float vH, float vB)
        {
            DuraçãoTeste = duracao;
            ValorExatas = vE;
            ValorHumanas = vH;
            ValorBiologicas = vB;
        }

        public DetalhesTeste()
        {

        }



    }
}
