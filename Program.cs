class SaySuIcer{
    public string name="Enes";

    public string Say(){
        return name + " Su İçer.";
    }
}

class Program {
    static void Main(string[] args) {
        SaySuIcer newPerson = new SaySuIcer();
        Console.WriteLine(newPerson.Say());
       
    }
}