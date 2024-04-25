package Models.Tarifa;

import java.sql.Timestamp;

import com.fasterxml.jackson.annotation.JsonProperty;

import EntityLayer.TarifaEntity;
import Enumerados.ProcessActionEnum;

public class TarifaSaveModel {

    public TarifaSaveModel() {
        this.tarifaId = 0;
        this.objetoReferenciaId = 0;
        this.correlativo = "";
        this.monedaId = 0;
        this.tipoTarifaEnum = 0;
        this.unidadMedidaId = 0;
        this.costoTarifa = 0;
        this.nomTarifa = "";
        this.nomComercial = "";
        this.descripcion = "";
        this.fechaRegistro = null;
        this.codUsuario = "";
        this.estadoRegistro = false;
    }

    public TarifaSaveModel(TarifaEntity Ent) {
        this.tarifaId = Ent.getTarifaId();
        this.objetoReferenciaId = Ent.getObjetoReferenciaId();
        this.correlativo = Ent.getCorrelativo();
        this.monedaId = Ent.getMonedaId();
        this.tipoTarifaEnum = Ent.getTipoTarifaEnum();
        this.unidadMedidaId = Ent.getUnidadMedidaId();
        this.costoTarifa = Ent.getCostoTarifa();
        this.nomTarifa = Ent.getNomTarifa();
        this.nomComercial = Ent.getNomComercial();
        this.descripcion = Ent.getDescripcion();
        this.fechaRegistro = Ent.getFechaRegistro();
        this.codUsuario = Ent.getCodUsuario();
        this.estadoRegistro = Ent.getEstadoRegistro();
    }

    @JsonProperty("TarifaId")
    private int tarifaId = 0;

    public int getTarifaId() {
        return tarifaId;
    }

    public void setTarifaId(int tarifaId) {
        this.tarifaId = tarifaId;
    }

    @JsonProperty("ObjetoReferenciaId")
    private int objetoReferenciaId = 0;

    public int getObjetoReferenciaId() {
        return objetoReferenciaId;
    }

    public void setObjetoReferenciaId(int objetoReferenciaId) {
        this.objetoReferenciaId = objetoReferenciaId;
    }

    @JsonProperty("Correlativo")
    private String correlativo = "";

    public String getCorrelativo() {
        return correlativo;
    }

    public void setCorrelativo(String correlativo) {
        this.correlativo = correlativo;
    }

    @JsonProperty("NomTarifa")
    private String nomTarifa = "";

    public String getNomTarifa() {
        return nomTarifa;
    }

    public void setNomTarifa(String nomTarifa) {
        this.nomTarifa = nomTarifa;
    }

    @JsonProperty("NomComercial")
    private String nomComercial = "";

    public String getNomComercial() {
        return nomComercial;
    }

    public void setNomComercial(String nomComercial) {

        this.nomComercial = nomComercial;
    }

    @JsonProperty("Descripcion")
    private String descripcion = "";

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    @JsonProperty("FechaRegistro")
    private Timestamp fechaRegistro = null;

    public Timestamp getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Timestamp fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    @JsonProperty("CodUsuario")
    private String codUsuario = "";

    public String getCodUsuario() {
        return codUsuario;
    }

    public void setCodUsuario(String codUsuario) {
        this.codUsuario = codUsuario;
    }

    @JsonProperty("EstadoRegistro")
    private boolean estadoRegistro = false;

    public boolean getEstadoRegistro() {
        return estadoRegistro;
    }

    public void setEstadoRegistro(boolean estadoRegistro) {
        this.estadoRegistro = estadoRegistro;
    }

    @JsonProperty("TipoTarifaEnum")
    private int tipoTarifaEnum = 0;

    public int getTipoTarifaEnum() {
        return tipoTarifaEnum;
    }

    public void setTipoTarifaEnum(int tipoTarifaEnum) {
        this.tipoTarifaEnum = tipoTarifaEnum;
    }

    @JsonProperty("CostoTarifa")
    private double costoTarifa = 0;

    public double getCostoTarifa() {
        return costoTarifa;
    }

    public void setCostoTarifa(double costoTarifa) {
        this.costoTarifa = costoTarifa;
    }

    @JsonProperty("MonedaId")
    private int monedaId = 0;

    public int getMonedaId() {
        return monedaId;
    }

    public void setMonedaId(int monedaId) {
        this.monedaId = monedaId;
    }

    @JsonProperty("UnidadMedidaId")
    private int unidadMedidaId = 0;

    public int getUnidadMedidaId() {
        return unidadMedidaId;
    }

    public void setUnidadMedidaId(int unidadMedidaId) {
        this.unidadMedidaId = unidadMedidaId;
    }

    @JsonProperty("Action")
    private ProcessActionEnum action = ProcessActionEnum.Loaded;

    public int getAction() {
        return action.getValor();
    }

    public void setAction(ProcessActionEnum Action) {
        this.action = Action;
    }

}
