package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import Enumerados.ProcessActionEnum;
import java.sql.Timestamp;

public class InfraestructuraEntity {

    @JsonProperty("InfraestructuraId")
    private int infraestructuraId = 0;
    public int getInfraestructuraId() {
        return infraestructuraId;
    }

    public void setInfraestructuraId(int infraestructuraId) {
        this.infraestructuraId = infraestructuraId;
    }

    @JsonProperty("SucursalId")
    private int sucursalId = 0;
    public int getSucursalId() {
        return sucursalId;
    }

    public void setSucursalId(int sucursalId) {
        this.sucursalId = sucursalId;
    }

    @JsonProperty("Estado")
    private int estado = 0;
    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    @JsonProperty("CodigoSistema")
    private String codigoSistema = "";
    public String getCodigoSistema() {
        return codigoSistema;
    }

    public void setCodigoSistema(String codigoSistema) {
        this.codigoSistema = codigoSistema;
    }

    @JsonProperty("CodigoInterno")
    private String codigoInterno = "";
    public String getCodigoInterno() {
        return codigoInterno;
    }

    public void setCodigoInterno(String codigoInterno) {
        this.codigoInterno = codigoInterno;
    }

    @JsonProperty("Descripcion")
    private String descripcion = "";
    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    @JsonProperty("TipoInfraestructuraId")
    private int tipoInfraestructuraId = 0;
    public int getTipoInfraestructuraId() {
        return tipoInfraestructuraId;
    }

    public void setTipoInfraestructuraId(int tipoInfraestructuraId) {
        this.tipoInfraestructuraId = tipoInfraestructuraId;
    }
    @JsonProperty("ClasificacionId")
    private int clasificacionId = 0;
    public int getClasificacionId() {
        return clasificacionId;
    }

    public void setclasificacionId(int clasificacionId) {
        this.clasificacionId = clasificacionId;
    }

    @JsonProperty("InfraestructuraDimensionId")
    private int infraestructuraDimensionId = 0;
    public int getInfraestructuraDimensionId() {
        return infraestructuraDimensionId;
    }

    public void setInfraestructuraDimensionId(int infraestructuraDimensionId) {
        this.infraestructuraDimensionId = infraestructuraDimensionId;
    }

    @JsonProperty("Aforo")
    private int aforo = 0;
    public int getAforo() {
        return aforo;
    }

    public void setAforo(int aforo) {
        this.aforo = aforo;
    }

    @JsonProperty("PisoId")
    private int pisoId = 0;
    public int getPisoId() {
        return pisoId;
    }

    public void setPisoId(int pisoId) {
        this.pisoId = pisoId;
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

// COMPLEMENTARIO*************************************************************************************************************************************

    @JsonProperty("Action")
    private ProcessActionEnum action = ProcessActionEnum.Loaded;

    public int getAction() {
        return action.getValor();
    }

    public void setAction(ProcessActionEnum Action) {
        this.action = Action;
    }

    @JsonProperty("TipoInfraestructura")
    private String tipoInfraestructura = "";

    public String getTipoInfraestructura() {
        return tipoInfraestructura;
    }

    public void setTipoInfraestructura(String tipoInfraestructura) {
        this.tipoInfraestructura = tipoInfraestructura;
    }

    
    private String clasificacion = "";

    public String getClasificacion() {
        return clasificacion;
    }

    public void setClasificacion(String clasificacion) {
        this.clasificacion = clasificacion;
    }


    private String infraestructuraDimension = "";


    public String getInfraestructuraDimension() {
        return infraestructuraDimension;
    }

    public void setInfraestructuraDimension(String infraestructuraDimension) {
        this.infraestructuraDimension = infraestructuraDimension;
    }

    private String piso= "";

    public String getPiso() {
        return piso;
    }

    public void setPiso(String piso) {
        this.piso = piso;
    }

}
