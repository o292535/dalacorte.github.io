/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PacoteJavaOO;

/**
 *
 * @author LAB
 */
public class Funcionario extends Pessoa{
    
    private String Setor;
    private boolean trabalhando;

    @Override
    public String toString() {
        return "Funcionario{" + "Setor=" + Setor + ", trabalhando=" + trabalhando + '}';
    }

    public String getSetor() {
        return Setor;
    }

    public void setSetor(String Setor) {
        this.Setor = Setor;
    }

    public boolean isTrabalhando() {
        return trabalhando;
    }

    public void setTrabalhando(boolean trabalhando) {
        this.trabalhando = trabalhando;
    }
    public boolean mudaTrabalho(){
        return true;
    }
}
