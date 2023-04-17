    public class Worker
    {   
        public Worker()
        {
        }

        public Worker(string fullName, int age, int salary)
        {
            //Id = id;
            Age = age;
            Salary = salary;
            FullName = fullName;
        }

        public int Id { get; set; }
        public int Age { get; set; }
        public int Salary {get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return $"[{Id} {FullName} {Age} {Salary}]";
        }

    }
public class NewWorker
    {   
        public NewWorker()
        {
        }

        public NewWorker(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public int Age { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return $"[{FullName} {Age}]";
        }

    }