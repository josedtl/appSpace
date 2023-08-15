package DataLayer;

import EntityLayer.personanaturalEntity;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author RUTH
 */
public class personanaturalDB {
     injector Inj = new injector();

    public ArrayList<personanaturalEntity> GetpersonanaturalItems() {

        ArrayList<personanaturalEntity> DatoMemoria = new ArrayList<>();
        personanaturalEntity en;
        try {

            Inj.Sp("sp_TipoElementoItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new personanaturalEntity();
                en.setPersonaNaturalId(rs.getInt("PersonaNaturalId"));
                en.setTipoDocumentoIdentidadId(rs.getInt("TipoDocumentoIdentidadId"));
                en.setNumDocumento(rs.getString("NumDocumento"));
                en.setNombres(rs.getString("Nombres"));
                en.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                en.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                en.setFechaNacimiento(rs.getDate("FechaNacimiento"));
                en.setUbigeoId(rs.getInt("UbigeoId"));
                en.setDireccion(rs.getString("Direccion"));
                en.setTelefono(rs.getString("Telefono"));
                en.setCorreo(rs.getString("Correo"));
                en.setGenero(rs.getInt("Genero"));
                en.setEstadoCivil(rs.getInt("EstadoCivil"));
                en.setAction(ProcessActionEnum.Loaded);
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
}
