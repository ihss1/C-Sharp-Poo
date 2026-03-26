

class Etudiant : Personne
{
    private float note;

    public Etudiant(string nom, int age, float note) : base(nom, age)
    {
        this.note = note;
    }
      public void afficherEtudiant()
    {
        Console.WriteLine("nom : "+get_nom());
        Console.WriteLine("age : "+get_age());
        Console.WriteLine("note : "+note);
    }


}