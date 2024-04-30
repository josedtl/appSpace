package Business;

import EntityLayer.EntidadEntity;
import EntityLayer.TarifaEntity;
import java.util.ArrayList;

import DataLayer.GeneralDB;
import DataLayer.TarifaDB;
import Framework.Inj;

public class Tarifa {

    public ArrayList<TarifaEntity> ObtenerMain() {
        try {
            TarifaDB BD = new TarifaDB();
            return BD.ObtenerMain();
        } catch (Exception ex) {
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public TarifaEntity Registrar(TarifaEntity Item) {
        try {
            Inj.IniciarTranssaccion(true);
            TarifaDB BD = new TarifaDB();
            BD.Registrar(Item);
            Inj.FinalizarTranssaccion();
            return Item;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<TarifaEntity> ObtenerItem(int Id) {
        try {
            TarifaDB BD = new TarifaDB();
            return BD.ObtenerItem(Id);
        } catch (Exception ex) {
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<TarifaEntity> BuscarRecurso(String Nombre, int Tipo) {
        try {
            TarifaDB BD = new TarifaDB();
            return BD.BuscarRecurso(Nombre, Tipo);
        } catch (Exception ex) {
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }
     public ArrayList<TarifaEntity> GetTarifaBuscarItem(String NomComercial) {
        try {
            TarifaDB BD = new TarifaDB();
            return BD.GetTarifaBuscarItem(NomComercial);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }
}
