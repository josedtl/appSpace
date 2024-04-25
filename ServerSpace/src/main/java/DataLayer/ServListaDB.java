package DataLayer;


import EntityLayer.ServListaEntity;
import Enumerados.ProcessActionEnum;
import Framework.BaseDB;
import Framework.Inj;
import Framework.Utilidades;
import Framework.injector;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class ServListaDB extends BaseDB {
    public ArrayList<ServListaEntity> ObtenerCodigo(String codigo) {

        injector InjDB = new injector();
        ArrayList<ServListaEntity> DatoMemoria = new ArrayList<>();
        ServListaEntity en;
        try {
            InjDB.Sp("sp_ServListaObtenerCodigo");
            InjDB.Pmt_String("@Codigo", codigo, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new ServListaEntity();
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


    public ArrayList<ServListaEntity> Buscar(String codigo, String Nombre){

        injector InjDB = new injector();
        ArrayList<ServListaEntity> DatoMemoria = new ArrayList<>();
        ServListaEntity en;
        try {
            InjDB.Sp("sp_ServListaBuscar");
            InjDB.Pmt_String("@Codigo", codigo, false);
            InjDB.Pmt_String("@Nombre", Nombre, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new ServListaEntity();
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

    public ArrayList<ServListaEntity> ObtenerMain(String codigo) {

        injector InjDB = new injector();
        ArrayList<ServListaEntity> DatoMemoria = new ArrayList<>();
        ServListaEntity en;
        try {
            InjDB.Sp("sp_ServListaObtenerMain");
            InjDB.Pmt_String("@Codigo", codigo, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new ServListaEntity();
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


    
    public ServListaEntity Registrar(ServListaEntity entity) {
        Boolean State = null;
        try {
            Inj.IniciarTranssaccion(false);
            String Store = "sp_ServListaRegistrar";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_ServListaActualizar";
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


    public ArrayList<ServListaEntity> ObtenerItem(int ListaId) {

        injector InjDB = new injector();
        ArrayList<ServListaEntity> DatoMemoria = new ArrayList<>();
        ServListaEntity en;
        try {
            InjDB.Sp("sp_ServListaObtenerItem");
            InjDB.Pmt_Integer("@ListaId", ListaId, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new ServListaEntity();
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
