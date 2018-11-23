/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PacoteJavaExercicio2;

/**
 *
 * @author LAB
 */
public class G4 extends Veiculo {
    private final String complementos = "Ar-Condicionado \n Champanhe \n etc...";
    private final String  tipo = "Carro de Luxo";

    @Override
    public String getTipo() {
        return tipo;
    }

    @Override
    public String getComplementos() {
        return complementos;
    }
    
}
