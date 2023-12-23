using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Datos.Conexion;
using Space.EntityLayer;


namespace Space.DataLayer
{

    public class EntDatoDB
    {
 
        public EntDatoEntity Save(EntDatoEntity Ent)
        {
            DatabaseManager dbManager = new DatabaseManager();

            String NameStore = "up_EntDato_Insert";
            if (Ent.EntDatoId > 0) NameStore = "up_EntDato_UpdateByKey";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@EntDatoId", Ent.EntDatoId)
            {
                Direction= ParameterDirection.InputOutput,
                SqlDbType= SqlDbType.Int
            },
            new SqlParameter("@EntidadId", Ent.EntidadId),
            new SqlParameter("@ValorAlfaNumerico", Ent.ValorAlfaNumerico),
            new SqlParameter("@ValorFecha",Ent.ValorFecha),
            new SqlParameter("@ListaRelacionId", Ent.ListaRelacionId),
            new SqlParameter("@EntCampoId",Ent.EntCampoId),
            };


            Ent.EntidadId = dbManager.ProcedimientoSave(NameStore, parametros, "@EntDatoId");



       
            return Ent;

        }
    }

}