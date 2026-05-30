using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ServisNalogPro.Models;

namespace ServisNalogPro.Repositories
{
    public class RadniNalogRepository
    {
        private string connectionString = "Server=31.147.206.65;Database=PI2526_bmatusic22_DB;User Id=PI2526_bmatusic22;Password=28gVnDyL<Hi6&A(z;TrustServerCertificate=True;";
        public void Spremi(RadniNalog nalog)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO RadniNalozi (OpisKvara, Datum, Status, IdZaposlenika) VALUES (@Opis, @Datum, @Status @IdZaposlenika)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OpisKvara", nalog.OpisKvara);
                    command.Parameters.AddWithValue("@Datum", nalog.Datum);
                    command.Parameters.AddWithValue("@Status", nalog.Status);
                    command.Parameters.AddWithValue("@IdZaposlenika", nalog.IdZaposlenika);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
