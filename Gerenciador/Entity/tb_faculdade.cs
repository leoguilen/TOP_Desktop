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
    
    public partial class tb_faculdade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_faculdade()
        {
            this.tb_contatoFaculdade = new HashSet<tb_contatoFaculdade>();
            this.tb_notaMec = new HashSet<tb_notaMec>();
        }
    
        public int facul_in_id { get; set; }
        public string facul_st_nome { get; set; }
        public string facul_st_endereco { get; set; }
        public string facul_st_uf { get; set; }
        public string facul_st_estado { get; set; }
        public string facul_st_cidade { get; set; }
        public string facul_st_site { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_contatoFaculdade> tb_contatoFaculdade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_notaMec> tb_notaMec { get; set; }
    }
}