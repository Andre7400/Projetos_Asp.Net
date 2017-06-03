using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ProjetoProva.Controller
{
    public class MedicoController
    {
        protected DadosBaseContainer contexto = new DadosBaseContainer();
        public void Adicionar(Medico medico)
        {
            if (medico != null)
            {
                contexto.Medicos.Add(medico);
                contexto.SaveChanges();
            }
        }
        public List<Medico> Listar()
        {
            return contexto.Medicos.Where(c => c.Ativo == true).ToList();
        }
        public List<Medico> ListarInativos()
        {
            return contexto.Medicos.Where(c => c.Ativo == false).ToList();
        }
        public Medico BuscarMedicoPorID(int id)
        {
            return contexto.Medicos.Find(id);
        }
        public void Excluir(Medico medico)
        {
            medico.Ativo = false;

            contexto.Entry(medico).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public void Editar(Medico medico)
        {
            contexto.Entry(medico).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}