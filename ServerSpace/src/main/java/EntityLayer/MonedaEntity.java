package EntityLayer;


import com.fasterxml.jackson.annotation.JsonProperty;

public class MonedaEntity {
    

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

    @JsonProperty("EstadoRegistro")
    private boolean estadoRegistro = false;
    public boolean getEstadoRegistro() {
        return estadoRegistro;
    }

    public void setEstadoRegistro(boolean estadoRegistro) {
        this.estadoRegistro = estadoRegistro;
    }
}
