/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DataLayer.MyCode;

import EntityLayer.PersonaNaturalEntity;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class PersonaNaturalDB {

    injector Inj = new injector();

    public ArrayList<PersonaNaturalEntity> GetPersonaNaturalMainItems() {

        ArrayList<PersonaNaturalEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalEntity en;
        try {
            Inj.Sp("sp_PersonaNaturalMainItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new PersonaNaturalEntity();
                en.setPersonaNaturalId(rs.getInt("PersonaNaturalId"));
                en.setNomDocumento(rs.getString("NomDocumento"));
                en.setNumDocumento(rs.getString("NumDocumento"));
                en.setNombres(rs.getString("Nombres"));
                en.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                en.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                en.setFechaRegistro(rs.getTimestamp("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

}
