package EntityLayer;

/**
 *
 * @author RUTH
 */
public class InfraestructuraEntity {

    private int InfraestructuraId;
    private int TipoInfraestructuraId;
    private String Estado;
    private String Codigo;
    private String Descripcion;
    private double Ancho;
    private String Largo;
    private String Altura;
    private String Nivel;
    private int Aforo;
    
    public int getInfraestructuraId() {
        return InfraestructuraId;
    }

    public void setInfraestructuraId(int InfraestructuraId) {
        this.InfraestructuraId = InfraestructuraId;
    }

    public int getTipoInfraestructuraId() {
        return TipoInfraestructuraId;
    }

    public void setTipoInfraestructuraId(int TipoInfraestructuraId) {
        this.TipoInfraestructuraId = TipoInfraestructuraId;
    }

    public String getEstado() {
        return Estado;
    }

    public void setEstado(String Estado) {
        this.Estado = Estado;
    }

    public String getCodigo() {
        return Codigo;
    }

    public void setCodigo(String Codigo) {
        this.Codigo = Codigo;
    }

    public String getDescripcion() {
        return Descripcion;
    }

    public void setDescripcion(String Descripcion) {
        this.Descripcion = Descripcion;
    }

    public double getAncho() {
        return Ancho;
    }

    public void setAncho(double Ancho) {
        this.Ancho = Ancho;
    }

    public String getLargo() {
        return Largo;
    }

    public void setLargo(String Largo) {
        this.Largo = Largo;
    }

    public String getAltura() {
        return Altura;
    }

    public void setAltura(String Altura) {
        this.Altura = Altura;
    }

    public String getNivel() {
        return Nivel;
    }

    public void setNivel(String Nivel) {
        this.Nivel = Nivel;
    }

    public int getAforo() {
        return Aforo;
    }

    public void setAforo(int Aforo) {
        this.Aforo = Aforo;
    }

 

}
