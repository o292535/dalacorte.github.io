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
public class TesteExercicio5 {
    public static void main(String[] args) {
        AssistenteAdministrativoNumeroMatricula ad = new AssistenteAdministrativoNumeroMatricula();
        AssistenteTecnicoNumeroMatricula at = new AssistenteTecnicoNumeroMatricula();
        ad.getNumeroMatricula();
        at.getNumeroMatricula();
        CachorroExercicio05 c = new CachorroExercicio05();
        c.latir();
        IngressoExercicio05 i = new IngressoExercicio05();
        i.ingresso();
    }
}
