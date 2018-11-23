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
public class Animal {

    private double peso;
    private String comida;
    private String foto;
    private String habitoAlimentar = "";
    private String reproducao = "";
    private double pesoMedio;

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public String getComida() {
        return comida;
    }

    public void setComida(String comida) {
        this.comida = comida;
    }

    public String getFoto() {
        return foto;
    }

    public void setFoto(String foto) {
        this.foto = foto;
    }

    public void detalhaAnimal(){
        
    }
    
    public void comer() {
        System.out.println("Comendo");
    }

    public void dormir() {
        System.out.println("Dormindo");
    }

    public void movimentar() {

    }

    public void fazerBarulho() {

    }
}
