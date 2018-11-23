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
public class Loja {
    public static void main(String[] args) {
        LivroCdDvd l = new Livros("Pedro",100,"Carlos Drumond");
        
        LivroCdDvd la = new Livros("X",222,"Carlos Drumond");
        LivroCdDvd ls = new Livros("Z",2,"Carlos Drumond");
        LivroCdDvd ld = new Livros("T",3,"Carlos Drumond");
        LivroCdDvd lf = new Livros("F",4,"Carlos Drumond");
        LivroCdDvd lg = new Livros("G",5,"Carlos Drumond");
    }
}
