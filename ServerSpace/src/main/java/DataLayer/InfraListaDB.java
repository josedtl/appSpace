package DataLayer;

import EntityLayer.InfraListaEntity;
import EntityLayer.InfraListaEntity;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import Framework.BaseDB;
import Framework.Inj;
import Framework.Utilidades;


public class InfraListaDB extends BaseDB{


   public ArrayList<InfraListaEntity> ObtenerCodigo(String codigo) {

        injector InjDB = new injector();
        ArrayList<InfraListaEntity> DatoMemoria = new ArrayList<>();
        InfraListaEntity en;
        try {
            InjDB.Sp("sp_InfraListaObtenerItemsCodigo");
            InjDB.Pmt_String("@Codigo", codigo, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new InfraListaEntity();
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


    public ArrayList<InfraListaEntity> Buscar(String codigo, String Nombre){

        injector InjDB = new injector();
        ArrayList<InfraListaEntity> DatoMemoria = new ArrayList<>();
        InfraListaEntity en;
        try {
            InjDB.Sp("sp_InfraListaBuscarItemCodigo");
            InjDB.Pmt_String("@Codigo", codigo, false);
            InjDB.Pmt_String("@Nombre", Nombre, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new InfraListaEntity();
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

    public ArrayList<InfraListaEntity> ObtenerMain(String codigo) {

        injector InjDB = new injector();
        ArrayList<InfraListaEntity> DatoMemoria = new ArrayList<>();
        InfraListaEntity en;
        try {
            InjDB.Sp("sp_InfraListaObtenerMain");
            InjDB.Pmt_String("@Codigo", codigo, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new InfraListaEntity();
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


    
    public InfraListaEntity Registrar(InfraListaEntity entity) {
        Boolean State = null;
        try {
            Inj.IniciarTranssaccion(false);
            String Store = "sp_InfraListaRegistrar";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_InfraListaActualizar";
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


    public ArrayList<InfraListaEntity> ObtenerItem(int ListaId) {

        injector InjDB = new injector();
        ArrayList<InfraListaEntity> DatoMemoria = new ArrayList<>();
        InfraListaEntity en;
        try {
            InjDB.Sp("sp_InfraListaObtenerItem");
            InjDB.Pmt_Integer("@ListaId", ListaId, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new InfraListaEntity();
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
