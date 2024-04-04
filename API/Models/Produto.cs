namespace API.Models;

public class Produto
{
//construtor
public Produto(){ 
    Id = Guid.NewGuid().ToString();
    CriadoEm = DateTime.Now;

}

public Produto (string nome, string descricao, double valor){

    Id = Guid.NewGuid().ToString();
    Nome = nome;
    Descricao = descricao;
    Valor = valor;
    CriadoEm = DateTime.Now;
}



    public string? Id {get; set;}
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public double Valor { get; set; }
    public DateTime CriadoEm { get; set; }

    // em JAVA =
    //     private string nome;
    //     private string descricao;

    //     public void setNome(string nome){
    //         this.nome = nome;
    //     }
    //     public string getNome(){
    //         return this.nome;
    //     }


}