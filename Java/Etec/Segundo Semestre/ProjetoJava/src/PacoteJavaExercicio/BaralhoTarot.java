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
public class BaralhoTarot extends Baralho {
    void BaralhoTarot(){
        
    }
    @Override
    int criarCarta(int valor,int naipe){
        int carta = valor + naipe;
        return carta;
    }
    @Override
    int menorValor(int valor){
        return valor;
    }
    @Override
    int maiorValor(int valor){
        return valor;
    }
    @Override
    int primeiroNaipe(int naipe){
        return naipe;
    }
    @Override
    int ultimoNaipe(int naipe){
        return naipe;
    }
}
