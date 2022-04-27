using System;

namespace Refreshing {
  struct StudyCandidate {
    string nazwisko;
    double punktyMatematyka;
    double punktyInformatyka;
    double PunktyJezykObcy;

    public StudyCandidate(string n, double pm, double pi, double pjo)
    {
      nazwisko = n;
      punktyMatematyka = pm;
      punktyInformatyka = pi;
      PunktyJezykObcy = pjo;
    }

    private double CandidatePoints() => (0.6 * punktyMatematyka) + (0.5 * punktyInformatyka) + (0.2 * PunktyJezykObcy);

    public void Show() {
      System.Console.WriteLine($"{nazwisko}: {CandidatePoints()}");
    }
  }
}