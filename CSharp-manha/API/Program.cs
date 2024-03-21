var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>();
produtos.add(new Produto("Celular", "IOS"));
produtos.add(new Produto("Celular", "Android"));
produtos.add(new Produto("Celular", "Motorola"));
produtos.add(new Produto("Celular", "Xaiomi"));

app.MapGet("/produto/listar", () => "LISTAGEM DE PRODUTOS ");

app.MapPost("/produto/cadastrar", () => "CADASTRO DE PRODUTOS");

app.Run();

record Produto(string nome, string descricao);