/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Framework;

import java.sql.CallableStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.util.ArrayList;

public class injector {

    CallableStatement cs;
    Conexion cn = new Conexion();
    ArrayList<String> dat = new ArrayList<>();
    ArrayList<variable> type = new ArrayList<>();

    public String getSp() {
        return m_Sp;
    }
    
    

    public void Pmt_String(String Param, String value, Boolean valueB) {
        variable v = new variable();
        v.setParameterName(Param);
        v.setString(value);
        v.setOUTPUT(valueB);
        type.add(v);
        //    dat.add(value);
    }

    public void Pmt_Boolean(String Param, Boolean value, Boolean valueB) {
        variable v = new variable();
        v.setParameterName(Param);
        v.setBoolean(value);
        v.setOUTPUT(valueB);
        type.add(v);
        //    dat.add(value);
    }

    public void Pmt_Integer(String Param, Integer value, Boolean valueB) {
        variable v = new variable();
        v.setParameterName(Param);
        v.setInt(value);
        v.setOUTPUT(valueB);
        type.add(v);
        //    dat.add(value);
    }

    public void Pmt_Double(String Param, Double value, Boolean valueB) {
        variable v = new variable();
        v.setParameterName(Param);
        v.setDouble(value);
        v.setOUTPUT(valueB);
        type.add(v);
        //    dat.add(value);
    }

    private String m_Sp;

    public String Sp(String value) {
        return m_Sp = value;

    }

    public CallableStatement CadenaPs(String value, int count) throws SQLException {

        String sum = "";
        String suma = "";
        for (int i = 0; i < count; i++) {
            sum += ",?";
        }
        suma = sum.substring(1);
        String parameter = "{CALL " + getSp() + "(" + suma + ")}";

        return cn.ConexionBD().prepareCall("" + parameter);

    }

    public Integer RunInsert() {
        Boolean OUTPUT = false;
        String sum = "";
        String suma = "";
        Integer RunValue = 1;
        int con=0;

        for (int i = 0; i < type.size(); i++) {
            sum += ",?";
        }
        suma = sum.substring(1);
        String parameter = "{CALL " + getSp() + "(" + suma + ")}";
        try {

            cs = cn.ConexionBD().prepareCall("" + parameter);
            for (variable t : type) {
                if (t.getInt() == null && t.getBoolean() == null && t.getDouble() == null) {
                    cs.setString(t.getParameterName(), t.getString());
                }
                if (t.getInt() == null && t.getString() == null && t.getDouble() == null) {
                    cs.setBoolean(t.getParameterName(), t.getBoolean());
                }
                if (t.getDouble() == null && t.getString() == null && t.getBoolean() == null) {
                    if (t.getOUTPUT()) {
                        cs.registerOutParameter(t.getParameterName(), Types.INTEGER);
                        OUTPUT = true;
                    } else {
                        cs.setInt(t.getParameterName(), t.getInt());
                        
                        if(con==0){
                        RunValue = t.getInt();
                            con+=1;
                        }
                        
                    }
                }
                if (t.getInt() == null && t.getString() == null && t.getBoolean() == null) {
                    cs.setDouble(t.getParameterName(), t.getDouble());
                }
            }
            cs.executeUpdate();

            if (OUTPUT) {
                RunValue = cs.getInt(1);
            }

            cs.close();

        } catch (SQLException ex) {

            throw new UnsupportedOperationException("INJECTOR :" + ex);

        }
        return RunValue;
    }

    public ResultSet RunSelect() {

        ResultSet rs = null;
        String sum = "";
        String suma = "";

        if (type.size() > 0) {
            for (int i = 0; i < type.size(); i++) {
                sum += ",?";
            }
            suma = sum.substring(1);
        }

        try {
            String Parmet = "" + getSp();
            cs = cn.ConexionBD().prepareCall("{CALL " + Parmet + "(" + suma + ")}");

            for (variable t : type) {
                if (t.getInt() == null && t.getBoolean() == null && t.getDouble() == null) {
                    cs.setString(t.getParameterName(), t.getString());
                }
                if (t.getInt() == null && t.getString() == null && t.getDouble() == null) {
                    cs.setBoolean(t.getParameterName(), t.getBoolean());
                }
                if (t.getDouble() == null && t.getString() == null && t.getBoolean() == null) {
                    cs.setInt(t.getParameterName(), t.getInt());
                }
                if (t.getInt() == null && t.getString() == null && t.getBoolean() == null) {
                    cs.setDouble(t.getParameterName(), t.getDouble());
                }
            }

            rs = cs.executeQuery();

        } catch (SQLException ex) {
            throw new UnsupportedOperationException("INJECTOR :" + ex);
        }
        return rs;
    }

    public Integer RunDelete() {
        Boolean OUTPUT = false;
        String sum = "";
        String suma = "";
        Integer RunValue = 1;

        for (int i = 0; i < type.size(); i++) {
            sum += ",?";
        }
        suma = sum.substring(1);
        String parameter = "{CALL " + getSp() + "(" + suma + ")}";
        try {

            cs = cn.ConexionBD().prepareCall("" + parameter);
            for (variable t : type) {
                if (t.getInt() == null && t.getBoolean() == null && t.getDouble() == null) {
                    cs.setString(t.getParameterName(), t.getString());
                }
                if (t.getInt() == null && t.getString() == null && t.getDouble() == null) {
                    cs.setBoolean(t.getParameterName(), t.getBoolean());
                }
                if (t.getDouble() == null && t.getString() == null && t.getBoolean() == null) {
                    if (t.getOUTPUT()) {
                        cs.registerOutParameter(t.getParameterName(), Types.INTEGER);
                        OUTPUT = true;
                    } else {
                        cs.setInt(t.getParameterName(), t.getInt());
                        RunValue = t.getInt();
                    }
                }
                if (t.getInt() == null && t.getString() == null && t.getBoolean() == null) {
                    cs.setDouble(t.getParameterName(), t.getDouble());
                }
            }
            cs.executeUpdate();

            if (OUTPUT) {
                RunValue = cs.getInt(1);
            }

            cs.close();

        } catch (SQLException ex) {

            throw new UnsupportedOperationException("INJECTOR :" + ex);

        }
        return RunValue;
    }
}
