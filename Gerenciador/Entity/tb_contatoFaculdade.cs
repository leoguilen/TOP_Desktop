//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gerenciador.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_contatoFaculdade
    {
        public int faculCont_in_id { get; set; }
        public int tipoContFacul_in_id { get; set; }
        public string contFacul_st_desc { get; set; }
    
        public virtual tb_faculdade tb_faculdade { get; set; }
        public virtual tb_tipoContatoFaculdade tb_tipoContatoFaculdade { get; set; }
    }
}