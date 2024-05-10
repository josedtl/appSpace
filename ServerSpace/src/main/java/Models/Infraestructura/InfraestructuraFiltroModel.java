package Models.Infraestructura;

import com.fasterxml.jackson.annotation.JsonProperty;

import EntityLayer.InfraestructuraEntity;

public class InfraestructuraFiltroModel {
    
    public InfraestructuraFiltroModel() {
        this.infraestructuraId = 0;
        this.clasificacion="";
        this.piso = "";
        this.estadoAdministrativo = "";
    }

    public InfraestructuraFiltroModel(InfraestructuraEntity Ent) {
        this.infraestructuraId = Ent.getInfraestructuraId();
        this.clasificacion=Ent.getClasificacion();
        this.piso = Ent.getPiso();
        this.estadoAdministrativo = Ent.getestadoAdministrativo();
    }

    @JsonProperty("InfraestructuraId")
    private int infraestructuraId = 0;

    public int getInfraestructuraId() {
        return infraestructuraId;
    }

    public void setInfraestructuraId(int infraestructuraId) {
        this.infraestructuraId = infraestructuraId;
    }

    @JsonProperty("Clasificacion")
    private String clasificacion = "";

    public String getClasificacion() {
        return clasificacion;
    }

    public void setClasificacion(String clasificacion) {
        this.clasificacion = clasificacion;
    }

    @JsonProperty("Piso")
    private String piso= "";

    public String getPiso() {
        return piso;
    }

    public void setPiso(String piso) {
        this.piso = piso;
    }

    @JsonProperty("EstadoAdministrativo")
    private String estadoAdministrativo= "";

    public String getestadoAdministrativo() {
        return estadoAdministrativo;
    }

    public void setestadoAdministrativo(String estadoAdministrativo) {
        this.estadoAdministrativo = estadoAdministrativo;
    }

}
