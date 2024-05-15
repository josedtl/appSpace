using Framework;
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
    public class TarifaDB : BaseDB
    {
        public List<TarifaEntity> ObtenerMain()
        {
            try
            {

                List<TarifaEntity> ListaData = new List<TarifaEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_TarifaObtenerMain");
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    TarifaEntity entity = new TarifaEntity();
                    if (FillFrom<TarifaEntity>(reader, entity)) ListaData.Add(entity);
                }
                reader.Close();
                Conexion.CloseConnection();
                return ListaData;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }

        public Int32 Registrar(TarifaEntity Ent)
        {
            try
            {

                String NameStore = "sp_TarifaRegistrar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("TarifaId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.TarifaId);
                Conexion.AddParemeter("ObjetoRefereciaId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.ObjetoReferenciaId);
                Conexion.AddParemeter("Correlativo", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Correlativo);
                Conexion.AddParemeter("MonedaId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.MonedaId);
                Conexion.AddParemeter("TipoTarifaEnum", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoTarifaEnum);
                Conexion.AddParemeter("UnidadMedidaId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.UnidadMedidaId);
                Conexion.AddParemeter("CostoTarifa", SqlDbType.Decimal, 17, ParameterDirection.Input, Ent.CostoTarifa);
                Conexion.AddParemeter("NomTarifa", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.NomTarifa);
                Conexion.AddParemeter("NomComercial", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.NomComercial);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("EstadoRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.EstadoRegistro);
                Ent.TarifaId = Conexion.ExecuteQueryItem("TarifaId");

                return Ent.TarifaId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }

        public Int32 Actualizar(TarifaEntity Ent)
        {
            try
            {

                String NameStore = "sp_TarifaActualizar";

                Conexion.Store(NameStore);
                Conexion.AddParemeter("TarifaId", SqlDbType.Int, 10, ParameterDirection.InputOutput, Ent.TarifaId);
                Conexion.AddParemeter("ObjetoRefereciaId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.ObjetoReferenciaId);
                Conexion.AddParemeter("Correlativo", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Correlativo);
                Conexion.AddParemeter("MonedaId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.MonedaId);
                Conexion.AddParemeter("TipoTarifaEnum", SqlDbType.Int, 10, ParameterDirection.Input, Ent.TipoTarifaEnum);
                Conexion.AddParemeter("UnidadMedidaId", SqlDbType.Int, 10, ParameterDirection.Input, Ent.UnidadMedidaId);
                Conexion.AddParemeter("CostoTarifa", SqlDbType.Int, 10, ParameterDirection.Input, Ent.CostoTarifa);
                Conexion.AddParemeter("NomTarifa", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.NomTarifa);
                Conexion.AddParemeter("NomComercial", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.NomComercial);
                Conexion.AddParemeter("Descripcion", SqlDbType.VarChar, 200, ParameterDirection.Input, Ent.Descripcion);
                Conexion.AddParemeter("FechaRegistro", SqlDbType.DateTime, 15, ParameterDirection.Input, Ent.FechaRegistro);
                Conexion.AddParemeter("CodUsuario", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.CodUsuario);
                Conexion.AddParemeter("EstadoRegistro", SqlDbType.VarChar, 20, ParameterDirection.Input, Ent.EstadoRegistro);
                Ent.TarifaId = Conexion.ExecuteQueryItem("TarifaId");

                return Ent.TarifaId;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }

        }

        public List<TarifaEntity> ObtenerItem(Int32 TarifaId)
        {
            try
            {

                List<TarifaEntity> ListaData = new List<TarifaEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_TarifaObtenerItem");
                Conexion.AddParemeter("TarifaId", SqlDbType.Int, 10, ParameterDirection.Input, TarifaId);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    TarifaEntity entity = new TarifaEntity();
                    if (FillFrom<TarifaEntity>(reader, entity)) ListaData.Add(entity);
                }
                reader.Close();
                return ListaData;
            }
            catch (Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }

        public List<TarifaEntity> BuscarRecurso(String Nombre,int Tipo)
        {
            try
            {
                List<TarifaEntity> ListaData = new List<TarifaEntity>();
                Conexion.OpenConnection();
                Conexion.Store("sp_TarifaBuscarRecurso");
                Conexion.AddParemeter("Nombre", SqlDbType.VarChar, 50, ParameterDirection.Input, Nombre);
                Conexion.AddParemeter("Tipo", SqlDbType.Int, 10, ParameterDirection.Input, Tipo);
                SqlDataReader reader = Conexion.ReaderData();
                FillSchemeTable(reader);
                while (reader.Read())
                {
                    TarifaEntity entity = new TarifaEntity();
                    if (FillFrom<TarifaEntity>(reader, entity)) ListaData.Add(entity);
                }
                reader.Close();
                return ListaData;
            }
            catch(Exception ex)
            {
                Conexion.Restore();
                throw ex;
            }
        }
    }
}
