package EntityLayer;

import Enumerados.ProcessActionEnum;
import java.util.Date;

/**
 *
 * @author DAVID
 */
public class TipoInfraestructuraEntity {

    private int TipoInfraestructuraId;
    private String Nombre;
    private Date FechaRegistro;
    private String CodUsuario;
    private boolean EstadoRegistro;
    private ProcessActionEnum Action = ProcessActionEnum.Loaded;

    public int getAction() {
        return Action.getValor();
    }

    /**
     * @param Action the Action to set
     */
    public void setAction(ProcessActionEnum Action) {
        this.Action = Action;
    }

    public int getTipoInfraestructuraId() {
        return TipoInfraestructuraId;
    }

    public void setTipoInfraestructuraId(int TipoInfraestructuraId) {
        this.TipoInfraestructuraId = TipoInfraestructuraId;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public Date getFechaRegistro() {
        return FechaRegistro;
    }

    public void setFechaRegistro(Date FechaRegistro) {
        this.FechaRegistro = FechaRegistro;
    }

    public String getCodUsuario() {
        return CodUsuario;
    }

    public void setCodUsuario(String CodUsuario) {
        this.CodUsuario = CodUsuario;
    }

    public boolean getEstadoRegistro() {
        return EstadoRegistro;
    }

    public void setEstadoRegistro(boolean EstadoRegistro) {
        this.EstadoRegistro = EstadoRegistro;
    }

}
