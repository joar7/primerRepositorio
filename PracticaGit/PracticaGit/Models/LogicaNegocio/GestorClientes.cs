using PracticaGit.Models.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaGit.Models.LogicaNegocio
{
    public class GestorClientes
    {
        RepositorioClientes repoClientes = new RepositorioClientes();

        public List<Persona> Listar()
        {
            return repoClientes.Listar();
        }

        
        public void Guardar(Persona persona)
        {
            repoClientes.Guardar(persona);
        }

        public void Eliminar(int id)
        {
            repoClientes.Eliminar(id);
        }
        
        
        public Persona ObtenerPorId(int id)
        {
            return repoClientes.ObtenerPorId(id);
        }

        public void Modificar(Persona persona)
        {

            repoClientes.Modificar(persona);
        }

        public List<Persona> Buscar(string parametroBusqueda)
        {
            return repoClientes.Buscar(parametroBusqueda);
        }
        
    }
}