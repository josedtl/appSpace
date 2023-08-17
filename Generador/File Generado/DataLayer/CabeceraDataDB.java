package DataLayer;

import EntityLayer.CabeceraDataEntity;;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class CabeceraDataDB {

    injector Inj = new injector();

    public ArrayList<CabeceraDataEntity> GetAllItems() { 

        ArrayList<CabeceraDataEntity> DatoMemoria = new ArrayList<>();
        CabeceraDataEntity en;
        try {
            Inj.Sp("sp_CabeceraDataAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new CabeceraDataEntity();
                en.setCabeceraDataId(rs.getInt("CabeceraDataId"));
                en.setCantidadEntera(rs.getInt("CantidadEntera"));
                en.setCantidadDecimal(rs.getInt("CantidadDecimal"));
                en.setCantidadNumerico(rs.getInt("CantidadNumerico"));
                en.setCantidadEnteraSmall(rs.getInt("CantidadEnteraSmall"));
                en.setLetrasGrande(rs.getString("LetrasGrande"));
                en.setLetrasMedia(rs.getString("LetrasMedia"));
                en.setLetrasPequena(rs.getString("LetrasPequena"));
                en.setLetrasPequenaSmall(rs.getString("LetrasPequenaSmall"));
                en.setLetrasPequenaSmallUno(rs.getString("LetrasPequenaSmallUno"));
                en.setFecha(rs.getInt("Fecha"));
                en.setFechaSola(rs.getInt("FechaSola"));
                en.setEstado(rs.getInt("Estado"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<CabeceraDataEntity> GetAllItem(int CabeceraDataId) { 

        ArrayList<CabeceraDataEntity> DatoMemoria = new ArrayList<>();
        CabeceraDataEntity en;
        try {
            Inj.Sp("sp_CabeceraDataAllItem");
            Inj.Pmt_Integer("v_CabeceraDataId", CabeceraDataId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new CabeceraDataEntity();
                en.setCabeceraDataId(rs.getInt("CabeceraDataId"));
                en.setCantidadEntera(rs.getInt("CantidadEntera"));
                en.setCantidadDecimal(rs.getInt("CantidadDecimal"));
                en.setCantidadNumerico(rs.getInt("CantidadNumerico"));
                en.setCantidadEnteraSmall(rs.getInt("CantidadEnteraSmall"));
                en.setLetrasGrande(rs.getString("LetrasGrande"));
                en.setLetrasMedia(rs.getString("LetrasMedia"));
                en.setLetrasPequena(rs.getString("LetrasPequena"));
                en.setLetrasPequenaSmall(rs.getString("LetrasPequenaSmall"));
                en.setLetrasPequenaSmallUno(rs.getString("LetrasPequenaSmallUno"));
                en.setFecha(rs.getInt("Fecha"));
                en.setFechaSola(rs.getInt("FechaSola"));
                en.setEstado(rs.getInt("Estado"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public CabeceraDataEntity Save(CabeceraDataEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_CabeceraData_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_CabeceraData_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_CabeceraDataId", entity.getCabeceraDataId(), true);
            Inj.Pmt_Integer("v_CantidadEntera", entity.getCantidadEntera(), false);
            Inj.Pmt_Double("v_CantidadDecimal", entity.getCantidadDecimal(), false);
            Inj.Pmt_Double("v_CantidadNumerico", entity.getCantidadNumerico(), false);
            Inj.Pmt_Integer("v_CantidadEnteraSmall", entity.getCantidadEnteraSmall(), false);
            Inj.Pmt_String("v_LetrasGrande", entity.getLetrasGrande(), false);
            Inj.Pmt_String("v_LetrasMedia", entity.getLetrasMedia(), false);
            Inj.Pmt_String("v_LetrasPequena", entity.getLetrasPequena(), false);
            Inj.Pmt_String("v_LetrasPequenaSmall", entity.getLetrasPequenaSmall(), false);
            Inj.Pmt_String("v_LetrasPequenaSmallUno", entity.getLetrasPequenaSmallUno(), false);
            Inj.Pmt_Date("v_Fecha", new java.sql.Date(entity.getFecha().getTime()), false);
            Inj.Pmt_Date("v_FechaSola", new java.sql.Date(entity.getFechaSola().getTime()), false);
            Inj.Pmt_Boolean("v_Estado", entity.getEstado(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setCabeceraDataId(Id);
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
            Inj.Sp("sp_CabeceraDataDelete");
            Inj.Pmt_Integer("v_CabeceraDataId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
