// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140

//1: Per evitare di dichiarare un tipo userò var
var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};

var acc1 = Maker();
var acc2 = Maker();

Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));

//Data una lista di interi, metterli tutti al quadrato
List<int> list = new List<int>() {1, 2, 3, 4, 5, 6, 7};
var Square = (List<int> list) =>
{
    List<int> result = new List<int>();
    foreach (int x in list)
        result.Add(x * x);
    return result;
};
List<int> squareList = Square(list); 
foreach(int a in squareList)
    Console.WriteLine(a);

// Ora realizzare un metodo che esegue l'elevamento al cubo
var Cubic = (List<int> list) =>
{
    List<int> result = new List<int>();
    foreach (int x in list)
        result.Add(x * x * x);

    return result;
};
List<int> cubicList = Cubic(list);
foreach (int a in cubicList)
    Console.WriteLine(a);

// Generica
var Pow = (List<double> list, double dNum) =>
 {
     List<double> result = new List<double>();
     foreach (double x in list)
         result.Add(Math.Pow(x, dNum));
 };

//Eseguire un caloclo generico
List<int> EseguiIlCalcolo(List<int> li, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    foreach (int n in li)
        lout.Add(fun(n));
    return lout;
}
List<int> lcalcolo = EseguiIlCalcolo(list, (n) => n * (n + 1) / 2);
foreach (int n in lcalcolo)
    Console.WriteLine(n);


//Data una lista di interi estrarre una lista che ottiene tutti i numeri pari
var Even = (List<int> list) =>
{
    List<int> listEven1 = new List<int>();
    foreach (int n in list)
        if ((n % 2) == 0)
            listEven1.Add(n);
    return listEven1;
};

var listEven = list.Where(n => n % 2 == 0);

//Dalla lista di stringhe {"uno", "due", "tre", "quattro","cinque","sei"} ordinarla e stampara in verso decrescente
List<string> numInString= new List<string>() { "uno", "due", "tre", "quattro", "cinque", "sei" };

numInString.Sort();
numInString.Reverse();
foreach (string s in numInString)
    Console.WriteLine(s);

//Oppure 
numInString.Sort((string s1, string s2) => -s1.CompareTo(s2));
foreach (string s in numInString)
    Console.WriteLine(s);

/*Esercizio Finale:
data una lista di coppie <string,int> stamparle ordinate rispetto alla stringa
una coppia si dichiara come Tuple<string, int> quindi una lista di coppie sarà */
List<Tuple<string, int>> lCoppie = new List<Tuple<string, int>>()
{
    new Tuple<string, int > ("uno", 1),
    new Tuple<string, int > ("due", 21),
    new Tuple<string, int > ("quattro", 41),
    new Tuple<string, int > ("sette", 71),
    new Tuple<string, int > ("diciannove", 191),
};

/*lCoppie.Sort((s2, s1) => s2.Item1.CompareTo(s1.Item1));
    foreach (Tuple<string, int> s in lCoppie)
    Console.WriteLine($"{ s.Item1} con  { s.Item2}"); */

/* Ordinare in base  al secondo elemento della tupla */
lCoppie.Sort((t1, t2) => t1.Item2.CompareTo(t2.Item2));
Console.WriteLine(String.Join("\t", lCoppie));

lCoppie.Sort();
lCoppie.Sort((t1, t2) => t1.Item2 - t2.Item2);
Console.WriteLine(String.Join ("\t", lCoppie));

/* Ordinare le nuove Tuple formate da tre elementi */
List<Tuple<int, int, int>> lterne = new List<Tuple<int, int, int>>()
{
    new Tuple<int, int, int>(1, 2, 3),
    new Tuple<int, int, int>(5, 5, 2),
    new Tuple<int, int, int>(2, 4, 11),
    new Tuple<int, int, int>(12, 15, 21),
    new Tuple<int, int, int>(55, 45, 32),
    new Tuple<int, int, int>(1, 2, 4),
    new Tuple<int, int, int>(1, 3, 0),
    new Tuple<int, int, int>(5, 5, 1)
};
lterne.Sort();
Console.WriteLine(String.Join("\t", lterne));

/* Verificare i microsecondi*/
double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
Console.WriteLine("microseconds: {0}", microseconds);