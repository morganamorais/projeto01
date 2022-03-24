

 namespace dotnet___poo.src.Entities
{
    public class Black : Hero
    {
        public Black(string Name, int Level, string HeroType, int HP, int MP): base(Name, Level, HeroType, HP, MP)
       {
       }
        public override string Attack()
      {
          return this.Name + " Lançou  Fogo"; 
      }
    }
}