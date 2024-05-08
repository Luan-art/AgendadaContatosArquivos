using AgendadaContatosArquivos;

string path = @"C:\DadosEstoque\";
string file = "contactTest.txt";

void ShowAll(List<Contact> recievedList)
{
    foreach (Contact contact in recievedList)
    {
        Console.WriteLine(contact.ToString());
    }
}

bool CheckIfExists(string p, string f)
{
    if (!Directory.Exists(p))
    {
        Directory.CreateDirectory(p);
    }
    if (!File.Exists(p + f))
    {
        File.Create(p + f);
    }

    return true;
}

void SaveFile(List<Contact> l, string p, string f)
{
    if (CheckIfExists(p, f))
    {
        StreamWriter sw = new(p + f);

        foreach (var item in l)
        {

            sw.WriteLine(item.ToString());
        }

        sw.Close();
    }

}


List<Contact> LoadFile(string p, string f)
{
    List<Contact> l = new();
    if (CheckIfExists(p, f))
    {
        string[] data;

  
        foreach (var linha in File.ReadAllLines(p + f))
        {
            data = linha.Split(";");
            l.Add(new Contact(data[0], data[1],  
                                new Address(data[2], data[3], data[4], data[5], data[6], int.Parse(data[7]), data[8]),
                                data.Skip(9).ToList()));   
        }
    }
    return l;
}

List<Contact> contacts = new(LoadFile(path, file));

List<string> telefones = new List<string>();

telefones.Add("777777777");
telefones.Add("777777777");
telefones.Add("777777777");

Address address1 = new Address("12345-678", "Outa City", "EX", "Example Street", "Avenue", 123, "Apt. 456");

contacts.Add(new("Outro", "Outro@gmail.com", address1, telefones));



SaveFile(contacts, path, file);

ShowAll(contacts);