using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEvaluacion.DTO;

namespace LibreriaEvaluacion.DAL
{
    public class PrestamoDAL
    {
        // ToDo: métodos

        //Insertar
        public bool Insertar(PrestamoDTO datos)
        {
            return PrestamoDTO.Add(datos);
        }

        //Actualizar
        public bool Actualizar(PrestamoDTO datos)
        {
            int indice = BuscarPorIdSimple(dato.Id); 
            return PrestamoDTO.Edit(datos, indice);  
        }

        //Eliminar
        public bool Eliminar(PrestamoDTO datos)
        {

        }

        //Listar
        public List<PrestamoDTO> Listar()
        {
            return PrestamoDTO.datos;
        }

        //Buscar por ID
        public int BuscarPorIdSimple(int id)
        {
            for (int i = 0; i < PrestamoDTO.List().Count; i++)
            {
                // si encuentra elemento
                if (PrestamoDTO.List()[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


        //Eliminar por indice
        public bool EliminarPorIndice(int indice)
        {
            return PrestamoDTO.RemoveAtIndex(indice);
        }

        //Buscar por ID
        public PrestamoDTO? BuscarPorId(int id)
        {
            foreach (PrestamoDTO datos in PrestamoDTO.List())
            {
                if (datos.Id == id) { return datos; }
            }
            return null;
        }

        

















    }
}
