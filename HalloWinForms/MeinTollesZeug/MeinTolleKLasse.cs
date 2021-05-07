using System;

namespace MeinTollesZeug
{
    public class MeinTolleKLasse
    {
        public string Text = "Hallo Welt"; //feld

        private string ort = "Heidelberg";
        public string GetOrt()
        {
            return ort;
        }
        public void SetOrt(string ort)
        {
            if (ort == "Saarländer")
                throw new StackOverflowException();

            this.ort = ort;
        }

        private string plz = "68141"; //backing field

        public string Plz //FULL property
        {
            get { return plz; } //getter
            set
            {
                if (plz == "0000")
                    throw new ExecutionEngineException();

                plz = value;
            } //setter
        }

        //auto property
        public string Bundesland { get; set; }



        public MeinTolleKLasse(string starttext)
        {
            Text = starttext;
        }

        public MeinTolleKLasse()
        {

        }

        public void MachMuhhhhh() //methode
        {
            Console.WriteLine("MUHHH");
            DateTime sss = new DateTime();
            
        }
        public int Määäh() //function
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                return -1;
            }
            else
            {
                return 12;
            }
        }


        enum Sizes
        {
            Groß = 17,
            WenigerGroß = 21
        }
    }

}
