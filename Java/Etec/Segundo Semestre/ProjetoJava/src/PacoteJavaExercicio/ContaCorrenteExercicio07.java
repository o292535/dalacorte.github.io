/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pacotejavaexercicio;

/**
 *
 * @author LAB
 */
public class ContaCorrenteExercicio07 {
    protected double valor;
    
    boolean deposita(boolean deposita){
        if (deposita == true){
            System.out.println("voce depositou com sucesso");
        } else {
            System.out.println("erro na hora de depositar");
        }
        return deposita;
    }
    
    double sacar (double sacar){
        return sacar = sacar - this.valor - 0.05;
    }
    
    void ver(){
        System.out.println("o seu saldo e de: "+ this.valor);
    }
}
