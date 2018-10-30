package jogo;

/**
 *
 * @author windyS, Regis
 */

import java.awt.*;
import java.awt.event.*;
import java.io.*;
import javax.swing.*;
import sun.audio.*;

public class Corpo extends JPanel implements ActionListener {

    private final int C_LARGURA = 400;
    private final int C_ALTURA = 400;
    private final int C_TAMANHO = 10;
    private final int TODOS_PONTOS = 1600;
    private final int POS_ALEAT = 29;

    private final int x[] = new int[TODOS_PONTOS];
    private final int y[] = new int[TODOS_PONTOS];

    private int pontos;
    private int peixe_x;
    private int peixe_y;
    private int DELAY = 100;

    private boolean direcaoEsquerda = false;
    private boolean direcaoDireita = true;
    private boolean direcaoCima = false;
    private boolean direcaoBaixo = false;
    private boolean inGame = true;

    private Timer timer;
    private Image bola;
    private Image bola2;
    private Image peixe;
    private Image peixe2;
    private Image peixe3;
    private Image cabeca;

    public Corpo() {

        iniciarPontos();
    }

    private void iniciarPontos() {

        addKeyListener(new TAdapter());
        setBackground(Color.BLACK);
        setFocusable(true);
        setDoubleBuffered(true);

        setPreferredSize(new Dimension(C_LARGURA, C_ALTURA));
        carregarImagens();
        comecarJogo();
    }

    public static void miau() {
        AudioPlayer MGP = AudioPlayer.player;
        AudioStream BGM;
        AudioData MD;
        AudioDataStream loop = null;

        try {
            BGM = new AudioStream(new FileInputStream("src/resources/miau.wav"));
            MD = BGM.getData();
            loop = new AudioDataStream(MD);
        } catch (IOException error) {
            System.out.println("Error!!!");

        }
        MGP.start(loop);
    }

    public static void bravo() {
        AudioPlayer MGP = AudioPlayer.player;
        AudioStream BGM;
        AudioData MD;
        AudioDataStream loop = null;

        try {
            BGM = new AudioStream(new FileInputStream("src/resources/bravo.wav"));
            MD = BGM.getData();
            loop = new AudioDataStream(MD);
        } catch (IOException error) {
            System.out.println("Error!!!");

        }
        MGP.start(loop);
    }

    public static void intro() {
        AudioPlayer MGP = AudioPlayer.player;
        AudioStream BGM;
        AudioData MD;
        ContinuousAudioDataStream loop = null;

        try {
            BGM = new AudioStream(new FileInputStream("src/resources/intro.wav"));
            MD = BGM.getData();
            loop = new ContinuousAudioDataStream(MD);

        } catch (IOException error) {
            System.out.println("Error!!!" + error);

        }
        MGP.start(loop);
    }

    private void carregarImagens() {

        ImageIcon iid = new ImageIcon("src/resources/bola.png");
        bola = iid.getImage();

        ImageIcon iip = new ImageIcon("src/resources/peixe.png");
        peixe = iip.getImage();

        ImageIcon iip2 = new ImageIcon("src/resources/peixe2.png");
        peixe2 = iip2.getImage();

        ImageIcon iip3 = new ImageIcon("src/resources/peixe3.png");
        peixe3 = iip3.getImage();

        ImageIcon iic = new ImageIcon("src/resources/cabeca.png");
        cabeca = iic.getImage();

        ImageIcon iic2 = new ImageIcon("src/resources/bola2.png");
        bola2 = iic2.getImage();
    }

