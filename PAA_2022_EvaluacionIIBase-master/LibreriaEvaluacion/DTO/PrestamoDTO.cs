using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    public class PrestamoDTO
    {
        // ToDo: atributos
        private int id;
        private int monto;


        public static List<PrestamoDTO> datos = new List<PrestamoDTO>()
        {
            new PrestamoDTO() { id = 1, monto = 50000 },
            new PrestamoDTO() { id = 2, monto = 100000 },
            new PrestamoDTO() { id = 3, monto = 150000 }
        };
       
        public int Id { get => id; set => id = value; }
        public int Monto { get => monto; set => monto = value; }

        // ToDo: propiedades



        // ToDo: métodos
        public static bool Add(PrestamoDTO datos)
        {
            try
            {
                datos.Add(datos);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<PrestamoDTO> List()
        {
            return datos;
        }
        public static int Find(int id)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        } 

        public static PrestamoDTO Find(PrestamoDTO datos)
        {
            for(int i = 0; i < datos.Count; i++)
            {
                if(datos[i].Id == datos.Id)
                {
                    return (PrestamoDTO)datos[i];
                }
            }
            return new PrestamoDTO();
        }

        public static bool Edit(PrestamoDTO datos, int index)
        {
            try
            {
                datos[indice] = datos;
                return true;
            }catch (Exception)
            {
                return false;
            }
        }

        public static bool RemoveAtIndex(PrestamoDTO datos, int index)
        {
           
        }

        public static bool RemoveById(PrestamoDTO datos, int index)
        {

        }

        public override string ToString()
        {
            return $"Id: {id}, Monto: {monto}, Monto con Interes: {MontoMasInteres}, Monto Con Interes y Atraso{} ";
        }









        

        
            
            
        
    }
}
