using Iterator.Models;

Console.WriteLine("=== Sistema de Playlist ===");

var playlist = new Playlist("Minhas Favoritas");
playlist.AddSong(new Song("Bohemian Rhapsody", "Queen", "Rock", 354, 1975));
playlist.AddSong(new Song("Imagine", "John Lennon", "Pop", 183, 1971));
playlist.AddSong(new Song("Smells Like Teen Spirit", "Nirvana", "Rock", 301, 1991));
playlist.AddSong(new Song("Billie Jean", "Michael Jackson", "Pop", 294, 1982));
playlist.AddSong(new Song("Hotel California", "Eagles", "Rock", 391, 1976));
playlist.AddSong(new Song("Sweet Child O' Mine", "Guns N' Roses", "Rock", 356, 1987));

var player = new MusicPlayer(playlist);

player.PlaySequential();
player.PlayShuffle();
player.PlayByGenre("Rock");
player.PlayOldies();

Console.WriteLine("\n=== PROBLEMAS ===");
Console.WriteLine("✗ Estrutura interna da coleção exposta (List<Song> público)");
Console.WriteLine("✗ Lógica de iteração repetida em múltiplos métodos");
Console.WriteLine("✗ Cliente depende do tipo de coleção (List, Array, Queue)");
Console.WriteLine("✗ Difícil mudar estrutura interna sem quebrar clientes");
Console.WriteLine("✗ Não é possível iterar múltiplas coleções uniformemente");
Console.WriteLine("✗ Não há forma padrão de pausar/retomar iteração");
Console.WriteLine("✗ Filtros e transformações implementados no cliente");

Console.WriteLine("\n=== Requisitos Não Atendidos ===");
Console.WriteLine("• Interface uniforme para diferentes coleções");
Console.WriteLine("• Múltiplas iterações simultâneas independentes");
Console.WriteLine("• Iteração sem conhecer estrutura interna");
Console.WriteLine("• Iteradores personalizados (reverso, circular, preguiçoso)");
Console.WriteLine("• Composição de iteradores com filtros");

// Perguntas para reflexão:
// - Como acessar elementos sem expor representação interna?
// - Como criar interface uniforme para diferentes coleções?
// - Como permitir múltiplas travessias simultâneas?
// - Como implementar diferentes formas de iteração?