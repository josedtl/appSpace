package Models.General;

import com.fasterxml.jackson.annotation.JsonProperty;

import EntityLayer.MonedaEntity;

public class MonedaModel {
    public MonedaModel() {
        this.monedaId = 0;
        this.codigo = "";
        this.codigoInterno = "";
        this.simbolo = "";
        this.nombre = "";
    }

    public MonedaModel(MonedaEntity Ent) {
        this.monedaId = Ent.getMonedaId();
        this.codigo = Ent.getCodigo();
        this.codigoInterno = Ent.getCodigoInterno();
        this.simbolo = Ent.getSimbolo();
        this.nombre = Ent.getNombre();
    }

    @JsonProperty("MonedaId")
    private int monedaId = 0;

    public int getMonedaId() {
        return monedaId;
    }

    public void setMonedaId(int monedaId) {
        this.monedaId = monedaId;
    }

    @JsonProperty("Codigo")
    private String codigo = "";

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    @JsonProperty("CodigoInterno")
    private String codigoInterno = "";

    public String getCodigoInterno() {
        return codigoInterno;
    }

    public void setCodigoInterno(String codigoInterno) {
        this.codigoInterno = codigoInterno;
    }


    @JsonProperty("Simbolo")
    private String simbolo = "";

    public String getSimbolo() {
        return simbolo;
    }

    public void setSimbolo(String simbolo) {
        this.simbolo = simbolo;
    }

    @JsonProperty("Nombre")
    private String nombre = "";

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
}
