package polimorfismo;
/**
 *
 * @author FourtZ
 */
public abstract class Animal {
    private String especie;
    private String tamanho;
    private double peso;
    
    public abstract void locomover();
    
    public abstract void emitirSom();
    
   public void setTamanho(String tamanho){
       this.tamanho = tamanho;
   }
     public void setEspecie(String especie){
     this.especie = especie;
 }
       public void setPeso(double peso) {
        this.peso = peso;
    }
     public double getPeso() {
        return peso;
    }
 public String getEspecie() {
        return especie;
    }
public String getTamanho(){
       return tamanho;
   } 
}

