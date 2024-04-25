package Models.ServLista;


import com.fasterxml.jackson.annotation.JsonProperty;
import EntityLayer.ServListaEntity;
public class ServListaModel {
    

    public ServListaModel() {
        this.listaId = 0;
        this.nombre = "";
    }

    public ServListaModel(ServListaEntity Ent) {
        this.listaId = Ent.getListaId();
        this.nombre = Ent.getNombre();
    }
    @JsonProperty("ListaId")
    private int listaId = 0;

    public int getListaId() {
        return listaId;
    }


    @JsonProperty("Nombre")
    private String nombre = "";

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

}
