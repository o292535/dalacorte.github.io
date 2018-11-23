/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package polimorfismo;

/**
 *
 * @author LAB
 */
public class CD extends LivroCdDvd {

        public CD(String n,double p,int f){
    super.setNome(n);
    super.setPreco(p);
    setnFaixas(f);
   
        System.out.println(toString());
        }
    private int nFaixas;

    public int getnFaixas() {
        return nFaixas;
    }

    public void setnFaixas(int nFaixas) {
        this.nFaixas = nFaixas;
    }
    @Override
    public String toString() {
        return "CD" + "\nNome do CD=" + getNome() + "\nPreço do CD=" + getPreco() + " \nNumero de faixas=" + getnFaixas();
    }

}
