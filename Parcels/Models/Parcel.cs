using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public string To { get; set; }
    public string Content { get; set; }
    public string From { get; set; }
    public double Weight { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }
    public string Address { get; set; }
    private static List<Parcel> _letters = new List<Parcel> {};

    public Parcel(string to, string content, string from, double weight, double width, double height, double length, string address)
    {
      To = to;
      Content = content;
      From = from;
      Weight = weight;
      Width = width;
      Height = height;
      Length = length;
      Address = address;
      _letters.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _letters;
    }

    public double Volume()
    {
      return Length * Width * Height; 
    }

    public double CostToShip()
    {
      return (Weight / 2) * 3;
    }
  }
}