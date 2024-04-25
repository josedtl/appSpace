package Business;

import EntityLayer.ServListaEntity;
import java.util.ArrayList;
import Framework.Inj;
import DataLayer.ServListaDB;

public class ServLista {

    public ArrayList<ServListaEntity> ObtenerCodigo(String codigo) {
        ServListaDB BD = new ServListaDB();
        return BD.ObtenerCodigo(codigo);
    }

    public ArrayList<ServListaEntity> Buscar(String codigo, String Nombre) {
        ServListaDB BD = new ServListaDB();
        return BD.Buscar(codigo, Nombre);
    }

    public ArrayList<ServListaEntity> ObtenerMain(String codigo) {
        ServListaDB BD = new ServListaDB();
        return BD.ObtenerMain(codigo);
    }

    public ServListaEntity Registrar(ServListaEntity Item) {
        try {
            Inj.IniciarTranssaccion(true);
            ServListaDB BD = new ServListaDB();
            BD.Registrar(Item);
            Inj.FinalizarTranssaccion();
            return Item;
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<ServListaEntity> ObtenerItem(int ListaId) {
        ServListaDB BD = new ServListaDB();
        return BD.ObtenerItem(ListaId);
    }

}
