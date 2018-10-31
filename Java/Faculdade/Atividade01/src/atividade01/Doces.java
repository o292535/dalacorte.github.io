package atividade01;

import javax.swing.JOptionPane;

public class Doces {

    double total = 0;
    String brigadeiro, pacoquinha, paoDeMel, mariaMole, resultados = "";

    public double Brigadeiro(double preco, int quantidade) {
        preco = quantidade * 5.00;
        total += preco;
        if (quantidade == 1) {
            brigadeiro = quantidade + " brigadeiro = R$" + preco;
        } else {
            brigadeiro = quantidade + " brigadeiros = R$" + preco;
        }
        resultados += brigadeiro + "\n";
        return (preco);
    }

    public double Pacoquinha(double preco, int quantidade) {
        preco = quantidade * 2.00;
        total += preco;
        if (quantidade == 1) {
            pacoquinha = quantidade + " paçoquinha = R$" + preco;
        } else {
            pacoquinha = quantidade + " paçoquinhas = R$" + preco;
        }
        resultados += pacoquinha + "\n";
        return (preco);
    }

    public double PaoDeMel(double preco, int quantidade) {
        preco = quantidade * 5.00;
        total += preco;
        if (quantidade == 1) {
            paoDeMel = quantidade + " pão-de-mel = R$" + preco;
        } else {
            paoDeMel = quantidade + " pães-de-mel = R$" + preco;
        }
        resultados += paoDeMel + "\n";
        return (preco);
    }

    public double MariaMole(double preco, int quantidade) {
        preco = quantidade * 3.00;
        total += preco;
        if (quantidade == 1) {
            mariaMole = quantidade + " maria-mole = R$" + preco;
        } else {
            mariaMole = quantidade + " maria-moles = R$" + preco;
        }
        resultados += mariaMole + "\n";
        return (preco);
    }
}
