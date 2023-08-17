package DataLayer;

import EntityLayer.DepartamentoEntity;;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class DepartamentoDB {

    injector Inj = new injector();

    public ArrayList<DepartamentoEntity> GetAllItems() { 

        ArrayList<DepartamentoEntity> DatoMemoria = new ArrayList<>();
        DepartamentoEntity en;
        try {
            Inj.Sp("sp_DepartamentoAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new DepartamentoEntity();
                en.setDepartamentoId(rs.getInt("DepartamentoId"));
                en.setCodDepartamento(rs.getInt("CodDepartamento"));
                en.setNomDepartamento(rs.getString("NomDepartamento"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<DepartamentoEntity> GetAllItem(int DepartamentoId) { 

        ArrayList<DepartamentoEntity> DatoMemoria = new ArrayList<>();
        DepartamentoEntity en;
        try {
            Inj.Sp("sp_DepartamentoAllItem");
            Inj.Pmt_Integer("v_DepartamentoId", DepartamentoId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new DepartamentoEntity();
                en.setDepartamentoId(rs.getInt("DepartamentoId"));
                en.setCodDepartamento(rs.getInt("CodDepartamento"));
                en.setNomDepartamento(rs.getString("NomDepartamento"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public DepartamentoEntity Save(DepartamentoEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_Departamento_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_Departamento_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_DepartamentoId", entity.getDepartamentoId(), true);
            Inj.Pmt_Integer("v_CodDepartamento", entity.getCodDepartamento(), false);
            Inj.Pmt_String("v_NomDepartamento", entity.getNomDepartamento(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setDepartamentoId(Id);
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

    public Boolean Delete(Integer Id) {

        Boolean State = false;
        try {
            Inj.Sp("sp_DepartamentoDelete");
            Inj.Pmt_Integer("v_DepartamentoId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
