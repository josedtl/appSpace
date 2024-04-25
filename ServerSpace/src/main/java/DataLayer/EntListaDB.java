package DataLayer;

import EntityLayer.EntListaEntity;
import Enumerados.ProcessActionEnum;
import Framework.BaseDB;
import Framework.Inj;
import Framework.Utilidades;
import Framework.injector;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class EntListaDB extends BaseDB {

    public ArrayList<EntListaEntity> ObtenerCodigo(String codigo) {

        injector InjDB = new injector();
        ArrayList<EntListaEntity> DatoMemoria = new ArrayList<>();
        EntListaEntity en;
        try {
            InjDB.Sp("sp_EntListaObtenerCodigo");
            InjDB.Pmt_String("@Codigo", codigo, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new EntListaEntity();
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

    public ArrayList<EntListaEntity> GetListaRelacion_Main(String codigo) {
        injector InjDB = new injector();
        ArrayList<EntListaEntity> DatoMemoria = new ArrayList<>();
        EntListaEntity en;
        try {
            InjDB.Sp("sp_ListaRelacion_Main");
            InjDB.Pmt_String("@Codigo", codigo, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new EntListaEntity();
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

    public EntListaEntity Registrar(EntListaEntity entity) {
        Boolean State = null;
        try {
            Inj.IniciarTranssaccion(false);
            String Store = "sp_PersonaNatural_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_PersonaNatural_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("@ListaId", entity.getListaId(), true);
            Inj.Pmt_Integer("@CampoId", entity.getCampoId(), false);
            Inj.Pmt_String("@Codigo", entity.getCodigo(), false);
            Inj.Pmt_String("@Nombre", entity.getNombre(), false);
            Inj.Pmt_String("@Descripcion", entity.getDescripcion(), false);
            Inj.Pmt_String("@CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_String("@FechaRegistro", Utilidades.getFechaRegistro(), false);
            Inj.Pmt_Boolean("@EstadoRegistro", entity.getEstadoRegistro(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setListaId(Id);
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

}
