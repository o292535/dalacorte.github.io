package Exemplo;
import javax.swing.JOptionPane;
public class Exemplo11 {
public static void main(String[] args) {
for(int sobe=1, desce=10 ; sobe<=10 && desce>=1; sobe++,desce--){
JOptionPane.showMessageDialog(null, "Sobe: " + sobe + "\nDesce: " + desce);
}
}
}