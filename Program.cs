
    class Person 
    {
        private string Name;
        private int age;

        public string encapsulatio_name
        {
            
            get{return Name;}
            
            set{Name=value;}
        }

        public int encapsulation_age
        {
           
            get{return age;}
            
            set{age=value;}
        }
        public Person(string Cons_Name,int Cons_Age)
        {
            encapsulatio_name=Cons_Name;
            encapsulation_age=Cons_Age;
        }

    }

     class Student : Person 
    {
        private string StudentID;
        private float GPA;

        public string encapsulation_StudentID
        {
            get{return StudentID;}
            set{StudentID=value;}
        }

        public float encapsulation_GPA
        {
            get{return GPA;}
            set{GPA=value;}
        }

        public Student(string Cons_Name,int Cons_Age,string Cons_StudentID,float Cons_GPA)
        :base(Cons_Name,Cons_Age)
        {
            encapsulation_StudentID=Cons_StudentID;
            encapsulation_GPA=Cons_GPA;
        }

    }
    
    class Teacher :Person
    {
        private string EmployeeID;
        private string Subject;
    
        public string encapsulation_EmployeedID
        {
            get{return EmployeeID;}
            set{EmployeeID=value;}
        }
        public string encapsulation_Subject
        {
            get{return Subject;}
            set{Subject=value;}
        }
        
        public Teacher(string Cons_Name,int Cons_Age,string Cons_EmployeeID,string Cons_Subject)
        :base(Cons_Name,Cons_Age)
        {
            encapsulation_EmployeedID=Cons_EmployeeID;
            encapsulation_Subject=Cons_Subject;
        }

    }



class Program {
    static void Main(string[] args) {
        Student Muco = new Student("Mücahit",20,"1526",91);
        Teacher Enes = new Teacher("Enes",37,"1453","Programlama Temelleri");
        Console.WriteLine("İsim :"+Enes.encapsulatio_name+" Yaş:"+Enes.encapsulation_age+" Çalışan Numarası:"+Enes.encapsulation_EmployeedID+" Ders:"+Enes.encapsulation_Subject);
        
    }
}