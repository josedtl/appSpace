/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controllers;

import Business.TipoElemento;
import EntityLayer.TipoElementoEntity;
import java.util.ArrayList;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Produces;
import javax.ws.rs.Consumes;
import javax.ws.rs.FormParam;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PUT;
import javax.ws.rs.PathParam;
import javax.ws.rs.core.MediaType;

@Path("TipoElemento")
public class TipoElementoController {

    @Context
    private UriInfo context;

    public TipoElementoController() {
    }

    @GET
    @Path("/GetTipoElementoItem/{TipoElementoId}")
    @Produces(MediaType.APPLICATION_JSON)
    public ArrayList<TipoElementoEntity> GetTipoElementoItem(@PathParam("TipoElementoId") int TipoElementoId) {

        TipoElemento BS = new TipoElemento();
        return BS.GetTipoElementoItem(TipoElementoId);
    }

    @GET
    @Path("/GetTipoElementoItems")
    @Produces(MediaType.APPLICATION_JSON)
    public ArrayList<TipoElementoEntity> GetTipoElementoItems() {

        TipoElemento BS = new TipoElemento();
        return BS.GetTipoElementoItems();
    }

//    @POST
//    @Path("/TipoElementoadd")
//    @Produces(MediaType.APPLICATION_JSON)
//    public ArrayList<TipoElementoEntity> addPersona(@FormParam("Entidad") TipoElementoEntity Entidad) {
//        ArrayList<TipoElementoEntity> data = new ArrayList<>();
//        Entidad.setTipoElementoId(1);
//        Entidad.setNombre("Dac");
//        data.add(Entidad);
//        return data;
//    }

    @POST
    @Path("/TipoElementoadd/add")
    public void addPersona(@FormParam("nombre") String nombre,
            @FormParam("apellidos") String apellidos) {
//   ArrayList<TipoElementoEntity> data = new ArrayList<>();
//        Entidad.setTipoElementoId(1);
//        Entidad.setNombre("Dac");
//        data.add(Entidad);
    }

//    @PUT
//    @Consumes(MediaType.APPLICATION_JSON)
//    public void putXml(String content) {
//    }
}
