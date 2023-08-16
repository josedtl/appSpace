/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EntityLayer;

import Enumerados.ProcessActionEnum;
import java.util.Date;

/**
 *
 * @author DAVID
 */
public class CargoEntity {

    private int CargoId;
    private String nombre;
    private Date fechaRegistro;
    private String codUsuario;
    private boolean estadoRegistro;
    private ProcessActionEnum Action = ProcessActionEnum.Loaded;

    /**
     * @return the Action
     */
    public int getAction() {
        return Action.getValor();
    }

    /**
     * @param Action the Action to set
     */
    public void setAction(ProcessActionEnum Action) {
        this.Action = Action;
    }

    /**
     * @return the CargoId
     */
    public int getCargoId() {
        return CargoId;
    }

    /**
     * @param CargoId the CargoId to set
     */
    public void setCargoId(int CargoId) {
        this.CargoId = CargoId;
    }

    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /**
     * @return the fechaRegistro
     */
    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    /**
     * @param fechaRegistro the fechaRegistro to set
     */
    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    /**
     * @return the codUsuario
     */
    public String getCodUsuario() {
        return codUsuario;
    }

    /**
     * @param codUsuario the codUsuario to set
     */
    public void setCodUsuario(String codUsuario) {
        this.codUsuario = codUsuario;
    }

    /**
     * @return the estadoRegistro
     */
    public boolean getEstadoRegistro() {
        return estadoRegistro;
    }

    /**
     * @param estadoRegistro the estadoRegistro to set
     */
    public void setEstadoRegistro(boolean estadoRegistro) {
        this.estadoRegistro = estadoRegistro;
    }

}