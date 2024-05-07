package Business;

import EntityLayer.InfraListaEntity;
import Framework.Inj;

import java.util.ArrayList;

import DataLayer.InfraListaDB;

public class InfraLista {
    
  
    public ArrayList<InfraListaEntity> ObtenerCodigo(String codigo) {
        InfraListaDB BD = new InfraListaDB();
        return BD.ObtenerCodigo(codigo);
    }

    public ArrayList<InfraListaEntity> Buscar(String codigo, String Nombre) {
        InfraListaDB BD = new InfraListaDB();
        return BD.Buscar(codigo, Nombre);
    }

    public ArrayList<InfraListaEntity> ObtenerMain(String codigo) {
        InfraListaDB BD = new InfraListaDB();
        return BD.ObtenerMain(codigo);
    }

    public InfraListaEntity Registrar(InfraListaEntity Item) {
        try {
            Inj.IniciarTranssaccion(true);
            InfraListaDB BD = new InfraListaDB();
            BD.Registrar(Item);
            Inj.FinalizarTranssaccion();
            return Item;
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<InfraListaEntity> ObtenerItem(int ListaId) {
        InfraListaDB BD = new InfraListaDB();
        return BD.ObtenerItem(ListaId);
    }
}
