/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DataLayer;

import EntityLayer.TipoElementoEntity;
import Enumerados.ProcessActionEnum;
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
                en.setAction(ProcessActionEnum.Loaded);
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
                en.setAction(ProcessActionEnum.Loaded);
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
            String Store = "sp_TipoElementoSave";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_TipoElementoUpdate";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_TipoElementoId", entity.getTipoElementoId(), true);
            Inj.Pmt_String("v_Nombre", entity.getNombre(), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_EstadoRegistro", entity.getEstadoRegistro(), false);

            int Id = Inj.RunInsert();
            State = Id > 0;
            if (State) {
                entity.setTipoElementoId(Id);
                entity.setAction(ProcessActionEnum.Add);
            }

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater :" + ex);
        }
        return State;
    }

    public Boolean Delete(Integer entity) {
        Boolean State = null;
        Inj.Sp("sp_TipoElementoDelete");
        Inj.Pmt_Integer("v_TipoElementoId", entity, false);
        State = Inj.RunDelete() > 0;
        return State;

    }

}
