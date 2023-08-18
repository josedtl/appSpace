package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import Enumerados.ProcessActionEnum;
import java.util.Date;

public class InfraestructuraEntity {

    @JsonProperty("InfraestructuraId")
    private int infraestructuraId = 0;
    public int getInfraestructuraId() {
        return infraestructuraId;
    }

    public void setInfraestructuraId(int infraestructuraId) {
        this.infraestructuraId = infraestructuraId;
    }

    @JsonProperty("TipoInfraestructuraId")
    private int tipoInfraestructuraId = 0;
    public int getTipoInfraestructuraId() {
        return tipoInfraestructuraId;
    }

    public void setTipoInfraestructuraId(int tipoInfraestructuraId) {
        this.tipoInfraestructuraId = tipoInfraestructuraId;
    }

    @JsonProperty("Estado")
    private String estado = "";
    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    @JsonProperty("Codigo")
    private String codigo = "";
    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    @JsonProperty("Descripcion")
    private String descripcion = "";
    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    @JsonProperty("Ancho")
    private double ancho = null;
    public double getAncho() {
        return ancho;
    }

    public void setAncho(double ancho) {
        this.ancho = ancho;
    }

    @JsonProperty("Largo")
    private String largo = "";
    public String getLargo() {
        return largo;
    }

    public void setLargo(String largo) {
        this.largo = largo;
    }

    @JsonProperty("Altura")
    private String altura = "";
    public String getAltura() {
        return altura;
    }

    public void setAltura(String altura) {
        this.altura = altura;
    }

    @JsonProperty("Nivel")
    private String nivel = "";
    public String getNivel() {
        return nivel;
    }

    public void setNivel(String nivel) {
        this.nivel = nivel;
    }

    @JsonProperty("Aforo")
    private int aforo = 0;
    public int getAforo() {
        return aforo;
    }

    public void setAforo(int aforo) {
        this.aforo = aforo;
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
