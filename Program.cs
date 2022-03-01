using MusicGraphQL;

var builder = WebApplication.CreateBuilder();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<QueryMusicCollection>()
    .AddMutationType<MutationMusicCollection>();

var app = builder.Build();

app.MapGraphQL(path: "/");

app.Run();
