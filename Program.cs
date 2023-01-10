//Initialize an array of 10 workers and sort them by salary in descending order and calculate annual salary


using leetcode;

public class Program
{
    
    static void Main()
    {
        
        List<Worker> workers = new List<Worker>();
        workers.Add(new Worker{
            Name = "Moraa",
            salary = new Salary{
                Currency = "Ksh",
                Amount = 45785
            }

        });
        workers.Add(new Worker{
            Name = "Maburi",
            salary = new Salary{
                Currency = "ksh",
                Amount = 25565
            }
        });
        workers.Add(new Worker{
            Name = "Cyril",
            salary = new Salary{
                Currency = "usd",
                Amount = 789546
            }
        });
        workers.Add(new Worker{
                Name = "Emily",
                salary = new Salary{
                    Currency = "ksh",
                    Amount = 87512
                }
        });
         workers.Add(new Worker{
                Name = "Nyaboke",
                salary = new Salary{
                    Currency = "ksh",
                    Amount = 158463
                }
        });
        workers.Add(new Worker{
                Name = "Edna",
                salary = new Salary{
                    Currency = "ksh",
                    Amount = 3028896
                }
        });
        workers.Add(new Worker{
                Name = "Agnes",
                salary = new Salary{
                    Currency = "ksh",
                    Amount = 258649
                    
                }
        });
        
     
        
        var newWorkers= workers.OrderByDescending(x => x.salary.Amount);

    foreach (var item in newWorkers)
    {
        decimal Amt = item.salary.CalculateTotal();
        Console.WriteLine($"Employee name: {item.Name}  monthly salay:   {item.salary.Amount}   annual salary:  {Amt}");
        
       
    }   

 
   

  }
 
  
}