package apsmilkes;

public class Heranca extends ExemploHeranca {

    public static void main(String[] args) {
        ExemploHeranca eh = new ExemploHeranca();
        eh.cachorro = "Cachorrinho";
        eh.gato = "Gatinho";
        eh.passarinho = "Passarinho";
        eh.peixe = "Peixinho";
        eh.tartaruga = "Tartaruguinha";
        System.out.println("Animal: " + eh.cachorro);
        System.out.println("Animal: " + eh.gato);
        System.out.println("Animal: " + eh.passarinho);
        System.out.println("Animal: " + eh.peixe);
        System.out.println("Animal: " + eh.tartaruga);
    }
}
