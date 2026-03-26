class Manager : Employee
{
    private string service;

    public Manager(string nom, float salaire, string service) : base(nom, salaire)
    {
        this.service = service;
    }

    public string get_service()
    {
        return this.service;
    }

    public void set_service( string service)
    {
        this.service = service;
    }

    public void afficherManager()
        {
            Console.WriteLine("Nom : " + get_nom());
            System.Console.WriteLine("Salaire " + get_salaire());
            System.Console.WriteLine("Service " + this.service);
        }
}
