/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EntityLayer;

import java.util.Date;

/**
 *
 * @author DAVID
 */
public class TipoInfraestructuraEntity {
  
  private int TipoInfraestructuraId ; 
  private String Nombre; 
  private Date FechaRegistro ; 
  private String CodUsuario ;
  private String EstadoRegistro ;

  public int getTipoInfraestructuraId() {
        return TipoInfraestructuraId;
    }

    public void setTipoInfraestructuraId(int TipoInfraestructuraId) {
        this.TipoInfraestructuraId = TipoInfraestructuraId;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public Date getFechaRegistro() {
        return FechaRegistro;
    }

    public void setFechaRegistro(Date FechaRegistro) {
        this.FechaRegistro = FechaRegistro;
    }

    public String getCodUsuario() {
        return CodUsuario;
    }

    public void setCodUsuario(String CodUsuario) {
        this.CodUsuario = CodUsuario;
    }

    public String getEstadoRegistro() {
        return EstadoRegistro;
    }

    public void setEstadoRegistro(String EstadoRegistro) {
        this.EstadoRegistro = EstadoRegistro;
    }
    

}
