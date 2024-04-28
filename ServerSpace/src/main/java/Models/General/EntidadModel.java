package Models.General;

import com.fasterxml.jackson.annotation.JsonProperty;

import EntityLayer.EntidadEntity;

public class EntidadModel {
    
    public EntidadModel() {
        this.entidadId = 0;
        this.nombrecompleto = "";
    }

    public EntidadModel(EntidadEntity Ent) {
        this.entidadId = Ent.getEntidadId();
        this.nombrecompleto = Ent.getNombreCompleto();
    }

    @JsonProperty("EntidadId")
    private int entidadId = 0;

    public int getEntidadId() {
        return entidadId;
    }

    public void setEntidadId(int entidadId) {
        this.entidadId = entidadId;
    }

    private String nombrecompleto = "";

    @JsonProperty("NombreCompleto")
    public String getNombreCompleto() {
        return nombrecompleto;
    }

    public void setNombreCompleto(String nombrecompleto) {
        this.nombrecompleto = nombrecompleto;
    }
}
