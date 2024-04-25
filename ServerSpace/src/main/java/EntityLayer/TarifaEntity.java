package EntityLayer;

import java.sql.Timestamp;
import com.fasterxml.jackson.annotation.JsonProperty;
import Enumerados.ProcessActionEnum;

public class TarifaEntity {

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


    @JsonProperty("CodigoUnidad")
    private String codigoUnidad = "";

    public String getCodigoUnidad() {
        return codigoUnidad;
    }

    public void setCodigoUnidad(String codigoUnidad) {
        this.codigoUnidad = codigoUnidad;
    }

    @JsonProperty("SimboloMoneda")
    private String simboloMoneda = "";

    public String getSimboloMoneda() {
        return simboloMoneda;
    }

    public void setSimboloMoneda(String simboloMoneda) {
        this.simboloMoneda = simboloMoneda;
    }

    @JsonProperty("NomCompleto")
    private String nomCompleto = "";

    public String getNomCompleto() {
        return nomCompleto;
    }

    public void setNomCompleto(String nomCompleto) {
        this.nomCompleto = nomCompleto;
    }
}
