package Models.General;

import java.sql.Timestamp;

import com.fasterxml.jackson.annotation.JsonProperty;

import EntityLayer.UnidadMedidaEntity;

public class UnidadMedidaModel {
    

    public UnidadMedidaModel() {
        this.unidadMedidaId = 0;
        this.codigo = "";
        this.codigoComercial = "";
        this.nombre = "";
        this.fechaRegistro = null;
        this.codUsuario = "";
        this.estadoRegistro = false;
    }

    public UnidadMedidaModel(UnidadMedidaEntity Ent) {
        this.unidadMedidaId = Ent.getUnidadMedidaId();
        this.codigo = Ent.getCodigo();
        this.codigoComercial = Ent.getCodigoComercial();
        this.nombre = Ent.getNombre();
        this.fechaRegistro = Ent.getFechaRegistro();
        this.codUsuario = Ent.getCodUsuario();
        this.estadoRegistro = Ent.getEstadoRegistro();
    }


    @JsonProperty("UnidadMedidaId")
    private int unidadMedidaId = 0;
    public int getUnidadMedidaId() {
        return unidadMedidaId;
    }

    public void setUnidadMedidaId(int unidadMedidaId) {
        this.unidadMedidaId = unidadMedidaId;
    }

    
    @JsonProperty("Codigo")
    private String codigo = "";
    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    @JsonProperty("CodigoComercial")
    private String codigoComercial = "";
    public String getCodigoComercial() {
        return codigoComercial;
    }

    public void setCodigoComercial(String codigoComercial) {
        this.codigoComercial = codigoComercial;
    }

    @JsonProperty("Nombre")
    private String nombre = "";
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
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
}
