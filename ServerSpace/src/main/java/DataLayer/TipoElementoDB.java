/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DataLayer;

import EntityLayer.TipoElementoEntity;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class TipoElementoDB {

    injector Inj = new injector();

    public ArrayList<TipoElementoEntity> GetTipoElementoItems() {
//das
        ArrayList<TipoElementoEntity> DatoMemoria = new ArrayList<>();
        TipoElementoEntity en;
        try {

            Inj.Sp("sp_TipoElementoItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new TipoElementoEntity();
                en.setTipoElementoId(rs.getInt("TipoElementoId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getDate("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<TipoElementoEntity> GetTipoElementoItem(int TipoElementoId) {

        ArrayList<TipoElementoEntity> DatoMemoria = new ArrayList<>();
        TipoElementoEntity en;
        try {

            Inj.Sp("sp_TipoElementoItem");
            Inj.Pmt_Integer("v_TipoElementoId", TipoElementoId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new TipoElementoEntity();
                en.setTipoElementoId(rs.getInt("TipoElementoId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getDate("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public Boolean Save(TipoElementoEntity entity) {
        Boolean State = null;
        try {

            if (entity.getTipoElementoId() == 0) {
                Inj.Sp("sp_TipoElementoSave");
            } else {
                Inj.Sp("sp_TipoElementoUpdate");
            }

            Inj.Pmt_Integer("v_TipoElementoId", entity.getTipoElementoId(), false);
            Inj.Pmt_String("v_Nombre", entity.getNombre(), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_EstadoRegistro", entity.getEstadoRegistro(), false);

            State = Inj.RunInsert() > 0;

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater :" + ex);
        }
        return State;
    }

}
