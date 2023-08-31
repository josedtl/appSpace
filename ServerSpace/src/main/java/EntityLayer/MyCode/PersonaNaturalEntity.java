/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EntityLayer.MyCode;

import EntityLayer.PersonaNaturalMedioComunicacionEntity;
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

    @JsonProperty("PersonaNaturalMedioComunicacioDetalle")
    private PersonaNaturalMedioComunicacionEntity personaNaturalMedioComunicacioDetalle = null;

    public PersonaNaturalMedioComunicacionEntity getDetalleMedioComunicacion() {
        return personaNaturalMedioComunicacioDetalle;
    }

    public void setDetalleMedioComunicacion(PersonaNaturalMedioComunicacionEntity ItemDetalle) {
        this.personaNaturalMedioComunicacioDetalle = ItemDetalle;
    }
    
    

}
