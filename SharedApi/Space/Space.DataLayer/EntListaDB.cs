﻿using Framework;
using Space.Common;
using Space.EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace Space.DataLayer
{
    public class EntListaDB : BaseDataEntity
    {
        public virtual List<EntListaEntity> ObtenerCodigo(String codigo)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 20, false, 0, 0, codigo);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_EntListaObtenerCodigo");
                FillSchemeTable(dr);
                List<EntListaEntity> EntityList = new List<EntListaEntity>();
                while (dr.Read())
                {
                    EntListaEntity entity = new EntListaEntity();
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

        public virtual List<EntListaEntity> GetListaRelacion_Main(String codigo)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 20, false, 0, 0, codigo);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_ListaRelacion_Main");
                FillSchemeTable(dr);
                List<EntListaEntity> EntityList = new List<EntListaEntity>();
                while (dr.Read())
                {
                    EntListaEntity entity = new EntListaEntity();
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

        public virtual bool Registrar(EntListaEntity Ent)
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
        
        private bool RegistrarDB(EntListaEntity Ent)
        {
            if (Ent.LogicalState == LogicalState.Added || Ent.LogicalState == LogicalState.Updated)
            {
                String storedName = "sp_EntListaActualizar";
                if (Ent.LogicalState == LogicalState.Added) storedName = "sp_EntListaRegistrar";
                DbDatabase.GetStoredProcCommand(storedName);
                DbDatabase.SetTransaction(Helper.DbTransaction);

                DbDatabase.AddParameter(MyUtils.GetOutputDirection(true), "ListaId", DbType.Int32, 4, false, 0, 0, Ent.ListaId);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "CodigoCampo", DbType.String, 120, false, 0, 0, Ent.Codigo);
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
        public virtual List<EntListaEntity> GetListaRelacionLike(String codigo, String Nombre)
        {
            try
            {
                StartHelper(false);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Codigo", DbType.String, 20, false, 0, 0, codigo);
                DbDatabase.AddParameter(MyUtils.GetOutputDirection(false), "Nombre", DbType.String, 20, false, 0, 0, Nombre);
                IDataReader dr = (IDataReader)DbDatabase.ExecuteReader(CommandType.StoredProcedure, "sp_ListaGenericaSelectCodigoLike");
                FillSchemeTable(dr);
                List<EntListaEntity> EntityList = new List<EntListaEntity>();
                while (dr.Read())
                {
                    EntListaEntity entity = new EntListaEntity();
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
