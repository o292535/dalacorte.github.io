package polimorfismo;

/**
 *
 * @author FourtZe windyS
 */
public abstract class Mamifero extends Animal{

    /**
     *Rescreevendo o Metodo Emitir som de latido para miado
     */
     @Override
     public abstract void emitirSom();

    /**
     *Rescrevendo o metodo Locomover/a Anotação Overide avisar o programador que esta ocorrendo isto
     */
     @Override
     public abstract void locomover();
     
     public void mamar(){
         System.out.println("MAMANDO");
     }
}
