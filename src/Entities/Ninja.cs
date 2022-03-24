
 namespace dotnet___poo.src.Entities
{
    public class Ninja : Hero
    {
     public Ninja(string Name, int Level, string HeroType, int HP, int MP): base(Name, Level, HeroType, HP, MP)
       {
       }
        public override string Attack()
      {
          return this.Name + " Lançou um Golpe"; 
      }
    }
}
 