class Personne
{
    private string nom ;
    private int age ;

    public Personne(string nom , int age)
    {
        this.nom=nom;
        this.age=age;
    }

    public string get_nom()
    {
        return this.nom;
    }
    public void set_nom(string nom)
    {
        this.nom=nom;
    }

    public int get_age()
    {
        return this.age;
    }
    public void set_age(int age)
    {
        this.age=age;
    }

        public void afficher()
        {
            Console.WriteLine("nom : "+this.nom+" , age = "+this.age);
        }
    }