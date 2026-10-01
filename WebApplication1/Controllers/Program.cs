
var builder = WebApplication.CreateBuilder(args);

// Configuração da Injeção de Dependência
IServiceCollection serviceCollection = builder.Services.AddScoped<ICandidatoRepository, CandidatoRepository>(); // Injeta repositório de candidatos
builder.Services.AddScoped<IVotoRepository, VotoRepository>(); // Injeta repositório de votos

builder.Services.AddControllers(); // Adiciona suporte a Controllers
var app = builder.Build();

app.MapControllers(); // Mapeia rotas dos controllers
app.Run(); // Executa aplicação

// ======================= RESUMO DA API =======================
// Objetivo: API para eleição do representante da turma
// Funcionalidades:
// 1. POST /api/candidatos → Cadastrar candidato
//    - Validações: Nome (3-50), Email válido, Turma (1-8),
//      Descrição (até 500), Número (10-99)
//    - Regra de negócio: não permitir número duplicado
//
// 2. GET /api/candidatos → Listar todos os candidatos
//
// 3. POST /api/votos → Registrar voto
//    - Classe Voto: RA do aluno, Data do voto, Número do candidato
//
// 4. GET /api/votos/{numeroCandidato} → Consultar votos de um candidato
//
// Persistência: listas em memória (sem banco de dados)
//
// Arquitetura:
// - Models → Candidato e Voto
// - Repository → classes para manipular listas
// - Interfaces → ICandidatoRepository, IVotoRepository
// - Controllers → CandidatosController, VotosController
// - Injeção de Dependência → configurada em Program.cs
//
// Critérios de avaliação:
// - Models bem estruturados
// - Métodos GET e POST funcionando
// - Repositório e interface corretos
// - DI configurada corretamente
// - Validações implementadas
// - Regras de negócio respeitadas (sem número duplicado)
// - Projeto funcional e organizado (Clean Code)
//
