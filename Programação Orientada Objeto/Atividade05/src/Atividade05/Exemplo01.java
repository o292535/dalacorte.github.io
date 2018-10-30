package Atividade05;
import java.awt.Container;
import java.text.ParseException;
import javax.swing.*;
import javax.swing.text.MaskFormatter;

public class Exemplo01 extends JFrame {
    private static final long serialVersionUID = 1L;

    /**
     * Creates new form Exemplo01
     */
    public Exemplo01() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">                          
    private void initComponents() {

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 549, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 300, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>                        

    public static void main(String args[]) {
        
        Exemplo01 field = new
        Exemplo01();
        field.testaExemplo01();
    }
    
    private void testaExemplo01() {
Container janela = getContentPane();
setLayout(null);

//Define os rótulos dos botões
JLabel labelCep = new JLabel("CEP: ");
JLabel labelTel = new JLabel("Telefone: ");
JLabel labelCpf = new JLabel("CPF: ");
JLabel labelData = new JLabel("Data: ");
labelCep.setBounds(50,40,100,20);
labelTel.setBounds(50,80,100,20);
labelCpf.setBounds(50,120,100,20);
labelData.setBounds(50,160,100,20);

//Define as máscaras
MaskFormatter mascaraCep = null;
MaskFormatter mascaraTel = null;
MaskFormatter mascaraCpf = null;
MaskFormatter mascaraData = null;

try{
mascaraCep = new MaskFormatter("#####-###");
mascaraTel = new MaskFormatter("(##)#####-####");
mascaraCpf = new MaskFormatter("###.###.###-##");

mascaraData = new MaskFormatter("##/##/####");
mascaraCep.setPlaceholderCharacter('_');
mascaraTel.setPlaceholderCharacter('_');
mascaraCpf.setPlaceholderCharacter('_');
mascaraData.setPlaceholderCharacter('_');
}
catch(ParseException excp) {
System.err.println("Erro na formatação: " +
excp.getMessage());
System.exit(-1);
}

//Seta as máscaras nos objetos JFormattedTextField
JFormattedTextField jFormattedTextCep = new
JFormattedTextField(mascaraCep);
JFormattedTextField jFormattedTextTel = new
JFormattedTextField(mascaraTel);
JFormattedTextField jFormattedTextCpf = new
JFormattedTextField(mascaraCpf);
JFormattedTextField jFormattedTextData = new
JFormattedTextField(mascaraData);
jFormattedTextCep.setBounds(150,40,100,20);
jFormattedTextTel.setBounds(150,80,100,20);

jFormattedTextCpf.setBounds(150,120,100,20);
jFormattedTextData.setBounds(150,160,100,20);

//Adiciona os rótulos e os campos de textos com
janela.add(labelCep);
janela.add(labelTel);
janela.add(labelCpf);
janela.add(labelData);
janela.add(jFormattedTextCep);
janela.add(jFormattedTextTel);
janela.add(jFormattedTextCpf);
janela.add(jFormattedTextData);
setSize(400, 250);
setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
setVisible(true);
    }

    // Variables declaration - do not modify                     
    // End of variables declaration                   
}
