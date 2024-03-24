using System.Diagnostics;

public class InputValidation
    {
     public bool validateName(string name)
         {
          return name.Trim().Length == 3;
         }

     public bool validateScore(int score)
         {
          return score >= 0;
         }

     public bool validateWave(int wave)
         {
          return wave >= 1;
         }

     public bool validateMode(string mode)
         {
          return mode.Trim().Length > 0;
         }
    }