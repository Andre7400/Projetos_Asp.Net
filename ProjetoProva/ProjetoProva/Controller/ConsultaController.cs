using ProjetoProva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProva.Controller
{
    public class ConsultaController
    {
        protected DadosBaseContainer contexto = new DadosBaseContainer();
        public void Adicionar(Consulta consulta)
        {
            if (consulta != null)
            {
                contexto.Consultas.Add(consulta);
                contexto.SaveChanges();
            }
        }
        public List<Consulta> Listar()
        {
           return contexto.Consultas.Where(c => c.Ativo == true).ToList();
        }
        public List<Consulta> ListarInativos()
        {
            return contexto.Consultas.Where(c => c.Ativo == false).ToList();
        }
        public Consulta BuscarConsultaPorID(int id)
        {
            return contexto.Consultas.Find(id);
        }
        public void Excluir(Consulta consulta)
        {
            consulta.Ativo = false;

            contexto.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public void Editar(Consulta consulta)
        {
            contexto.Entry(consulta).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}