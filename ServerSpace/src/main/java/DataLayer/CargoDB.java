/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DataLayer;

import EntityLayer.CargoEntity;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class CargoDB {

    injector Inj = new injector();

    public ArrayList<CargoEntity> GetCargoItems() {

        ArrayList<CargoEntity> DatoMemoria = new ArrayList<>();
        CargoEntity en;
        try {

            Inj.Sp("sp_CargoItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new CargoEntity();
                en.setCargoId(rs.getInt("CargoId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getDate("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
                en.setAction(ProcessActionEnum.Loaded);
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<CargoEntity> GetCargoItem(int CargoId) {

        ArrayList<CargoEntity> DatoMemoria = new ArrayList<>();
        CargoEntity en;
        try {

            Inj.Sp("sp_CargoItem");
            Inj.Pmt_Integer("v_CargoId", CargoId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new CargoEntity();
                en.setCargoId(rs.getInt("CargoId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getDate("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
                en.setAction(ProcessActionEnum.Loaded);
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public Boolean Save(CargoEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_CargoSave";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_CargoUpdate";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_CargoId", entity.getCargoId(), true);
            Inj.Pmt_String("v_Nombre", entity.getNombre(), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_EstadoRegistro", entity.getEstadoRegistro(), false);

            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setCargoId(Id);
                }
            }
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Inj.RunUpdate();
            }

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater :" + ex);
        }
        return State;
    }

    public Boolean Delete(Integer entity) {
        Boolean State = null;
        Inj.Sp("sp_CargoDelete");
        Inj.Pmt_Integer("v_CargoId", entity, false);
        State = Inj.RunDelete() > 0;
        return State;

    }

}
