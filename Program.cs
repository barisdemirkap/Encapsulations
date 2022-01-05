using System ;

namespace encapsulation
{
    class Program
    {
        static void Main(string [] args)
        {
            student Student = new student() ;
            Student.Nameofstudent = "Ayse" ;
            Student.Surnameofstudent = "Deniz" ;
            Student.Idnumber = 10 ;
            Student.Class = 3 ;

            Student.studentdata() ; 
            Student.classpromoting() ;

            student Student1 = new student("Deniz", "Arda" , 256 , 1) ;
            Student1.classdemoting() ;
            Student1.classdemoting() ;
            Student1.studentdata() ; 
        

        }
    }

    class student
    {
        private string nameofstudent ;
        private string surnameofstudent ;
        private int idnumber;
        private int _class;

    public string Nameofstudent 
    { get {return nameofstudent;} 
      set {nameofstudent = value ;} 
    }
    public string Surnameofstudent { get => surnameofstudent; set => surnameofstudent = value; }
    public int Idnumber { get => idnumber; set => idnumber = value; }
    public int Class { 
        get => _class; 
        set 
        { 
            if(value<1)
                {
                    Console.WriteLine("Sinif En Az 1 olabilir!!") ;
                    Class =1;
                }
                else
                _class = value; 
        }
        
        }

    public student(string nameofstudent, string surnameofstudent , int ıdnumber = 0, int @class = 0)
    {
        Nameofstudent = nameofstudent;
        Surnameofstudent = surnameofstudent;
        Idnumber = ıdnumber;
        Class = @class;
    }

    public student (){}

        public void studentdata()
        {
            Console.WriteLine ("***** Student info *********") ;
            Console.WriteLine ("Name of Student         : {0}", this.Nameofstudent) ;
            Console.WriteLine ("Surname of Student      : {0}", this.Surnameofstudent) ;
            Console.WriteLine ("Number of the Student       : {0}", this.Idnumber) ;
            Console.WriteLine ("Class of the student        :{0}" , this.Class ) ; 

        }

        public void classpromoting ()
        {
           this.Class += 1 ;     
        }
        public void classdemoting ()
        {
            this.Class -= 1 ; 
           
        }
   
    
    }
}
    
