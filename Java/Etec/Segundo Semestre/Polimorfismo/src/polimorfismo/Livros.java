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
public class Livros extends LivroCdDvd {

    private String autor;

    public Livros(String n,double p,String a){
    super.setNome(n);
    super.setPreco(p);
    setAutor(a);
        System.out.println(toString());
}
    public String getAutor() {
        return autor;
    }

    public void setAutor(String autor) {
        this.autor = autor;
    }

    @Override
    public String toString() {
        return "Livros" +"\nNome do Livro=" + getNome() + "\nPreço Do Livro=" + getPreco() + "\nAutor do Livro=" + getAutor();
    }

}
