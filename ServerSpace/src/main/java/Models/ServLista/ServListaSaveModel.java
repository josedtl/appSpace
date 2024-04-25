package Models.ServLista;


import java.sql.Timestamp;

import com.fasterxml.jackson.annotation.JsonProperty;
import EntityLayer.ServListaEntity;
import Enumerados.ProcessActionEnum;

public class ServListaSaveModel {
    
    
    public ServListaSaveModel() {
        this.listaId = 0;
        this.codigoCampo = "";
        this.codigo = "";
        this.nombre = "";
        this.descripcion = "";
        this.fechaRegistro = null;
        this.codUsuario = "";
        this.estadoRegistro = false;
    }

    public ServListaSaveModel(ServListaEntity Ent) {
        this.listaId = Ent.getListaId();
        this.codigoCampo = Ent.getCodigoCampo();
        this.codigo = Ent.getCodigo();
        this.nombre = Ent.getNombre();
        this.descripcion = Ent.getDescripcion();
        this.fechaRegistro = Ent.getFechaRegistro();
        this.codUsuario = Ent.getCodUsuario();
        this.estadoRegistro = Ent.getEstadoRegistro();
    }

    @JsonProperty("ListaId")
    private int listaId = 0;

    public int getListaId() {
        return listaId;
    }

    public void setListaId(int listaId) {
        this.listaId = listaId;
    }

    @JsonProperty("CodigoCampo")
    private String codigoCampo = "";

    public String getCodigoCampo() {
        return codigoCampo;
    }

    public void setCodigoCampo(String codigoCampo) {
        this.codigoCampo = codigoCampo;
    }

    @JsonProperty("Codigo")
    private String codigo = "";

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    @JsonProperty("Nombre")
    private String nombre = "";

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    @JsonProperty("Descripcion")
    private String descripcion = "";

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
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
