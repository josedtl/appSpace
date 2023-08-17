package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.math.BigDecimal;
import java.util.Date;

public class TipoElementoEntity {

    @JsonProperty("TipoElementoId")
    private int tipoElementoId = 0;
    public int getTipoElementoId() {
        return tipoElementoId;
    }

    public void setTipoElementoId(int tipoElementoId) {
        this.tipoElementoId = tipoElementoId;
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
    private Date fechaRegistro = null;
    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
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
