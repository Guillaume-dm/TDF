using System;
using System.Collections.Generic;

namespace TDF
{
    class Sprint
    {
        public Sprint(int avance, string J1, string J2, string J3, string J4, string J5, string nom_sprint)
        {
            string[] SprintEchappée = {J1,J2,J3,J4,J5}; // Liste de l'échappée servant pour la simulation du sprint intermédiaire
            string[] SprintPeloton = {" 55 M. CAVENDISH    (DQT)", " 71 P. SAGAN        (BOH)", "132 N. BOUHANNI     (ARK)", " 15 C. EWAN         (LTS)",
                            " 58 M. MØRKØV       (DQT)", " 34 A. GREIPEL      (ISN)", "221 B. COQUARD      (BBK)","216 D. VAN POPPEL   (   )",
                            " 76 N. POLITT       (BOH)", " 51 J. ALAPHILIPPE  (DQT)", "165 M. MOHORIC      (TBV)"," 12 W. VAN AERT     (TJV)",
                            "116 M. CORT NIELSEN (EFN)","163 S. COLBRELLI    (TBV)"," 74 P. KONRAD       (BOH)"};
            string premier; // Sert à stocker le vainqueur du sprint intermédiaire
            string second;
            string troisième;
            string quatrième;
            string cinquième;
            string sixième;
            string septième;
            string huitième;
            string neuvième;
            string dixième;
            string onzième;
            string douzième;
            string treizième;
            string quatorzième;
            string quinzième;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine(nom_sprint); // Affiche le nom du sprint parcouru
            Console.WriteLine(" ");
            if (avance > 5)
            {
                Random rnd = new Random();
                int mIndex = rnd.Next(SprintEchappée.Length);
                Console.WriteLine(" 1    " + SprintEchappée[mIndex].Substring(4, 21)); // Annonce la vainqueur du sprint intermédiaire du jour
                premier = SprintEchappée[mIndex]; // Sauvegarde la valeur du vainqueur de l'étape pour les futurs tests de doublons pour le classement de l'étape

                int nIndex = rnd.Next(SprintEchappée.Length);

                second = SprintEchappée[nIndex];
                while (second == premier) // On test si le vainqueur du sprint est bien différent du second
                {
                    nIndex = rnd.Next(SprintEchappée.Length);

                    second = SprintEchappée[nIndex];
                }
                Console.ForegroundColor = ConsoleColor.White;

                // SIMULATION DU 3° TEMPS AU SPRINT INTERMÉDIAIRE
                int oIndex = rnd.Next(SprintEchappée.Length);

                troisième = SprintEchappée[oIndex];
                while (troisième == premier || troisième == second)
                {
                    oIndex = rnd.Next(SprintEchappée.Length);

                    troisième = SprintEchappée[oIndex];
                }

                // SIMULATION DU 4° TEMPS AU SPRINT INTERMÉDIAIRE
                int pIndex = rnd.Next(SprintEchappée.Length);

                quatrième = SprintEchappée[pIndex];
                while (quatrième == premier || quatrième == second || quatrième == troisième)
                {
                    pIndex = rnd.Next(SprintEchappée.Length);

                    quatrième = SprintEchappée[pIndex];
                }

                // SIMULATION DU 5° TEMPS AU SPRINT INTERMÉDIAIRE
                int qIndex = rnd.Next(SprintEchappée.Length);

                cinquième = SprintEchappée[qIndex];
                while (cinquième == premier || cinquième == second || cinquième == troisième || cinquième == quatrième)
                {
                    qIndex = rnd.Next(SprintEchappée.Length);

                    cinquième = SprintEchappée[qIndex];
                }

                // SIMULATION DU 6° TEMPS AU SPRINT INTERMÉDIAIRE
                int rIndex = rnd.Next(SprintPeloton.Length);
                sixième = SprintPeloton[rIndex];
                while (sixième == premier || sixième == second || sixième == troisième || sixième == quatrième || sixième == cinquième) // On test si le septième du sprint est bien différent du sixième du sprint intermédiaire
                {
                    rIndex = rnd.Next(SprintPeloton.Length);

                    sixième = SprintPeloton[rIndex];
                }

                // SIMULATION DU 7° TEMPS AU SPRINT INTERMÉDIAIRE
                int sIndex = rnd.Next(SprintPeloton.Length);
                septième = SprintPeloton[sIndex];
                while (septième == premier || septième == second || septième == troisième || septième == quatrième || septième == cinquième || 
                          septième == sixième)
                {
                    sIndex = rnd.Next(SprintPeloton.Length);

                    septième = SprintPeloton[sIndex];
                }

                // SIMULATION DU 8° TEMPS AU SPRINT INTERMÉDIAIRE
                int tIndex = rnd.Next(SprintPeloton.Length);
                huitième = SprintPeloton[tIndex];
                while (huitième == premier || huitième == second || huitième == troisième || huitième == quatrième || huitième == cinquième
                          || huitième == sixième || huitième == septième)
                {
                    tIndex = rnd.Next(SprintPeloton.Length);

                    huitième = SprintPeloton[tIndex];
                }

                // SIMULATION DU 9° TEMPS AU SPRINT INTERMÉDIAIRE
                int uIndex = rnd.Next(SprintPeloton.Length);
                neuvième = SprintPeloton[uIndex];
                while (neuvième == premier || neuvième == second || neuvième == troisième || neuvième == quatrième || neuvième == cinquième || 
                          neuvième == sixième || neuvième == septième || neuvième == huitième)
                {
                    uIndex = rnd.Next(SprintPeloton.Length);

                    neuvième = SprintPeloton[uIndex];
                }

                // SIMULATION DU 10° TEMPS AU SPRINT INTERMÉDIAIRE
                int vIndex = rnd.Next(SprintPeloton.Length);
                dixième = SprintPeloton[vIndex];
                while (dixième == premier || dixième == second || dixième == troisième || dixième == quatrième || dixième == cinquième || 
                          dixième == sixième || dixième == septième || dixième == huitième || dixième == neuvième)
                {
                    vIndex = rnd.Next(SprintPeloton.Length);

                    dixième = SprintPeloton[vIndex];
                }

                // SIMULATION DU 11° TEMPS AU SPRINT INTERMÉDIAIRE
                int wIndex = rnd.Next(SprintPeloton.Length);
                onzième = SprintPeloton[wIndex];
                while (onzième == premier || onzième == second || onzième == troisième || onzième == quatrième || onzième == cinquième || 
                          onzième == sixième || onzième == septième || onzième == huitième || onzième == neuvième || onzième == dixième)
                {
                    wIndex = rnd.Next(SprintPeloton.Length);

                    onzième = SprintPeloton[wIndex];
                }

                // SIMULATION DU 12° TEMPS AU SPRINT INTERMÉDIAIRE
                int xIndex = rnd.Next(SprintPeloton.Length);
                douzième = SprintPeloton[xIndex];
                while (douzième == premier || douzième == second || douzième == troisième || douzième == quatrième || 
                          douzième == cinquième || douzième == sixième || douzième == septième || douzième == huitième || 
                          douzième == neuvième || douzième == dixième || douzième == onzième)
                {
                    xIndex = rnd.Next(SprintPeloton.Length);

                    douzième = SprintPeloton[xIndex];
                }

                // SIMULATION DU 13° TEMPS AU SPRINT INTERMÉDIAIRE
                int yIndex = rnd.Next(SprintPeloton.Length);
                treizième = SprintPeloton[yIndex];
                while (treizième == premier || treizième == second || treizième == troisième || treizième == quatrième || 
                          treizième == cinquième || treizième == sixième || treizième == septième || treizième == huitième || 
                          treizième == neuvième || treizième == dixième || treizième == onzième || treizième == douzième)
                {
                    yIndex = rnd.Next(SprintPeloton.Length);

                    treizième = SprintPeloton[yIndex];
                }

                // SIMULATION DU 14° TEMPS AU SPRINT INTERMÉDIAIRE
                int zIndex = rnd.Next(SprintPeloton.Length);
                quatorzième = SprintPeloton[zIndex];
                while (quatorzième == premier || quatorzième == second || quatorzième == troisième || quatorzième == quatrième || 
                          quatorzième == cinquième || quatorzième == sixième || quatorzième == septième || quatorzième == huitième || 
                          quatorzième == neuvième || quatorzième == dixième || quatorzième == onzième || quatorzième == douzième || 
                          quatorzième == treizième)
                {
                    zIndex = rnd.Next(SprintPeloton.Length);

                    quatorzième = SprintPeloton[zIndex];
                }

                // SIMULATION DU 15° TEMPS AU SPRINT INTERMÉDIAIRE
                int zzIndex = rnd.Next(SprintPeloton.Length);
                quinzième = SprintPeloton[zzIndex];
                while (quinzième == premier || quinzième == second || quinzième == troisième || quinzième == quatrième || 
                          quinzième == cinquième |quinzième == sixième || quinzième == septième || quinzième == huitième || 
                          quinzième == neuvième || quinzième == dixième || quinzième == onzième || quinzième == douzième || 
                          quinzième == treizième || quinzième == quatorzième)
                {
                    zzIndex = rnd.Next(SprintPeloton.Length);

                    quinzième = SprintPeloton[zzIndex];
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" 2    " + second.Substring(4, 21)); // Annonce du second au sprint intermédiaire
                Console.WriteLine(" 3    " + troisième.Substring(4, 21)); // Annonce du troisième du sprint intermédiaire
                Console.WriteLine(" 4    " + quatrième.Substring(4, 21)); // Annonce du quatrième du sprint intermédiaire
                Console.WriteLine(" 5    " + cinquième.Substring(4, 21)); // Annonce du cinquième du sprint intermédiaire
                Console.WriteLine(" 6    " + sixième.Substring(4, 21)); // Annonce du sixième du sprint intermédiaire
                Console.WriteLine(" 7    " + septième.Substring(4, 21)); // Annonce du septième au sprint intermédiaire
                Console.WriteLine(" 8    " + huitième.Substring(4, 21)); // Annonce du huitième du sprint intermédiaire
                Console.WriteLine(" 9    " + neuvième.Substring(4, 21)); // Annonce du neuvième au sprint intermédiaire
                Console.WriteLine("10    " + dixième.Substring(4, 21)); // Annonce du dixième du sprint intermédiaire
                Console.WriteLine("11    " + onzième.Substring(4, 21)); // Annonce du onzième du sprint intermédiaire
                Console.WriteLine("12    " + douzième.Substring(4, 21)); // Annonce du douzième au sprint intermédiaire
                Console.WriteLine("13    " + treizième.Substring(4, 21)); // Annonce du treizième du sprint intermédiaire
                Console.WriteLine("14    " + quatorzième.Substring(4, 21)); // Annonce du quatorzième au sprint intermédiaire
                Console.WriteLine("15    " + quinzième.Substring(4, 21)); // Annonce du quinzième du sprint intermédiaire
            }
            else // Si le sprint intermédiaire est franchi par le peloton de tête de course
            {
                Random rnd = new Random();
                int mIndex = rnd.Next(SprintPeloton.Length);
                Console.WriteLine(" 1    " + SprintPeloton[mIndex].Substring(4, 21)); // Annonce la vainqueur du sprint intermédiaire du jour
                premier = SprintPeloton[mIndex]; // Sauvegarde la valeur du vainqueur de l'étape pour les futurs tests de doublons pour le classement de l'étape

                int nIndex = rnd.Next(SprintPeloton.Length);

                second = SprintPeloton[nIndex];
                while (second == premier) // On test si le vainqueur du sprint est bien différent du second
                {
                    nIndex = rnd.Next(SprintPeloton.Length);

                    second = SprintPeloton[nIndex];
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" 2    " + second.Substring(4, 21)); // Annonce du second au sprint intermédiaire

                // SIMULATION DU 3° TEMPS AU SPRINT INTERMÉDIAIRE
                int oIndex = rnd.Next(SprintPeloton.Length);

                troisième = SprintPeloton[oIndex];
                while (troisième == premier || troisième == second)
                {
                    oIndex = rnd.Next(SprintPeloton.Length);

                    troisième = SprintPeloton[oIndex];
                }

                // SIMULATION DU 4° TEMPS AU SPRINT INTERMÉDIAIRE
                int pIndex = rnd.Next(SprintPeloton.Length);

                quatrième = SprintPeloton[pIndex];
                while (quatrième == premier || quatrième == second || quatrième == troisième)
                {
                    pIndex = rnd.Next(SprintPeloton.Length);

                    quatrième = SprintPeloton[pIndex];
                }

                // SIMULATION DU 5° TEMPS AU SPRINT INTERMÉDIAIRE
                int qIndex = rnd.Next(SprintPeloton.Length);

                cinquième = SprintPeloton[qIndex];
                while (cinquième == premier || cinquième == second || cinquième == troisième || cinquième == quatrième)
                {
                    qIndex = rnd.Next(SprintPeloton.Length);

                    cinquième = SprintPeloton[qIndex];
                }


                // SIMULATION DU 6° TEMPS AU SPRINT INTERMÉDIAIRE
                int rIndex = rnd.Next(SprintPeloton.Length);

                sixième = SprintPeloton[rIndex];
                while (sixième == premier || sixième == second || sixième == troisième || sixième == quatrième || sixième == cinquième)
                {
                    rIndex = rnd.Next(SprintPeloton.Length);

                    sixième = SprintPeloton[rIndex];
                }

                // SIMULATION DU 7° TEMPS AU SPRINT INTERMÉDIAIRE
                int sIndex = rnd.Next(SprintPeloton.Length);

                septième = SprintPeloton[sIndex];
                while (septième == premier || septième == second || septième == troisième || septième == quatrième || septième == cinquième || septième == sixième)
                {
                    sIndex = rnd.Next(SprintPeloton.Length);

                    septième = SprintPeloton[sIndex];
                }

                // SIMULATION DU 8° TEMPS AU SPRINT INTERMÉDIAIRE
                int tIndex = rnd.Next(SprintPeloton.Length);

                huitième = SprintPeloton[tIndex];
                while (huitième == premier || huitième == second || huitième == troisième || huitième == quatrième || huitième == cinquième || huitième == sixième || huitième == septième)
                {
                    tIndex = rnd.Next(SprintPeloton.Length);

                    huitième = SprintPeloton[tIndex];
                }

                // SIMULATION DU 9° TEMPS AU SPRINT INTERMÉDIAIRE
                int uIndex = rnd.Next(SprintPeloton.Length);

                neuvième = SprintPeloton[uIndex];
                while (neuvième == premier || neuvième == second || neuvième == troisième || neuvième == quatrième || neuvième == cinquième || neuvième == sixième || neuvième == septième || neuvième == huitième)
                {
                    uIndex = rnd.Next(SprintPeloton.Length);

                    neuvième = SprintPeloton[uIndex];
                }

                // SIMULATION DU 10° TEMPS AU SPRINT INTERMÉDIAIRE
                int vIndex = rnd.Next(SprintPeloton.Length);

                dixième = SprintPeloton[vIndex];
                while (dixième == premier || dixième == second || dixième == troisième || dixième == quatrième || dixième == cinquième || dixième == sixième || dixième == septième || dixième == huitième || dixième == neuvième)
                {
                    vIndex = rnd.Next(SprintPeloton.Length);

                    dixième = SprintPeloton[vIndex];
                }

                Console.WriteLine(" 3    " + troisième.Substring(4, 21)); // Annonce du troisième du sprint intermédiaire
                Console.WriteLine(" 4    " + quatrième.Substring(4, 21)); // Annonce du quatrième du sprint intermédiaire
                Console.WriteLine(" 5    " + cinquième.Substring(4, 21)); // Annonce du cinquième du sprint intermédiaire
                Console.WriteLine(" 6    " + sixième.Substring(4, 21)); // Annonce du 6° du sprint intermédiaire
                Console.WriteLine(" 7    " + septième.Substring(4, 21)); // Annonce du 7° du sprint intermédiaire
                Console.WriteLine(" 8    " + huitième.Substring(4, 21)); // Annonce du 8° du sprint intermédiaire
                Console.WriteLine(" 9    " + neuvième.Substring(4, 21)); // Annonce du 9° du sprint intermédiaire
                Console.WriteLine("10    " + dixième.Substring(4, 21)); // Annonce du dixième du sprint intermédiaire
            }
        }
    }
}
