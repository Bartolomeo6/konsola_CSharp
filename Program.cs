using System.Collections;
using System.ComponentModel.Design;

void wylosujLiczby(int[] tab)
{
    Random random = new Random();
    for (int i = 0; i<10; i++)
    {
        tab[i] = random.Next(1,21);
    }
}

//void wylosujLiczby(List<int> lista)
//{
//    Random random = new Random();
//    for (int i = 0; i < 9; i++)
//    {
//        lista.Add(random.Next(20)+1);
//    }
//    for (int i = 0; i < lista.Count-1; i++)
//    {
//        Console.WriteLine(lista[i]);
//    }
//}

//void wylosujLiczby(ArrayList arrayList)
//{
//    // nie dziala
//}

void dominanta(int[] tab)
{
    int najwLicznik = 0;
    int[] dominujace;
    dominujace = new int[10];
    int licznikDominant = 0;

    for (int i = 0; i < tab.Length-1; i++)
    {
        int licznik = 0;
        for (int j = 0; j < tab.Length-1; j++)
        {
            if (tab[i] == tab[j])
            {
                licznik++;
            }
        }
        if (licznik > najwLicznik)
        {
            najwLicznik = licznik;
            licznikDominant = 0;
            dominujace[licznikDominant++] = tab[i];
        }
        else if (licznik == najwLicznik)
        {
            bool istnieje = false;
            for (int k = 0; k < licznikDominant; k++)
            {
                if (dominujace[k] == tab[i])
                {
                    istnieje = true;
                    break;
                }
            }
            if (!istnieje)
            {
                dominujace[licznikDominant++] = tab[i];
            }
        }
    }

    if (najwLicznik == 1)
    {
        Console.WriteLine("Brak dominanty");
    }
    else
    {
        Console.WriteLine("\nDominanta/y tego zbioru: ");
        for (int i = 0; i < licznikDominant; i++)
        {
            Console.WriteLine(dominujace[i]);
        }
    }
}

void sortowanieWybor(int[] tab)
{
    for (int i = 0; i < tab.Length-1; i++)
    {
        int najmIndeks = i;

        for (int j = i+1; j < tab.Length; j++)
        {
            if (tab[j] < tab[najmIndeks])
            {
                najmIndeks = j;
            }
        }
        if(najmIndeks != i)
        {
            int temp = tab[najmIndeks];
            tab[najmIndeks] = tab[i];
            tab[i] = temp;
        }
    }
}

void wypisz(int[] tab)
{
    for (int i = 0; i < tab.Length; ++i)
    {
        Console.WriteLine(tab[i]);
    }
}

// nie dziala, popraw
void dolosujLiczby(int[] staraTab, int[] nowaTab, int n)
{
    Random random = new Random();
    staraTab.CopyTo(nowaTab, 0);
    for (int i = staraTab.Length - 1; i < nowaTab.Length - 1; ++i) 
    {
        if (nowaTab[i] != staraTab[i])
        {
            nowaTab[i] = random.Next(1, 21);
        }
        else
        {
            continue;
        }
    }
}

int maksymalnaWart(int[] tab)
{
    sortowanieWybor(tab);
    int najw = 0;
    najw = tab[tab.Length-1];
    return najw;
}

int[] liczby = [];
liczby = new int[10];
int[] noweLiczby = [];
noweLiczby = new int[20];
wylosujLiczby(liczby);
sortowanieWybor(liczby);
wypisz(liczby);
Console.WriteLine("Nowa tablica: \n");
dolosujLiczby(liczby, noweLiczby, 10);
sortowanieWybor(noweLiczby);
wypisz(noweLiczby);
Console.WriteLine("\n Najwieksza wartosc: "+maksymalnaWart(liczby));
dominanta(liczby);
