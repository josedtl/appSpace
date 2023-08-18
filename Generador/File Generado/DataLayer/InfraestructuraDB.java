package DataLayer;

import EntityLayer.InfraestructuraEntity;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class InfraestructuraDB {

    injector Inj = new injector();

    public ArrayList<InfraestructuraEntity> GetAllItems() { 

        ArrayList<InfraestructuraEntity> DatoMemoria = new ArrayList<>();
        InfraestructuraEntity en;
        try {
            Inj.Sp("sp_InfraestructuraAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new InfraestructuraEntity();
                en.setInfraestructuraId(rs.getInt("InfraestructuraId"));
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
                en.setEstado(rs.getString("Estado"));
                en.setCodigo(rs.getString("Codigo"));
                en.setDescripcion(rs.getString("Descripcion"));
                en.setAncho(rs.getInt("Ancho"));
                en.setLargo(rs.getString("Largo"));
                en.setAltura(rs.getString("Altura"));
                en.setNivel(rs.getString("Nivel"));
                en.setAforo(rs.getInt("Aforo"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR "+e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<InfraestructuraEntity> GetAllItem(int InfraestructuraId) { 

        ArrayList<InfraestructuraEntity> DatoMemoria = new ArrayList<>();
        InfraestructuraEntity en;
        try {
            Inj.Sp("sp_InfraestructuraAllItem");
            Inj.Pmt_Integer("v_InfraestructuraId", InfraestructuraId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new InfraestructuraEntity();
                en.setInfraestructuraId(rs.getInt("InfraestructuraId"));
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
                en.setEstado(rs.getString("Estado"));
                en.setCodigo(rs.getString("Codigo"));
                en.setDescripcion(rs.getString("Descripcion"));
                en.setAncho(rs.getInt("Ancho"));
                en.setLargo(rs.getString("Largo"));
                en.setAltura(rs.getString("Altura"));
                en.setNivel(rs.getString("Nivel"));
                en.setAforo(rs.getInt("Aforo"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR "+e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public InfraestructuraEntity Save(InfraestructuraEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_Infraestructura_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_Infraestructura_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_InfraestructuraId", entity.getInfraestructuraId(), true);
            Inj.Pmt_Integer("v_TipoInfraestructuraId", entity.getTipoInfraestructuraId(), false);
            Inj.Pmt_String("v_Estado", entity.getEstado(), false);
            Inj.Pmt_String("v_Codigo", entity.getCodigo(), false);
            Inj.Pmt_String("v_Descripcion", entity.getDescripcion(), false);
            Inj.Pmt_Double("v_Ancho", entity.getAncho(), false);
            Inj.Pmt_String("v_Largo", entity.getLargo(), false);
            Inj.Pmt_String("v_Altura", entity.getAltura(), false);
            Inj.Pmt_String("v_Nivel", entity.getNivel(), false);
            Inj.Pmt_Integer("v_Aforo", entity.getAforo(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setInfraestructuraId(Id);
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
            Inj.Sp("sp_InfraestructuraDelete");
            Inj.Pmt_Integer("v_InfraestructuraId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
