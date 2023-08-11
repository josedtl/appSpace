/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Framework;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author DAVID
 */
public class Conexion {

//    private String usuario = "dtimo";
//    private String pass = "123456";
//    private String host = "localhost";
//    private String nombre_BD = "DBAlmacenLogistico";
    private Connection con = null;

    private String URL = "jdbc:mysql://192.168.18.14:3306/spaceDB?autoReconnect=true&useSSL=false";
    private String usuario = "root";
    private String contraseña = "123456";
    private String driver = "com.mysql.jdbc.Driver";

    public Connection ConexionBD() {
        try {

//            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver").newInstance();
//            String servidor = "jdbc:sqlserver://" + host + "/" + nombre_BD;
//            con = DriverManager.getConnection(servidor, usuario, pass);
//            
//            con = DriverManager.getConnection("jdbc:sqlserver://" + host + "\\SQLExpress:1433;databaseName=" + nombre_BD + ";user=" + usuario + ";password=" + pass + ";");
            Class.forName(driver);
            con = DriverManager.getConnection(URL, usuario, contraseña);

            return con;
        } catch (Exception e) {
            e.printStackTrace();
            return con;
        }
    }
}
