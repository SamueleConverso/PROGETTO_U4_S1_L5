namespace PROGETTO_U4_S1_L5.Models {
    public class Contribuente {

        private string nome;
        private string cognome;
        private string dataNascita;
        private string codiceFiscale;
        private string sesso;
        private string comuneResidenza;
        private decimal redditoAnnuale;

        public string Nome {
            get {
                return nome;
            }
            set {
                nome = value;
            }
        }

        public string Cognome {
            get {
                return cognome;
            }
            set {
                cognome = value;
            }
        }
        public string DataNascita {
            get {
                return dataNascita;
            }
            set {
                dataNascita = value;
            }
        }
        public string CodiceFiscale {
            get {
                return codiceFiscale;
            }
            set {
                codiceFiscale = value;
            }
        }
        public string Sesso {
            get {
                return sesso;
            }
            set {
                sesso = value;
            }
        }
        public string ComuneResidenza {
            get {
                return comuneResidenza;
            }
            set {
                comuneResidenza = value;
            }
        }

        public decimal RedditoAnnuale {
            get {
                return redditoAnnuale;
            }
            set {
                redditoAnnuale = value;
            }
        }

        public decimal CalcolaImposte() {
            decimal imposte = 0;
            decimal reddito = RedditoAnnuale;

            if (reddito >= 0 && reddito <= 15000) {
                if (reddito <= 0) {
                    return 0;
                } else {
                    imposte = reddito * 0.23m;
                }
            } else if (reddito >= 15001 && reddito <= 28000) {
                imposte = 3450 + (0.27m * (reddito - 15000));
            } else if (reddito >= 28001 && reddito <= 55000) {
                imposte = 6960 + (0.38m * (reddito - 28000));
            } else if (reddito >= 55001 && reddito <= 75000) {
                imposte = 17220 + (0.41m * (reddito - 55000));
            } else if (reddito >= 75001) {
                imposte = 25420 + (0.43m * (reddito - 75000));
            }

            return imposte;
        }

        public Contribuente(string nome, string cognome, string dataNascita, string codiceFiscale, string sesso, string comuneResidenza, decimal redditoAnnuale) {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }
    }
}
