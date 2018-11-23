/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package polimorfismo;

/**
 *
 * @author LAB
 */
public class Cachorro extends Mamifero {

    @Override
    public void emitirSom() {
        System.out.println("Au au");     
    }

    @Override
    public void locomover() {
        System.out.println("Andando");
    }
    
    public void mostar(){
        locomover();
        emitirSom();
    }
}