    private void comecarJogo() {

        pontos = 1;
        for (int z = 0; z < pontos; z++) {
            x[z] = 0 - z * 10;
            y[z] = 50;
        }

        localPeixe();

        timer = new Timer(DELAY, this);
        timer.start();

        intro();
    }

    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);

        desenhar(g);
    }

    private void desenhar(Graphics g) {

        if (inGame) {

            if (pontos % 3 == 0) {
                g.drawImage(peixe3, peixe_x, peixe_y, this);
            } else if (pontos % 2 == 0) {
                g.drawImage(peixe, peixe_x, peixe_y, this);
            } else {
                g.drawImage(peixe2, peixe_x, peixe_y, this);
            }

            for (int z = 0; z < pontos; z++) {
                if (z == 0) {
                    g.drawImage(cabeca, x[z], y[z], this);
                } else {
                    if (z % 3 == 0) {
                        g.drawImage(cabeca, x[z], y[z], this);
                    } else if (z % 2 == 0) {
                        g.drawImage(bola, x[z], y[z], this);
                    } else {
                        g.drawImage(bola2, x[z], y[z], this);
                    }
                }
            }

            Toolkit.getDefaultToolkit().sync();

        } else {
            fimDeJogo(g);
        }
    }

    private void fimDeJogo(Graphics g) {

        bravo();
        String msg = "Fim de Jogo!";
        String j1 = "WINDYS 230 PTS";
        String j2 = "REGIS 229 PTS ";
        String j3 = "BRUNA 200 PTS";
        String j4 = "VOCE " + pontos + " PTS";
        System.out.println(msg);
        Font small = new Font("Helvetica", Font.BOLD, 14);
        FontMetrics metr = getFontMetrics(small);

        g.setColor(Color.white);
        g.setFont(small);
        g.drawString(msg, (C_LARGURA - metr.stringWidth(msg)) / 2, C_ALTURA / 5);
        g.drawString(j1, (C_LARGURA - metr.stringWidth(msg)) - 166, C_ALTURA - 250);
        g.drawString(j2, (C_LARGURA - metr.stringWidth(msg)) - 160, C_ALTURA - 220);
        g.drawString(j3, (C_LARGURA - metr.stringWidth(msg)) - 162, C_ALTURA - 190);
        g.setColor(Color.yellow);
        g.setFont(small);
        g.drawString(j4, (C_LARGURA - metr.stringWidth(msg)) - 154, C_ALTURA - 160);
        
    }

    private void checarPeixe() {

        if ((x[0] == peixe_x) && (y[0] == peixe_y)) {

            pontos++;
            miau();
            localPeixe();
        }
    }

    private void mover() {

        for (int z = pontos; z > 0; z--) {
            x[z] = x[(z - 1)];
            y[z] = y[(z - 1)];
        }

        if (direcaoEsquerda) {
            x[0] -= C_TAMANHO;
        }

        if (direcaoDireita) {
            x[0] += C_TAMANHO;
        }

        if (direcaoCima) {
            y[0] -= C_TAMANHO;
        }

        if (direcaoBaixo) {
            y[0] += C_TAMANHO;
        }
    }

    private void checarColisao() {

        for (int z = pontos; z > 0; z--) {

            if ((z > 4) && (x[0] == x[z]) && (y[0] == y[z])) {
                inGame = false;
            }
        }

        if (y[0] >= C_ALTURA) {
            inGame = false;
        }

        if (y[0] < 0) {
            inGame = false;
        }

        if (x[0] >= C_LARGURA) {
            inGame = false;
        }

        if (x[0] < 0) {
            inGame = false;
        }

        if (!inGame) {
            timer.stop();
        }
    }

    private void localPeixe() {

        int r = (int) (Math.random() * POS_ALEAT);
        peixe_x = ((r * C_TAMANHO));

        r = (int) (Math.random() * POS_ALEAT);
        peixe_y = ((r * C_TAMANHO));
    }

    @Override
    public void actionPerformed(ActionEvent e) {

        if (inGame) {

            checarPeixe();
            checarColisao();
            mover();
        }

        repaint();
    }

    private class TAdapter extends KeyAdapter {

        @Override
        public void keyPressed(KeyEvent e) {

            int key = e.getKeyCode();

            if ((key == KeyEvent.VK_LEFT) && (!direcaoDireita)) {
                direcaoEsquerda = true;
                direcaoDireita = false;
                direcaoCima = false;
                direcaoBaixo = false;
            }

            if ((key == KeyEvent.VK_RIGHT) && (!direcaoEsquerda)) {
                direcaoDireita = true;
                direcaoEsquerda = false;
                direcaoCima = false;
                direcaoBaixo = false;
            }

            if ((key == KeyEvent.VK_UP) && (!direcaoBaixo)) {
                direcaoCima = true;
                direcaoBaixo = false;
                direcaoDireita = false;
                direcaoEsquerda = false;
            }

            if ((key == KeyEvent.VK_DOWN) && (!direcaoCima)) {
                direcaoBaixo = true;
                direcaoCima = false;
                direcaoDireita = false;
                direcaoEsquerda = false;
            }
        }
    }
}