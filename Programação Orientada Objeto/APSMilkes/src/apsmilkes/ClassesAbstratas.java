package apsmilkes;

public class ClassesAbstratas {

    abstract class Animal {

        abstract String getHabitat();

        public String getRaca() {
            return "Raça indefinida";
        }
    }

    class Cachorro extends Animal {

        public String getHabitat() {
            return "";
        }
    }

    class Gato extends Animal {

        public String getHabitat() {
            return "indefinido";
        }

        public String getRaca() {
            return "Munchkin";
        }
    }
}
/* Cachorro c = new Cachorro();
System.out.println(c.getRaca()); //A saída será "Raça indefinida"

Gato g = new Gato();
System.out.println(g.getRaca()); //A saída será "Munchkin" */
