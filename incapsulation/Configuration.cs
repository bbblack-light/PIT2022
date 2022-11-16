namespace PIT2022
{

   public class Configuration
   {
      public string Command
      {
         get
         {
            if (_command == "")
            {
               _command = "Command from file"; // load file: File.Open("...").ReadAllText();
            }

            return _command;
         }
         set
         {
            _command = value;
            //File.Open("...").WriteAllText(newCommand);
         }
      }

      private string _command;

      public string GetCommand()
      {
         if (Command == "")
         {
            Command = "Command from file"; /// load file: File.Open("...").ReadAllText();
         }

         return Command;
      }

      // public void SetCommand(string newCommand)
      // {
      //    Command = newCommand;
      //    //File.Open("...").WriteAllText(newCommand);
      // }
   }
}