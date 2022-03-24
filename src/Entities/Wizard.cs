namespace dotnet___poo.src.Entities
{
    public class Wizard : Hero
   {
       public Wizard(string Name, int Level, string HeroType, int HP, int MP): base(Name, Level, HeroType, HP, MP)
       {
       }

      public override string Attack()
      {
          return this.Name + " Lançou Magia"; 
      }
      public string Attack(int Bonus)
      {
          if(Bonus > 6){
              return this.Name + " Lançou Magia super efetiva com bonus " + Bonus; 
          }else{
              return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
          }
         
      }
  }
}