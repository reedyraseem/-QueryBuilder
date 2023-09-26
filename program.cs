// QueryBuilder
var queryBuilder = new QueryBuilder();

// Delete all
queryBuilder.DeleteAll<Pokemon>();

// Pokemon objects
var pokemonCollection = new List<Pokemon>
        {
            new Pokemon { Id = 1, /* Add other Pokemon properties */ },
            new Pokemon { Id = 2, /* Add other Pokemon properties */ },
        };

// BannedGame objects
var bannedGamesCollection = new List<BannedGame>
        {
            new BannedGame { Id = 1, /* Add other BannedGame properties */ },
            new BannedGame { Id = 2, /* Add other BannedGame properties */ },
        };

// Insert objects
foreach (var pokemon in pokemonCollection)
{
    object value = QueryBuilder.Create(pokemon);
}

foreach (var bannedGame in bannedGamesCollection)
{
    QueryBuilder.Create(bannedGame);
}

// New pokemon and new game
var newPokemon = new Pokemon { Id = 3, /* Add other Pokemon properties */ };
var newBannedGame = new BannedGame { Id = 3, /* Add other BannedGame properties */ };

QueryBuilder.Create(newPokemon);
QueryBuilder.Create(newBannedGame);

// Console message
Console.WriteLine("Records inserted and deleted successfully.");
