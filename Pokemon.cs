using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseIntegration
{
    public class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type1 { get; set; } = string.Empty;
        public string Type2 { get; set; } = string.Empty;
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public Pokemon() { }

        public Pokemon(int id, int dexNumber, string name, string type1, string type2, int HP, int Attack, int Defense, int SpecialAttack, int SpecialDefense, int Speed, int Generation)
        {
            Id = id;
            DexNumber = dexNumber;
            Name = name;
            Type1 = type1;
            Type2 = type2;
            Total = 0;
            HP = 0;
            Attack = 0;
            Defense = 0;
            SpecialAttack = 0;
            SpecialDefense = 0;
            Speed = 0;
            Generation = 0;
        }

        public override string ToString()
        {
            return $"{Id}: {Name} -- ({Type1}/{Type2})";
        }
    }
}