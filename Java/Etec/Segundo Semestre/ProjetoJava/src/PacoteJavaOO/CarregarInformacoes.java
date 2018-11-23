package PacoteJavaOO;

import javax.swing.*;

public class CarregarInformacoes {

    public static void main(String[] args) {
        Aluno ps1 = new Aluno();
        Funcionario ps2 = new Funcionario();
        Professor ps3 = new Professor();

        ps1.setNome("Carlos Justino");
        ps1.setIdade(25);
        ps1.setSexo("M");
        ps1.setCurso("Informática");
        ps1.setMatricula(25846796);

        ps2.setNome("Antonio Beiramar");
        ps2.setIdade(45);
        ps2.setSexo("M");
        ps2.setSetor("Administrativo");

        ps3.setNome("Professor Josias");
        ps3.setIdade(33);
        ps3.setSexo("M");
        ps3.setSalario(150000);
        ps3.setEspecialidade("Redes de Computadores");

        System.out.println(ps1.toString());
        System.out.println(ps2.toString());
        System.out.println(ps3.toString());
    }
}
