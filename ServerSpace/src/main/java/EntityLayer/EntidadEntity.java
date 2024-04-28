package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;

public class EntidadEntity {
    
    private int entidadId = 0;

    public int getEntidadId() {
        return entidadId;
    }

    public void setEntidadId(int entidadId) {
        this.entidadId = entidadId;
    }
    private String nombrecompleto = "";

    public String getNombreCompleto() {
        return nombrecompleto;
    }

    public void setNombreCompleto(String nombrecompleto) {
        this.nombrecompleto = nombrecompleto;
    }




}
