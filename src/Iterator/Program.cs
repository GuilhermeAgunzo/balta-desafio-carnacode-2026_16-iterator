using Iterator.Models;

// DESAFIO: Sistema de Playlist de Música
// PROBLEMA: Uma aplicação de streaming precisa permitir diferentes formas de navegar por
// playlists (sequencial, aleatória, por gênero, filtrada). O código atual expõe a
// estrutura interna das coleções e repete lógica de iteração em vários lugares

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
