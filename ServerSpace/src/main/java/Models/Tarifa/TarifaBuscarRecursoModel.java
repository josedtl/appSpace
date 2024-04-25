package Models.Tarifa;

import com.fasterxml.jackson.annotation.JsonProperty;
import EntityLayer.TarifaEntity;

public class TarifaBuscarRecursoModel {
    public TarifaBuscarRecursoModel() {
        this.objetoReferenciaId = 0;
        this.nomCompleto = "";
        this.tipoTarifaEnum = 0;
    }

    public TarifaBuscarRecursoModel(TarifaEntity Ent) {
        this.objetoReferenciaId = Ent.getObjetoReferenciaId();
        this.nomCompleto = Ent.getNomCompleto();
        this.tipoTarifaEnum = Ent.getTipoTarifaEnum();
    }

    @JsonProperty("ObjetoReferenciaId")
    private int objetoReferenciaId = 0;

    public int getObjetoReferenciaId() {
        return objetoReferenciaId;
    }

    public void setObjetoReferenciaId(int objetoReferenciaId) {
        this.objetoReferenciaId = objetoReferenciaId;
    }

    @JsonProperty("NomCompleto")
    private String nomCompleto = "";

    public String getNomCompleto() {
        return nomCompleto;
    }

    public void setNombre(String nomCompleto) {
        this.nomCompleto = nomCompleto;
    }

    @JsonProperty("TipoTarifaEnum")
    private int tipoTarifaEnum = 0;

    public int getTipoTarifaEnum() {
        return tipoTarifaEnum;
    }

    public void setTipoTarifaEnum(int tipoTarifaEnum) {
        this.tipoTarifaEnum = tipoTarifaEnum;
    }

}
