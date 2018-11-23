/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PacoteJavaExercicio;

/**
 *
 * @author LAB
 */
public class Assistente extends Funcionario {
    private int matricula = 54564645;
    
    
    void exibeDados(){
        System.out.println(getMatricula());
    }

    public int getMatricula() {
        return matricula;
    }

    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }
}
