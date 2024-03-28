var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Produto produto = new Produto();
// produto.setNome("Bolacha");
// Console.WriteLine(produto.getNome());


List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Celular", "IOS"));
produtos.Add(new Produto("Celular", "Android"));
produtos.Add(new Produto("Celular", "Motorola"));
produtos.Add(new Produto("Celular", "Xaiomi"));


app.MapGet("/", () => "API DE PRODUTOS ");

app.MapGet("/produto/listar", () => "LISTAGEM DE PRODUTOS ");

app.MapPost("/produto/cadastrar", () => "CADASTRO DE PRODUTOS");

app.Run();

record Produto(string nome, string descricao);