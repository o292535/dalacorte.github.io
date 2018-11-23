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
public class ContaCorrenteEspecialExercicio07 extends ContaCorrenteExercicio07 {

    @Override
    double sacar(double sacar) {
        return sacar = sacar - super.valor - 0.01;
    }
}
