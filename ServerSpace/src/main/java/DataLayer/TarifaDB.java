package DataLayer;

import EntityLayer.EntidadEntity;
import EntityLayer.TarifaEntity;
import Enumerados.ProcessActionEnum;
import Framework.BaseDB;
import Framework.Inj;
import Framework.Utilidades;
import Framework.injector;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class TarifaDB extends BaseDB {

    injector InjDB = new injector();

    public ArrayList<TarifaEntity> ObtenerMain() {

        ArrayList<TarifaEntity> DatoMemoria = new ArrayList<>();
        TarifaEntity en;
        try {
            InjDB.Sp("sp_TarifaObtenerMain");
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new TarifaEntity();
                if (fillFrom(rs, en)) {
                    DatoMemoria.add(en);
                }
            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public TarifaEntity Registrar(TarifaEntity entity) {
        Boolean State = null;
        try {
            Inj.IniciarTranssaccion(false);
            String Store = "sp_TarifaRegistrar";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_TarifaActualizar";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("@TarifaId", entity.getTarifaId(), true);
            Inj.Pmt_Integer("@ObjetoRefereciaId", entity.getObjetoReferenciaId(), false);
            Inj.Pmt_String("@Correlativo", entity.getCorrelativo(), false);
            Inj.Pmt_Integer("@MonedaId", entity.getMonedaId(), false);
            Inj.Pmt_Integer("@TipoTarifaEnum", entity.getTipoTarifaEnum(), false);
            Inj.Pmt_Integer("@UnidadMedidaId", entity.getUnidadMedidaId(), false);
            Inj.Pmt_Double("@CostoTarifa", entity.getCostoTarifa(), false);
            Inj.Pmt_String("@NomTarifa", entity.getNomTarifa(), false);
            Inj.Pmt_String("@NomComercial", entity.getNomComercial(), false);
            Inj.Pmt_String("@Descripcion", entity.getDescripcion(), false);
            Inj.Pmt_String("@FechaRegistro", Utilidades.getFechaRegistro(), false);
            Inj.Pmt_String("@CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("@EstadoRegistro", entity.getEstadoRegistro(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setTarifaId(Id);
                }
            }
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Inj.RunUpdate();
            }

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return entity;
    }

    public ArrayList<TarifaEntity> ObtenerItem(int TarifaId) {

        ArrayList<TarifaEntity> DatoMemoria = new ArrayList<>();
        TarifaEntity en;
        try {
            InjDB.Sp("sp_TarifaObtenerItem");
            InjDB.Pmt_Integer("@TarifaId", TarifaId, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new TarifaEntity();
                if (fillFrom(rs, en)) {
                    DatoMemoria.add(en);
                }
            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<TarifaEntity> BuscarRecurso(String Nombre, int Tipo) {

        ArrayList<TarifaEntity> DatoMemoria = new ArrayList<>();
        TarifaEntity en;
        try {
            InjDB.Sp("sp_TarifaBuscarRecurso");
            InjDB.Pmt_String("@Nombre", Nombre, false);
            InjDB.Pmt_Integer("@Tipo", Tipo, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new TarifaEntity();
                if (fillFrom(rs, en)) {
                    DatoMemoria.add(en);
                }
            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
    
    public ArrayList<TarifaEntity> GetTarifaBuscarItem(String NomComercial) {
        injector InjDB = new injector();
        ArrayList<TarifaEntity> DatoMemoria = new ArrayList<>();
        TarifaEntity en;
        try {
            InjDB.Sp("sp_TarifaBuscarItem");
            InjDB.Pmt_String("@NomComercial", NomComercial , false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new TarifaEntity();
                if (fillFrom(rs, en)) {
                    DatoMemoria.add(en);
                }
            }
        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
}
