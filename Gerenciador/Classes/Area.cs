using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Classes
{
    public class Area
    {
        private bd_top bd;

        public int IDArea { get; private set; }
        public string DescriçãoArea { get; private set; }

        public Area(int id,string desc)
        {
            IDArea = id;
            DescriçãoArea = desc;
        }

        public Area(){}

        public List<tb_curso> ListarCursosPorArea(int area)
        {
            bd = new bd_top();

            List<tb_curso> _listCurso = new List<tb_curso>();

            var buscarCurso = from cur in bd.tb_curso
                              .Where(c => c.areaCur_in_id == area)
                              select cur;

            foreach (var curso in buscarCurso)
            {
                _listCurso.Add(curso);
            }

            return _listCurso;

        }

    }
}
