using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            string FPath = Path.Combine(Directory.GetCurrentDirectory());
            if(!Directory.Exists(FPath))
            {
                Directory.CreateDirectory(FPath);
            }
            string FilePath = Path.Combine(FPath, "EMP.txt");
            if(!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            Console.Write("enter Employee Id");
            string ID = Console.ReadLine();
            Console.WriteLine("enter employee  name");
            string Name = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            string Salary = Console.ReadLine();

            string empData = $"ID:{ID},name{Name},Salary{Salary},Date{DateTime.Now}";

            using(StreamWriter write=new StreamWriter(FilePath,true))
            {
                write.WriteLine(empData);
            }
            Console.WriteLine("reading Empoyees");
            using (StreamReader read=new StreamReader(FilePath))
            {
                string line;
                while((line=read.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch(UnauthorizedAccessException)
        {
            Console.WriteLine("access deined");
        }
        catch(IOException ex)
        {
            Console.WriteLine("file eror"+ex.Message.ToString());
        }
        catch(Exception ex1)
        {
            Console.WriteLine("unexcepted error"+ex1.Message.ToString());
        }
    }
}