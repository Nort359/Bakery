using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    class Helper
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static int getId(string query)
        {
            OleDbCommand selectCommandGetCountryId = new OleDbCommand(query, Connection.getConnection());

            string id = selectCommandGetCountryId.ExecuteScalar().ToString();

            int countryEmployeeId = 0;

            int.TryParse(id, out countryEmployeeId);

            return countryEmployeeId;
        }

        public static void PaintLabelUp(Control lbl)
        {
            lbl.ForeColor = Color.FromArgb(133, 156, 42);
            lbl.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Italic);
        }

        public static void PaintLabelDown(Control lbl)
        {
            lbl.ForeColor = Color.FromArgb(41, 39, 40);
            lbl.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }
    }
}
