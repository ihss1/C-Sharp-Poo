class Employee
{
    private string nom;
    private float salaire;

    public Employee(string nom, float salaire)
    {
        this.nom = nom;
        this.salaire = salaire;
    }

    public string get_nom()
    {
        return this.nom;
    }

    public void set_nom(string nom)
    {
        this.nom = nom;
    }

    public float get_salaire()
    {
        return this.salaire;
    }

    public void set_salaire(float salaire)
    {
        this.salaire = salaire;
    }

     public void afficher()
        {
            Console.WriteLine("Nom : "+this.nom+" , Salaire = "+this.salaire);
        }
}