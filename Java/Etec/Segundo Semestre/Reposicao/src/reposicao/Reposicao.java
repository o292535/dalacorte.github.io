package reposicao;
public class Reposicao {

    public static void main(String[] args) {
        Conta pokemon = new Conta();
        pokemon.setNome("Jorge");
        pokemon.setAgencia(185894);
        pokemon.setConta(152348);
        pokemon.setSaldo(40500);
        System.out.println("Agencia Numero: "+pokemon.getAgencia());
        System.out.println("Conta numero: "+pokemon.getConta());
        System.out.println("Nome da Conta: "+pokemon.getNome());
        System.out.println("Saldo Disponivel: "+pokemon.getSaldo());
    }
 
}