using System;

namespace CursoComposicao.Entites {
  class HourContract {
    public DateTime Date { get; set; }
    public double ValuePerHour { get; set; }
    public int Hour { get; set; }

    public HourContract() {
    }

    public HourContract (DateTime date, double valuePHour, int hour) {
      Date = date;
      ValuePerHour = valuePHour;
      Hour = hour;
    }

    public double TotalValue () {
      return Hour * ValuePerHour;
    }
  }
}