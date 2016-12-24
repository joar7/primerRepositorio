using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PracticaGit.Models.AccesoDatos
{
    public class RepositorioClientes
    {
        TallerDB baseDatos = new TallerDB();

        public List<Persona> Listar()
        {
            return baseDatos.Persona.ToList();
        }

    
        public void Guardar(Persona persona)
        {
            baseDatos.Persona.Add(persona);
            baseDatos.SaveChanges();
        }
      

        public void Eliminar(int id)
        {
           
        }

        public Persona ObtenerPorId(int id)
        {
            return null;
        }

        public void Modificar(Persona persona)
        {

        }

        public List<Persona> Buscar(string parametroBusqueda)
        {
            return null;
        }
    }
}