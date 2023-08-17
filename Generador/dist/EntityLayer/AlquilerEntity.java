package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.math.BigDecimal;
import java.util.Date;

public class AlquilerEntity {

    @JsonProperty("AlquilerId")
    private int alquilerId = 0;
    public int getAlquilerId() {
        return alquilerId;
    }

    public void setAlquilerId(int alquilerId) {
        this.alquilerId = alquilerId;
    }

    @JsonProperty("FecharAlquiler")
    private Date fecharAlquiler = null;
    public Date getFecharAlquiler() {
        return fecharAlquiler;
    }

    public void setFecharAlquiler(Date fecharAlquiler) {
        this.fecharAlquiler = fecharAlquiler;
    }

    @JsonProperty("CodUsuario")
    private String codUsuario = "";
    public String getCodUsuario() {
        return codUsuario;
    }

    public void setCodUsuario(String codUsuario) {
        this.codUsuario = codUsuario;
    }

    @JsonProperty("EstadoAlquiler")
    private String estadoAlquiler = "";
    public String getEstadoAlquiler() {
        return estadoAlquiler;
    }

    public void setEstadoAlquiler(String estadoAlquiler) {
        this.estadoAlquiler = estadoAlquiler;
    }

}
