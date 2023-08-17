package EntityLayer;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.math.BigDecimal;
import java.util.Date;

public class ProductoEntity {

    @JsonProperty("ProductoId")
    private int productoId = 0;
    public int getProductoId() {
        return productoId;
    }

    public void setProductoId(int productoId) {
        this.productoId = productoId;
    }

    @JsonProperty("Codigo")
    private String codigo = "";
    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    @JsonProperty("TipoProductoId")
    private int tipoProductoId = 0;
    public int getTipoProductoId() {
        return tipoProductoId;
    }

    public void setTipoProductoId(int tipoProductoId) {
        this.tipoProductoId = tipoProductoId;
    }

    @JsonProperty("MarcaId")
    private int marcaId = 0;
    public int getMarcaId() {
        return marcaId;
    }

    public void setMarcaId(int marcaId) {
        this.marcaId = marcaId;
    }

    @JsonProperty("ModeloId")
    private int modeloId = 0;
    public int getModeloId() {
        return modeloId;
    }

    public void setModeloId(int modeloId) {
        this.modeloId = modeloId;
    }

    @JsonProperty("UnidadMedidaId")
    private int unidadMedidaId = 0;
    public int getUnidadMedidaId() {
        return unidadMedidaId;
    }

    public void setUnidadMedidaId(int unidadMedidaId) {
        this.unidadMedidaId = unidadMedidaId;
    }

    @JsonProperty("PrecioCompra")
    public double getPrecioCompra() {
        return precioCompra;
    }

    public void setPrecioCompra(double precioCompra) {
        this.precioCompra = precioCompra;
    }

    @JsonProperty("MonedaId")
    private int monedaId = 0;
    public int getMonedaId() {
        return monedaId;
    }

    public void setMonedaId(int monedaId) {
        this.monedaId = monedaId;
    }

    @JsonProperty("RutaImagen")
    private String rutaImagen = "";
    public String getRutaImagen() {
        return rutaImagen;
    }

    public void setRutaImagen(String rutaImagen) {
        this.rutaImagen = rutaImagen;
    }

    @JsonProperty("CantidadStock")
    public double getCantidadStock() {
        return cantidadStock;
    }

    public void setCantidadStock(double cantidadStock) {
        this.cantidadStock = cantidadStock;
    }

    @JsonProperty("CantidadReserva")
    public double getCantidadReserva() {
        return cantidadReserva;
    }

    public void setCantidadReserva(double cantidadReserva) {
        this.cantidadReserva = cantidadReserva;
    }

    @JsonProperty("FechaRegistro")
    private Date fechaRegistro = null;
    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
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

    @JsonProperty("Estado")
    private boolean estado = false;
    public boolean getEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

}
