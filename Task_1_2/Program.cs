using static System.Console;

internal class Program
{
    static void Main()
    {
        string pattern = "Ф.И.О.: {0}\nВозраст: {1}\nE-mail: {2}\nБаллы по программированию: {3}\nБаллы по математике: {4}\nБаллы по физике: {5}";
        string fullName = "Зигмунд Аристархович Швондер";
        byte age = 56;
        string e_mail = "ziggi@shwonder.ty";
        decimal programmingScore = 78.34M;
        decimal mathScore = 56.32M;
        decimal physicsScore = 67.01M;

        string strAverageScore = "Средний балл по предметам составляет: {0}";
        decimal sumScores = programmingScore + mathScore + physicsScore;
        decimal averageScore = sumScores / 3;

        WriteLine(pattern, 
            fullName, 
            age, 
            e_mail, 
            programmingScore, 
            mathScore, 
            physicsScore );

        ReadKey(true);

        WriteLine(strAverageScore, averageScore.ToString("#.##"));

        ReadKey(true);
    }
}
