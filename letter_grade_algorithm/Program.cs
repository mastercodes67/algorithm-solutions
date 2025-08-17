class Program
{
    static void Main(string[] args)
    {
        //Harf notu hesaplayacaz
        string[] grades = new string[7] { "A", "B", "C", "D", "F", "C", "B" };
        int[] statics = new int[5];
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] == "A")
            {
                statics[0]++;
            }
            else if (grades[i] == "B")
            {
                statics[1]++;
            }
            else if (grades[i] == "C")
            {
                statics[2]++;
            }
            else
            {
                statics[3]++;
            }
            Console.WriteLine("Öğrencilerin Sıraysıyla Harf notu Dağılımı");

        }
          for (int i=0; i < 5; i++) {
                 Console.WriteLine(statics[i]);
            }
        
    }
}