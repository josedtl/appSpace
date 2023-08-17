package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import Enumerados.ProcessActionEnum;
import java.util.Date;

/**
 *
 * @author RUTH
 */
public class PersonaNaturalEntity {

  
    @JsonProperty("PersonaNaturalId")
    private int personaNaturalId = 0;

    @JsonProperty("TipoDocumentoIdentidadId")
    private int tipoDocumentoIdentidadId = 0;

    @JsonProperty("NumDocumento")
    private String numDocumento = "";

    @JsonProperty("Nombres")
    private String nombres = "";

    @JsonProperty("ApellidoPaterno")
    private String apellidoPaterno = "";

    @JsonProperty("ApellidoMaterno")
    private String apellidoMaterno = "";

    @JsonProperty("FechaNacimiento")
    private Date fechaNacimiento = new Date();

    @JsonProperty("UbigeoId")
    private int ubigeoId = 0;

    @JsonProperty("Direccion")
    private String direccion = "";

    @JsonProperty("Telefono")
    private String telefono = "";

    @JsonProperty("Correo")
    private String correo = "";

    @JsonProperty("Genero")
    private int genero = 0;

    @JsonProperty("EstadoCivil")
    private int estadoCivil = 0;

    @JsonProperty("Action")
    private ProcessActionEnum action = ProcessActionEnum.Loaded;

    public int getPersonaNaturalId() {
        return personaNaturalId;
    }

    public void setPersonaNaturalId(int PersonaNaturalId) {
        this.personaNaturalId = PersonaNaturalId;
    }

    public int getTipoDocumentoIdentidadId() {
        return tipoDocumentoIdentidadId;
    }

    public void setTipoDocumentoIdentidadId(int TipoDocumentoIdentidadId) {
        this.tipoDocumentoIdentidadId = TipoDocumentoIdentidadId;
    }

    public String getNumDocumento() {
        return numDocumento;
    }

    public void setNumDocumento(String NumDocumento) {
        this.numDocumento = NumDocumento;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String Nombres) {
        this.nombres = Nombres;
    }

    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String ApellidoPaterno) {
        this.apellidoPaterno = ApellidoPaterno;
    }

    public String getApellidoMaterno() {
        return apellidoMaterno;
    }

    public void setApellidoMaterno(String ApellidoMaterno) {
        this.apellidoMaterno = ApellidoMaterno;
    }

    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Date FechaNacimiento) {
        this.fechaNacimiento = FechaNacimiento;
    }

    public int getUbigeoId() {
        return ubigeoId;
    }

    public void setUbigeoId(int UbigeoId) {
        this.ubigeoId = UbigeoId;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String Direccion) {
        this.direccion = Direccion;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String Telefono) {
        this.telefono = Telefono;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String Correo) {
        this.correo = Correo;
    }

    public int getGenero() {
        return genero;
    }

    public void setGenero(int Genero) {
        this.genero = Genero;
    }

    public int getEstadoCivil() {
        return estadoCivil;
    }

    public void setEstadoCivil(int EstadoCivil) {
        this.estadoCivil = EstadoCivil;
    }

    public int getAction() {
        return action.getValor();
    }

    public void setAction(ProcessActionEnum Action) {
        this.action = Action;
    }

}
