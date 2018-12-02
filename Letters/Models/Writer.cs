using System.Collections.Generic;

namespace Letters.Models
{

  public class Writer
  {
    private string _location;
    private string _sender;
    private string _recipient;

    public string GetLocation()
    {
      return _location;
    }

    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

  }
}
