﻿using System;
using System.Globalization;
using CursoComposicao.Entites;
using CursoComposicao.Entites.Enums;

namespace CursoComposicao {
  class Program {
    static void Main (string[] args) {

      Console.Write ("Enter department's name: ");
      string depName = Console.ReadLine ();
      Console.WriteLine ("Enter worker data:");
      Console.Write ("Name: ");
      string name = Console.ReadLine ();
      Console.WriteLine ("Level (Junior/MidLevel/Senior)");
      WorkerLevel level = Enum.Parse<WorkerLevel> (Console.ReadLine ());
      Console.Write ("Base Salary: ");
      double salary = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);

      Department dept = new Department (depName);
      Worker worker = new Worker (name, level, salary, dept);

      Console.WriteLine ();
      Console.Write ("How many contracts to this worker? ");
      int n = int.Parse (Console.ReadLine ());

      for (int i = 0; i < n; i++) {
        Console.Write ($"Enter {i+1} contract data: ");
        Console.Write ("Date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse (Console.ReadLine ());
        Console.Write ("Value per hour: ");
        double valuePerHour = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
        Console.Write ("Duration (hour): ");
        int hours = int.Parse (Console.ReadLine ());

        HourContract contract = new HourContract (date, valuePerHour, hours);

        worker.AddContract (contract);
      }

      Console.WriteLine ();
      Console.WriteLine ("Enter month and year to calculate income (MM/YYYY): ");
      string monthAndYear = Console.ReadLine();
      int mouth = int.Parse(monthAndYear.Substring(0,2));
      int year = int.Parse (monthAndYear.Substring(3));
      Console.WriteLine("Name: " + worker.Name);
      Console.WriteLine("Department: " + worker.Department.Name);
      Console.WriteLine($"Income for: {monthAndYear}: {worker.Income(year, mouth)}");
    }
  }
}