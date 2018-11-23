package teste;

import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author Victor Gabriel Dalacorte, Reginaldo Daniel Ferreira
 */

public class Cano {

    public int x, y;
    public int holesize = 100;
    public HitBox boxCima;
    public HitBox boxBaixo;
    NewJFrame j = new NewJFrame();
    JLabel label5 = new JLabel("");
    JLabel label6 = new JLabel("");

    public Cano(int x, int y) {
        this.x = x;
        this.y = y;

        ImageIcon icon = new ImageIcon(getClass().getClassLoader().getResource("Imagens/Canopbaixoof.png"));
        label5.setIcon(icon);
        label5.setBounds(x, y - 512, 120, 512);

        ImageIcon icon2 = new ImageIcon(getClass().getClassLoader().getResource("Imagens/Canopcimaof.png"));
        label6.setIcon(icon2);
        label6.setBounds(x, y + 200, 120, 512);

    }

    public void update() {
        x -= 1;
        label5.setLocation(x, y - 512);
        label6.setLocation(x, y + 100);

    }

}
