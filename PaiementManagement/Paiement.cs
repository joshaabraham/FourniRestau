using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaiementManagement
{
    public class Paiement
    {
        public Guid ID     { get; set; }
        public DateTime Created { get; set; }
        public StatusPaiement StatusPaiement { get; set; }
        public AccountSender AccountSender { get; set; } 
        public AccountReceiver AccountReceiver { get; set; }
        public PaiementMethod PaiementMethod { get; set; }
    }


    public enum StatusPaiement
    {
        created,
        pending, 
        completed,
        canceled,
        failed
    }

    public enum PaiementMethod
    {
        interac,
        moneyTransfert
    }
}
