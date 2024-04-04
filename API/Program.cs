using API.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// produto.setNome("Bolacha");
// Console.WriteLine(produto.getNome());




List <Produto> produtos =
[
    new Produto("Celular", "IOS", 1000),
    new Produto("Celular", "Android", 400),
    new Produto("Televisao", "samsung",5000),
    new Produto("Celular", "Xaiomi",755.6),
];


app.MapGet("/", () => "API DE PRODUTOS ");

app.MapGet("/produto/listar", () => produtos);

app.MapGet("/produto/buscar/{nome}", ([FromRoute] string nome) =>
{
    for (int i = 0; i < produtos.Count; i++)
    {
        if (produtos[i].Nome == nome)
        {
            return Results.Ok(produtos[i]) ;
        }
    }
    return Results.NotFound("Produto não encontrado!");
});


app.MapPost("/produto/cadastrar/{nome}/{descricao}/{valor}", 
([FromRoute] string nome, [FromRoute] string descricao, [FromRoute] double valor) => {

    Produto produto = new Produto(nome, descricao, valor);

    produtos.Add(produto);
    return Results.Created("", produto);
});



//Exercicios
//1)cadastrar um produto
//a)pela url
//b)pelo corpo
//2)remoção do produto
//3)Alteração do Produto

app.Run();

// record Produto(string nome, string descricao);