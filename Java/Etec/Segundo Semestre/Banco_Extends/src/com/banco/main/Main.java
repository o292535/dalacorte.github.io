package com.banco.main;

import com.banco.model.Pessoa;
import com.banco.model.Gerente;

/**
 *@author Julio - Aluno
 */
public class Main  {
    public static void main(String[] args) {
       Pessoa pessoa = new Pessoa();
     Gerente gerente = new Gerente();
        gerente.setNome("Julio Gato");
        System.out.println(gerente.getNome());
    }
}
