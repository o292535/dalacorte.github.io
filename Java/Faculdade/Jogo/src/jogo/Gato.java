package jogo;

/**
 *
 * @author windyS, Regis
 */

import java.awt.EventQueue;
import javax.swing.JFrame;

public class Gato extends JFrame {

    public Gato() {

        initUI();
    }

    private void initUI() {

        add(new Corpo());

        setResizable(false);
        pack();

        setTitle("Gato");
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    public static void main(String[] args) {

        EventQueue.invokeLater(() -> {
            JFrame ex = new Gato();
            ex.setVisible(true);
        });
    }
}
