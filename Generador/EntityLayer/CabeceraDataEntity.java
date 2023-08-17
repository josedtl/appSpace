package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.math.BigDecimal;
import java.util.Date;

public class CabeceraDataEntity {

    @JsonProperty("CabeceraDataId")
    private int cabeceraDataId = 0;
    public int getCabeceraDataId() {
        return cabeceraDataId;
    }

    public void setCabeceraDataId(int cabeceraDataId) {
        this.cabeceraDataId = cabeceraDataId;
    }

    @JsonProperty("CantidadEntera")
    private int cantidadEntera = 0;
    public int getCantidadEntera() {
        return cantidadEntera;
    }

    public void setCantidadEntera(int cantidadEntera) {
        this.cantidadEntera = cantidadEntera;
    }

    @JsonProperty("CantidadDecimal")
    public double getCantidadDecimal() {
        return cantidadDecimal;
    }

    public void setCantidadDecimal(double cantidadDecimal) {
        this.cantidadDecimal = cantidadDecimal;
    }

    @JsonProperty("CantidadNumerico")
    public double getCantidadNumerico() {
        return cantidadNumerico;
    }

    public void setCantidadNumerico(double cantidadNumerico) {
        this.cantidadNumerico = cantidadNumerico;
    }

    @JsonProperty("CantidadEnteraSmall")
    private int cantidadEnteraSmall = 0;
    public int getCantidadEnteraSmall() {
        return cantidadEnteraSmall;
    }

    public void setCantidadEnteraSmall(int cantidadEnteraSmall) {
        this.cantidadEnteraSmall = cantidadEnteraSmall;
    }

    @JsonProperty("LetrasGrande")
    private String letrasGrande = "";
    public String getLetrasGrande() {
        return letrasGrande;
    }

    public void setLetrasGrande(String letrasGrande) {
        this.letrasGrande = letrasGrande;
    }

    @JsonProperty("LetrasMedia")
    private String letrasMedia = "";
    public String getLetrasMedia() {
        return letrasMedia;
    }

    public void setLetrasMedia(String letrasMedia) {
        this.letrasMedia = letrasMedia;
    }

    @JsonProperty("LetrasPequena")
    private String letrasPequena = "";
    public String getLetrasPequena() {
        return letrasPequena;
    }

    public void setLetrasPequena(String letrasPequena) {
        this.letrasPequena = letrasPequena;
    }

    @JsonProperty("LetrasPequenaSmall")
    private String letrasPequenaSmall = "";
    public String getLetrasPequenaSmall() {
        return letrasPequenaSmall;
    }

    public void setLetrasPequenaSmall(String letrasPequenaSmall) {
        this.letrasPequenaSmall = letrasPequenaSmall;
    }

    @JsonProperty("LetrasPequenaSmallUno")
    private String letrasPequenaSmallUno = "";
    public String getLetrasPequenaSmallUno() {
        return letrasPequenaSmallUno;
    }

    public void setLetrasPequenaSmallUno(String letrasPequenaSmallUno) {
        this.letrasPequenaSmallUno = letrasPequenaSmallUno;
    }

    @JsonProperty("Fecha")
    private Date fecha = null;
    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    @JsonProperty("FechaSola")
    private Date fechaSola = null;
    public Date getFechaSola() {
        return fechaSola;
    }

    public void setFechaSola(Date fechaSola) {
        this.fechaSola = fechaSola;
    }

    @JsonProperty("Estado")
    private boolean estado = false;
    public boolean getEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

}
