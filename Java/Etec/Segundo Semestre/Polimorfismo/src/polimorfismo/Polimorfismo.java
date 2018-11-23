package polimorfismo;
/**
 *
 * @author FourtZ
 */
public class Polimorfismo {
    public static void main(String[] args) {
        Animal animal = new Cachorro();
        animal.emitirSom();
        animal.locomover();
        //Super Classe nome da variavel e depois a classe mais especifica
        Animal animal2 = new Ave();
        animal2.emitirSom();
        animal2.locomover();
        
        VIP i = new CamaroteSuperior();
        i.imprimeValor();
        System.out.println(i.getLocalizacao());
   }
}
