package PacoteJavaOO;

/**
 *
 * @author windyS
 */
public class Usuario {
    
    private String nome;
    private String email;
    private String login;
    private String senha;

    public Usuario(String l, String s, String e, String n){
        setLogin(l);
        setSenha(s);
        setEmail(e);
        setNome(n);
        provarExistencia();
    }
    
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getLogin() {
        return login;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }
    
    public void provarExistencia(){
        if(this.login == this.senha && this.email == "etec@etecia.com"){
            System.out.println("Login realizado com sucesso\nBem Vindo "+this.nome);
        } else{
            System.out.println("Voce não conseguiu realizar o login");
        }
    }
    
}
