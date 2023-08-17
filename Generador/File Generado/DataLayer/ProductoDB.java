package DataLayer;

import EntityLayer.ProductoEntity;;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class ProductoDB {

    injector Inj = new injector();

    public ArrayList<ProductoEntity> GetAllItems() { 

        ArrayList<ProductoEntity> DatoMemoria = new ArrayList<>();
        ProductoEntity en;
        try {
            Inj.Sp("sp_ProductoAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new ProductoEntity();
                en.setProductoId(rs.getInt("ProductoId"));
                en.setCodigo(rs.getString("Codigo"));
                en.setTipoProductoId(rs.getInt("TipoProductoId"));
                en.setMarcaId(rs.getInt("MarcaId"));
                en.setModeloId(rs.getInt("ModeloId"));
                en.setUnidadMedidaId(rs.getInt("UnidadMedidaId"));
                en.setPrecioCompra(rs.getInt("PrecioCompra"));
                en.setMonedaId(rs.getInt("MonedaId"));
                en.setRutaImagen(rs.getString("RutaImagen"));
                en.setCantidadStock(rs.getInt("CantidadStock"));
                en.setCantidadReserva(rs.getInt("CantidadReserva"));
                en.setFechaRegistro(rs.getInt("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstado(rs.getInt("Estado"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<ProductoEntity> GetAllItem(int ProductoId) { 

        ArrayList<ProductoEntity> DatoMemoria = new ArrayList<>();
        ProductoEntity en;
        try {
            Inj.Sp("sp_ProductoAllItem");
            Inj.Pmt_Integer("v_ProductoId", ProductoId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new ProductoEntity();
                en.setProductoId(rs.getInt("ProductoId"));
                en.setCodigo(rs.getString("Codigo"));
                en.setTipoProductoId(rs.getInt("TipoProductoId"));
                en.setMarcaId(rs.getInt("MarcaId"));
                en.setModeloId(rs.getInt("ModeloId"));
                en.setUnidadMedidaId(rs.getInt("UnidadMedidaId"));
                en.setPrecioCompra(rs.getInt("PrecioCompra"));
                en.setMonedaId(rs.getInt("MonedaId"));
                en.setRutaImagen(rs.getString("RutaImagen"));
                en.setCantidadStock(rs.getInt("CantidadStock"));
                en.setCantidadReserva(rs.getInt("CantidadReserva"));
                en.setFechaRegistro(rs.getInt("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstado(rs.getInt("Estado"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ProductoEntity Save(ProductoEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_Producto_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_Producto_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_ProductoId", entity.getProductoId(), true);
            Inj.Pmt_String("v_Codigo", entity.getCodigo(), false);
            Inj.Pmt_Integer("v_TipoProductoId", entity.getTipoProductoId(), false);
            Inj.Pmt_Integer("v_MarcaId", entity.getMarcaId(), false);
            Inj.Pmt_Integer("v_ModeloId", entity.getModeloId(), false);
            Inj.Pmt_Integer("v_UnidadMedidaId", entity.getUnidadMedidaId(), false);
            Inj.Pmt_Double("v_PrecioCompra", entity.getPrecioCompra(), false);
            Inj.Pmt_Integer("v_MonedaId", entity.getMonedaId(), false);
            Inj.Pmt_String("v_RutaImagen", entity.getRutaImagen(), false);
            Inj.Pmt_Double("v_CantidadStock", entity.getCantidadStock(), false);
            Inj.Pmt_Double("v_CantidadReserva", entity.getCantidadReserva(), false);
            Inj.Pmt_Date("v_FechaRegistro", new java.sql.Date(entity.getFechaRegistro().getTime()), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_Estado", entity.getEstado(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setProductoId(Id);
                }
            }
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Inj.RunUpdate();
            }

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return entity;
    }

    public Boolean Delete(Integer Id) {

        Boolean State = false;
        try {
            Inj.Sp("sp_ProductoDelete");
            Inj.Pmt_Integer("v_ProductoId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
