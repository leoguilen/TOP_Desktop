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
    
    public partial class tb_contato
    {
        public int userCont_in_id { get; set; }
        public int tipoCont_in_id { get; set; }
        public string cont_st_desc { get; set; }
    
        public virtual tb_tipoContato tb_tipoContato { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
    }
}