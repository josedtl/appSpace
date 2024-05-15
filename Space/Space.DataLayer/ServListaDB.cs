using Framework;
using Space.Common;
using Space.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.DataLayer
{
    public class ServListaDB : BaseDataEntity
    {
        public virtual List<ServListaEntity> ObtenerServListaCodigo(String codigo)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 30, false, 0, 0, codigo);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_ServListaObtenerCodigo");
                FillSchemeTable(dr);
                List<ServListaEntity> EntityList = new List<ServListaEntity>();
                while (dr.Read())
                {
                    ServListaEntity entity = new ServListaEntity();
                    if (FillFrom(dr, entity)) EntityList.Add(entity);
                    entity.OnLogicalLoaded();
                }

                Helper.Close(dr);
                return EntityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual List<ServListaEntity> BuscarServLista(String codigo, String Nombre)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 20, false, 0, 0, codigo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Nombre", DbType.String, 20, false, 0, 0, Nombre);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_ServListaBuscar");
                FillSchemeTable(dr);
                List<ServListaEntity> EntityList = new List<ServListaEntity>();
                while (dr.Read())
                {
                    ServListaEntity entity = new ServListaEntity();
                    if (FillFrom(dr, entity)) EntityList.Add(entity);
                    entity.OnLogicalLoaded();
                }

                Helper.Close(dr);
                return EntityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual List<ServListaEntity> ObtenerServListaMain(String codigo)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 20, false, 0, 0, codigo);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_ServListaObtenerMain");
                FillSchemeTable(dr);
                List<ServListaEntity> EntityList = new List<ServListaEntity>();
                while (dr.Read())
                {
                    ServListaEntity entity = new ServListaEntity();
                    if (FillFrom(dr, entity)) EntityList.Add(entity);
                    entity.OnLogicalLoaded();
                }

                Helper.Close(dr);
                return EntityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool Registrar(ServListaEntity Ent)
        {
            StartHelper(true);
            try
            {
                RegistrarDB(Ent);
            }
            catch (Exception ex)
            {
                Helper.CancelTransaction();
                throw ex;
            }

            Helper.Close();
            return true;
        }
        private bool RegistrarDB(ServListaEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_ServListaActualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_ServListaRegistrar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);

                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "ListaId", DbType.Int32, 4, false, 0, 0, Ent.ListaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodigoCampo", DbType.String, 120, false, 0, 0, Ent.CodigoCampo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.Int32, 250, false, 0, 0, Ent.Codigo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Nombre", DbType.String, 250, false, 0, 0, Ent.Nombre);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Descripcion", DbType.String, 250, false, 0, 0, Ent.Descripcion);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "FechaRegistro", DbType.DateTime, 8, false, 0, 0, Ent.FechaRegistro);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodUsuario", DbType.String, 20, false, 0, 0, Ent.CodUsuario);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "EstadoRegistro", DbType.Boolean, 1, false, 0, 0, Ent.EstadoRegistro);
                int returnValue = DbDatabase.ExecuteNonQuery();
                if (Ent.LogicalState == LogicalState.Added)
                {
                    if (Ent.ListaId <= 0) Ent.ListaId = (Int32)DbDatabase.GetParameterValue("ListaId");
                    Ent.OnLogicalAdded();
                }
                else
                {
                    if (returnValue <= 0) throw new Exception("ErrorDB.UpdateEntity");
                    Ent.OnLogicalUpdate();
                }
            }


            return true;
        }
        public virtual List<ServListaEntity> ObtenerServListaItem(Int32 ListaId)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 30, false, 0, 0, ListaId);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_ServListaObtenerItem");
                FillSchemeTable(dr);
                List<ServListaEntity> EntityList = new List<ServListaEntity>();
                while (dr.Read())
                {
                    ServListaEntity entity = new ServListaEntity();
                    if (FillFrom(dr, entity)) EntityList.Add(entity);
                    entity.OnLogicalLoaded();
                }

                Helper.Close(dr);
                return EntityList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    }
}
