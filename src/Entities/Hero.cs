using System;

    namespace dotnet___poo.src.Entities
    {
        public abstract class Hero
        {

            public string Name;
            public int Level;
            public string HeroType;
            public int HP;
            public int MP;

            public Hero(string Name, int Level, string HeroType, int HP, int MP)
            {
                this.Name = Name;
                this.Level = Level;
                this.HeroType = HeroType;
                this.HP = HP;
                this.MP = MP;

            }
            //  esse override esta ingnorando o que herdou da outra classe 
            //e vai sobre escrever com outro comportamento
            public override string ToString(){
                return this.Name + " " + this.Level + "  " + this.HeroType;
            }
            public virtual string Attack(){
                return this.Name + " Atacou com uma espada";
            }
           
        }
    }