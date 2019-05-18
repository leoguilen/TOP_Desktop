using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador.Classes.ObjetosBanco;
using Gerenciador.Entity;

namespace Gerenciador.Classes.ObjetosCrud
{
    class Contato
    {
        private bd_top bd;

        public int IDContato { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }

        public Contato(string tel, string cel)
        {
            Telefone = tel;
            Celular = cel;
        }

        public Contato(){}

        public void AdicionarContatos(string username, Contato cont)
        {
            bd = new bd_top();

            try
            {
                var retNovosContatos = bd.sp_inserirNovosContatos(username,cont.Telefone,cont.Celular);

                if (retNovosContatos >= 0)
                {
                    bd.SaveChanges();
                    bd.Dispose();
                }
                else
                {
                    throw new EntityException("Inserção de novo email falhou por algum motivo");
                }
            }
            catch (EntityCommandExecutionException entityCmdEx)
            {
                MessageBox.Show("Erro: " + entityCmdEx.Message + "Gerador do erro: " + entityCmdEx.Source);

            }
            catch (EntityException entityEX)
            {
                MessageBox.Show("Erro: " + entityEX.Message + "Gerador do erro: " + entityEX.Source);
            }

        }

    }
    
    class Email
    {
        private bd_top bd;

        public int IDEmail { get; private set; }
        public string DescEmail { get; private set; }
        public byte ReceberNoticias { get; private set; }

        public Email(string email)
        {
            DescEmail = email;
        }

        public Email(){}


        public void AdicionarEmail(string username,Email em)
        {
            bd = new bd_top();

            try
            {
                var retNovoEmail = bd.sp_inserirNovoEmail(username, em.DescEmail);

                if (retNovoEmail >= 0)
                {
                    bd.SaveChanges();
                    bd.Dispose();
                }
                else
                {
                    throw new EntityException("Inserção de novo email falhou por algum motivo");
                }
            } catch (EntityCommandExecutionException entityCmdEx) {
                MessageBox.Show("Erro: " + entityCmdEx.Message + "Gerador do erro: " + entityCmdEx.Source);

            } catch (EntityException entityEX) {
                MessageBox.Show("Erro: " + entityEX.Message + "Gerador do erro: " + entityEX.Source);
            }
        }
    }
    
    public class Usuario
    {
        private bd_top bd;

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public byte FezTeste { get; set; }
        public string ImagemPerfil { get; set; }
        public string Bio { get; set; }
        public int Nivel { get; set; }
        private Email email;
        private Contato contato;

        public Usuario(string nome, string sexo,DateTime dtnasc,string username,string senha,string uf,string cidade,int nivel,DateTime dtcad,byte teste,string imagem,string bio)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dtnasc;
            Username = Username;
            Senha = senha;
            Uf = uf;
            Cidade = cidade;
            Nivel = nivel;
            DataCadastro = dtcad;
            FezTeste = teste;
            ImagemPerfil = imagem;
            Bio = bio;
        }

        public Usuario(string nome, string sexo, DateTime dtnasc, string username, string uf, string cidade, int nivel)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dtnasc;
            Username = Username;
            Uf = uf;
            Cidade = cidade;
            Nivel = nivel;
        }

        public Usuario(){}

        public void AdicionarUsuario(Usuario us, string mail,string tel,string cel)
        {
            bd = new bd_top();

            try
            {

                var retNovoUser = bd.sp_inserirNovoUsuario(us.Nome, us.Sexo, us.DataNascimento,
                                                                  us.Username, us.Senha, us.Uf,
                                                                  us.Cidade,us.Nivel,us.DataCadastro,
                                                                  us.FezTeste,us.ImagemPerfil,us.Bio);
                
                if(retNovoUser <= 0)
                {
                    contato = new Contato(tel,cel);
                    email = new Email(mail);
                    email.AdicionarEmail(us.Username, email);
                    contato.AdicionarContatos(us.Username, contato);

                    bd.SaveChanges();
                    bd.Dispose();

                } else {
                    throw new EntityException("Inserção de novo usuario falhou por algum motivo");
                }

            }
            catch (EntityCommandExecutionException entityCmdEx)
            {
                MessageBox.Show("Erro: " + entityCmdEx.Message + "Gerador do erro: " + entityCmdEx.Source);
            }
            catch (EntityException entityEX)
            {
                MessageBox.Show("Erro: " + entityEX.Message + "Gerador do erro: " + entityEX.Source);
            }
        }

        public int RetornarID(string username)
        {
            bd = new bd_top();
            int Id = 0;

            foreach (var itemId in from id in bd.tb_usuario.Where(i=>i.user_st_username.Contains(username)) select new {id.user_in_id})
            {
                Id = itemId.user_in_id;
            }

            return Id;
        }

        public List<Usuario> BuscarUsuario(string nome)
        {
            bd = new bd_top();
            List<Usuario> users = new List<Usuario>();
            var buscaUs = from us in bd.tb_usuario  where us.user_st_username.Contains(nome) select us;

            foreach (var lista_us in buscaUs)
            {
                Usuario usu = new Usuario()
                {
                    ID = lista_us.user_in_id,
                    Nome = lista_us.user_st_nome,
                    Sexo = lista_us.user_st_sexo,
                    DataNascimento = lista_us.user_dt_dtNasc,
                    Username = lista_us.user_st_username,
                    Uf = lista_us.user_st_uf,
                    Cidade = lista_us.user_st_cidade,
                    Nivel = lista_us.user_in_nivelAcad,
                    DataCadastro = lista_us.user_dt_dtCad
                };

                users.Add(usu);
            }

            return users;
        }
        
    }

    
}
