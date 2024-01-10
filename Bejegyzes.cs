namespace bejegyzes;

class Bejegyzes
{
   string szerzo;
   string tartalom;
   int likeok;
   DateTime letrejott;
   DateTime szerkesztve;

   public Bejegyzes(string szerzo, string tartalom)
   {
      this.szerzo = szerzo;
      this.tartalom = tartalom;
      this.likeok = 0;
      this.letrejott = DateTime.Now;
      this.szerkesztve = DateTime.Now;
   }

   public string Szerzo { get => szerzo; }
   public string Tartalom { get => tartalom; set {
      this.tartalom = value;
      this.szerkesztve = DateTime.Now;
   } }
   public int Likeok { get => likeok; }
   public DateTime Letrejott { get => letrejott; }
   public DateTime Szerkesztve { get => szerkesztve; }

   public void Like() { this.likeok++; }

   override public string ToString()
   {
      bool marSzerkesztve = this.szerkesztve != this.letrejott;
      string szerkesztettText = marSzerkesztve ? $"(szerkesztve: {this.szerkesztve})" : "";

      return $"{this.szerzo} - {this.likeok} - {this.letrejott}{szerkesztettText}\n{this.tartalom}";
   }
}