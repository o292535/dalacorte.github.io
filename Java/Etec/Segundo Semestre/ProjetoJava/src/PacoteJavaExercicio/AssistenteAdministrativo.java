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
public class AssistenteAdministrativo extends Funcionario{
    private String periodo = "";

    public String getPeriodo() {
        return periodo;
    }

    public void setPeriodo(String periodo) {
        if(this.periodo == "dia"){
            System.out.println("Voce nao tera adicional");
        }
        else if(this.periodo == "noite"){
            System.out.println("Voce tera um adicional");
             double salario = getSalario() * 1.5; 
        }
        this.periodo = periodo;
    }
    
}
