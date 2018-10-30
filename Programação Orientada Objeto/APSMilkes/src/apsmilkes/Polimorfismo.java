package apsmilkes;

public class Polimorfismo{

    public static void main(String args[]) {
        System.out.println("Polimorfismo");
        Felino felino1 = new Gato();
        System.out.println("Teste Feline, Gato. Valor: " + felino1.acao());
        Felino felino2 = new Leopardo();
        System.out.println("Teste Felino2, Leopardo. Valor: " + felino2.acao());
    }
}
