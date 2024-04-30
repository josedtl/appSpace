package Models.Tarifa;

import com.fasterxml.jackson.annotation.JsonProperty;

import EntityLayer.TarifaEntity;

public class TarifaBuscarItem {
    public TarifaBuscarItem() {
        this.tarifaId = 0;
        this.nomcomercial = "";
        this.tipoTarifaEnum = 0;
    }

    public TarifaBuscarItem(TarifaEntity Ent) {
        this.tarifaId = Ent.getTarifaId();
        this.nomcomercial = Ent.getNomComercial();
        this.tipoTarifaEnum = Ent.getTipoTarifaEnum();
    }

    @JsonProperty("TarifaId")
    private int tarifaId = 0;

    public int getTarifaId() {
        return tarifaId;
    }

    public void setTarifaId(int tarifaId) {
        this.tarifaId = tarifaId;
    }

    @JsonProperty("NomComercial")
    private String nomcomercial = "";

    public String getNomCompleto() {
        return nomcomercial;
    }

    public void setNomCompleto(String nomcomercial) {
        this.nomcomercial = nomcomercial;
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
