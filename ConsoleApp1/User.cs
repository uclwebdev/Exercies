using System;

namespace ConsoleApp1
{
    /// <summary>
    /// User objekt, med 2 egenskaber: navn og fødselsdato
    /// </summary>
    class User
    {
        public string Name;
        public DateTime Birthdate;

        /// <summary>
        /// Beregn User's alder
        /// </summary>
        /// <returns>Users alder</returns>
        public int GetAge()
        {
            // Dette år minus Users fødselsår
            return DateTime.Now.Year - Birthdate.Year;
        }

        //birthdate = 
        /// <summary>
        /// Metode til at få Users fødselsdato vha. input fra consolen
        /// Input forventes i dette format: "01-02-1234"
        /// </summary>
        /// <param name="birthdate">Det string der indtastes vha. consolen</param>
        /// <returns>et DateTime objekt</returns>
        public DateTime GetBirthDate(string birthdate)
        {
            // vi starter med et DateTime objekt, som er nu, eks. 23 september 2019
            DateTime resultDT = DateTime.Now;
            // hvis ikke input consolen indeholder "-", kan vi ikke få en dato
            if(!birthdate.Contains('-'))
                //så vi returnerer dags daro
                return resultDT;
            else {
                // input fra consolen indeholder "-", så vi forsøger at danne et array, ved at dele teksten fra consolen 
                var result = birthdate.Split('-');
                //vi kan kun fortsætte, hvis arrayet indeholder 3 tekst ord
                //og hvis disse tekster er tal
                if(result.Length == 3 && ArrayConatiansNumbers(result))
                {
                    int day = int.Parse(result[0]);
                    int month = int.Parse(result[1]);
                    int year = int.Parse(result[2]);
                    resultDT = new DateTime(year, month, day);
                    
                }
                return resultDT;
            }
        }

        /// <summary>
        /// metode til at tjekke, at alle elementer i et array er tal
        /// </summary>
        /// <param name="array">Det array der skal tjekkes</param>
        /// <returns>sandt, hvis eller elementer er tal, ellers falsk</returns>
        private bool ArrayConatiansNumbers(string[] array)
        {
            //vi bruger et loop, for at tjekke hver tegn i de enkelte ord
            foreach (string s in array)
            {
                //hvis et tegn ikke er tal
                if (!WordIsNumber(s))
                    //stopper vi operationen
                    return false;
            }
            return true;

            /*** Alternativt måde at gøre det ovenstående, hvis ikke man kan loop
             * ved at kigge på de enkelte ord i arrayet
            if (WordIsNumber(array[0]) && WordIsNumber(array[1]) && WordIsNumber(array[2]))
                return true;
            return false;
            */
        }
        /// <summary>
        /// Metode til at tjekke at en string kun indeholder tal
        /// </summary>
        /// <param name="word"></param>
        /// <returns>sandt, hvis teksten indeholder tal, ellers falsk</returns>
        private bool WordIsNumber(string word)
        {
            //split et ord i et array af chars
            var chars = word.ToCharArray();
            foreach(var c in chars)
            {
                if (!IsNumber(c))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Metode til at tjekke om et tal (X) er tal
        /// </summary>
        /// <param name="x">Det tegn der skal tjekkes</param>
        /// <returns>sandt, hvis tegn X er tal, ellers falsk</returns>
        private bool IsNumber(char x)
        {
            // hvis X er tal, svarer vi sandt tilbage
            if (char.IsDigit(x))
                return true;
            // ellers svarer vi falsk
            return false;
        }

    }
}
