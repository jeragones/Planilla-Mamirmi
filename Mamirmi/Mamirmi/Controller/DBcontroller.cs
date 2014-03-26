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

        public string Insert_Persona(Persona nn)
        {
            string result=string.Empty;
            //using (TransactionScope scope = new TransactionScope())
            //{
            using (MamirmiEntities BDmodel = new MamirmiEntities())
            {

                    BDmodel.Persona.Add(nn);
                    bool a = BDmodel.ChangeTracker.HasChanges(); //double check if there was any change detected by EF or not?
                    if (a)
                    {
                        BDmodel.SaveChanges();
                        result = "Correcto: Empleado Agregado con Exito";
                    }
                    else
                    {
                        result = "Error: Revisar datos de entrada";
                    }
            }
            //}
            return result;
        }

        public string Update_Persona(Persona newp)
        {
            using (MamirmiEntities BDmodel = new MamirmiEntities())
            {
                Persona oldp = BDmodel.Persona.SingleOrDefault(x=> x.ID==newp.ID);
                oldp.nombre = newp.nombre;
                oldp.apellidos = newp.apellidos;
                oldp.edad = newp.edad;
                oldp.EstadoCivil = newp.EstadoCivil;
                oldp.nacionalidad = newp.nacionalidad;
                oldp.direccion = newp.direccion;
                oldp.sexo = newp.sexo;
                oldp.Hijos = newp.Hijos;
                oldp.fecha_de_ingreso = newp.fecha_de_ingreso;
                bool a = BDmodel.ChangeTracker.HasChanges(); //double check if there was any change detected by EF or not?
                if (a)
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
                var query = from x in BDmodel.Persona
                            where x.nombre.Contains(input) || x.apellidos.Contains(input)
                            select new { x.nombre, x.apellidos };
                //var query=BDmodel.Persona.Select( x=> new Persona {
                //    nombre= x.nombre,
                //    apellidos= x.apellidos
                //}).ToList();
                
                List<Tuple<string,string>> my = new List<Tuple<string,string>>();
                String s = "";
                String m = "";
                var tuple = Tuple.Create("allam","bas");
                foreach (var item in query)
                {
                    s = item.nombre.ToString().ToUpper();
                    m = item.apellidos.ToString().ToUpper();
                    tuple = Tuple.Create(s,m);
                    my.Add(tuple);
                    s="";
                    m="";
                }
                var wordQuery = from word in my
                                select word;

                return wordQuery.ToList();
            }
        }

        public Persona Get_Persona(string nom,string ap)
        {
            using (MamirmiEntities BDmodel = new MamirmiEntities())
            {
                Persona query = BDmodel.Persona.SingleOrDefault(x => x.nombre == nom && x.apellidos == ap);
                return query;
            }
        }


    
    }
}
