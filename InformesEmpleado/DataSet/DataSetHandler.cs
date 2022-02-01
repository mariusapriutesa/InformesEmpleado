using InformesEmpleado.DataSet._2dam03DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformesEmpleado.DataSet
{
    class DataSetHandler
    {
        private static InformeTableAdapter adapter = new InformeTableAdapter();

        public static void GetByIdDpto(int id_dpto) {

            var data = adapter.GetDataByIdDpto(id_dpto);
        
        }



            }
}
