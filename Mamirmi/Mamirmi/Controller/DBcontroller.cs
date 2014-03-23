using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mamirmi.Data;
using System.Transactions;


namespace Mamirmi.Controller
{
    class DBcontroller
    {

        public string Insert_Empleado(Empleado nn)
        {
            string result=string.Empty;
            //using (TransactionScope scope = new TransactionScope())
            //{
            using (MamirmiEntities BDmodel = new MamirmiEntities())
            {
                var query = from x in BDmodel.Empleado
                            where x.carne == nn.carne && x.estado == true
                            select x;
                if (query==null)
                {
                    BDmodel.Empleado.Add(nn);
                    if (BDmodel.ChangeTracker.HasChanges())//double check if there was any change detected by EF or not?
                    {
                        BDmodel.SaveChanges();
                        result = "Correcto: Empleado Agregado con Exito";
                    }
                    else
                    {
                        result = "Error: Revisar datos de entrada";
                    }
                }
                else
                {
                    result = "Error: El carnet ingresado se encuentra en uso.";
                }
            }
            return result;
        }

        public string Update_Persona(Empleado newp)
        {
            using (MamirmiEntities BDmodel = new MamirmiEntities())
            {
                Empleado oldp = BDmodel.Empleado.SingleOrDefault(x=> x.ID==newp.ID);
                oldp.nombre = newp.nombre;
                oldp.apellidos = newp.apellidos;
                if (BDmodel.ChangeTracker.HasChanges())
                {
                    BDmodel.SaveChanges();
                    return "Correcto: Empleado Actualizado con Exito";
                }
                else
                {
                    return "Error: Revisar datos de entrada";
                }
            }
        }

        public object view_Personas(string input)
        {
            using (MamirmiEntities BDmodel = new MamirmiEntities())
            {
                var query = from x in BDmodel.Empleado
                            where x.nombre.Contains(input) || x.apellidos.Contains(input)
                            select new {x.nombre, x.apellidos};
                    
                //var query=BDmodel.Persona.Select( x=> new Persona {
                //    nombre= x.nombre,
                //    apellidos= x.apellidos
                //}).ToList();

                return query.ToList();
            }
        }

        public Empleado Get_Persona(string iD)
        {
            using (MamirmiEntities BDmodel = new MamirmiEntities())
            {
                Empleado query = BDmodel.Empleado.SingleOrDefault(x => x.ID == iD);
                return query;
            }
        }


    
    }
}
