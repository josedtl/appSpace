/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.api.server;

import Framework.EnvItem;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.core.env.Environment;

/**
 *
 * @author DAVID
 */
public class Configuracion {

    @Autowired
    private Environment environment;

    public void DataConfi() {

//        System.out.println("Variable estática: " + environment.getProperty("mi.variable"));
//        EnvItem.setServer(environment.getProperty("app.Server"));
//        EnvItem.setBaseDatos(environment.getProperty("app.db"));
//        EnvItem.setUsuario(environment.getProperty("app.use"));
//        EnvItem.setContrasena(environment.getProperty("app.password"));
        EnvItem.setURL(environment.getProperty("app.url"));
        EnvItem.setUsuario(environment.getProperty("app.user"));
        EnvItem.setContrasena(environment.getProperty("app.password"));
//        System.out.println("Variable estática: " + Conexion.usuario);
//        return environment.getProperty("mi.variable");
    }

}
