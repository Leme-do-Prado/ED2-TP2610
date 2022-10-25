public class Senhas{
    int proximoAtend;
    Queue<Senha> filaSenhas;

    public Senhas(){
        filaSenhas = new Queue<Senha>(); 
        this.proximoAtend = 1;
    }

    void gerar(){
        filaSenhas.enqueue();
    }
}
