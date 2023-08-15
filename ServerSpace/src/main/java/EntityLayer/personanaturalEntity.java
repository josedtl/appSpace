package EntityLayer;

import Enumerados.ProcessActionEnum;
import java.util.Date;

/**
 *
 * @author RUTH
 */
public class personanaturalEntity {

    private int PersonaNaturalId;
    private int TipoDocumentoIdentidadId;
    private String NumDocumento;
    private String Nombres;
    private String ApellidoPaterno;
    private String ApellidoMaterno;
    private Date FechaNacimiento;
    private int UbigeoId;
    private String Direccion;
    private String Telefono;
    private String Correo;
    private int Genero;
    private int EstadoCivil;
    private ProcessActionEnum Action;

    public int getPersonaNaturalId() {
        return PersonaNaturalId;
    }

    public void setPersonaNaturalId(int PersonaNaturalId) {
        this.PersonaNaturalId = PersonaNaturalId;
    }

    public int getTipoDocumentoIdentidadId() {
        return TipoDocumentoIdentidadId;
    }

    public void setTipoDocumentoIdentidadId(int TipoDocumentoIdentidadId) {
        this.TipoDocumentoIdentidadId = TipoDocumentoIdentidadId;
    }

    public String getNumDocumento() {
        return NumDocumento;
    }

    public void setNumDocumento(String NumDocumento) {
        this.NumDocumento = NumDocumento;
    }

    public String getNombres() {
        return Nombres;
    }

    public void setNombres(String Nombres) {
        this.Nombres = Nombres;
    }

    public String getApellidoPaterno() {
        return ApellidoPaterno;
    }

    public void setApellidoPaterno(String ApellidoPaterno) {
        this.ApellidoPaterno = ApellidoPaterno;
    }

    public String getApellidoMaterno() {
        return ApellidoMaterno;
    }

    public void setApellidoMaterno(String ApellidoMaterno) {
        this.ApellidoMaterno = ApellidoMaterno;
    }

    public Date getFechaNacimiento() {
        return FechaNacimiento;
    }

    public void setFechaNacimiento(Date FechaNacimiento) {
        this.FechaNacimiento = FechaNacimiento;
    }

    public int getUbigeoId() {
        return UbigeoId;
    }

    public void setUbigeoId(int UbigeoId) {
        this.UbigeoId = UbigeoId;
    }

    public String getDireccion() {
        return Direccion;
    }

    public void setDireccion(String Direccion) {
        this.Direccion = Direccion;
    }

    public String getTelefono() {
        return Telefono;
    }

    public void setTelefono(String Telefono) {
        this.Telefono = Telefono;
    }

    public String getCorreo() {
        return Correo;
    }

    public void setCorreo(String Correo) {
        this.Correo = Correo;
    }

    public int getGenero() {
        return Genero;
    }

    public void setGenero(int Genero) {
        this.Genero = Genero;
    }

    public int getEstadoCivil() {
        return EstadoCivil;
    }

    public void setEstadoCivil(int EstadoCivil) {
        this.EstadoCivil = EstadoCivil;
    }

    public ProcessActionEnum getAction() {
        return Action;
    }

    public void setAction(ProcessActionEnum Action) {
        this.Action = Action;
    }

}
