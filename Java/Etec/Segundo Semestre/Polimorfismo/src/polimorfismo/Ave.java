package polimorfismo;

/**
 *
 * @author FourtZ
 */
public class Ave extends Animal {
    @Override
    public void emitirSom(){
        System.out.println("piando");
    }
    @Override
    public void locomover(){
        System.out.println("Voando");
    }
    public void fazerNinho(){
        System.out.println("Fazendo ninho");
    }
}
