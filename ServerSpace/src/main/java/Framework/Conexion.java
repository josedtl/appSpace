package Framework;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author DAVID
 */
public class Conexion {

    private String URL = "jdbc:mysql://localhost:3306/spaceDB?autoReconnect=true&useSSL=false";
    private String usuario = "root";
    private String contraseña = "123456";
    private String driver = "com.mysql.jdbc.Driver";

    public Connection ConexionBD() {
        Connection con = null;
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
