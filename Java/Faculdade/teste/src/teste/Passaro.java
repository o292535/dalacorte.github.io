package teste;

/**
 *
 * @author Victor Gabriel Dalacorte, Reginaldo Daniel Ferreira
 */
public class Passaro {

    public int x, y;
    public double vy = 0;
    public static double g = 30;
    public static double FLAP = -100;
    public int cont = 0;
    NewJFrame j = new NewJFrame();
    public HitBox box;

    public Passaro(int x, int y) {
        this.x = x;
        this.y = y;

    }

    public int atualiza(int y) {
        return y += 1;
    }

    public int flap(int y) {
        return y -= 1;

    }

}
