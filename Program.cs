

List<Person> personlista = new List<Person>();
    personlista.Add(new Person(1, "Darth Vader"));
    personlista.Add(new Person(2, "Luke Skywalker"));
    personlista.Add(new Person(3, "Han Solo"));
    personlista.Add(new Person(4, "Leia Organa"));
    personlista.Add(new Person(5, "Lando Calrissian"));
    personlista.Add(new Person(6, "C3PO"));
    personlista.Add(new Person(7, "R2D2"));





int BinarySearch(List<Person> list, int key){
    int first = 0,last = list.Count -1;
    while(first<=last){
        int mid=(first+last) /2;
        if(key>list[mid].Personnr){
            first=mid+1;
        }
        else if(key<list[mid].Personnr){
            last=mid-1;
        }
        else{
            return mid;
        }
    }
    return -1;
}

class Person
{
    private int personnr;
    private string namn;

    public Person(int p, string n)
    {
        personnr = p;
        namn = n;
    }

    public string Namn
    {
        set { namn = value; }
        get { return namn; }
    }

    public int Personnr
    {
        set { personnr = value; }
        get { return personnr; }
    }
}

    



