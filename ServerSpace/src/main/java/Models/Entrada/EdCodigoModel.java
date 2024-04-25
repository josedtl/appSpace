package Models.Entrada;

import com.fasterxml.jackson.annotation.JsonProperty;

public class EdCodigoModel {

    public EdCodigoModel() {
        this.codigo = "";
    }

    @JsonProperty("Codigo")
    private String codigo = "";

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
}
