
package com.api.server;

import Business.personanatural;
import EntityLayer.personanaturalEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

/**
 *
 * @author RUTH
 */
@RestController
@RequestMapping("/api/personanatural")
public class personanaturalController {
   
    @GetMapping("/GetpersonanaturalItems")
    public ArrayList<personanaturalEntity> GetpersonanaturalItems() {

        personanatural BS = new personanatural();
        return BS.GetpersonanaturalItems();

    }
}
