package atividade01;
public class Animal {
    private double preco;
    
    
    public double Gato (double racaogato, double gramas){
        racaogato = gramas * 1.70;
        System.out.println(racaogato);
        return (racaogato);
    }  
    public double Cachorro (double racaocachorro, double gramas){
        racaocachorro = gramas * 2.15;
        System.out.println(racaocachorro);
        return (racaocachorro);
    }

    /**
     * @return the preco
     */
    public double getPreco() {
        return preco;
    }

    /**
     * @param preco the preco to set
     */
    public void setPreco(double preco) {
        this.preco = preco;
    }
}
