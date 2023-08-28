/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EntityLayer.MyCode;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 *
 * @author DAVID
 */
public class PersonaNaturalEntity {

    @JsonProperty("NomDocumento")
    private String nomDocumento = "";

    public String getNomDocumento() {
        return nomDocumento;
    }

    public void setNomDocumento(String nomDocumento) {
        this.nomDocumento = nomDocumento;
    }
}
