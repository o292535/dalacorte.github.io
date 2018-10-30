package apsmilkes;

public class Encapsulamento {

    public static void main(String[] args) {
        ExemploEncapsulamento ee = new ExemploEncapsulamento();

        ee.setRacaoGato(150);
        ee.setRacaoCachorro(150);
        ee.setPipicat(100);
        ee.setBrinquedos(50);
        ee.setArranhador(50);
        System.out.println("Preço da Ração de Gato: " + ee.getRacaoGato());
        System.out.println("Preço da Ração de Cachorro: " + ee.getRacaoCachorro());
        System.out.println("Preço do Pipicat: " + ee.getPipicat());
        System.out.println("Preço dos Brinquedos: " + ee.getBrinquedos());
        System.out.println("Preço do Arranhador: " + ee.getArranhador());
    }
}
