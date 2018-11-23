/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PacoteJavaExercicio2;

/**
 *
 * @author LAB
 */
public class Veiculo {
    
    public Veiculo(){
//    setFilial(f);
//    if(getFilial() == "Automovel-MG"){
//        System.out.println(toString());
//    }
//    else if(getFilial()=="Nenhum"){
//        
//    }
}
    
    private String placa;

    @Override
    public String toString() {
        return "Veiculo{" + "placa=" + placa + ", chassi=" + chassi + ", numeroMotor=" + numeroMotor + ", cor=" + cor + ", filial=" + filial + ", tipo=" + tipo + ", complementos=" + complementos + '}';
    }
    
    private double chassi;
    private int numeroMotor;
    private String cor;
    private String filial;
    private String tipo;
    private String complementos;
    private boolean disponivel;
//    private int datad;
//    private int datam;
//    private int dataa;
    private double dataDevolucao;
    private double numeroKleninho;
    private String carrosAlugados[] = new String [30];

    public double getNumeroKleninho() {
        return numeroKleninho;
    }

    public void setNumeroKleninho(double numeroKleninho) {
        this.numeroKleninho = numeroKleninho;
    }

    public boolean getDisponivel() {
        return disponivel;
    }

    public void setDisponivel(boolean disponivel) {
        this.disponivel = disponivel;
    }

//    public int getDatad() {
//        return datad;
//    }
//
//    public void setDatad(int datad) {
//        this.datad = datad;
//    }
//
//    public int getDatam() {
//        return datam;
//    }
//
//    public void setDatam(int datam) {
//        this.datam = datam;
//    }
//
//    public int getDataa() {
//        return dataa;
//    }
//
//    public void setDataa(int dataa) {
//        this.dataa = dataa;
//    }
    

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getComplementos() {
        return complementos;
    }

    public void setComplementos(String complementos) {
        this.complementos = complementos;
    }
    public String getFilial() {
        return filial;
    }

    public void setFilial(String filial) {
        this.filial = filial;
    }
    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public double getChassi() {
        return chassi;
    }

    public void setChassi(double chassi) {
        this.chassi = chassi;
    }

    public int getNumeroMotor() {
        return numeroMotor;
    }

    public void setNumeroMotor(int numeroMotor) {
        this.numeroMotor = numeroMotor;
    }

    public String getCor() {
        return cor;
    }

    public void setCor(String cor) {
        this.cor = cor;
    }
    
    void veiculosDisponiveis(){
        if(getChassi() == getNumeroKleninho()){
            System.out.println("kleninho quer uma ferrari");
            if(getDisponivel() == false){
                System.out.println("klebinho quer uma ferrari, mas querer nao é poder. o carro ja esta alugado");
                System.out.println("o carro estara disponivel na data: "+ this.dataDevolucao);
            }else{
                System.out.println("klebinho pode alugar a ferrari");      
            }
        }
    }
    
    void carrosAlugados(){
        for(int i = 0; i < carrosAlugados.length; i++){
            System.out.println("CARROS QUE JA FORAM ALUGADOS: "+ carrosAlugados[i]);
        }
    }
    
}
