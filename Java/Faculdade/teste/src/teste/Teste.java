package teste;

import java.util.ArrayList;

/**
 *
 * @author Victor Gabriel Dalacorte, Reginaldo Daniel Ferreira
 */

public class Teste {

    public static void main(String[] args) {

        ArrayList<Cano> canos = new ArrayList<Cano>();
        canos.add(new Cano(10, 10));
        canos.add(new Cano(10, 10));
        canos.add(new Cano(10, 10));
        canos.add(new Cano(10, 10));
        canos.add(new Cano(10, 10));

        System.out.println(canos.get(0).x);
        System.out.println(canos.get(0).y);
    }

}
