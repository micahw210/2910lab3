using DatabaseIntegration;
using QueryBuilderStarter;

namespace QueryBuilder_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var dbpath = root + "\\data\\Data.db";


            using(var q = new QueryBuilder(dbpath))
            {
                q.DeleteAll<Pokemon>();
                q.DeleteAll<BannedGame>();

                q.ReadAll<Pokemon>();

               // q.ReadAll<BannedGame>();

                Pokemon p = new Pokemon(2, 190, "squirtle", "Black", "Water",123,2,44,35,67,2,3);
                q.Create(p);

                BannedGame b = new BannedGame(4, "ISHOWMEAT", "ISHOWMEATS", "America", "Nudity");
                q.Create(b);


                string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
                string filepath = folder + Path.DirectorySeparatorChar + "AllPokemon.csv";

                List<Pokemon> pokeman = new List<Pokemon>();

                using (var sr = new StreamReader(filepath))
                {
                    while (!sr.EndOfStream)
                    {
                        int pkcounter = 1;
                        string? line = sr.ReadLine();


                        string[] lineElements = line.Split(',');

                        Pokemon Poke = new Pokemon()
                        {
                            Id = pkcounter,
                            DexNumber = Convert.ToInt32(lineElements[0].Trim()),
                            Name = lineElements[1].Trim(),
                            Type1 = lineElements[3].Trim(),
                            Type2 = lineElements[4].Trim(),
                            Total = Convert.ToInt32(lineElements[5].Trim()),
                            HP = Convert.ToInt32(lineElements[6].Trim()),
                            Attack = Convert.ToInt32(lineElements[7].Trim()),
                            Defense = Convert.ToInt32(lineElements[8].Trim()),
                            SpecialAttack = Convert.ToInt32(lineElements[9].Trim()),
                            SpecialDefense = Convert.ToInt32(lineElements[10].Trim()),
                            Speed = Convert.ToInt32(lineElements[11].Trim()),
                            Generation = Convert.ToInt32(lineElements[12].Trim())
                        };

                        pokeman.Add(Poke);
                        pkcounter++;
                    }

                }

                foreach (var item in pokeman)
                {
                    q.Create(item);
                }



                string folder2 = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
                string filepath2 = folder + Path.DirectorySeparatorChar + "BannedGames.csv";

                List<BannedGame> bans = new List<BannedGame>();

                using (var sr = new StreamReader(filepath2))
                {
                    while (!sr.EndOfStream)
                    {
                        int counter = 1;
                        string? line = sr.ReadLine();


                        string[] lineElements = line.Split(',');

                        BannedGame bn = new BannedGame()
                        {
                            Id = counter,
                            Title = lineElements[0].Trim(),
                            Series = lineElements[1].Trim(),
                            Country = lineElements[2].Trim(),
                            Details = lineElements[3].Trim()
                        };

                        bans.Add(bn);
                        counter++;
                    }

                }

                foreach (var item in pokeman)
                {
                    q.Create(item);
                }

                foreach (var item in bans)
                {
                    q.Create(item);
                }
            }
        }
    }
}