using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pokedex
{
    public class Pokedexx
    {
        public Pokedexx()
        {
            this.InicializaLista();
        }
        private List<PokemonPlus> pokemons;
        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }
        private void InicializaLista()
        {
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbasauro", "pokémon tipo planta", 8);
            this.pokemons.Add(p);
            p = new PokemonPlus("Ivysaur", "pokémon tipo planta e venenoso", 12);
            this.pokemons.Add(p);
            p = new PokemonPlus("Venusaur", "pokémon tipo planta e venenoso", 53);
            this.pokemons.Add(p);
            p = new PokemonPlus("Charmander", "pokémon tipo fogo", 5);
            this.pokemons.Add(p);
            p = new PokemonPlus("Charmeleon", "pokémon tipo fogo", 15);
            this.pokemons.Add(p);
            p = new PokemonPlus("Charizard", "pokémon tipo fogo e voador", 60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Squirtle", "pokémon de água", 4);
            this.pokemons.Add(p);
            p = new PokemonPlus("Wartortle", "pokémon de água", 18);
            this.pokemons.Add(p);
            p = new PokemonPlus("Blastoise", "pokémon de agua", 50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Caterpie", "Pokémon inseto", 2);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metapod", "Pokémon inseto", 3);
            this.pokemons.Add(p);
            p = new PokemonPlus("Butterfree", "Pokémon tipo inseto e voador", 20);
            this.pokemons.Add(p);
            p = new PokemonPlus("Weedle", "pokémon tipo planta e venenoso", 1);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kakuna", "pokémon tipo planta e venenoso", 6);
            this.pokemons.Add(p);
            p = new PokemonPlus("Beedrill", "pokémon tipo planta e venenoso", 19);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pidgey", "pokémon Normal e Voador", 7);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pidgeotto", "pokémon Normal e Voador", 33);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pidgeot", "pokémon Normal e Voador", 52);
            this.pokemons.Add(p);
            p = new PokemonPlus("Rattata", "pokémon Normal", 2);
            this.pokemons.Add(p);
            p = new PokemonPlus("Raticate", "pokémon Normal", 25);
            this.pokemons.Add(p);
            p = new PokemonPlus("Spearow", "pokémon Normal e Voador", 6);
            this.pokemons.Add(p);
            p = new PokemonPlus("Fearow", "pokémon Normal e Voador", 29);
            this.pokemons.Add(p);
            p = new PokemonPlus("Ekans", "Pokémon Venenoso", 17);
            this.pokemons.Add(p);  
            p = new PokemonPlus("Arbok", "Venenoso", 66);
            this.pokemons.Add(p);   
            p = new PokemonPlus("Pikachu", "Elétrico", 40);
            this.pokemons.Add(p);   
            p = new PokemonPlus("Raichu", "Elétrico", 68);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Sandshrew", "Pokémon Terrestre", 11);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Sandslash", "Pokémon Terrestre", 57);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Nidoran", "Pokémon Venenoso", 9);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Nidorina", "Pokémon Venenoso", 24);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Nidoqueen", "Pokémon Venenoso e Terrestre", 67);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Nidoran", "Pokémon Venenoso", 10);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Nidorino", "Pokémon Venenoso", 29);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Nidoking", "Pokémon Venenoso e Terrestre", 93);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Clefairy", "Pokémon tipo Fada", 27);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Clefable", "Pokémon tipo Fada", 39);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Vulpix", "Pokémon de Fogo", 17);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Ninetales", "Pokémon de Fogo", 64);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Jigglypuff", "Pokémon Normal e tipo Fada", 13);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Wigglytuff", "Pokémon Normal e tipo Fada", 32);
            this.pokemons.Add(p); 
            p = new PokemonPlus("Zubat", "Pokémon Venenoso e Voador", 11);
            this.pokemons.Add(p);
            p = new PokemonPlus("Golbat", "Pokémon Venenoso e Voador", 61);
            this.pokemons.Add(p);
            p = new PokemonPlus("Oddish", "Pokémon Planta e Venenoso", 10);
            this.pokemons.Add(p);
            p = new PokemonPlus("Gloom", "Pokémon Planta e Venenoso", 38);
            this.pokemons.Add(p);
            p = new PokemonPlus("Vileplume", "Pokémon Planta e Venenoso", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Paras", "Pokémon tipo Inseto e Planta", 17);
            this.pokemons.Add(p);
            p = new PokemonPlus("Parasect", "Pokémon tipo Inseto e Planta", 48);
            this.pokemons.Add(p);
            p = new PokemonPlus("Venonat", "Pokémon tipo Inseto e Venenoso", 27);
            this.pokemons.Add(p);
            p = new PokemonPlus("Venomoth", "Pokémon tipo Inseto e Venenoso", 55);
            this.pokemons.Add(p);
            p = new PokemonPlus("Diglett", "Pokémon Terrestre", 2);
            this.pokemons.Add(p);
            p = new PokemonPlus("Dugtrio", "Pokémon Terrestre", 27);
            this.pokemons.Add(p);
            p = new PokemonPlus("Meowth", "Pokémon Normal", 68);
            this.pokemons.Add(p);
            p = new PokemonPlus("Persian", "Pokémon Normal", 77);
            this.pokemons.Add(p);
            p = new PokemonPlus("Psyduck", "Pokémon tipo água", 26);
            this.pokemons.Add(p);
            p = new PokemonPlus("Golduck", "Pokémon tipo água", 72);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mankey", "Pokémon Lutador", 27);
            this.pokemons.Add(p);
            p = new PokemonPlus("Primeape", "Pokémon Lutador", 73);
            this.pokemons.Add(p);
            p = new PokemonPlus("Growlithe", "Pokémon de Fogo", 14);
            this.pokemons.Add(p);
            p = new PokemonPlus("Arcanine", "Pokémon de Fogo", 67);
            this.pokemons.Add(p);
            p = new PokemonPlus("Poliwag", "Pokémon Tipo água", 12);
            this.pokemons.Add(p);
            p = new PokemonPlus("Poliwhirl", "Pokémon Tipo água", 49);
            this.pokemons.Add(p);
            p = new PokemonPlus("Poliwrath", "Pokémon Tipo água e Lutador", 75);
            this.pokemons.Add(p);
            p = new PokemonPlus("Abra", "Pokémon Psiquico", 37);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kadabra", "Pokémon Psiquico", 75);
            this.pokemons.Add(p);
            p = new PokemonPlus("Alakazam", "Pokémon Psiquico", 95);
            this.pokemons.Add(p);
            p = new PokemonPlus("Machop", "Pokémon Lutador", 30);
            this.pokemons.Add(p);
            p = new PokemonPlus("Machoke", "Pokémon Lutador", 77);
            this.pokemons.Add(p);
            p = new PokemonPlus("Machamp", "Pokémon Lutador", 92);
            this.pokemons.Add(p);
            p = new PokemonPlus("Bellsprout", "Pokémon Tipo Planta e Venenoso", 18);
            this.pokemons.Add(p);
            p = new PokemonPlus("Weepinbell", "Pokémon Tipo Planta e Venenoso", 56);
            this.pokemons.Add(p);
            p = new PokemonPlus("Victreebel", "Pokémon Tipo Planta e Venenoso", 80);
            this.pokemons.Add(p);
            p = new PokemonPlus("Tentacool", "Pokémon tipo água e Venenoso", 42);
            this.pokemons.Add(p);
            p = new PokemonPlus("Tentacruel", "Pokémon tipo água e Venenoso", 83);
            this.pokemons.Add(p);
            p = new PokemonPlus("Geodude", "Pokémon tipo Pedra e Terrestre", 21);
            this.pokemons.Add(p);
            p = new PokemonPlus("Graveler", "Pokémon tipo Pedra e Terrestre", 76);
            this.pokemons.Add(p);
            p = new PokemonPlus("Golem", "Pokémon tipo Pedra e Terrestre", 81);
            this.pokemons.Add(p);
            p = new PokemonPlus("Ponyta", "Pokémon de Fogo", 37);
            this.pokemons.Add(p);
            p = new PokemonPlus("Rapidash", "Pokémon de Fogo", 76);
            this.pokemons.Add(p);
            p = new PokemonPlus("Slowpoke", "Pokémon tipo água e Psiquico", 48);
            this.pokemons.Add(p);
            p = new PokemonPlus("Slowbro", "Pokémon tipo água e Psiquico", 64);
            this.pokemons.Add(p);
            p = new PokemonPlus("Magnemite", "Pokémon tipo Elétrico e Aço", 34);
            this.pokemons.Add(p);
            p = new PokemonPlus("Magneton", "Pokémon tipo Elétrico e Aço", 79);
            this.pokemons.Add(p);
            p = new PokemonPlus("Farfetch'd", "Pokémon tipo Normal e Voador", 16);
            this.pokemons.Add(p);
            p = new PokemonPlus("Doduo", "Pokémon tipo Normal e Voador", 17);
            this.pokemons.Add(p);
            p = new PokemonPlus("Dodrio", "Pokémon tipo Normal e Voador", 64);
            this.pokemons.Add(p);
            p = new PokemonPlus("Seel", "Pokémon tipo água", 16);
            this.pokemons.Add(p);
            p = new PokemonPlus("Dewgong", "Pokémon tipo água e Gelo", 28);
            this.pokemons.Add(p);
            p = new PokemonPlus("Grimer", "Pokémon Venenoso", 47);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "Pokémon Venenoso", 72);
            this.pokemons.Add(p);
            p = new PokemonPlus("Shellder", "Pokémon tipo água", 29);
            this.pokemons.Add(p);
            p = new PokemonPlus("Cloyster", "Pokémon tipo água e Gelo", 56);
            this.pokemons.Add(p);
            p = new PokemonPlus("Gastly", "Pokémon tipo Fantasma e Venenoso", 48);
            this.pokemons.Add(p);
            p = new PokemonPlus("Haunter", "Pokémon tipo Fantasma e Venenoso", 74);
            this.pokemons.Add(p);
            p = new PokemonPlus("Gengar", "Pokémon tipo Fantasma e Venenoso", 94);
            this.pokemons.Add(p);
            p = new PokemonPlus("Onix", "Pokémon tipo Pedra e Terrestre", 76);
            this.pokemons.Add(p);
            p = new PokemonPlus("Drowzee", "Pokémon Psiquico", 26);
            this.pokemons.Add(p);
            p = new PokemonPlus("Hypno", "Pokémon Psiquico", 58);
            this.pokemons.Add(p);
            p = new PokemonPlus("Krabby", "Pokémon tipo água", 8);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kingler", "Pokémon tipo água", 27);
            this.pokemons.Add(p);
            p = new PokemonPlus("Voltorb", "Pokémon tipo Elétrico", 33);
            this.pokemons.Add(p);
            p = new PokemonPlus("Electrode", "Pokémon tipo Elétrico", 66);
            this.pokemons.Add(p);
            p = new PokemonPlus("Exeggcute", "Pokémon tipo Planta e Psiquico", 6);
            this.pokemons.Add(p);
            p = new PokemonPlus("Exeggutor", "Pokémon tipo Planta e Psiquico", 34);
            this.pokemons.Add(p);
            p = new PokemonPlus("Cubone", "Pokémon Terrestre", 13);
            this.pokemons.Add(p);
            p = new PokemonPlus("Marowak", "Pokémon Terrestre", 26);
            this.pokemons.Add(p);
            p = new PokemonPlus("Hitmonlee", "Pokémon Lutador", 44);
            this.pokemons.Add(p);
            p = new PokemonPlus("Hitmonchan", "Pokémon Lutador", 41);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lickitung", "Pokémon Normal", 32);
            this.pokemons.Add(p);
            p = new PokemonPlus("Koffing", "Pokémon Venenoso", 56);
            this.pokemons.Add(p);
            p = new PokemonPlus("Weezing", "Pokémon Venenoso", 76);
            this.pokemons.Add(p);
            p = new PokemonPlus("Rhyhorn", "Pokémon tipo Terrestre e Pedra", 83);
            this.pokemons.Add(p);
            p = new PokemonPlus("Rhydon", "Pokémon tipo Terrestre e Pedra", 88);
            this.pokemons.Add(p);
            p = new PokemonPlus("Chansey", "Pokémon Normal", 97);
            this.pokemons.Add(p);
            p = new PokemonPlus("Tangela", "Pokémon tipo Planta", 74);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kangaskhan", "Pokémon Normal", 79);
            this.pokemons.Add(p);
            p = new PokemonPlus("Horsea", "Pokémon tipo água", 17);
            this.pokemons.Add(p);
            p = new PokemonPlus("Seadra", "Pokémon tipo água", 86);
            this.pokemons.Add(p);
            p = new PokemonPlus("Goldeen", "Pokémon tipo água", 27);
            this.pokemons.Add(p);
            p = new PokemonPlus("Seaking", "Pokémon tipo água", 51);
            this.pokemons.Add(p);
            p = new PokemonPlus("Staryu", "Pokémon tipo água", 36);
            this.pokemons.Add(p);
            p = new PokemonPlus("Starmie", "Pokémon tipo água e Psiquico", 96);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mr. Mime", "Pokémon tipo Psiquico e Fada", 58);
            this.pokemons.Add(p);
            p = new PokemonPlus("Scyther", "Pokémon tipo Inseto e Voador", 77);
            this.pokemons.Add(p);
            p = new PokemonPlus("Jynx", "Pokémon tipo Gelo e Psquico", 46);
            this.pokemons.Add(p);
            p = new PokemonPlus("Electabuzz", "Pokémon Elétrico", 63);
            this.pokemons.Add(p);
            p = new PokemonPlus("Magmar", "Pokémon de Fogo", 39);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pinsir", "Pokémon tipo Inseto", 61);
            this.pokemons.Add(p);
            p = new PokemonPlus("Tauros", "Pokémon Normal", 90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Magikarp", "Pokémon tipo água", 1);
            this.pokemons.Add(p);
            p = new PokemonPlus("Gyarados", "Pokémon tipo água e Voador", 99);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lapras", "Pokémon tipo água e Gelo", 79);
            this.pokemons.Add(p);
            p = new PokemonPlus("Ditto", "Pokémon Normal", 3);
            this.pokemons.Add(p);
            p = new PokemonPlus("Eevee", "Pokémon Normal", 4);
            this.pokemons.Add(p);
            p = new PokemonPlus("Vaporeon", "Pokémon tipo água", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Jolteon", "Pokémon Elétrico", 91);
            this.pokemons.Add(p);
            p = new PokemonPlus("Flareon", "Pokémon de Fogo", 72);
            this.pokemons.Add(p);
            p = new PokemonPlus("Porygon", "Pokémon Normal", 43);
            this.pokemons.Add(p);
            p = new PokemonPlus("Omanyte", "Pokémon tipo Pedra e Água", 2);
            this.pokemons.Add(p);
            p = new PokemonPlus("Omastar", "Pokémon tipo Pedra e Água", 52);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kabuto", "Pokémon tipo Pedra e Água", 5);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kabutops", "Pokémon tipo Pedra e Água", 71);
            this.pokemons.Add(p);
            p = new PokemonPlus("Aerodactyl", "Pokémon tipo Pedra e Voador", 54);
            this.pokemons.Add(p);
            p = new PokemonPlus("Snorlax", "Pokémon Normal", 74);
            this.pokemons.Add(p);
            p = new PokemonPlus("Articuno", "Pokémon tipo Gelo e Voador", 56);
            this.pokemons.Add(p);
            p = new PokemonPlus("Zapdos", "Pokémon tipo Elétrico e Voador", 76);
            this.pokemons.Add(p);
            p = new PokemonPlus("Moltres", "Pokémon tipo Fogo e Voador", 89);
            this.pokemons.Add(p);
            p = new PokemonPlus("Dratini", "Pokémon tipo Dragão", 21);
            this.pokemons.Add(p);
            p = new PokemonPlus("Dragonair", "Pokémon tipo Dragão", 49);
            this.pokemons.Add(p);
            p = new PokemonPlus("Dragonite", "Pokémon tipo Dragão e Voador", 92);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "Pokémon Psiquico", 105);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "Pokémon Psiquico", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Meltan", "Pokémon de Aço", 68);
            this.pokemons.Add(p);
            p = new PokemonPlus("Melmetal", "Pokémon de Aço", 103);
            this.pokemons.Add(p);
        }
        public void ListarPokemons()
        {
            for(int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do pokémon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();
            }
        }

    }
}