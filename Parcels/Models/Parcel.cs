using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public string To { get; set; }
    public string Content { get; set; }
    public string From { get; set; }
    public int Weight { get; set; }
    public string Address { get; set; }
    private static List<Parcel> _letters = new List<Parcel> {};

    public Parcel(string to, string content, string from, int weight, string address)
    {
      To = to;
      Content = content;
      From = from;
      Weight = weight;
      Address = address;
      _letters.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _letters;
    }
  }
}