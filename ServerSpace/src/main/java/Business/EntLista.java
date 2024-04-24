package Business;

import DataLayer.EntListaDB;
import EntityLayer.EntListaEntity;
import java.util.ArrayList;
import Framework.Inj;

public class EntLista {
    public ArrayList<EntListaEntity> ObtenerCodigo(String codigo) {
        try {
            EntListaDB BD = new EntListaDB();
            Inj.IniciarTranssaccionConsulta();
            return BD.ObtenerCodigo(codigo);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<EntListaEntity> GetListaRelacion_Main(String codigo) {
        try {
            EntListaDB BD = new EntListaDB();
            Inj.IniciarTranssaccionConsulta();
            return BD.GetListaRelacion_Main(codigo);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public EntListaEntity Registrar(EntListaEntity Item) {
        try {
            Inj.IniciarTranssaccion(true);
            EntListaDB BD = new EntListaDB();
            BD.Registrar(Item);
            Inj.FinalizarTranssaccion();
            return Item;
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }
}
