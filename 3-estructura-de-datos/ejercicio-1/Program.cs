Client claret = new Client("Claret Devigne", "2285938856", "Calle Pelícanos", "claret@claret.com", true);

System.Console.WriteLine(claret);

public struct Client 
{
  public Client(string FullName, string Tel, string Address, string Email, bool IsNewClient) 
  {
    fullName = FullName;
    tel = Tel;
    address = Address;
    email = Email;
    isNewClient = IsNewClient;
  }

  public string fullName { get; set; }
  public string tel { get; set; }
  public string address { get; set; }
  public string email { get; set; }
  public bool isNewClient { get; set; }

  public override string ToString()
  {
    return $"Full name: { fullName }.\nTel: { tel }.\nAddress: { address }.\nEmail: { email }.\nNew Client?: { isNewClient}.";
  }
}