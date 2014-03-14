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

        public void InsertPersona()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                MamirmiEntities BDmodel = new MamirmiEntities();
                Persona nn = new Persona();
                nn.id = "123456789012";
                nn.nombre = "Daniel";
                nn.apellidos="Murillo Porras";
                nn.edad=18;
                nn.nacionalidad="cr";
                nn.direccion="santa clara";
                nn.sexo="M";
                nn.Hijos=3;
                nn.fecha_de_ingreso="13/03/2014";
                BDmodel.Persona.Add(nn);
                BDmodel.SaveChanges();
             }
        }
    }
}
