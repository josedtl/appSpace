package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import Enumerados.ProcessActionEnum;
import java.sql.Timestamp;

public class TipoElementoEntity extends EntityLayer.MyCode.TipoElementoEntity{

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



    @JsonProperty("Action")
    private ProcessActionEnum action = ProcessActionEnum.Loaded;

    public int getAction() {
        return action.getValor();
    }

    public void setAction(ProcessActionEnum Action) {
        this.action = Action;
    }
}
